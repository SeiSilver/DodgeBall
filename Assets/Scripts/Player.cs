using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 150f;

    private Rigidbody2D rb;

    public float mapWith = 3.25f;

    public float MouseSpeed = 5f;

    public GameObject LoseUI;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        // use 'A' or 'D' or right/left arrow to move
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        if (x == 0) {
            x = Input.GetAxis("Mouse X") * Time.fixedDeltaTime * speed * MouseSpeed; // use mouse to control
        }

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWith, mapWith);

        rb.MovePosition(newPosition);

    }

    void OnCollisionEnter2D() {
        LoseUI.SetActive(true);
        FindObjectOfType<GameManager>().EndGame();
        //Debug.Log("End");
    }
}
