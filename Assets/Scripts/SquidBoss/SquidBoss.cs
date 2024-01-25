using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidBoss : MonoBehaviour
{
    public Transform origin;
    public Transform target;
    public GameObject InkProjectile;

    public Transform[] pathwayPoint;
    int currentPathwayPoint;

    public float speed = 2;
    public float shotDelay = 1;
    Boolean movingForward = true;

    public AudioSource ShootInk;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShootProjectileSpread());
    }

    // Update is called once per frame
    void Update()
    {
        Transform targetWaypoint = pathwayPoint[currentPathwayPoint];
        
        // Move boss towards target waypoint
        if (movingForward)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);
        }

        // new way point
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            currentPathwayPoint = (currentPathwayPoint + 1) % pathwayPoint.Length;
            movingForward = true;
        }

        // manual testing shoot stuff
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F key");
            ShootProjectile();
        }


    }

    // shoot a spread of 3
    IEnumerator ShootProjectileSpread()
    {

        yield return new WaitForSeconds(3*shotDelay);
        //Debug.Log("shootagin");

        movingForward = false;

        for (int i = 0; i < 3; i++)
        {
            Vector3 direction = origin.position - target.position;
            
            // calc angle for squid to face player
            float angle = Unity.Mathematics.math.degrees(Unity.Mathematics.math.atan2(direction.x, direction.y));


            Debug.Log("preangle" + angle);

            angle-= 90;
            angle = angle % 360;
            if (angle > 180)
                angle -= 360;
            angle = -(angle + 180);

            Debug.Log("angle" + angle);
            transform.rotation = Quaternion.Euler(0, 0, angle);

            // play sound
            ShootInk.Play();

            ShootProjectile();
            Debug.Log("created " + i);

            yield return new WaitForSeconds(shotDelay);
        }

        // reset rotation

        transform.rotation = Quaternion.Euler(0, 0, 0);

        movingForward = true;

        //Debug.Log("ture");


        // restart
        StartCoroutine(ShootProjectileSpread());
    }

    //shoot single projectile
    public void ShootProjectile()
    {
        GameObject ink = Instantiate(InkProjectile, origin.position, origin.rotation);



        //// Instantiate projectiles in a pattern
        //// Example: Instantiate 3 projectiles in a fan-shaped spread
        //float spreadAngle = 30f;
        //for (int i = 0; i < 3; i++)
        //{
        //    float angleOffset = spreadAngle * (i - 1);
        //    Vector2 projectileDirection = Vector3.RotateTowards(transform.up, targetPosition - transform.position, angleOffset, 0f);
        //    GameObject ink = Instantiate(InkProjectile, transform.position, Quaternion.LookRotation(projectileDirection));

        //    Debug.Log("created " + i);
        //    // Set projectile's target and speed
        //    //// (assuming projectile has a script with these properties)
        //    //Ink.GetComponent<InkProjectile>().targetPosition = targetPosition;
        //    //Ink.GetComponent<InkProjectile>().speed = 5f;
        //}
    }
}
