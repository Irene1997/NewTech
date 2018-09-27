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
        if (BeatManager._beatCountX8 == 0 && BeatManager._beatFull) {

            beatSection++;
            _audioMixer.SetFloat("lowcutoff", Random.Range(500f, 10000f));
            _audioMixer.SetFloat("delayecho", Random.Range(500f, 10000f));
        }
        if (/*beatSection == 1 &&*/ BeatManager._beatCountX8 == 0 && BeatManager._beatFull) {
            //GameObject prefab = (GameObject)Instantiate(_prefab[0]);
            //prefab.transform.position = _prefabPos[0].position;
            GameObject prefab = Instantiate(_prefab[0], new Vector3(0, 1, 10), Quaternion.identity);
        }
    }
}
