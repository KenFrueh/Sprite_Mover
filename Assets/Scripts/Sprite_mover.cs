﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_mover : MonoBehaviour
{
    //The transform of the variable
    private Transform tf;
    //Allow to change speed of object moving
    public float Speed = 1.0f;
    public bool flipX;

    // Start is called before the first frame update
    void Start()
    {
        //Get transform component
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move to the Right
        if (Input.GetKey(KeyCode.D))
        {
            tf.position = tf.position + (Vector3.right * Time.deltaTime * Speed); //Vector is moving up in the preset (0,1,0) at slow pace
        }
        //Moving to the Left
        if (Input.GetKey(KeyCode.A))
        {
            tf.position = tf.position + (Vector3.left * Time.deltaTime * Speed);
            
            
        }
        //Moving up
        if (Input.GetKey(KeyCode.W))
        {
            tf.position = tf.position + (Vector3.up * Time.deltaTime * Speed);
        }
        //Moving down
        if (Input.GetKey(KeyCode.S))
        {
            tf.position = tf.position + (Vector3.down * Time.deltaTime * Speed);
        }
        //Changing speed of the character
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            Speed = 5;
        }
        //Normal speed
        else
        {
            Speed = 1;
        }
    }
}
