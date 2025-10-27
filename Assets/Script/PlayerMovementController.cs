using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    private Rigidbody2D _playerRB;
    public GroundDetector groundDetector;
    public float velocity = 6;
    public float jumpHeight = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // WASD
        // delta_s = v * delta_t
        // pengen ngubah velocity, bikin aja public float velocity
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            _playerRB.linearVelocityX = -velocity;
        }
        else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            _playerRB.linearVelocityX = velocity;
        }
        else
        {
            _playerRB.linearVelocityX = 0;
        }
        if (groundDetector.isOnGround && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)))
        {
            Jump();
        }

    }

    private void Jump()
    {
        // v = sqrt(2gh)
        _playerRB.linearVelocityY = Mathf.Sqrt(2 * Mathf.Abs(Physics2D.gravity.y) * jumpHeight);
        groundDetector.isOnGround = false;
    }
}
