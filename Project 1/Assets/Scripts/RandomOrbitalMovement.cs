using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOrbitalMovement : MonoBehaviour {
    //Put this script on a game object. That game object needs to have one child-object, in our case the spawner. 

    [Header("ParentOfSpawnVariables")]
    [SerializeField]
    private Transform origin;

    [SerializeField]
    private float timer;
    private float timerOld;

    [SerializeField]
    private float randomSpeedMax;
    [SerializeField]
    private float randomSpeedMin;
    private float speed;


    [SerializeField]
    private float originOffset;

    private float wantedX;
    private float wantedY;
    private float wantedZ;

    private float posXOffset;

    // Use this for initialization
    void Start () {
        wantedX = 0;
        timerOld = timer;
        posXOffset = transform.position.x + originOffset;
        transform.GetChild(0).position = new Vector3(posXOffset, transform.position.y, transform.position.z);
        GetRot(true);
    }

    private Vector3 targetDir;
    private Vector3 newDir;

    // Update is called once per frame
    void FixedUpdate () {
        timer -= 1 * Time.deltaTime;
        if (timer < 0) {
            GetRot(true);
            timer = timerOld;
        }
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(wantedX, wantedY, wantedZ), Time.deltaTime * speed);

    }

    private void GetRot(bool a) {
        if (a == true) {
            wantedY = Random.Range(0, 360);
            wantedZ = Random.Range(0, 360);
            speed = Random.Range(randomSpeedMin, randomSpeedMax);
            a = false;
        }

    }
}
