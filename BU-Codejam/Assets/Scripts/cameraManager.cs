using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameraManager : MonoBehaviour
{
    Cinemachine.CinemachineVirtualCamera camera;
    public GameObject camTarget;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Cinemachine.CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeTarget(GameObject target)
    {
        camTarget = target;
        do
        {
            transform.position = Vector3.MoveTowards(transform.position, camTarget.transform.position, speed * Time.deltaTime);
        } while(transform.position != camTarget.transform.position);
        
        //camera.m_LookAt = camTarget.transform;
        ////camera.m_Lens.FieldOfView = 20;
    }
}
