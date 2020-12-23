using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public float gravitySpeedRateAdd = 10f;

    void Start() {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravitySpeedRateAdd;
        //Debug.Log(GetComponent<Rigidbody2D>().gravityScale);
    }

    void Update() {
        if (transform.position.y < -3f) {
            Destroy(gameObject);
        }
    }
}
