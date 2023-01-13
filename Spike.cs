using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{

    Vector3 Spawn;
    Vector3 Rotation;
    public Transform player;
    public GameManager gameManager;
    Quaternion startRotate;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        Spawn = player.position;
        startRotate = player.rotation;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter2D(Collision2D spikeCol)
    {
        if (spikeCol.gameObject.tag == "Player")
        {
            player.position = Spawn;
            player.rotation = startRotate;
            gameManager.playerChances = gameManager.playerChances - 1;
        }
    }
   
}

