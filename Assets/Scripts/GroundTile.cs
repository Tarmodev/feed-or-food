using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    public GameObject obstaclePrefab;

    GroundSpawner groundSpawner;

    void Start() {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();

    }

    private void OnTriggerExit(Collider other) {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);

    }

    void SpawnObstacle() {
        // Choose a random point to spawn the obstacle 
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        // Spawn the obstacle at the position
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

    }

}
