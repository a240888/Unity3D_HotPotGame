using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRecord : MonoBehaviour
{
    public GameObject player;
    public string score;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }

    void Update()
    {
        if (FindObjectOfType<PlayerMovement>())
        {
            score = player.transform.position.z.ToString("0");
        }
        
        
    }
}
