using UnityEngine;

public class MusuhGakNabrakPlayer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
