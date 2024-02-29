using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class universityManager : MonoBehaviour
{
    //initial class variables for what each building would need to include
    public int budget = 5000000;
    //annual income for Bournemouth university is £162.4 mill
    //I have changed the budget to be 5 mill instead
    // not sure how much we want to give to the player to use but we can figure it out
    private int cost;
    private float floodLevel;
    private float emissionLevel;
    private float studentSatisfaction;
    private float energyConsumed;
    private float waterConsumed;
    private string buildingName;

    public TMP_Text budgetText;

    // Start is called before the first frame update
    void Start()
    {
        floodLevel = 0;
        emissionLevel = 100;
        studentSatisfaction = 0;
        budgetText.text = "£" + budget.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
