using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float distanceToOpen = 2f; // The maximum distance at which the door can be opened
    public Transform playerTransform; // The transform of the player object

    private bool isOpen = false; // Flag to track if the door is currently open
    private Vector3 initialPosition; // The initial position of the door

    void Start()
    {
        initialPosition = transform.position; // Store the initial position of the door
    }

    void Update()
    {
        // Calculate the distance between the player and the door
        float distance = Vector3.Distance(transform.position, playerTransform.position);

        // If the player is close enough to the door and the door is not already open
        if (distance <= distanceToOpen && !isOpen)
        {
            // Open the door by moving it along its local z-axis
            transform.Translate(Vector3.forward * 2f);
            isOpen = true; // Set the flag to indicate that the door is open
        }
        // If the player is too far away from the door and the door is open
        else if (distance > distanceToOpen && isOpen)
        {
            // Close the door by moving it back to its initial position
            transform.position = initialPosition;
            isOpen = false; // Set the flag to indicate that the door is closed
        }
    }
}
