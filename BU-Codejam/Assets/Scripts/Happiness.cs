using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Happiness : MonoBehaviour
{
    public int happy;
    private Image imageComponent;
    public universityManager BU;
    public TMP_Text budgetText;
    int moneyChange = 0;

    // Start is called before the first frame update
    void Start()
    {
        happy = 100;
    }

    // Update is called once per frame
    void Update()
    {
        imageComponent = GetComponent<Image>();

        Sprite sp = Resources.Load<Sprite>("Graphics/Faces/T_happy");

        moneyChange = 300000;

        if (happy < 66)
        {
            sp = Resources.Load<Sprite>("Graphics/Faces/T_neutral");
            moneyChange = 100000;
        }

        if (happy < 33)
        {
            sp = Resources.Load<Sprite>("Graphics/Faces/T_sad");
            moneyChange = 0;
        }

        if (sp == null)
        {
            Debug.LogError("Failed to load sprite.");
        }

        imageComponent.sprite = sp;

        if (happy <= 0) 
        {
            moneyChange = -200000;
        }
    }

    public void change(int value)
    {
        happy += value;
        BU.budget += moneyChange;
        budgetText.text = "£" + BU.budget.ToString();

        if (happy > 100)
        {
            happy = 100;
        }
    }
}
