using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Example : MonoBehaviour
{
    public cameraManager camera;
    Transform lookAt;
    bool isFocus = false;

    // Start is called before the first frame update
    void Start()
    {
        lookAt = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (isFocus)
        {
            if (Input.GetKeyDown(KeyCode.E))
            { 
                isFocus = false;
                camera.focused = false;
                camera.changeTarget(camera.prevPos);
            }

        }
    }

    private void OnMouseDown()
    {
        if (camera.move == false && camera.focused == false)
        {
            if (Input.GetMouseButtonUp(0))
            {
                camera.changeTarget(lookAt.position);
                camera.focused = true;
                isFocus = true;
            }
        }
    }
}
