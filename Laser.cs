using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Laser : MonoBehaviour
{

    public float laserSpeed;

    public Rigidbody2D laserRb2D;

    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        //first parm is the game object that this script is attached to
        //second parm is how many seconds before ob is destroyed
        Destroy(gameObject, 5f);
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //makes laser go up in the y axis
        //using the laserSpeed variable
        transform.Translate(laserSpeed, 0, 0);
        this.laserRb2D.gravityScale = 0.0f;

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Blastable")
        {
            Debug.Log("Collided");
            Destroy(other.gameObject);
        }

    }
}
