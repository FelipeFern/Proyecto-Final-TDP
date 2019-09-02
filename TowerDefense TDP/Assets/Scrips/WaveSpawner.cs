using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5.5f;
    private float countdown = 2.5f;
    private int waveEnemies = 1;
    public float secondsPerEnemy = 0.5f;
    public int waveNumber = 0;

    public Text waveCount;

     void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        waveCount.text = Mathf.Round(countdown).ToString();
    }
    //Nos deja pausar por un tiempo. Se llama pero se ejecta cada cierto tiempo.
    IEnumerator SpawnWave()
    {
        for (int i = 0; i < waveEnemies; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(secondsPerEnemy);
        }
        if(waveEnemies < 8)
        {
            waveEnemies = waveEnemies * 2;
        }

        waveNumber++;
        Player.SetRounds(Player.GetRounds() + 1);
        
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
