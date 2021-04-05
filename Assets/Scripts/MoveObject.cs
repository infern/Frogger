using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed=0.2f;


    void Update()
    {
       transform.localPosition = new Vector2(transform.localPosition.x + speed * Time.deltaTime, transform.localPosition.y);
    }

}
