using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour
{
    [SerializeField] GameObject frogObject;
    [SerializeField] AudioSource aS;
    [SerializeField] AudioClip claimedSFX;
    private bool pointClaimed = false;


    //Claim station, kills frog if it was already claimed
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            FrogController script = col.gameObject.GetComponent<FrogController>();

            if (!pointClaimed)
            {
                script.StopCoroutine(script.jumpCoroutine);
                script.Respawn();
                GameController.Instance.GrantPoints(50f);
                GameController.Instance.StationCleared();
                frogObject.SetActive(true);
                aS.clip = claimedSFX;
                aS.Play();
                GameController.Instance.fadeAnim.Play("yellowBlink");
                pointClaimed = true;
    
            }
            else  script.Death();
  
        }
    }

    public void Reset()
    {
        pointClaimed = false;
        frogObject.SetActive(false);
    }





}
