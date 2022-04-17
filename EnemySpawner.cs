using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] objects;                
    public float spawnTime = 6f;            
    //private Vector3 spawnPosition;
   
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", spawnTime);
        //if you want enemies to spawning repeatly, use invoke repeating.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {

        //spawnPosition.x = Random.Range(-17, 17);
        // spawnPosition.y = -0.2f;
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));
       


        Instantiate(objects[Random.Range(0, objects.Length - 1)], screenPosition, Quaternion.identity);
        }
    }
