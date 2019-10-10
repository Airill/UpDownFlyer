using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hudScript : MonoBehaviour
{
    float playerScore = 0;
    
    void Update()
    {
        playerScore += Time.deltaTime; 
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)playerScore); 
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)playerScore*100);
    }
}

