using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    
    //object must have
    // 1. rigid body
    // 2. collider
    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
        }

    }
}
