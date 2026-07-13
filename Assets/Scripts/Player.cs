using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3.0f;

    private Rigidbody2D rb;
    private float movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = 0;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            movement = 1;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            movement = -1;
        }
    }

    void FixedUpdate()
    {
        // FixedUpdate is called at a fixed interval and is independent of frame rate.
        // It is used for physics calculations.

        Vector2 newPosition = rb.position + new Vector2(movement, 0) * speed * Time.fixedDeltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, -2.245f, 2.245f); // Clamp the x position to stay within the screen bounds

        rb.MovePosition(newPosition);
    }
}
