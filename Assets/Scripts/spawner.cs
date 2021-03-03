using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] zorro;
    public float minX, maxX, SpawnRate;
    private float NextSpawn;
    // Start is called before the first frame update
    void Start()
    {
        NextSpawn = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        if(Time.time > NextSpawn) { 
        Vector3 position = new Vector3(Random.Range(minX, maxX), transform.position.y);
        Instantiate(zorro[Random.Range(0, zorro.Length)], new Vector3(position.x, position.y, position.z), transform.rotation);
        NextSpawn = Time.time + SpawnRate;
    }
    }
}
