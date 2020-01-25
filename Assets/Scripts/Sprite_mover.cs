using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_mover : MonoBehaviour
{
    //The transform of the variable
    private Transform tf;
    //Allow to change speed of object moving
    public float Speed = 1.0f;
    //Apply flipping of sprite
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
            Debug.Log("Key 'D' was pressed");
            flipX = false;
        }
        //Moving to the Left
        if (Input.GetKey(KeyCode.A))
        {
            tf.position = tf.position + (Vector3.left * Time.deltaTime * Speed);
            Debug.Log("Key 'A' was pressed");
            flipX = true;
        }
        //Moving up
        if (Input.GetKey(KeyCode.W))
        {
            tf.position = tf.position + (Vector3.up * Time.deltaTime * Speed);
            Debug.Log("Key 'W' id pressed");
            
        }
        //Moving down
        if (Input.GetKey(KeyCode.S))
        {
            tf.position = tf.position + (Vector3.down * Time.deltaTime * Speed);
            Debug.Log("Key 'S' is pressed");
        }
        //Changing speed of the character
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            Speed = 5;
            Debug.Log("Key 'Shift' is pressed");
        }
        //Normal speed
        else
        {
            Speed = 1;
            Debug.Log("Key 'Shift is released");//Log info for key press
        }
        //Works if player is holding or not holding down shift
        if (Input.GetKeyDown(KeyCode.Space))
        {//Sets position to center of screen
            tf.position = new Vector3(0, 0, 0);
            Debug.Log("Position reset to center");
        }
        
    }
}
