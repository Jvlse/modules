using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO add requirements
// Moves the object in z direction with variable speed
public class Bullet : MonoBehaviour
{
    float speed = 30;
    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // TODO shoot bullet in direction that player is facing
        // Relies on SimpleMovement for moving the bullet
    }
}
