using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public List<GameObject> obstaclesPrefabs;
    public GameObject player;
    
    void Start()
    {
        
    }

    void Update()
    {
        spawnObstacle();
    }

    void spawnObstacle()
    {
        System.Random r = new System.Random();
        int pos = r.Next(0,obstaclesPrefabs.Capacity-1);
        GameObject go = obstaclesPrefabs[pos];
        Vector3 positionToSpawn = player.transform.forward + new Vector3(0,0,10);
        Instantiate(go,positionToSpawn,Quaternion.identity);
    }
}
