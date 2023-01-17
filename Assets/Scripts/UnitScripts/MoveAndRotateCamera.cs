using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotateCamera : MonoBehaviour
{
    public Vector2 turn;

    public GameObject allyGroup1;

    public Vector3 cameraOffset;
    

    // Start is called before the first frame update
    void Start()
    {
        allyGroup1 = GameObject.Find("AllyGroup1");
        cameraOffset = transform.position - allyGroup1.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        RotateCamera();
    }

    void MoveCamera()
    {
        transform.position = new Vector3(allyGroup1.transform.position.x, 
                                         allyGroup1.transform.position.y + 3.0f,
                                         allyGroup1.transform.position.z);
        
        
    }

    void RotateCamera()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        MoveCamera();
        
        
        
    }
}
