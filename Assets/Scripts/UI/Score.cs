using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;

    private float timer;
    private int score;

    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 5f)
        {

            score += 5;

            ScoreText.text = ("Score = " + score.ToString());

        }
    }
}
