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
        Vector3 direction = new Vector3(0, 0, 1);
		if (playerCol == false) {
			gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);
		}
        if (gameObject.transform.position.x < -2) {
            score++;
            Destroy(gameObject);
        }
        if (gameObject.transform.position.x > 2) {
            score++;
            Destroy(gameObject);
        }



        //if behind player

        if (gameObject.transform.position.z < -5) {
            score -= 10;
            Destroy(gameObject);
        }
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			playerCol = true;
		}
	}

}
