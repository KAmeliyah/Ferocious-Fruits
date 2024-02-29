using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Weeks : MonoBehaviour
{
    public int week;
    public float timePerWeek = 3.0f;
    float threshold = 0.01f;

    private float lastIterationTime;

    public TMP_Text weekLabel;

    public Emissions emissions;
    public Happiness happiness;

    public EndScreen endScreen;


    //for now each week will be 3 seconds (prompt every minute or week for doing upgrades)

    // Start is called before the first frame update
    void Start()
    {
        week = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastIterationTime >= timePerWeek - threshold)
        {
            week += 1;

            weekLabel.text = "Week " + week;
            emissions.grow();
            happiness.change(5);

            // Update the last iteration time
            lastIterationTime = Time.time;
        }

        if (week == 42)
        {
            endScreen.Show();
        }
    }
}
