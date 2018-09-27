using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start (/*float Speed*/) {
        //speed = speed;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = new Vector3(0, 0, 1);

        gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);
        //if behind player

        if(gameObject.transform.position.z < 0) {
            Destroy(gameObject);
        }
	}

}
