using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class universityManager : MonoBehaviour
{
    //initial class variables for what each building would need to include
    public int budget = 1000000;
    //annual income for Bournemouth university is £162.4 mill
    //I have changed the budget to be 5 mill instead
    // not sure how much we want to give to the player to use but we can figure it out

    public TMP_Text budgetText;

    // Start is called before the first frame update
    void Start()
    {
        budgetText.text = "£" + budget.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
