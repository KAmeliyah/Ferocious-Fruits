using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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
        if (camera.focused && camera.move == false)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
