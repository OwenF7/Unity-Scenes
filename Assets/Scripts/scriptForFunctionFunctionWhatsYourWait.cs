using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptForFunctionFunctionWhatsYourWait : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ConsoleWindow();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ConsoleWindow ()
    {
        Debug.Log("Hey! This function has no arguments, and is going to serve as the guide for this homework. Well, that was what I said originally when I created this Function... I'll go ahead and be honest that I got very confused when it came to arguments with Functions. " +
            "A common argument error I got was that there wasn't anything defining levelOfTiredness, another one is that I can't get the answer to print in the Console window... Not sure what's happening here.");
    }


    public string AmISleepDeprivedRightNow (float levelOfTiredness, string yesOrNo)
    {
        float level = levelOfTiredness;
        level = 5.0f;

        string answer = yesOrNo;
        float randomNumber = Random.Range(0, 50.0f); 

        if (randomNumber < levelOfTiredness)
        {
            answer += " yes";
        }

        else
        {
            answer += " no"; 
        }

        Debug.Log(answer);

        return answer;
    }
}
