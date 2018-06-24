using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");

        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }

        if (gameController == null)
        {
            Debug.Log("Couldn't find game controller script");
        }

    }

	void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Enemy")     //checks to make sure it's colliding with enemy  
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

            gameController.UpdateScore(1);
        }
    }
}
