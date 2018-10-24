using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class onBeat : MonoBehaviour
{
    public int beatSection;


    public GameObject[] _prefab;
    public Transform[] _prefabPos;
    public AudioMixer _audioMixer;

	public AudioSource audiosource;
	public AudioSource[] voiceClips;

	Vector3 pos;
	Quaternion rot;
	int counterOne = 0;
	int counterTwo = 0;

	// Use this for initialization
    void Start() {

        beatSection = 0;
    }

    // Update is called once per frame
    void Update() {
		pos = gameObject.transform.position;
		rot = gameObject.transform.rotation;

		if (beatSection == 21) {
			BeatFireworks ();
		}
		if (beatSection == 23) {
			BeatFireworks ();
		}

        if (BeatManager._beatCountX2 == 0 && BeatManager._beatFull) {
			counterOne++;
			counterOne = counterOne % 3;
			GameObject prefab = Instantiate(_prefab[counterOne], pos, rot);
        }

		if (BeatManager._beatCountX32 == 0 && BeatManager._beatFull) {
			counterTwo++;
			counterTwo = counterTwo % 5;
			voiceClips[counterTwo].Play();
		}
       
    }
	void BeatFireworks() {
		GameObject prefab = Instantiate(_prefab[0], new Vector3(0, 1, 10), Quaternion.identity);
		GameObject prefab2 = Instantiate(_prefab[0], new Vector3(0, 0, 10), Quaternion.identity);
	}
}
