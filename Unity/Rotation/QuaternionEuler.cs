using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionEuler : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        // Rotates object by 45° on all axes, Euler means first z then x and then y axes gets rotated
        transform.rotation = Quaternion.Euler(45, 45, 45);
    }

    void Update()
    {
        // keeps the object facing the target
        Vector3 lookVector = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(lookVector);
        // Same as Transform.LookAt(target);
    }
}
