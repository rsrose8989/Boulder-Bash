using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject wallPrefab;
    public GameObject spawnedWall;

    // Start is called before the first frame update
    void Start()
    {
        SpawnWall();
    }

    // Update is called once per frame
    void Update()
    {
        //spawns wall when R is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            SpawnWall();
        }
    }

    void SpawnWall()
    {
        //destroy previous wall then create new in random location
        Destroy(spawnedWall);
        spawnedWall = Instantiate(wallPrefab);
        float randomX = Random.Range(-7f, 8f);
        spawnedWall.transform.position = new Vector3(randomX, spawnedWall.transform.position.y, spawnedWall.transform.position.z);
    }
}

