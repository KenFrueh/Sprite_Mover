using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{// Object class for the sprite
    public GameObject VanGogh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//Checks the game object "VanGogh" as active or inactive
        if (Input.GetKeyDown(KeyCode.Q))
        {
            VanGogh.SetActive(!VanGogh.activeInHierarchy);
            Debug.Log("Q was pressed");
        }//Quits the application on press of 'Escape' key 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
