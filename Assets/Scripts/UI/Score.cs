using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text txt;
    int score;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score = score + 1;
        txt.GetComponent<UnityEngine.UI.Text>().text = "Score = "+ score.ToString();
    }
}
