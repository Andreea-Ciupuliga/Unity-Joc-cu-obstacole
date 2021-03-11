using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    //pentru atunci cand ajungem la finalul nivelului
    public gameManager gameManager;
    
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

   
}
