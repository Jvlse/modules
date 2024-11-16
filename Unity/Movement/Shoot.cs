using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// creates bullet out of prefab at LMB press and deletes it after 2.5 seconds
public class Shoot : MonoBehaviour
{
    public GameObject bulletObject;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletObject, transform.position, transform.rotation);
            Destroy(bullet, 2.5f);
        }
    }
}
