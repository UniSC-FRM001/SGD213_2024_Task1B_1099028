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

    // Use this for initialization
    void Start()
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
        else
        {
            Debug.Log("Movement Direction Not Selected.");
        }
    }

    // Update is called once per frame
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
        else
        {
            Debug.Log("Movement Direction Not Selected.");
        }
    }
}
