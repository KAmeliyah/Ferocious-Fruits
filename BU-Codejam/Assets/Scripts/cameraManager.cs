using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class cameraManager : MonoBehaviour
{
    public float zoomSpeed = 100f;
    public float dragSpeed = 20f;

    public Cinemachine.CinemachineVirtualCamera mainCamera;
    public Cinemachine.CinemachineVirtualCamera dragCamera;
    public Vector3 camTarget;
    public Vector3 prevPos;
    Vector3 dragOrigin;
    Vector3 dragPos;
    Vector3 dragMove;
    public bool move = false;
    public bool focused = false;
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
        if (move) 
        {
            if (transform.position == camTarget)
            {
                move = false;
                mainCamera.m_Priority -= 2;
            }
            transform.position = Vector3.MoveTowards(transform.position, camTarget, zoomSpeed * Time.deltaTime);
        }
        if (focused == true && move == false)
        {
            exitButton.gameObject.SetActive(true);
            canvasShop.SetActive(true);
        }
        else
        {
            exitButton.gameObject.SetActive(false);
            canvasShop.SetActive(false);
        }

        if (move == false && focused == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                dragOrigin = Input.mousePosition;
            }
            if (Input.GetMouseButtonUp(0))
            {
                dragPos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
                dragMove = new Vector3(dragPos.y * dragSpeed, 0, -(dragPos.x * dragSpeed));
                transform.Translate(dragMove, Space.World);
            }
        }
    }

    public void changeTarget(Vector3 target)
    {
        mainCamera.m_Priority += 2;
        camTarget = new Vector3(target.x, target.y, target.z);
        prevPos = transform.position;
        
        move = true;
    }

    void clickExit()
    {
        changeTarget(prevPos);
        focused = false;
    }

}
