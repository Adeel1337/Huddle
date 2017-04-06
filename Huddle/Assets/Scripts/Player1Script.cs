﻿using UnityEngine;
using System.Collections;
using System;

public class Player1Script : MonoBehaviour
{

    public Vector2 speed = new Vector2(50, 50);
	private Vector3 movement;
	private bool isboxStuck;
	private Collision2D boxStuck;

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY);

        movement *= Time.deltaTime;

        transform.Translate(movement);
		try {boxStuck.transform.Translate (movement);}
		catch (Exception e) {
		}
    }
	// drag object
	void OnCollisionEnter2D(Collision2D box) {


		if (box.gameObject.layer == 13 || box.gameObject.layer == 19&&Input.GetKey(KeyCode.Space)) {
				//Debug.Log ("the correct box is here");
				isboxStuck = true;
				boxStuck = box;
			}

	}



}
