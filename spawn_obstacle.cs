using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_obstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float timebetweenSpawn;
    private float spawnTime;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if(Time.time>spawnTime){
            Spawn();
            spawnTime = Time.time + timebetweenSpawn;
        }
        
    }
    void Spawn(){
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        var copy = Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        Destroy(copy,3);
    }
}
