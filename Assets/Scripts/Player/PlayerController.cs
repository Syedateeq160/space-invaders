using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public SpriteRenderer playerSprite;
    private float rightScreenEdge;
    private float leftScreenEdge;
    private float playerSpriteHalfWidth;

    // Start is called before the first frame update
    private void Start()
    {
        // Initialise mainCamera variable with the game's current main camera
        Camera mainCamera = Camera.main;

        // Find the point in game world where the right screen edge touches
        Vector2 screenTopRightCorner = new Vector2(Screen.width, Screen.height);
        Vector2 topRightCornerInWorldSpace = mainCamera.ScreenToWorldPoint(screenTopRightCorner);
        rightScreenEdge = topRightCornerInWorldSpace.x;

        // Find the point in game world where the left screen edge touches
        Vector2 screenBottomLeftCorner = new Vector2(0f, 0f);
        Vector2 bottomLeftCornerInWorldSpace = mainCamera.ScreenToWorldPoint(screenBottomLeftCorner);
        leftScreenEdge = bottomLeftCornerInWorldSpace.x;

        // Calculate the player sprite's half-width
        playerSpriteHalfWidth = playerSprite.bounds.size.x / 2f;
    }

    // Update is called once per frame
    private void Update()
    {
        float inputHl = Input.GetAxis("Horizontal");

        // if pressed right (inputHl will be 1) and player character hasn't crossed the right limit of the screen,
        // allow them to keep moving right
        if (inputHl > 0 && (transform.position.x <= rightScreenEdge - playerSpriteHalfWidth - 0.05))
        {
            // move right
            Vector3 currentPos = transform.position;

            // we ADD 1 point along the X direction
            Vector3 newPos = currentPos + new Vector3(1f, 0f);

            // Apply the movement to the player character's position, adjusted by the speed and deltaTime
            transform.position = Vector3.MoveTowards(currentPos, newPos, moveSpeed * Time.deltaTime);
        }
        else if (inputHl < 0 && (transform.position.x >= leftScreenEdge + playerSpriteHalfWidth - 0.05))
        {
            // move left
            Vector3 currentPos = transform.position;

            // we SUBTRACT 1 point along the X direction
            Vector3 newPos = currentPos - new Vector3(1f, 0f);

            transform.position = Vector3.MoveTowards(currentPos, newPos, moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Laser"))
        {
            Destroy(this.gameObject);
        }
    }
}