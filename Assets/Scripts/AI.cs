using UnityEngine;

public class AI : MonoBehaviour
{
    public Transform ballTransform;
    public float speed = 5.0f;

    private Rigidbody2D rb;
    private float movement = 0;
    private float lastY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastY = ballTransform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ballTransform != null && ballTransform.position.y > lastY)
        {
            if (ballTransform.position.x > 0f)
            {
                movement = 1;
            }

            if (ballTransform.position.x < 0f)
            {
                movement = -1;
            }
        }
    }

    void FixedUpdate()
    {
        Vector2 newPosition = rb.position + new Vector2(movement, 0) * speed * Time.fixedDeltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, -2.245f, 2.245f);

        rb.MovePosition(newPosition);
    }

}
