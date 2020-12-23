using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour {

    public Rigidbody2D block;

    private int nextLv = 7;

    private int currentlv = 1;

    public Text UI;

    void Update() {
        //Debug.Log(Time.timeSinceLevelLoad);
        if (Time.timeSinceLevelLoad >= nextLv) {
            currentlv += 1;
            nextLv += 7;
            UI.text = currentlv.ToString();
        }
    }
}
