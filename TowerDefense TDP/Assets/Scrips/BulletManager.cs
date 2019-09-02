using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    private Transform target;

    public float speedBullet = 70f;

    public int damage = 50;

   




   public void Seek(Transform enemy)
    {
        target = enemy;
    }
    

    // Start is called before the first frame update
    void Start()
    {
       
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


        transform.Translate(direction.normalized * distance, Space.World);
    }


    void HitEnemy()
    {
        EnemyMovement1 e = target.GetComponent<EnemyMovement1>();

        e.TakeDamage(damage);       
        Destroy(gameObject);
       
    }



    

}




