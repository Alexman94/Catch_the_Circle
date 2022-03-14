using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text scoreText;
    public GameObject restartButton;
    uint score;
    uint maxScore;


    private void Start()
    {
        scoreText.text = "Score: " + score;
        maxScore = (uint)GameObject.FindGameObjectsWithTag("Circle").Length;
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        if (score >= maxScore)
        {
            restartButton.SetActive(true);
        }
    }
}
