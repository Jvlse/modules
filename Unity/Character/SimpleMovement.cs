using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Doesn't require any classes
// TODO add jumping/gravity
public class SimpleMovement : MonoBehaviour
{
    private float speed = 10;
    
    void Update()
    {
        float horizontal_movement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical_movement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        
        transform.Translate(horizontal_movement, 0, vertical_movement);
    }
}
