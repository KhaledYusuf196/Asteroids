using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] Asteroids;
    [SerializeField] float minimumSpeed;
    [SerializeField] float maximumSpeed;

    public void SpawnAsteroid()
    {
        GameObject spawnedAsteroid =  Instantiate(Asteroids[Random.Range(0, Asteroids.Length -1)], transform.position, Quaternion.identity);
        spawnedAsteroid.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.value - 0.5f, Random.value - 0.5f).normalized * Random.Range(minimumSpeed, maximumSpeed);
    }

}
