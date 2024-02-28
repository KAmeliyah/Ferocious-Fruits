using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startScreen : MonoBehaviour
{
    Button startButton;
    public cameraManager camScript;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        gameObject.SetActive(true);
        startButton = transform.GetChild(1).GetComponent<Button>();
        startButton.onClick.AddListener(startGame);
    }

    void Update()
    {
        
    }

    void startGame()
    {
        gameObject.SetActive(false);
        camScript.lockMouse = false;
        Time.timeScale = 1;
    }
}
