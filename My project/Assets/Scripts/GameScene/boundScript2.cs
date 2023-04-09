using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundScript2 : MonoBehaviour
{
    // Collision force
    public float force = 10.0f;
    public float forceRadius = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // if collider with the ball, add an explosion force
    private void OnCollisionEnter(Collision collision)
    {
        foreach (Collider collider in Physics.OverlapSphere(transform.position, forceRadius))
        {
            // The component with an RigidBody
            if (collider.GetComponent<Rigidbody>())
            {
                collider.GetComponent<Rigidbody>().AddExplosionForce(force, transform.position, forceRadius);
            }
        }
        
    }
}
