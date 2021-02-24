using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollicion : MonoBehaviour
{
    public PlayerMovement movement;
    bool gameover = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "wall")
        {
            if (gameover == false)
            {
                movement.enabled = false;
                FindObjectOfType<GameManager>().itai();
                FindObjectOfType<GameManager>().Endgame();
                gameover = true;
            }  
        }

    }
}
