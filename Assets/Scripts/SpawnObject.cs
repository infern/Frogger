using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{

    [SerializeField] GameObject objectPrefab;
    private float spawnLocation = 0f;
    [Range(0f, 12f)] [SerializeField] public float spawnOffset = 0f;
    [Range(1f, 12f)] [SerializeField] public float objectOffset = 6.5f;
    [Range(0.1f, 12f)] [SerializeField] public float objectSpeed = 5f;
    public int spawnCount = 3;
    public List<GameObject> spawnedObjects = new List<GameObject>();
    public bool flipped = false;


    void Awake()
    {
       if (flipped) Flip();
    }

    //Create obstacles with position offset between them and set their movement speed
    public void CreateObjects()
    {
        spawnLocation = transform.position.x;
        for (int i = 0; i < spawnCount; i++)
            {
                GameObject spawned = Instantiate(objectPrefab, new Vector2(spawnLocation + spawnOffset*transform.localScale.x, transform.position.y), Quaternion.identity);
                spawnLocation += objectOffset * transform.localScale.x;
                spawned.SetActive(true);
                spawned.transform.parent = transform;
                spawned.GetComponent<MoveObject>().speed = objectSpeed;
                spawnedObjects.Add(spawned);
                if (flipped) spawned.transform.localScale = new Vector2(spawned.transform.localScale.x * -1, spawned.transform.localScale.y);
            }

    }
   
    public void DestroyObjects()
    {
       foreach (GameObject spawned in spawnedObjects) Destroy(spawned);
    }


    //If object moves outside of screen it will be moved to the beggining of the zone.
    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = transform.position;
        if (collision.gameObject.CompareTag("Car")) collision.GetComponent<CarSpriteVariation>().ChangeLook();

    }


    public void Flip()
    {
        transform.position = new Vector2(transform.position.x*-1, transform.position.y);
        transform.localScale = new Vector2(transform.localScale.x*-1,1);
    }



}
