﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    public float movespeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate (new Vector3(movespeed, 0, 0) * Time.deltaTime);
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag== "Block" || col.gameObject.tag == "Enemy" )
        {
            movespeed *= -1;
        }

       
        if (col.gameObject.tag == "Player")
        {
            //Destroy(col.gameObject);
            //Pauses gameplay
            //Application.LoadLevel(Application.loadedLevel);
        }
    }
}
