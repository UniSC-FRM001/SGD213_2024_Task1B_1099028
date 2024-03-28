using UnityEngine;
using System.Collections;

public enum MovementDirection
{
    MovesUp,
    MovesDown
}

public class MoveForward : MonoBehaviour {

    [SerializeField]
    private float acceleration = 75f;

    [SerializeField]
    private float initialVelocity = 2f;

    [SerializeField]
    private MovementDirection movementDirection = MovementDirection.MovesDown;

    private Rigidbody2D ourRigidbody;

    void Start() // When the object initializes, store a reference to it's rigidbody component and set it's movement speed and direction
    {
        ourRigidbody = GetComponent<Rigidbody2D>();

        if (movementDirection == MovementDirection.MovesUp)
        {
            ourRigidbody.velocity = Vector2.up * initialVelocity;
        }
        else if (movementDirection == MovementDirection.MovesDown)
        {
            ourRigidbody.velocity = Vector2.down * initialVelocity;
        }
        else // Display a message in the log if there is no direction selected (though this should never happen as the script sets the direction as down by default)
        {
            Debug.Log("Movement Direction Not Selected.");
        }
    }

     void Update()
    {
        if (movementDirection == MovementDirection.MovesUp)
        {
            Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;
            ourRigidbody.AddForce(ForceToAdd);
        }
        else if (movementDirection == MovementDirection.MovesDown)
        {
            Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;
            ourRigidbody.AddForce(ForceToAdd);
        }
        else // Display a message in the log if there is no direction selected (though this should never happen as the script sets the direction as down by default)
        {
            Debug.Log("Movement Direction Not Selected.");
        }
    }
}