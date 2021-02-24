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
    AudioSource audiosource;
    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    public void Endgame()
    {
        if (GameOver == false)
        {
            GameOver = true;
            Invoke("Restart", restartDelay);
        }
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
