using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Adds +1 to score when LMB is pressed
[RequireComponent(typeof(TMP_Text))]
public class ScoreText : MonoBehaviour
{
    private int score = 0;
    private TMP_Text textComponent;
    
    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            score += 1;
        textComponent.text = "Score: " + score;
    }
}
