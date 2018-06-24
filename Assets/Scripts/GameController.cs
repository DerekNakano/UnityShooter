using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy;
    public float enemySpawnDist;

	// Use this for initialization
	void Start () {
        Vector3 enemySpawn = new Vector3(Random.Range(-4.5f,4.5f), Random.Range(0.0f,8.0f), enemySpawnDist);
        Quaternion spawnRot = Quaternion.identity;

        Instantiate(enemy, enemySpawn, spawnRot);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
