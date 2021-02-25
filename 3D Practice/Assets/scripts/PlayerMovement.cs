using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fowardforce = 2000f;
    public float sidewayforce = 500f;
    public Vector3 PlayerSpeed = new Vector3(0, 0, 0);
    private Vector3 Stop = new Vector3(0, 0, 0);
    private Transform PlayerTransform;
    public bool lose = false;
    float time = 0;
    public float time_after_flash = 2;
    bool flashed = false;
    public GameObject FlashParical;


    void Start()
    {
        PlayerTransform = GetComponent<Transform>();
        
    }
    private void Update()
    {
        if (time < 2)
        {
            time += 1f*Time.deltaTime;
        }
        else
        {
            time = 0;
        }
        if (lose == false)
        {
            FindObjectOfType<GameManager>().ChangePicture(time);
        }
        if ((Input.GetKeyDown("d") || Input.GetKeyDown("f")) && lose == false && FindObjectOfType<FlashCoolDown>().IsStartTimer == false)
        {
            time_after_flash = 0;
            PlayerTransform.position = new Vector3(PlayerTransform.position.x, PlayerTransform.position.y, PlayerTransform.position.z + 6);
            FindObjectOfType<GameManager>().FlashSound();
            flashed = true;
            Instantiate(FlashParical, PlayerTransform.position, PlayerTransform.rotation);
            if (FindObjectOfType<FlashCoolDown>().IsStartTimer == false)
            {
                FindObjectOfType<FlashCoolDown>().OnCool();
            }
        }
        if (flashed)
        {
            time_after_flash += Time.deltaTime;
        }
        
    }
    public void Hitbanana()
    {
        fowardforce += 1000;
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
        else if (rb.position.y < -1f)
        {
            if (lose == false)
            {
                lose = true;
                FindObjectOfType<GameManager>().WhatAreYouDoing();
                FindObjectOfType<GameManager>().Endgame();

            }
            
        }
        else
        {
            rb.velocity = Stop;

        }

    }
}
