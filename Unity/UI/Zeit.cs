using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Zeit : MonoBehaviour
{
    public TMP_Text uhrzeit;

    void Update()
    {
        uhrzeit.text = DateTime.Now.ToString();
    }
}
