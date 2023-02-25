/*
 * PlayerController
 * Author: Jaime Lorenzo Sanchez
 * Version: 1.0
 * The PlayerController's script performs the following fundamental steps:
 *  1. Add movement to the vehicle.
 *  2. Add speed to the vehicle.
 *  3. Allow the vehicle to move left/right.
 *  4. Base left/right movement on input.
 *  5. Take control of the vehicle speed.
 *  6. Make vehicle rotate instead of slide.
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    // Initialize variables with values
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward based on vertical input.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the vehicle based on horizontal input.
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
