using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Changer : MonoBehaviour
{   //Declare variables
    private SpriteRenderer spriteRenderer;
    public Color color = Color.blue;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        if (spriteRenderer != null)
        {
            //change the color of sprite
            spriteRenderer.color = Color.green;
        }
        else
        {
            //Logging errors
            Debug.LogError(message: "No sprite renderer");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (spriteRenderer != null)
        {
            //change the color of sprite
            spriteRenderer.color = color;
        }
        else
        {
            //Logging errors
            Debug.LogError(message: "No sprite renderer");
        }

    }
}
