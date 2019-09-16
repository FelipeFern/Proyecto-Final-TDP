using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    private Transform target;

    public float speedBullet = 70f;

    public int damage = 50;
    

   public void Assing(Transform enemy)
    {
        target = enemy;
    }
    

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distance = speedBullet * Time.deltaTime;

        if(direction.magnitude <= distance)
        {
            HitEnemy();
            return;
        }

        //Si no estoy cerca como para pegarle, translado la posicion de la bala.
        transform.Translate(direction.normalized * distance, Space.World);
    }


    void HitEnemy()
    {
        EnemyMovement1 e = target.GetComponent<EnemyMovement1>();

        e.TakeDamage(damage);       
        Destroy(gameObject);
       
    }
}




