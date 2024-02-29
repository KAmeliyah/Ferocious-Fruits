using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restartButton : MonoBehaviour
{
    Button self;

    public universityManager m_universityManager;
    public Emissions m_emissions;
    public Happiness m_happiness;
    public Weeks m_weeks;
    public Cinemachine.CinemachineVirtualCamera dragCamera;
    public startScreen startScreen;

    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Button>();
        self.onClick.AddListener(Restart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Restart()
    {
        dragCamera.m_Priority += 2;
        dragCamera.transform.position = new Vector3(18.60178f, 20f, 7.346703f);
        m_emissions.emissions = 0;
        m_emissions.emissionRate = 25;

        m_happiness.happy = 100;

        m_weeks.week = 0;

        startScreen.restartGame();
    }
}
