using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject enemy;
    public float enemySpawnDist;

    public int waveCount;
    public float waveDelay;

    public Text scoreText;
    public Text healthText;
    public Text gameOverText;

    private bool gameOver;

    private int score;
    private int health;

    // Use this for initialization
    void Start () {
        score = 0;                          //initializes the score
        health = 100;

        gameOver = false;
        gameOverText.text = "";

        UpdateScore();
        UpdateHealth();
        

        StartCoroutine(SpawnWaves());       //starts spawning enemies

	}

    IEnumerator SpawnWaves()
    {
        while(!gameOver)
        {
            for (int i = 0; i < waveCount; i++)
            {
                //yield return new WaitForSeconds(waveDelay);

                Vector3 enemySpawn = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(0.0f, 8.0f), enemySpawnDist);
                Quaternion spawnRot = Quaternion.identity;

                Instantiate(enemy, enemySpawn, spawnRot);

                yield return new WaitForSeconds(1.0f);  //delay of 1 second per enemy so they dont collide with one another
            }
            yield return new WaitForSeconds(waveDelay);
        }

    }
	
    public void UpdateScore(int points = 0)  //increments score when bullet destroys enemy
    {
        score += points;

        scoreText.text = "Score: " + score;
    }

    public void UpdateHealth(int points = 0)
    {
        health -= points;
        health = health < 0 ? 0 : health;

        if (health == 0)
        {
            gameOver = true;
            gameOverText.text = "Game Over!!!";
        }

        healthText.text = "Health: " + health;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
