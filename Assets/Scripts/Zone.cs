using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{

    [SerializeField] public SpawnObject spawn;
    public bool pointClaimed = false;
    public bool river = false;

    //Grant point if entering this zone with each frog, kills if frog jumps into river.
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            FrogController script = col.gameObject.GetComponent<FrogController>();
            if (script.alive)
            {
                if (river && !script.isOnPlatform)
                {
                    script.Death();
                }
                if (!pointClaimed)
                {
                    GameController.Instance.GrantPoints(50f);
                    pointClaimed = true;
                }
            }

        }

    }

}
