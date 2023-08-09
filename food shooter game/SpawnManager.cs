using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
        public GameObject[] animals;
        public int animalIndex;
        public float spawnPositionZ =20f;
        public float spawnPositionX =20f;
        private float startDelay =2;
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

    void SpawnRandomAnimal() 
    {
        animalIndex = Random.Range(0,animals.Length);
            Vector3 spawnPosition = new (Random.Range(-spawnPositionX,spawnPositionZ),0,spawnPositionZ);
            Instantiate(animals[animalIndex],spawnPosition, animals[animalIndex].transform.rotation);
    }
}

