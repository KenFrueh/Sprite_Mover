﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseInput : MonoBehaviour
{
    //Instance to variable
    public Sprite_mover sprite_Mover;

    // Start is called before the first frame update
    void Start()
    {//Calling the game object in order to receive pause function
        sprite_Mover = gameObject.GetComponent<Sprite_mover>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Pause and Unpause character
        if (Input.GetKeyDown(KeyCode.P))
        {
            sprite_Mover.enabled = !sprite_Mover.enabled;
            Debug.Log("P was pressed");//Shows in log when button is pressed
        }
    }
}
