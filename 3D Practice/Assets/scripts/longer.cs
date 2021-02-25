using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class longer : MonoBehaviour
{
    public Transform Player;
    void Start()
    {
        
    }

    
    void Update()
    {
        GetComponent<Transform>().localScale=new Vector3(15, 1, (int)Player.position.z*10+265);
        
    }
}
