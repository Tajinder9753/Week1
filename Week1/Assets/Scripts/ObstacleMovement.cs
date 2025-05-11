using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public static float speed = 4f;
    GameObject ScoreUI;

    void Start()
    {
        ScoreUI = GameObject.FindGameObjectWithTag("ScoreText");    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Score.score++;
            Score.increaseSpeed++;
        }
    }
}
