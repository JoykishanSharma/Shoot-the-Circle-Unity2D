using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncyAreaScript : MonoBehaviour
{
    
    public float pushBackForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Pin" && other.gameObject.layer == LayerMask.NameToLayer("Shootable"))
        {
            //pushBack(other.transform);
        }
    }

    void pushBack(Transform pushedObject)
    {
        Vector2 pushDirection = new Vector2(0,(pushedObject.position.y + transform.position.y)).normalized;
        pushDirection *= pushBackForce;
        Rigidbody2D pushRB = pushedObject.gameObject.GetComponent<Rigidbody2D>();
        pushRB.velocity = Vector2.zero;
        pushRB.AddForce(pushDirection,ForceMode2D.Impulse);
    }
}
