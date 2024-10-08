using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    // public variables: -> Can be changed in Unity editor
    public float speed;
    public float gravity;   
    // will be added to currentGravity each frame

    // private variables:
    private CharacterController character;
    private float currentGravity = 0f;

    void Start()
    {
        character = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 finalMovement = Movement() + ApplyGravity();
        character.Move(finalMovement * Time.deltaTime);
        // character.SimpleMove(finalMovement);
    }

    Vector3 ApplyGravity()
    {
        Vector3 gravityMovement = new Vector3(0, -currentGravity, 0);
        currentGravity += gravity * Time.deltaTime;
        
        // if character touches the ground 
        if (character.isGrounded)
        {
            if (currentGravity > 1f)
                currentGravity = 1f;
            // current Gravity has to be >= 1, because finalMovement has to point down for isGrounded to be true
        }
        return gravityMovement;
    }
    Vector3 Movement()
    {
        Vector3 moveVector = Vector3.zero;

        moveVector += transform.forward * Input.GetAxis("Vertical");
        moveVector += transform.right * Input.GetAxis("Horizontal");
        // Input.GetAxis("") is either 0, 1 or -1 

        moveVector *= speed;
        return moveVector;
    }
}
