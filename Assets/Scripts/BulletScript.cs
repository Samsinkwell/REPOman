﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    private Transform bullet;
    public float speed;

    // Start is called before the first frame update
    void Start() {
        bullet = GetComponent<Transform> ();
        
    }

    void FixedUpdate() {
        bullet.position += Vector3.up * speed;

        if (bullet.position.y >= 10)
            Destroy(gameObject);
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Enemy"){
            Destroy (other.gameObject);
            Destroy(gameObject);
            //increase player score later
        }
        else if(other.tag == "Base")
            Destroy(gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
