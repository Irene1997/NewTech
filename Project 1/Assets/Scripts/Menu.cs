using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public GameObject explosion;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	private void Explode() {
		GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity);
		Destroy(gameObject); // destroy the cube
		Destroy(expl, 3);
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Player") {
			Debug.Log ("Hi ");
			Explode ();
			SceneManager.LoadScene (1);
		}
	}
}

