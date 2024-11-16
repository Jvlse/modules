using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public GameObject cube; // Variable cube, in der man ein Game Object speichern kann

    void Start()
    {
        cube = GameObject.Find("SuperCube");
    }

    void Update()
    {
        // Adds constant rotation
        cube.transform.Rotate(0, 30 * Time.deltaTime, 0);
    }
}
