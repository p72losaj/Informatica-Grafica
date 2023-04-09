using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerScript : MonoBehaviour
{
    // Power float
    public float power;
    public float minPower = 0f;
    public float maxPower = 100f;
    public Slider powerSlider;
    public List<Rigidbody> ballLists;
    public bool ballReady = true;

    // Start is called before the first frame update
    void Start()
    {
        powerSlider.minValue = 0f;
        powerSlider.maxValue = maxPower;
        ballLists = new List<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set Active
        if (ballReady)
        {
            powerSlider.gameObject.SetActive(true);
        }
        else
        {
            powerSlider.gameObject.SetActive(false);
        }
        powerSlider.value = power;
        if(ballLists.Count > 0)
        {
            ballReady = true;
            // If pulse space, increase the power's slider
            if (Input.GetKey(KeyCode.Space))
            {
                if(power <= maxPower)
                {
                    power += 50 * Time.deltaTime;
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                foreach (Rigidbody r in ballLists)
                {
                    r.AddForce(power * Vector3.forward);       
                }
            }
        }
        else
        {
            ballReady = false;
            power = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballLists.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballLists.Remove(other.gameObject.GetComponent<Rigidbody>());
            power = 0f;
        }
    }
}
