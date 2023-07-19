using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] topAnimalPrefabs;
    public GameObject[] leftAnimalPrefabs;
    public GameObject[] rightAnimalPrefabs;
    private float spawnRangeX = 15.0f;
    private float spawnPosZ = 15.0f;

    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Spawn animal at random
    void SpawnRandomAnimal()
    {
        int topAnimalIndex = Random.Range(0, topAnimalPrefabs.Length);
        int leftAnimalIndex = Random.Range(0, leftAnimalPrefabs.Length);
        int rightAnimalIndex = Random.Range(0, rightAnimalPrefabs.Length);
        
        Vector3 topSpawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(topAnimalPrefabs[topAnimalIndex], topSpawnPos, topAnimalPrefabs[topAnimalIndex].transform.rotation);

        Vector3 leftSpawnPos = new Vector3(-19, 0, Random.Range(0, spawnPosZ));
        Instantiate(leftAnimalPrefabs[leftAnimalIndex], leftSpawnPos, leftAnimalPrefabs[leftAnimalIndex].transform.rotation);

        Vector3 rightSpawnPos = new Vector3(19, 0, Random.Range(0, spawnPosZ));
        Instantiate(rightAnimalPrefabs[rightAnimalIndex], rightSpawnPos, rightAnimalPrefabs[rightAnimalIndex].transform.rotation);
    }
}
