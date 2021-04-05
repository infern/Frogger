using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public FrogController frog;
    public bool active = true;

    //Frog moves together with platform and is immune to dying from water while its on it
     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && active)
        {
            FrogController script = col.gameObject.GetComponent<FrogController>();
            frog = script;
            if (script.alive)
            {
                script.transform.parent = this.transform;
                script.isOnPlatform = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            FrogController script = col.gameObject.GetComponent<FrogController>();
            frog = null;
            script.transform.parent = null;
            script.isOnPlatform = false;

        }
    }


}
