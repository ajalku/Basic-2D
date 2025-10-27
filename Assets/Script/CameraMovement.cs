using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = playerTransform.position;
        position.z = transform.position.z;
        transform.position = position;
    }
}
