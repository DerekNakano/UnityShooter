using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

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

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
            gameController.UpdateHealth(10);

        Destroy(other.gameObject);
    }
}
