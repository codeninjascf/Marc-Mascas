using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

//Game manager object
[Header("Game Controller Object for controlling the game")]
public GameController gameController;
[Header("Default Velocity")]
public float velocity = 1;
//Physics for the bird
private Rigidbody2D rb;
//height of the bird object on the y axis
private float objectHeight;