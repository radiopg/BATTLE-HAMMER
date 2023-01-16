using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotateCamera : MonoBehaviour
{
    public Vector2 turn;

    public GameObject allyGroup1;
    

    // Start is called before the first frame update
    void Start()
    {
        allyGroup1 = GameObject.Find("AllyGroup1");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        MoveCamera();
        //RotateCamera();
    }

    void MoveCamera()
    {

    }

    void RotateCamera()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        //transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        //transform.RotateAround(allyGroup1.transform.position, new Vector3(turn.x, turn.y, 0), 1.0f*Time.deltaTime);
        
    }
}
