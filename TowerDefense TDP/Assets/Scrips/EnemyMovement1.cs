using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement1 : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    public int moneyPerKill = 10;
    public int health = 100;

    public Color damageColor;
 

    void Start()
    {
        target = WayPoints.points[0];       
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.3f)
        {
            GetNextWayPoint();
        }
    }

    void GetNextWayPoint()
    {
        if (wavepointIndex == WayPoints.points.Length - 1)
        {
            Destroy(gameObject);
            Player.ReduceLives();             
        }
        else
        {
            wavepointIndex++;
            target = WayPoints.points[wavepointIndex];
        }
    }

    public int getMoney()
    {
        return moneyPerKill;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        GetComponent<Renderer> ().material.color = damageColor;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Player.IncreaseMoney(moneyPerKill);
        Destroy(gameObject);

    }
}
