using UnityEngine;
using TMPro;

public class scoreScript : MonoBehaviour
{
    int score = 0;
    
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        GetComponent<TextMeshPro>().text = ("Your score: " + score*100 + "! \n Good job!");
    }


}
