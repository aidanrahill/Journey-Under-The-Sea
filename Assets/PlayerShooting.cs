using TarodevController;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab; // Reference to the projectile prefab
    public PlayerAnimator playerAnimator;
    public Transform firePoint; // Transform representing the point where the projectile will be spawned

    void Update()
    {
        // Check if the "E" key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            ShootProjectile();
        }
    }

    void ShootProjectile()
    {
        // Instantiate a new projectile at the firePoint's position and rotation
        GameObject newProjectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Assuming the projectile has a MoveProjectile script, set its facing direction
        MoveProjectile moveProjectile = newProjectile.GetComponent<MoveProjectile>();
        if (moveProjectile != null)
        {
            moveProjectile.isFacingRight = !playerAnimator._sprite.flipX; // Check the player's local scale to determine direction
        }
    }
}
