using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontal;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal,rb.linearVelocity.y);
    }
}
