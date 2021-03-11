using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    /* Ca sa facem camera sa urmareasca jucatorul putem sa o luam si sa o
       tragem peste jucator dar nu este o idee buna ptc daca 
       obiectul se roteste atunci se va roti si camera
       Facem un script pentru Main Camera a.i. sa urmareasca doar pozitia playerului
     */

    public Transform player; //se refera la Transform din Unity din panoul din dreapta unde ne arata pozitia obiectului
    public Vector3 offset; //un vector cu axele x,y,z
      
    void Update()
    {
        transform.position = player.position + offset;
    }
}
