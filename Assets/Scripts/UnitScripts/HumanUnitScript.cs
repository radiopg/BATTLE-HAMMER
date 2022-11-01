using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanUnitScript : MonoBehaviour
{


    float moveToX = 0.0f;
    float moveToY = 0.0f;
    float moveToZ = 0.0f;

    float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootRay();
        }
        MoveUnit();
    }

    void MoveUnit()
    {
        transform.LookAt(new Vector3(moveToX, moveToY, moveToZ));
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void ShootBullets()
    {

    }

    void ShootRay()
    {
        Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        
        if(Physics.Raycast(rayOrigin, out hitInfo))
        {
            moveToX = hitInfo.point.x;
            moveToY = hitInfo.point.y + 0.54f;
            moveToZ = hitInfo.point.z;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

}
