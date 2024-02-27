using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Emotions : MonoBehaviour
{
    string []PersonStates = { "Happy", "Meh", "Sad" };
    //will change based on certain things like lights
    string []CurrentState;
    float happyLevel = 100;
    //this will change based on how the student level in the game

    Material newMat;

    // Start is called before the first frame update
    void Start()
    {
        CurrentState[0] = PersonStates[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (happyLevel >= 60.00 && happyLevel <= 100.00)
        {
            {
                newMat = Resources.Load("Happy", typeof(Material)) as Material;
                GetComponent<Renderer>().material = newMat;
            }
        }
        if (happyLevel >= 35.00 && happyLevel <= 60.00)
        {
            {
                newMat = Resources.Load("Eh", typeof(Material)) as Material;
                GetComponent<Renderer>().material = newMat;
            }
        }
        if (happyLevel >= 0.00 && happyLevel <= 35.00)
        {
            {
                newMat = Resources.Load("Sad", typeof(Material)) as Material;
                GetComponent<Renderer>().material = newMat;
            }
        }
    }
}
