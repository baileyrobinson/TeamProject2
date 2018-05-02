using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class wave {
    public int EnemiesPerWave;
    public GameObject Enemy;
}
public class EnemyManager : MonoBehaviour {

    public wave[] waves;
    public Transform[] SpawnPoints;
    public float SpawnTime = 2f;

    private int totalEnemiesInWave;
    public int enemiesLeft;
    private int spawnedEnemies;

    private int currentWave;
    private int totalWaves;

    public float timeLeft = 30f;
    private bool showText = false;
    
    
    
    // Use this for initialization
    void Start () {

       
        currentWave = -1;
        totalWaves = waves.Length - 1;

        StartNextWave();
        
    }

    void StartNextWave()
    {
        currentWave++;

        //end game or win
        if (currentWave > totalWaves)
        {
            return;
        }

        totalEnemiesInWave = waves[currentWave].EnemiesPerWave;
        enemiesLeft = 0;
        spawnedEnemies = 0;

        StartCoroutine(SpawnEnemies());
    }
    
    IEnumerator SpawnEnemies()
    {
        GameObject enemy = waves[currentWave].Enemy;
        while (spawnedEnemies < totalEnemiesInWave)
        {
            spawnedEnemies++;
            enemiesLeft++;

            int spawnPointIndex = Random.Range(0, SpawnPoints.Length);

            Instantiate(enemy, SpawnPoints[spawnPointIndex].position, SpawnPoints[spawnPointIndex].rotation);
            yield return new WaitForSeconds(SpawnTime);
        }
        yield return null;
    }

    public void enemyDefeated()
    {
        enemiesLeft--;

        if (enemiesLeft == 0 && spawnedEnemies == totalEnemiesInWave)
        {
            showText = true;
        }
    }
    void OnGUI()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 60F);
        int seconds = Mathf.FloorToInt(timeLeft - minutes * 60);
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        
        if (showText)
            GUI.Label(new Rect(400, 0, 250, 100), "Time To Next Wave: " + niceTime);
    }


    // Update is called once per frame
    void Update () {
        
        if (showText == true)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                timeLeft = 30f;
                showText = false;
                StartNextWave();
            }
        }
      
    }
}
