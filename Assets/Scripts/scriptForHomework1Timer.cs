using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptForHomework1Timer : MonoBehaviour
{

    public int stopwatch;
    private int plusOne = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch += plusOne;

        Debug.Log("This is how many frames you've been looking at this for: " + stopwatch);
    }
}
