using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submerge : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] Platform platformScript;

    [Header("Settings")]
    [SerializeField] private Vector2 timerBracket = new Vector2(3f, 6f);
    [Range(1f, 3f)] [SerializeField] private float warningDuration = 1.3f;
    [Range(1f, 3f)] [SerializeField] private float submergedDuration = 1.2f;


    void Start()
    {
        StartCoroutine(SubCor());
    }

    IEnumerator SubCor()
    {
        //Random value from bracket, determines time required for warning to start
        float a = Random.Range(timerBracket.x, timerBracket.y);
        yield return new WaitForSeconds(a);
        anim.Play("warning");
        yield return new WaitForSeconds(warningDuration);
        anim.Play("submerge");
        yield return new WaitForSeconds(0.2f);
       //Drops frog off the platform when lilypads are submerged
        platformScript.active = false;
        if (platformScript.frog != null)
        {
            platformScript.frog.isOnPlatform = false;
            platformScript.frog.transform.parent = null;
            platformScript.frog = null;
        }
        yield return new WaitForSeconds(submergedDuration);
        anim.Play("emerge");
        platformScript.active = true;
        StartCoroutine(SubCor());
    }

}
