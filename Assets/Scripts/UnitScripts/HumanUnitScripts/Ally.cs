using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : HumanUnitScript
{
    float moveToX;
    float moveToY;
    float moveToZ;

    float speed = 1.5f;

    GameObject cameraVar;

    public GameObject targetLocAndRot;
    public Vector3 directionTarget;
    private Quaternion lookRotation;

    

    // Start is called before the first frame update
    void Start()
    {
        moveToX = gameObject.transform.position.x;
        moveToZ = gameObject.transform.position.z;
        cameraVar = GameObject.Find("Main Camera");
        
    }


    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.Tab))
        {
            ShootRay();
            
            targetLocAndRot.transform.LookAt(new Vector3(moveToX, 0.54f, moveToZ));
            targetLocAndRot.transform.position = new Vector3(moveToX, 0.54f, moveToZ);

            directionTarget = (targetLocAndRot.transform.position - transform.position).normalized;
            lookRotation = Quaternion.LookRotation(directionTarget);

        }
        
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10);
        MoveAllyUnit();
    }

    void UsePassiveAbility()
    {

    }

    void UseActiveAbility()
    {

    }

    void UseEquipmentGrenade()
    {

    }

    void MoveAllyUnit()
    {
        if (!(transform.position.x == moveToX && transform.position.z == moveToZ))
        {
            transform.position -= (transform.position - new Vector3(moveToX, 0.54f, moveToZ)).normalized * speed * Time.deltaTime;
            
            MoveCamera();
        }
        
    }

    void ShootRay()
    {
        Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(rayOrigin, out hitInfo))
        {
            moveToX = hitInfo.point.x;
            moveToZ = hitInfo.point.z;
        }

    }

    void MoveCamera()
    {
        //move camera when ally moves
        cameraVar.transform.position -= (transform.position - new Vector3(moveToX, 0.54f, moveToZ)).normalized * speed * Time.deltaTime;
    }
}
