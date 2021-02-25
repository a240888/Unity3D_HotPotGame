using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{   
    private float Player;
    void Start()
    {       
        if(gameObject.tag=="partical")
        {
            Invoke("destroy_itself", 2);
        }    
    }
    private void destroy_itself()
    {   
        Destroy(gameObject);
    }
    void Update()
    {
        Player = GameObject.Find("player").GetComponent<Transform>().position.z;
        if (gameObject.tag == "wall" && gameObject.transform.position.z + 10 < Player)
        {
            Destroy(gameObject);
        }
    }
}
