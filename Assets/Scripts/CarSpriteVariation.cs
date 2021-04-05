using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpriteVariation : MonoBehaviour
{
    [SerializeField] Sprite[] sprites = new Sprite[3];
    [SerializeField] SpriteRenderer sr;


    void Awake()
    {
        ChangeLook();
    }



    public void ChangeLook()
    {
        sr.sprite = sprites[Random.Range(0, sprites.Length)];
    }


}
