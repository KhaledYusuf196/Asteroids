using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed;
    [SerializeField] float bulletSpawnOffset;

    public void shoot(Vector2 direction)
    {
        Transform spawnedBullet = Instantiate(bullet, transform.position, transform.rotation).transform;
        spawnedBullet.position += bulletSpawnOffset * new Vector3(direction.x, direction.y, 0);
        spawnedBullet.GetComponent<Rigidbody2D>().velocity = bulletSpeed * direction;
    }
}
