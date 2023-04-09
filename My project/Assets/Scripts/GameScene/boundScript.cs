using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundScript : MonoBehaviour
{
    // Collision force
    public float force = 10.0f;
    public float forceRadius = 1.0f;
    public int scoreValue = 100;

    // Collision sound
    private AudioSource audioSource;
    public AudioClip boundSound;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
        audioSource.PlayOneShot(boundSound, 1.0f);
        ScoreManager.score += scoreValue;
    }
}
