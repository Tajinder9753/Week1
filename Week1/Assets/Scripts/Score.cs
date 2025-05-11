using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int increaseSpeed = 0;
    TextMeshProUGUI gameScore;
    
    
    void Start()
    {
        gameScore = GetComponent<TextMeshProUGUI>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameScore.text = score.ToString();
        Debug.Log(gameScore.text);

        if (increaseSpeed == 10)
        {
            increaseSpeed = 0;
            ObstacleMovement.speed += 3;
        }
    }
}
