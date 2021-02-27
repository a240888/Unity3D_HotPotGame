using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour
{
    public GameObject Wall;
    public GameObject Banana;
    public Transform Player;
    private float timer = 0;
    private float BananaTimer = 0;
    public float CreateTime = 6;
    public float BananaCreateTime = 6;
    private float Space;
    private Vector3 RandomPos;
    private Quaternion BananaRot;
    
    void Start()
    {
        BananaRot = Quaternion.Euler(0f, 0f, 0f);
    }

  
    void Update()
    {
        BananaTimer += Time.deltaTime;
        timer += Time.deltaTime;
        if (timer > CreateTime)
        {
            for(int i = 0; i < 5; i++)
            {
                Space = Random.Range(-6.5f, 6.5f);
                RandomPos = new Vector3(Space, 1.6f, Player.transform.position.z + 90);
                Instantiate(Wall, RandomPos, Player.transform.rotation);
            }
            timer = 0;
        }
        if (BananaTimer > BananaCreateTime)
        {
            for (int i = 0; i < 3; i++)
            {
                Space = Random.Range(-6, 6);
                RandomPos = new Vector3(Space, 1.6f, Player.transform.position.z + 90);
                Instantiate(Banana, RandomPos, BananaRot);
            }
            BananaTimer = 0;
        }
    }
}
