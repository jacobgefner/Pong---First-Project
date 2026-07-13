using UnityEngine;

public class Movment : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        Vector2 direction = new Vector2(
            Random.value < 0.5f ? -1 : 1,
            Random.Range(-0.5f, 0.5f)
        ).normalized;

        rb2d.linearVelocity = direction * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb2d.linearVelocity = rb2d.linearVelocity.normalized * speed;
    }
}
