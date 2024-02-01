using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed
    public bool isFacingRight = true; // Set this based on the initial direction

    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveDirection = isFacingRight ? 1f : -1f;
        Vector3 movement = new Vector3(moveDirection, 0f, 0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
