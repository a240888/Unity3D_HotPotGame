using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scores : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;
    public GameObject player;
    void Update()
    {
        if (player.GetComponent<PlayerMovement>().enabled == true)
        {
            ScoreText.text = Player.position.z.ToString("0");
        }
        else
        {
            ScoreText.text = "ㄚㄚㄚ一代一代";
        }
        
    }
}
