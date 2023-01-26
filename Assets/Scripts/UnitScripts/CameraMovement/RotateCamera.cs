using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    public GameObject unit;
    public float sensitivity = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("a"))
        {
            transform.RotateAround(unit.transform.position, Vector3.up, 1 * Time.deltaTime * sensitivity);
        }

        if (Input.GetKey("d"))
        {
            transform.RotateAround(unit.transform.position, Vector3.up, -1 * Time.deltaTime * sensitivity);
        }
        //transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
