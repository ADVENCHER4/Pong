using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour
{
    private Rigidbody2D rb;
    private int coeff;
    public float speed = 5f;
    public Vector2 velo;// Start is called before the first frame update
    void Start()
    {  
        //coeff = Random.Range(-1, 1);
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
        {
        if (other.gameObject.tag == "Border")
        {
            velo = rb.velocity;
            velo.y *= -1f;
            rb.velocity = velo;
        } else if(other.gameObject.tag == "Player")
        {

            velo = rb.velocity;
            velo.x *= -1f;
            rb.velocity = velo;
        }
    }
}
