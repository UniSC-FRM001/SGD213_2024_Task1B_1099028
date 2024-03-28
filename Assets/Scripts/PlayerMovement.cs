using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float speed = 5000f;
    
    private Rigidbody2D playerRigidBody;

    void Start() // Executed on initialization
    {
        playerRigidBody = GetComponent<Rigidbody2D>(); // Store a reference to the pawn's rigidbody component.
    }

    public void HorizontalMovement(float HorizontalInput)
    {
        Vector2 ForceToAdd = Vector2.right * HorizontalInput * speed * Time.deltaTime;
        playerRigidBody.AddForce(ForceToAdd);
    }
}
