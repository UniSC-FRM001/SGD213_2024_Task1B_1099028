using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Shooting shootingScript;

    void Start() // Set references to the other components when the script loads
    {
        playerMovement = GetComponent<PlayerMovement>();
        shootingScript = GetComponent<Shooting>();
    }

    // Each Frame, check if there is a player input and call the appropriate script for that action.
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
       
        if(HorizontalInput != 0.0f)
        {
            if (playerMovement != null) // If there is a script for movement, tell it to move the object.
            {
                playerMovement.HorizontalMovement(HorizontalInput);
            }
            else // If there is no script for movement attached to the player character, post in the log.
            {
                Debug.Log("Attach the PlayerMovement Script.");
            }
        }

        if(Input.GetButton("Fire1"))
        {
            if (shootingScript != null) // If there is a script for shooting, tell it to shoot.
            {
                shootingScript.Shoot();
            }
            else // If there is no script for shooting attached to the player character, post in the log.
            {
                Debug.Log("Attach the Shooting Script.");
            }
        }
    }
}
