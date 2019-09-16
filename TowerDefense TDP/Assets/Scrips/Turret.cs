using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private Transform target;
    public float range = 15f;
    public string enemyName = "Enemy";
    

    public Transform partToRotate;

    public float fireRate = 1f;
    private float fireCountdown = 0f;

    public GameObject bullet;
    public Transform bulletPoint;

    // Use this for initialization 
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);    //Hace que UpdateTarget se ejecute 2 veces por segundo.(0.5)
    }

    // Update is called once per frame.
    void Update()
    {
        //Si no encuentra enemigo no hace nada.
        if (target == null)
            return;

        //Rotaciones.
        Vector3 direction = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction); 
        Vector3 rotation =  lookRotation.eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y + 90, 0f);


        //Disparos
        if(fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime; // Tiempo entre el anterior y el actual frame.

    }


    // Disparo
    void Shoot()
    {
        GameObject bala = (GameObject)Instantiate(bullet, bulletPoint.position, bulletPoint.rotation);
        BulletManager realBullet = bala.GetComponent<BulletManager>();

        if(realBullet != null)
        {
            realBullet.Assing(target);
        }

    }


    //Busca a su enemigo mas cercano dentro de su alcance.
    void UpdateTarget()
    {
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag(enemyName);
        float minDistance = Mathf.Infinity;
        GameObject minEnemy = null;
        
        foreach (GameObject enemy in enemigos)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if(distance < minDistance)
            {
                minDistance = distance;
                minEnemy = enemy;
            }

        }

        if(minEnemy != null && minDistance <= range)
        {
            target = minEnemy.transform;
        }
        else
        {
            target = null;
        }


    }



}
