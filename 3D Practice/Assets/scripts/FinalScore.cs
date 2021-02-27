using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    string score;
    void Start()
    {
        score = FindObjectOfType<ScoreRecord>().GetComponent<ScoreRecord>().score;

    }


    void Update()
    {
        GetComponent<Text>().text = "Score " + score;
    }
}
