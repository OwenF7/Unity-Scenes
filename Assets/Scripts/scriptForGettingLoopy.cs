using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptForGettingLoopy : MonoBehaviour
{

    int numberOfZombies = 5; 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfZombies; i++)
        {
            Debug.Log("Uh-Oh, that's A LOT of zombies: " + i);
        }

        while (numberOfZombies > 0)
        {
            Debug.Log("I killed a zombie!"); 
            numberOfZombies--;
        }

        string[] actions = new string[3];

        actions[0] = "Run!";
        actions[1] = "Shoot!";
        actions[2] = "Hide!"; 

        foreach(string item in actions)
        {
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
