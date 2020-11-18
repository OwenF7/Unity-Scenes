using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptForIsItTrue : MonoBehaviour
{

    public GameObject mainCamera;

    public GameObject cube;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            Debug.Log("Hello!"); 
        }


        if (Input.GetKey(KeyCode.S))
        {
            cube.transform.Rotate(new Vector3(0, 0, 0)); 
        }

        else
        {
            cube.transform.Rotate(new Vector3(1, 2, 3));
        }


        if (Input.GetKey(KeyCode.R))
        {
            mainCamera.transform.Rotate(new Vector3(0, 1, 0));
        }

        else if (Input.GetKey(KeyCode.L))
        {
            mainCamera.transform.Rotate(new Vector3(0, -1, 0));
        }

        else 
        {
            mainCamera.transform.Rotate(new Vector3(0, 0, 0));
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.C))
        {
            cube.transform.localScale += new Vector3(2, 4, 6); 
        }
    }
}
