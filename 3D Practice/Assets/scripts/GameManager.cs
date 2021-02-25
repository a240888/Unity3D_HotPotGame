using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameOver = false;
    public float restartDelay = 1f;
    //public AudioSource hit;
    //public AudioSource drop;
    public AudioClip hit;
    public AudioClip drop;
    public AudioSource bgm;
    public AudioClip flash;
    public AudioClip whataflash;
    public AudioClip sliding;
    AudioSource audiosource;
    public Material[] material;
    MeshRenderer render;
    public GameObject Player;
    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    public void ChangePicture(float time)
    {
        render = Player.GetComponent<MeshRenderer>();
        if (time < 1)
        {
            render.sharedMaterial = material[0];
        }
        else if (time < 2)
        {
            render.sharedMaterial = material[1];
        }
    }
    public void FlashSound()
    {
        audiosource.PlayOneShot(flash);
    }
    public void whataFlashSound()
    {
        audiosource.PlayOneShot(whataflash);
    }
    public void GotHit()
    {
        render = Player.GetComponent<MeshRenderer>();
        render.sharedMaterial = material[2];
        
    }
    public void Endgame()
    {
        if (GameOver == false)
        {
            GameOver = true;
            Invoke("Restart", restartDelay);
        }
    }
    public void slide()
    {
        audiosource.PlayOneShot(sliding);
    }
    public void itai()
    {

        audiosource.PlayOneShot(hit);
            
    }
    public void WhatAreYouDoing()
    {
        audiosource.PlayOneShot(drop);
        audiosource.volume = 0.15f;
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
