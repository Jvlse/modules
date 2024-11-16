using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Changes objects color
[RequireComponent(typeof(MeshRenderer))]
public class ModifyMaterial : MonoBehaviour
{
    private MeshRenderer renderer;
    public Color col = Color.blue;
    
    void Start()
    {
        renderer = gameObject.GetComponent<MeshRenderer>();

        renderer.material.color = col;
    }
}
