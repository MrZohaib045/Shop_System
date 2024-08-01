using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of player movement
    void Update()
    {
        // Get horizontal and vertical input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // Normalize the movement vector to ensure diagonal movement isn't faster
        movement.Normalize();
        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
