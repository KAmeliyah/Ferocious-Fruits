using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameraManager : MonoBehaviour
{
    Cinemachine.CinemachineVirtualCamera camera;
    public GameObject camTarget;
    public float speed;
    bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Cinemachine.CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (move) 
        {
            if (transform.position == camTarget.transform.position)
            {
                move = true;
            }
            transform.position = Vector3.MoveTowards(transform.position, camTarget.transform.position, speed * Time.deltaTime);
        }
    }

    public void changeTarget(GameObject target)
    {
        camTarget = target;
        move = true;
        //camera.m_LookAt = camTarget.transform;
        ////camera.m_Lens.FieldOfView = 20;
    }
}
