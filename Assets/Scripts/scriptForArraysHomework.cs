using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class scriptForArraysHomework : MonoBehaviour
{

    int[] newArray = { 10, 18, 22, 25, 28 }; 

    // Start is called before the first frame update
    void Start()
    { 
        // Debug.Log(newArray[2]); 
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.C))
        {
            newArray[0] = 11; 
        }

        if (Input.GetKey(KeyCode.R))
        {
            newArray[0] = 10;
        }

        if (Input.GetKey(KeyCode.D))
        {
            newArray = newArray.Except(new int[] { 18 }).ToArray();
        }


        if (Input.GetKey(KeyCode.B))
        {
            newArray.Reverse ();
        }


        if (Input.GetKey(KeyCode.Keypad0)) 
        {
            Debug.Log(newArray[0]); 
        }

        else if (Input.GetKey(KeyCode.Keypad1))
        {
            Debug.Log(newArray[1]);
        }

        else if (Input.GetKey(KeyCode.Keypad2))
        {
            Debug.Log(newArray[2]);
        }

        else if (Input.GetKey(KeyCode.Keypad3))
        {
            Debug.Log(newArray[3]);
        }

        else if (Input.GetKey(KeyCode.Keypad4))
        {
            Debug.Log(newArray[4]);
        }
    }
}
