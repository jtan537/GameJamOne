using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
	public Rigidbody _rb;
	public float forwardForce = 200f;
	public float sidewaysForce = 50f;
	public float upForce = 50f;
	public bool moveLeft = false;
	public bool moveRight = false;
	public bool moveUp = false;
    // Start is called before the first frame update


    void Update() {
    	moveLeft = Input.GetKey("a");
    	moveRight = Input.GetKey("d");
		moveUp = Input.GetKey("space");


    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	_rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    	if (moveRight){
    		_rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

    	}
    	if (moveLeft){
    		_rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

    	}
		if (moveUp) {
			_rb.AddForce(0, upForce * Time.deltaTime, 0, ForceMode.VelocityChange);
		}
        if (_rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();

        }
        
    }
}
