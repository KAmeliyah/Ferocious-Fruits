using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Happiness : MonoBehaviour
{
    public int happy;
    private Image imageComponent;
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

        if (happy < 66)
        {
            sp = Resources.Load<Sprite>("Graphics/Faces/T_neutral");
        }

        if (happy < 33)
        {
            sp = Resources.Load<Sprite>("Graphics/Faces/T_sad");
        }

        if (sp == null)
        {
            Debug.LogError("Failed to load sprite.");
        }

        imageComponent.sprite = sp;

        if (happy == 0) 
        { 
            //increase water levels
        }
    }

    public void change()
    {
        happy -= 5;
    }
}
