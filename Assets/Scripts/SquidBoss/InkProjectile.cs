using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkProjectile : MonoBehaviour
{
    public int speed = 1;
    int playerLayer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Despawn", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;

        //// Check for collision with player or screen boundaries
        //if (Physics2D.OverlapCircle(transform.position, GetComponent<CircleCollider2D>().radius, playerLayer) ||
        //    transform.position.y < 0f || transform.position.y > Screen.height)
        //{
        //    Destroy(gameObject);
        //}
    }

    void Despawn ()
    {
        Destroy(gameObject);
    }
}
