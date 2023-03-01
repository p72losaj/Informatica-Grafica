using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{

    public float speed;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal2");
        // Rotate every frame around the Z axis
        transform.Rotate(Vector3.forward * speed * horizontalInput * Time.deltaTime);
    }
}
