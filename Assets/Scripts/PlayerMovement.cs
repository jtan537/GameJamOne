using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
	public Rigidbody _rb;
	public float forwardForce = 5000f;
	public float sidewaysForce = 80f;
	public float upForce = 50f;
	public bool moveLeft = false;
	public bool moveRight = false;
	public bool moveUp = false;

    public float _jumpDelay = 0.5f;
    public float jumpForce = 20f;
    public bool canJump = true;

    private AudioSource _fartSound;


    // Start is called before the first frame update

    void Start()
    {
        _fartSound = GameObject.Find("FartSoundManager").GetComponent<AudioSource>();
    }

    void Update() {
    	moveLeft = Input.GetKey("a");
    	moveRight = Input.GetKey("d");
		moveUp = Input.GetButtonDown("Jump");
        if (canJump && moveUp)
        {
            _rb.velocity = new Vector3(_rb.velocity.x, jumpForce, _rb.velocity.z);
            canJump = false;
            _fartSound.Play();
            StartCoroutine(Delay());
        }
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
        
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(_jumpDelay);
        canJump = true;
    }
}
