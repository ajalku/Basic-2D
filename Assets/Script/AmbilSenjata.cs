using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class AmbilSenjata : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    private Transform grabPoint;
    [SerializeField]
    private Transform rayPoint;
    [SerializeField]
    private float rayDistance;

    private GameObject grabbedObject;
    private int layerIndex;
    private void Start()
    {
        layerIndex = LayerMask.NameToLayer("Object");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(rayPoint.position, transform.right, rayDistance); // 
        if (hitInfo.collider != null && hitInfo.collider.gameObject.layer == layerIndex)
        {
            // grab object
            if (Keyboard.current.eKey.wasPressedThisFrame && grabbedObject == null)
            {
                grabbedObject = hitInfo.collider.gameObject;
                grabbedObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                grabbedObject.transform.position = grabPoint.position;
                grabbedObject.transform.SetParent(transform);
            }
            // release object
            else if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                grabbedObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                grabbedObject.transform.SetParent(null);
                grabbedObject = null;
            }
        }
        Debug.DrawRay(rayPoint.position, transform.right * rayDistance);
    }
}
