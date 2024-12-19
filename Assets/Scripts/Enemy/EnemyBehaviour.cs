using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public AudioClip destructionSFX;

    // variables to hold the laster object
    public GameObject laserPrefab;

    // varabales to hold the postion , object and prefab of the object
    public float laserSpeed = 10f;

    public Transform LaserSpawnPoint;
    private GameObject spawnedLaser;

    // physical sim hits. For Unity to call this, at least one of the colliding objects
    // needs to have their RigidBody component set to "Dynamic" for Body Type
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // print("I'm hit collision!");
    }

    // This is called if the Collider on the game object has "Is Trigger" checked.
    // Then it doesn't physically react to hits but still detects them
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("I'm hit!");

        // Check the other colliding object's tag to know if it's
        // indeed a player projectile
        if (collision.tag == "PlayerProjectile")
        {
            // Play an audio clip in the scene and not attached to the alien
            // so the sound keeps playing even after it's destroyed
            AudioSource.PlayClipAtPoint(destructionSFX, Vector3.zero);

            // Destroy the alien game object
            Destroy(gameObject);

            // Destroy the projectile game object
            Destroy(collision.gameObject);
            GameManager.instance.AddScore();
        }
    }

    public void ShootLaser()
    {
        if (spawnedLaser == null)
        {
            // spawns the lasrer from the prefab and the targated spawn point
            spawnedLaser = Instantiate(laserPrefab, LaserSpawnPoint.position, Quaternion.identity);
            spawnedLaser.GetComponent<Rigidbody2D>().velocity = (-LaserSpawnPoint.up) * (laserSpeed);
        }
    }
}