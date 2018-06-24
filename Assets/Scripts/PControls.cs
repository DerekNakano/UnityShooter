using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PControls : MonoBehaviour {

    public GameObject bulletPrefab;
    //public Transform bulletSpawn;
    public float bulletSpeed;
    public float lookSensitivity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * lookSensitivity;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * lookSensitivity;

        transform.Rotate(-z, x, 0);
        //transform.Translate(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
	}
    
    //Fire spawns bullet
    void Fire()
    {
        Vector3 bulletSpawnOffset = new Vector3(0.0f, 0.0f, 0.0f);

        //creates a bullet from gameobject bullet
        Instantiate(
            bulletPrefab,
            (transform.position + bulletSpawnOffset),
            transform.rotation
            );

    }
}
