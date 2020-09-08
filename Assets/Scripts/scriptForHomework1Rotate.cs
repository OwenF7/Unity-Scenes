using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptForHomework1Rotate : MonoBehaviour
{

    public float rotateX;
    public float rotateY;
    public float rotateZ;
    public Transform cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube.Rotate(rotateX, rotateY, rotateZ);
    }
}
