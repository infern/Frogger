using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnTriggerEnter : MonoBehaviour
{
    public bool penalty = true;

    //Kill frog, if it went out of the screen at starting zone (penalty==false) then just respawn the frog at starting position
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (penalty) collision.GetComponent<FrogController>().Death();
            else collision.GetComponent<FrogController>().Respawn();

        }
            
            
          
    }

}
