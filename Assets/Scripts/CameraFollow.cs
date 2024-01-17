using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // Reference to the player object
    public Vector3 offset;   // Offset position for the camera relative to the player

    void Update()
    {
        // Ensure player reference is set
        if (player == null)
        {
            Debug.LogError("Player reference not set in CameraFollow script!");
            return;
        }

        // Set the camera's position to follow the player with the desired offset
        transform.position = player.position + offset;
    }
}
