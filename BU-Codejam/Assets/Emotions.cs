using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Emotions : MonoBehaviour
{
    string []PersonStates = { "Happy", "Meh", "Sad" };
    //will change based on certain things like lights
    string []CurrentState;

    // Start is called before the first frame update
    void Start()
    {
        CurrentState[0] = PersonStates[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
