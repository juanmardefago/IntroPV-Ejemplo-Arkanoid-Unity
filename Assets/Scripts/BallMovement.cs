using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    private Rigidbody2D rBody;
    public int speed;
    public float xVelocity;
    public float yVelocity;
    public Vector3 bounds;

	// Use this for initialization
	void Start () {
        bounds = GetComponent<Collider2D>().bounds.extents * 0.5f;
        rBody = GetComponent<Rigidbody2D>();
        xVelocity = speed;
        yVelocity = speed;
        rBody.velocity = new Vector2(xVelocity, yVelocity);
	}
	
	// Update is called once per frame
	void Update () {
        rBody.velocity = new Vector2(xVelocity, yVelocity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 other = collision.contacts[0].point;
        Debug.Log(other);
        Debug.Log(transform.position);
        if(other.x > transform.position.x + bounds.x || other.x < transform.position.x - bounds.x)
        {
            xVelocity = -xVelocity;
        }
        else if (other.y > transform.position.y + bounds.y || other.y < transform.position.y - bounds.y)
        {
            yVelocity = -yVelocity;
        }
    }

}
