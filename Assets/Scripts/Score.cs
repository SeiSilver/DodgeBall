using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;

    private int score = 0;

    // Update is called once per frame
    void Update() {

        score = Mathf.FloorToInt(Time.timeSinceLevelLoad * 4f);
        scoreText.text = score.ToString("0");
    }
}
