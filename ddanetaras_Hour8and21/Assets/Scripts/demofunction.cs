using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demofunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string sentence = "I am Pizza!";
        LogSomething(sentence);

        string sentence2 = "I am Pasta!";
        LogSomething(sentence2);

        LogSomething("I am Pizza and Pasta!");

        LogSomething("Pinapple on Pizza!",100);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LogSomething(string something, int numLoops)
    {
        for (int i = 1; i <= numLoops; i++)
        {
            Debug.Log(something);
        }
    }

    void LogSomething(string something)
    {
        for (int i = 1; i <= 3; i++)
        {
            Debug.Log(something);
        }
    }
}
