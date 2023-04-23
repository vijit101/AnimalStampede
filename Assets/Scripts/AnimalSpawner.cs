using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    float Xbound = 22;
    float Zspawn = 22;
    public GameObject[] AnimalArray;
    int startDelay = 2;
    int SpawnInterval = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    void SpawnRandomAnimal()
    {
        int randomAnimalIndex = Random.Range(0, AnimalArray.Length - 1);

        Vector3 SpawnPosition = new Vector3(Random.Range(-Xbound, Xbound), 0, Zspawn);
    }
}
