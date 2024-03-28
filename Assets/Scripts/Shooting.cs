using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{
    /// <summary>
    /// This script will spawn a projectile object directly above the object that the script is attached to.  
    /// It currently will not take the direction that the parent object is facing into consideration.
    /// </summary>
    [SerializeField]
    private GameObject bullet;

    private float lastFiredTime = 0f;

    [SerializeField]
    private float fireDelay = 1f;

    private float bulletOffset = 2f;

    void Start() // When the object that will shoot initializes, set the spawn location for any bullets that it will shoot
    {
        // Offset the bullets spawn location from the object it's spawning from
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Use half of the objects vertical size to find the edge of the object
            + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus add half of the bullet size to place the center of the bullets
    }

    public void Shoot()
    {
        float CurrentTime = Time.time;

        // Have a delay so we don't shoot too many bullets
        if (CurrentTime - lastFiredTime > fireDelay) // If the fire delay has passed...
        {
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset); // Use the objects current location plus the offset, to determine the bullet spawn location.

            Instantiate(bullet, spawnPosition, transform.rotation); // Create a new instance of the bullet

            lastFiredTime = CurrentTime;
        }
    }
}