using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hudScript : MonoBehaviour
{
    float playerScore = 0;

    private GUIStyle guiStyle = new GUIStyle();

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
        guiStyle.fontSize = 60;
        guiStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(20, 20, 800, 250), "Score: " + (int)playerScore*100, guiStyle);
    }
}

