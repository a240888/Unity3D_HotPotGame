using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollicion : MonoBehaviour
{
    public PlayerMovement movement;
    bool gameover = false;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "banana")
        {
            FindObjectOfType<GameManager>().slide();
            FindObjectOfType<PlayerMovement>().Hitbanana();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "wall")
            if (gameover == false)
            {
                movement.enabled = false;
                if (FindObjectOfType<PlayerMovement>().time_after_flash < 1 )
                {
                    FindObjectOfType<GameManager>().whataFlashSound();
                }          
                FindObjectOfType<GameManager>().itai();
                FindObjectOfType<GameManager>().GotHit();
                FindObjectOfType<GameManager>().Endgame();
                gameover = true;
            }  
        }

    }

