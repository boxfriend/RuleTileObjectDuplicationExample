using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject TileMapPrefab;
    private GameObject spawnedObject;

    public void SpawnTileMap()
    {
        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
        }

        spawnedObject = Instantiate(TileMapPrefab, Vector3.zero, Quaternion.identity);
    }
}
