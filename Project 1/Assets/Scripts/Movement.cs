using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    public int score = 0;
	private bool playerCol = false;
	// Use this for initialization
	void Start (/*float Speed*/) {
        //speed = speed;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = new Vector3(1, 0, 0);
		if (playerCol == false) {
			gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);
		}
        
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			playerCol = true;
		}
	}

}
