using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private MovementBehavior movementBehavior;

    private void Start()
    {
        // Initialize the movement behavior to MoveForward
        movementBehavior = new MoveForward();
    }

    private void Update()
    {
        // Call the Move() method of the selected movement behavior
        movementBehavior.Move(transform); // ABSTRACTION
    }
}
