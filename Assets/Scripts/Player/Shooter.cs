using UnityEngine;

public class Shooter : MonoBehaviour
{
    // reference to the original prefab to instatiate
    public GameObject projectilePrefab;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        // We instantiate the prefab at the same position as the player,
        // since this script is on the player GameObject
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}