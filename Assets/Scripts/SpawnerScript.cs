using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] prefabs;
    public int maxSpawnCount = 20; 
    GameManager gameManager;

    void Start()
    {
        int spawnCount = Random.Range(1, maxSpawnCount + 1); 

        for (int i = 0; i < spawnCount; i++)
        {
            SpawnRandomPrefab();
        }
    }

    void SpawnRandomPrefab()
    {
        int randomIndex = Random.Range(0, prefabs.Length);
        GameObject prefabToSpawn = prefabs[randomIndex];
        Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        if (randomIndex == 0) 
        {
            prefabToSpawn.tag = gameManager.randomTag;
        }        
        prefabToSpawn.AddComponent<GameManager>();
    }
}


