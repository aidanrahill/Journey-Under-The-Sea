//using UnityEngine;

//public class ApplyUpwardForce : MonoBehaviour
//{
//    public float forceMagnitude = 100f; // Magnitude of the upward force
//    private Rigidbody2D rb; // Reference to the Rigidbody2D component

//    void Start()
//    {
//        // Getting the reference to the Rigidbody2D component attached to the same GameObject
//        rb = GetComponent<Rigidbody2D>();

//        // Call the ApplyForceRepeatedly method every 1.5 seconds starting from the beginning
//        InvokeRepeating("ApplyForceRepeatedly", 1f, 1.5f);
//        Invoke
//    }

//    void ApplyForceRepeatedly()
//    {
//        // Applying an upward force to the Rigidbody2D
//        rb.AddForce(Vector2.up * forceMagnitude, ForceMode2D.Impulse);
//    }
//}
