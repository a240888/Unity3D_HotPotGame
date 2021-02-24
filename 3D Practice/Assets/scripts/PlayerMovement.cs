using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fowardforce = 2000f;
    public float sidewayforce = 500f;
    public Vector3 PlayerSpeed = new Vector3(0, 0, 0);
    private Vector3 Stop = new Vector3(0, 0, 0);
    private Transform PlayerTransform;
    private bool lose = false;

    void Start()
    {
        PlayerTransform = GetComponent<Transform>();
        
    }

    void FixedUpdate()
    {
        if (lose == false)
        {
            rb.AddForce(0, 0, fowardforce*Time.deltaTime);
        }
        PlayerSpeed.z = rb.velocity.z;
        PlayerSpeed.y = rb.velocity.y;
        Stop.z = rb.velocity.z;
        Stop.y = rb.velocity.y;
        if (Input.GetKey(KeyCode.RightArrow) && lose == false)
        {
            rb.velocity = PlayerSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && lose == false)
        {
            PlayerSpeed.z *= -1;
            rb.velocity = -PlayerSpeed;
            
        }
        else if (Input.GetKeyDown("d") && lose == false)
        {
            PlayerTransform.position = new Vector3(PlayerTransform.position.x, PlayerTransform.position.y, PlayerTransform.position.z+6);

        }
        else if (rb.position.y < -1f)
        {
            if (lose == false)
            {
                FindObjectOfType<GameManager>().WhatAreYouDoing();
                FindObjectOfType<GameManager>().Endgame();
                lose = true;
            }
            
        }
        else
        {
            rb.velocity = Stop;

        }

    }
}
