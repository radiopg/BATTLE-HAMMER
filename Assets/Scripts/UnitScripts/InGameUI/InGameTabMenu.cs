using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InGameTabMenu : MonoBehaviour
{

    public GameObject inGameUI;

    // Start is called before the first frame update
    void Start()
    {
        inGameUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            inGameUI.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            inGameUI.SetActive(false);
        }
    }
}
