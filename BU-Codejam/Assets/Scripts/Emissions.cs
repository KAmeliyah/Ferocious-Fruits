using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Emissions : MonoBehaviour
{
    public universityManager m_universityManager;
    public int emissions = 0;
    public int maxEmissions = 500;
    public int emissionRate = 25;
    public EndScreen endScreen;
    // Start is called before the first frame update
    void Start()
    {
        emissions = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Transform pointer = transform.Find("Meter").Find("MeterPointer");
        pointer.rotation = Quaternion.Euler(0f, 0f, 90f - (((float) emissions / maxEmissions) * 180f));

        if (emissions == maxEmissions)
        {
            endScreen.Show();
        }
    }

    public void grow()
    {
        emissions += emissionRate;
    }
}
