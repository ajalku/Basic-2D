using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    private int _colliderGround = 0;
    public bool isOnGround;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tanah"))
        {
            isOnGround = true;
            _colliderGround++;
        }
    }
        void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Tanah"))
        {
            _colliderGround--;
        }
        if (_colliderGround == 0)
        {
            isOnGround = false;
        }
    }
}
