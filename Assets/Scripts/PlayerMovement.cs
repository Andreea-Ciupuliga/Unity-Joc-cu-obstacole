using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
   
    void FixedUpdate()

        //tastele cu care controlam cubul

    {  if (Input.GetKey("up")) 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("down")) 
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime);

        if (Input.GetKey("left")) 
        rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        // ForceMode.VelocityChange -> ignora greutatea obiectului si raspunde mai repede la comenzi stanga/dreapta
        
        if (Input.GetKey("right")) 
        rb.AddForce(sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        if (rb.position.y < -1f)
            FindObjectOfType<gameManager>().EndGame(); //jocul se termina si cand playerul cade de pe margine
    }

}
