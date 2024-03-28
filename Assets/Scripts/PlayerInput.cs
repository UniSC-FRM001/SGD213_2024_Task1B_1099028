using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Shooting shootingScript;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        shootingScript = GetComponent<Shooting>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
       
        if(HorizontalInput != 0.0f)
        {
            if (playerMovement != null)
            {
                playerMovement.HorizontalMovement(HorizontalInput);
            }
            else
            {
                Debug.Log("Attach the PlayerMovement Script.");
            }
        }

        if(Input.GetButton("Fire1"))
        {
            if (shootingScript != null)
            {
                shootingScript.Shoot();
            }
            else
            {
                Debug.Log("Attach the Shooting Script.");
            }
        }
    }
}
