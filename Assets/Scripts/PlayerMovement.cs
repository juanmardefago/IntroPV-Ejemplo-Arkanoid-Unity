using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rBody;
    public int speed;

	// Use this for initialization
	void Start () {
        rBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        // Consigo el input horizontal (LeftArrow - RightArrow) con smoothing
        float hInput = Input.GetAxis("Horizontal");
        // Le cambio la velocidad al RigidBody2D por el Vector2 que tenga en X la velocidad * el input horizontal, y en la Y, 0.
        rBody.velocity = new Vector2(hInput * speed, 0);        
	}

}
