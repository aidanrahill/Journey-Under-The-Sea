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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform targetWaypoint = pathwayPoint[currentPathwayPoint];
        
        // Move boss towards target waypoint
        // ...

        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            currentPathwayPoint = (currentPathwayPoint + 1) % pathwayPoint.Length;
            //movingForward = !movingForward;
        }

        // manual testing shoot stuff
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F key");
            ShootProjectile();
        }


    }

    //shoots projectiles
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
