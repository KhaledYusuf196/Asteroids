using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverTimeSpawner : MonoBehaviour
{
    [SerializeField] float spawnRate;
    private AsteroidSpawner[] spawner;
    private Coroutine spawnCoroutine;

    private void Awake()
    {
        spawner = GetComponentsInChildren<AsteroidSpawner>();
    }

    void OnEnable()
    {
        
        spawnCoroutine = StartCoroutine(SpawnOverTime());
    }

    IEnumerator SpawnOverTime()
    {
        while (true) 
        {
            yield return new WaitForSeconds(spawnRate);

            spawner[Random.Range(0, spawner.Length)].SpawnAsteroid();
        }
    }

    private void OnDisable()
    {
        StopCoroutine(spawnCoroutine);
    }

}
