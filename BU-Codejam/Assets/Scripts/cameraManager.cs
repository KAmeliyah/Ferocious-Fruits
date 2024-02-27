using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class cameraManager : MonoBehaviour
{
    public float zoomSpeed;
    public float dragSpeed;

    public Vector3 camTarget;
    public Vector3 prevPos;
    Vector3 dragOrigin;
    Vector3 dragPos;
    Vector3 dragMove;
    public GameObject dragBox;
    public bool move = false;
    public bool focused = false;
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
            }
            transform.position = Vector3.MoveTowards(transform.position, camTarget, zoomSpeed * Time.deltaTime);
        }
        if (focused == true && move == false)
        {
            exitButton.gameObject.SetActive(true);
        }
        else
        {
            exitButton.gameObject.SetActive(false);
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
                dragMove = new Vector3(dragPos.x * dragSpeed, 0, dragPos.y * dragSpeed);
                transform.Translate(dragMove, Space.World);
            }
        }
    }

    public void changeTarget(Vector3 target)
    {
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
