using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	public float speed = 10f;
	public float pushBackForce = 0f;
	public Camera cam;
	//public Rigidbody2D rotatorBody;
	
	
    // Start is called before the first frame update
    void Start()
    {
		//cam.backgroundColor = Color.green;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
	    if (other.tag == "Pin")
	    {
		    pushBack(other.transform);
	    }
    }

    public void pushBack(Transform pushedObject)
    {
	    Vector2 pushDirection = new Vector2(0,(pushedObject.position.y + (transform.position.y)/2f)).normalized;
	    pushDirection *= pushBackForce;
	    Rigidbody2D pushRB = pushedObject.gameObject.GetComponent<Rigidbody2D>();
	    pushRB.velocity = Vector2.zero;
	    pushRB.AddForce(pushDirection,ForceMode2D.Impulse);
	    
    }
}
