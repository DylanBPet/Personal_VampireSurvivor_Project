using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletScript : MonoBehaviour
{
    public List<GameObject> bulletsList;

    public GameObject bulletPrefab;

    public GameObject spawnedBullet;

    public Transform enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            spawnedBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bulletsList.Add(spawnedBullet);
        }

        for(int i = bulletsList.Count - 1; i >= 0; i--)
        {

            float distance = Vector2.Distance(bulletsList[i].transform.position, enemy.position);

          if (distance <= 1)
             {
                GameObject bullet = bulletsList[i];
                bulletsList.Remove(bullet);
                Destroy(bullet);
             }
            

        }

    }
}
