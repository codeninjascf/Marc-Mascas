using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        //Game Controller component
        gameController = GetComponent<GameController>();
        //Speed for the game is at playing state
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        //Object Height equals the size of the height of the sprite
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
=======

        //Game Controller component
        gameController = GetComponent<GameController>();
        //Speed for the game is at a playing state
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        //Object Height equals the size of the height of the sprite
        objectHeight = transform.GetComponents<SpriteRenderer>().bounds.size.y / 2;
>>>>>>> 383baaa7a217841ae386541d24e14bec35c40732
    }

    // Update is called once per frame
    void Update()
    {
        //If the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            //The bird will float up on the y axis
            //and float back down on Y axis
            rb.velocity = Vector2.up * velocity;
        }
    }
}

//Game manager object
[Header("Game Controller Object for controlling the game")]
public GameController gameController;
[Header("Default Velocity")]
public float velocity = 5;
//Physics for the bird
private Rigidbody2D rb;
//height of the bird object on the y axis
private float objectHeight;
