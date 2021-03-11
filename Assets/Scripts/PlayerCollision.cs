using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
   
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacol")
        {
            //atunci cand playerul loveste ceva sa se opreasca
            movement.enabled = false;
            FindObjectOfType<gameManager>().EndGame(); 
           /*
            nu puteam folosit o variabila deoarece cand playerul moare se termina jocul asa ca in cazul asta 
            vom cauta in Unity dupa gameManager
           */
        }
    }
   
}
