using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyPrefab2;
    public Transform spawnSpot;
    int appearedEnemy = 0;
    int appearedEnemy2 = 0;
    int appearedEnemy3 = 0;
    float totaltime = 0f;
    float time = 0f;
    public Text wave;
    public int amountToEnemy;
    public int amountToEnemy2;
    public int amountToEnemy3;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        totaltime += Time.deltaTime;
        if (time >= 2f && appearedEnemy < amountToEnemy)
        {
            wave.text = "Level 1 Wave 1";
            GameObject enemy = (GameObject)Instantiate(enemyPrefab, spawnSpot.position, spawnSpot.rotation);
            time = 0f;
            appearedEnemy += 1;
        }

        if (time >= 1f && totaltime > 50 && appearedEnemy2 < amountToEnemy2)
        {
            wave.text = "Level 1 Wave 2";
            GameObject enemy = (GameObject)Instantiate(enemyPrefab2, spawnSpot.position, spawnSpot.rotation);
            time = 0f;
            appearedEnemy2 += 1;
        }

        if (time >= 1.5f && totaltime > 80 && appearedEnemy3 < amountToEnemy3)
        {
            wave.text = "Level 1 Wave 3";
            GameObject enemy1 = (GameObject)Instantiate(enemyPrefab, spawnSpot.position, spawnSpot.rotation);
            GameObject enemy2 = (GameObject)Instantiate(enemyPrefab2, spawnSpot.position, spawnSpot.rotation);
            time = 0f;
            appearedEnemy3 += 1;
        }
    }
}
