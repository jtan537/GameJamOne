using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnTriggerEnter(Collision collision)
    {
    	if (collision.collider.tag == "Player")
    	{
    		Destroy(this.gameObject);
    	}
    }
}
