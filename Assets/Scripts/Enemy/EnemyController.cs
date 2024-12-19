using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float minPosX;
    public float maxPosX;

    public float minPosY;
    public float maxPosY;

    public float moveDistance = 1f;
    public float timeStep = 1f;

    private bool isMovingRight = true;
    private bool isMovingDown = true;

    // Use this for initialization
    private void Start()
    {
        // Invoke repeating will be called once after timeStep (2nd parameter) amount,
        // and then repeatedly every timeStep (3rd parameter) amount
        InvokeRepeating("Move", timeStep, timeStep);
    }

    private void Move()
    {
        if (isMovingRight)
        {
            // Moving right
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos + new Vector3(moveDistance, 0f);
            transform.position = newPos;
            moveUpNDown();
            // If aliens group reached the right-most edge, flip their direction
            if (transform.position.x >= maxPosX)
            {
                isMovingRight = false;
            }
        }
        else
        {
            // Moving left
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos - new Vector3(moveDistance, 0f);
            transform.position = newPos;
            moveUpNDown();
            // If aliens group reached the left-most edge, flip their direction
            if (transform.position.x <= minPosX)
            {
                isMovingRight = true;
            }
        }
    }

    private void moveUpNDown()
    {
        if (isMovingDown)
        {
            // Moving down
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos - new Vector3(0f, moveDistance, 0f);
            transform.position = newPos;

            // If aliens group reached the bottom-most edge, flip their direction
            if (transform.position.y <= minPosY)
            {
                isMovingDown = false;
            }
        }
        else
        {
            // Moving up
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos + new Vector3(0f, moveDistance, 0f);
            transform.position = newPos;

            // If aliens group reached the top-most edge, flip their direction
            if (transform.position.y >= maxPosY)
            {
                isMovingDown = true;
            }
        }
    }
}
