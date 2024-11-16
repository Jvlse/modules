using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CollisionTest : MonoBehaviour
{
    // Used for testing collisions with object
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision happened");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision is happening"); // Printed at ever frame during collision
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision ended");
    }
}
