using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class cameraManager : MonoBehaviour
{
    public float zoomSpeed = 100f;
    public float dragSpeed = 50f;

    public Cinemachine.CinemachineVirtualCamera mainCamera;
    public Cinemachine.CinemachineVirtualCamera dragCamera;
    public Vector3 camTarget;
    public Vector3 prevPos;
    Vector3 dragOrigin;
    Vector3 dragPos;
    Vector3 lastDrag;
    Vector3 dragzooming;
    public bool zooming = false;
    public bool focused = false;
    public bool lockMouse = true;
    public bool hold = false;
    public bool drag = false;
    public GameObject canvasShop;
    public Button exitButton;
    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(clickExit);
    }

    // Update is called once per frame
    void Update()
    {
        if (zooming)
        {
            if (transform.position == camTarget)
            {
                zooming = false;
                mainCamera.m_Priority -= 2;
            }
            transform.position = Vector3.MoveTowards(transform.position, camTarget, zoomSpeed * Time.deltaTime);
        }
        if (focused == true && zooming == false)
        {
               exitButton.gameObject.SetActive(true);
               canvasShop.SetActive(true);
        }
        else
        {
            exitButton.gameObject.SetActive(false);
            canvasShop.SetActive(false);
        }

        if (zooming == false && focused == false)
        {
            if (Input.GetMouseButtonDown(0))
            {   
                if (!hold)
                {
                    dragOrigin = Input.mousePosition;
                    lastDrag = dragOrigin;
                    hold = true;
                }

            
            }
        }

        if (hold)
        {
            dragPos = Camera.main.ScreenToViewportPoint(Input.mousePosition - lastDrag);
            dragzooming = new Vector3(dragPos.y * dragSpeed, 0, -(dragPos.x * dragSpeed));
            transform.Translate(dragzooming, Space.World);
            lastDrag = Input.mousePosition;
            
            if (dragOrigin != lastDrag)
            {
                    drag = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            hold = false;
            dragPos = new Vector3(0, 0, 0);
            dragzooming = new Vector3(0, 0, 0);
            drag = false;
        }

    }

    public void changeTarget(Vector3 target)
    {
        mainCamera.m_Priority += 2;
        camTarget = new Vector3(target.x, target.y, target.z);
        prevPos = transform.position;
        zooming = true;
    }

    void clickExit()
    {
        changeTarget(prevPos);
        focused = false;
    }

}
