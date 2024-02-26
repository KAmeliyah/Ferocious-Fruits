using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Days : MonoBehaviour
{
    private int DayCounter;
    private int timePerDay = 10; 
    //for now each day will be 10 seconds (prompt every minute or week for doing upgrades)

    // Start is called before the first frame update
    void Start()
    {
        DayCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //check the time to see if it has been 10 seconds
        if (Time.time % 10 != 0)
        {
            DayCounter += 1;
        }
    }
}
