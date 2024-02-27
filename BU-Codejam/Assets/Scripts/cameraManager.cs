using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameraManager : MonoBehaviour
{
    public Cinemachine.CinemachineVirtualCamera camera;
    public Vector3 camTarget;
    public Vector3 prevPos;
    public float speed;
    bool move = false;
    // Start is called before the first frame update
    void Start()
    {

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
            Debug.Log(prevPos);
            transform.position = Vector3.MoveTowards(transform.position, camTarget, speed * Time.deltaTime);
        }
    }

    public void changeTarget(Vector3 target)
    {
        camTarget = new Vector3(target.x, target.y, target.z);
        prevPos = transform.position;
        
        move = true;
    }
}
