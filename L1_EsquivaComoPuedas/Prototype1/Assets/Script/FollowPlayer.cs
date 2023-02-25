/*
 * FollowPlayer controller
 * Author: Jaime Lorenzo Sanchez
 * Version: 1.0
 * The PlayerController's script performs the following fundamental steps:
 *  1. Assign the camera's position to the player's position.
 *  2. Add an offset to the camera position.
 *  3. Smooth the Camera
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // GameObject player
    public GameObject player;

    // Make the offset into a Vector3 variable
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    
    // Smooth the Camera with LateUpdate 
    void LateUpdate()
    {   
        transform.position = player.transform.position + offset;
    }
}
