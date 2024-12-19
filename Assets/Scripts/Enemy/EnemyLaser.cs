using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    public float destroyAfter = 3f;

    // Called when this object's collider triggers with another collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // destroys the laser after 3 seconds
        Destroy(this.gameObject, destroyAfter);

        // Check if the collided object has the "Player" tag
        if (collision.gameObject.CompareTag("Player"))
        {
            print("Killed the player"); // Log a message indicating the collision with the player
            Destroy(collision.gameObject); // Destroy the Player gameObject
            Destroy(this.gameObject); // Destroy the EnemyLaser gameObject
        }
    }
}