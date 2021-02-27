using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScore : MonoBehaviour
{
    private GameObject score;
    public void DesroyScore()
    {
        score = GameObject.Find("Score");
        Destroy(score);
    }
    
}
