using UnityEngine;

public class MembunuhMusuh : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Musuh Bang"))
        {
            var enemy = collision.gameObject.GetComponent<PengontrolMusuh>();
            enemy.Kill();
        }
        
    }
}
