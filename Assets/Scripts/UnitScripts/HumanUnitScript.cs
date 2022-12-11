using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanUnitScript : MonoBehaviour
{


    float moveToX;
    float moveToY;
    float moveToZ;

    float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        moveToX = transform.position.x;
        moveToZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootRay();
            transform.LookAt(new Vector3(moveToX, 0.54f, moveToZ));
        }
        MoveUnit();
    }

    void MoveUnit()
    {
        if(!(transform.position.x == moveToX && transform.position.z == moveToZ))
        {
            transform.position -= (transform.position - new Vector3(moveToX, 0.54f, moveToZ)).normalized * speed * Time.deltaTime;
        }
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
            moveToZ = hitInfo.point.z;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

}
