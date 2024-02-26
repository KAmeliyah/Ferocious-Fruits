using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour
{
    Cinemachine.CinemachineVirtualCamera camera;
    public GameObject camTarget;
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
        camera.m_LookAt = camTarget.transform;
        //camera.m_Lens.FieldOfView = 20;
    }
}
