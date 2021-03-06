﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineForceScript : MonoBehaviour {
    private float timeToDestroy = 0;

    private float trampolineForceLevel = 10; // set from shared pref

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeToDestroy += Time.deltaTime;
        if (timeToDestroy > 10)
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.GetComponent<Rigidbody2D>().AddForce(new Vector3(200 * trampolineForceLevel, 100 * trampolineForceLevel, 0));
    }
}
