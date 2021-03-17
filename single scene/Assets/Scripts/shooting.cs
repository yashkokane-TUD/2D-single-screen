using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    
        float fireRate;
        float nextFire;
    
        void Start()
        {
            fireRate = 1f;
            nextFire = Time.time;
        }
    
        void Update()
        {
            CheckIfTimeToFire();
        }
    
        void CheckIfTimeToFire()
        {
            if(Time.time > nextFire)
            {
                Instantiate(Bullet, transform.position, Quaternion.identity);
                nextFire = Time.time + fireRate;
            }
        }
}
