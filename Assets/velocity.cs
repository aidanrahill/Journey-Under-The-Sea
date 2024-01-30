using UnityEngine;

public class SpriteAnimationController : MonoBehaviour
{
    private Animator animator;
   private Rigidbody2D rb;

    void Start()
    {
        // Get the Animator and Rigidbody2D components from the GameObject
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void UpdateAnimation()
    {
        // Check the velocity of the Rigidbody2D component
        float velocity = rb.velocity.magnitude;

        // Set the Animator's parameter based on the velocity
        // Assuming we have a float parameter named "Velocity" in the Animator
        animator.SetFloat("Velocity", velocity);

        // Change state based on velocity
        // For example, switch to swimming animation if velocity is above a certain threshold
        if (velocity > 1f) // You can adjust this threshold
        {
            animator.SetBool("IsSwimming", true);
        }
        else
        {
            animator.SetBool("IsSwimming", false);
        }
    }
}
