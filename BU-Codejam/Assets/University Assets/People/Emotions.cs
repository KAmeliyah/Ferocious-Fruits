using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Emotions : MonoBehaviour
{
    public Happiness m_happiness;
    Renderer ren;
    string[] PersonStates = { "Happy", "Meh", "Sad" };
    //will change based on certain things like lights
    string CurrentState;
    int happyLevel;


    Material newMat;

    // Start is called before the first frame update
    void Start()
    {
        happyLevel = m_happiness.happy;
        //this will change based on how the student level in the game
        ren = GetComponent<Renderer>();
        ren.material.color = Color.green;
        CurrentState = PersonStates[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (happyLevel >= 60.00 && happyLevel <= 100.00)
        {
            {
                CurrentState = PersonStates[0];
                ren = GetComponent<Renderer>();
                ren.material.color = Color.green;
            }
        }
        if (happyLevel >= 35.00 && happyLevel <= 60.00)
        {
            {
                CurrentState = PersonStates[1];
                ren = GetComponent<Renderer>();
                ren.material.color = Color.yellow;

            }
        }
        if (happyLevel >= 0.00 && happyLevel <= 35.00)
        {
            {
                CurrentState = PersonStates[2];
                ren = GetComponent<Renderer>();
                ren.material.color = Color.red;

            }
        }
    }
}
