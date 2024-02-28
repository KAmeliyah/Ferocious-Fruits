using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class exitButton : MonoBehaviour
{
    Button exit;
    public cameraManager camera;
    // Start is called before the first frame update
    void Start()
    {
        exit = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(camera.focused);
        if (camera.focused == true && camera.zooming == false)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}