using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    public float MoveSpeed { get => moveSpeed; private set => moveSpeed = value; }
    [SerializeField] private float jumpForce = 10f;
    private bool isInvulnerable = false;
    public bool IsInvulnerable { get => isInvulnerable; private set => isInvulnerable = value; }
    public Rigidbody2D rb;
    private bool isInvulnerable1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2 (moveInput * moveSpeed, rb.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void SetMoveSpeed(float newSpeed)
    {
        Debug.Log($"Your Speed: {MoveSpeed}");
    }

    public void SetInvulnerability(bool isEnable)
    {
        Debug.Log($"Your Invulnerability: {IsInvulnerable}");
    }
}
