using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserControl : MonoBehaviour
{
    public static EnemyLaserControl instance; // Singleton instance for easy access

    public EnemyBehaviour[] topEnemy; // Array of top-level enemy behaviors
    public EnemyBehaviour[] midEnemy; // Array of mid-level enemy behaviors
    public EnemyBehaviour[] botEnemy; // Array of bottom-level enemy behaviors

    private int key; // Variable to store a random key for enemy type selection

    private void Start()
    {
        instance = this; // Set the instance to this script, creating a singleton

        StartCoroutine(StartRandomShooting()); // Start the coroutine for random enemy shooting
    }

    private IEnumerator StartRandomShooting()
    {
        while (true) // Infinite loop to continuously perform random shooting
        {
            yield return new WaitForSeconds(Random.Range(0f, 2.5f)); // Wait for a random time between 0 and 2.5 seconds
            RandomEnemyShooting(); // Call the method for random enemy shooting
        }
    }

    public void RandomEnemyShooting()
    {
        key = Random.Range(0, 3); // Generate a random key (0, 1, or 2) for enemy type selection

        switch (key)
        {
            case 0:
                int i = Random.Range(0, 9); // Randomly select an index for topEnemy array
                if (topEnemy[i] == null)
                {
                    print("Enemy is dead"); // Log a message if the selected enemy is null
                }
                else
                {
                    topEnemy[i].ShootLaser(); // Call the ShootLaser method of the selected top-level enemy
                }
                break;

            case 1:
                int j = Random.Range(0, 9); // Randomly select an index for midEnemy array
                if (midEnemy[j] == null)
                {
                    print("Enemy is dead"); // Log a message if the selected enemy is null
                }
                else
                {
                    midEnemy[j].ShootLaser(); // Call the ShootLaser method of the selected mid-level enemy
                }
                break;

            case 2:
                int k = Random.Range(0, 9); // Randomly select an index for botEnemy array
                {
                    if (botEnemy[k] == null)
                    {
                        print("Enemy is dead"); // Log a message if the selected enemy is null
                    }
                    else
                    {
                        botEnemy[k].ShootLaser(); // Call the ShootLaser method of the selected bottom-level enemy
                    }
                }
                break;
        }
    }
}