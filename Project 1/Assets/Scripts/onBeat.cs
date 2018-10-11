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


    // Use this for initialization
    void Start() {

        beatSection = 0;
    }

    // Update is called once per frame
    void Update() {
        if (BeatManager._beatCountX2 == 0 && BeatManager._beatFull) {

            beatSection++;
            _audioMixer.SetFloat("lowcutoff", Random.Range(500f, 10000f));
            _audioMixer.SetFloat("delayecho", Random.Range(500f, 10000f));
        }
        if (BeatManager._beatCountX2 == 0 && BeatManager._beatFull) {
            GameObject prefab = Instantiate(_prefab[0], new Vector3(0, 2, 10), Quaternion.identity);
        }

        if (BeatManager._beatCountX4 == 0 && BeatManager._beatFull) {
            GameObject prefab = Instantiate(_prefab[1], new Vector3(1, 2, 10), Quaternion.identity);
        }

        if (BeatManager._beatCountX8 == 0 && BeatManager._beatFull) {
            GameObject prefab = Instantiate(_prefab[2], new Vector3(-1, 2, 10), Quaternion.identity);
        }
    }
}
