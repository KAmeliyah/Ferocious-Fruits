using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class universityManager : MonoBehaviour
{
    //initial class variables for what each building would need to include
    public int budget = 162400000;
    //annual income for Bournemouth university is £162.4 mill
    // not sure how much we want to give to the player to use but we can figure it out
    private int cost;
    private float floodLevel;
    private float emissionLevel;
    private float studentSatisfaction;
    private float energyConsumed;
    private float waterConsumed;
    private string buildingName;

    // Start is called before the first frame update
    void Start()
    {
        floodLevel = 0;
        emissionLevel = 100;
        studentSatisfaction = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time % 10 != 0)
            //will update every 10 seconds
        {
            if (emissionLevel > 70)
            {
                floodLevel += 3;
                //increase the flood level based on how high emissions are
            }
            else if (emissionLevel > 40)
            {
                floodLevel += 2;
            }
            else if (emissionLevel > 1)
            {
                floodLevel += 1;
            }
            else if (emissionLevel == 0)
            {
                emissionLevel += 0;
            }
        }

    }
}
