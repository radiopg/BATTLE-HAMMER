using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInfoForOtherClasses : MonoBehaviour
{

    public GameObject initialCanvas;
    public GameObject assaultInfoUI;
    public GameObject supportInfoUI;
    public GameObject engineerInfoUI;
    public GameObject reconInfoUI;
    public GameObject returnButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableOtherUI()
    {
        initialCanvas.SetActive(false);
    }

    public void ActivateAssaultInfo()
    {
        DisableOtherUI();
        supportInfoUI.SetActive(false);
        engineerInfoUI.SetActive(false);
        reconInfoUI.SetActive(false);
        assaultInfoUI.SetActive(true);
        returnButton.SetActive(true);
    }

    public void ActivateSupportInfo()
    {
        DisableOtherUI();
        assaultInfoUI.SetActive(false);
        engineerInfoUI.SetActive(false);
        reconInfoUI.SetActive(false);
        supportInfoUI.SetActive(true);
        returnButton.SetActive(true);
    }

    public void ActivateEngineerInfo()
    {
        DisableOtherUI();
        assaultInfoUI.SetActive(false);
        supportInfoUI.SetActive(false);
        reconInfoUI.SetActive(false);
        engineerInfoUI.SetActive(true);
        returnButton.SetActive(true);
    }

    public void ActivateReconInfo()
    {
        DisableOtherUI();
        assaultInfoUI.SetActive(false);
        supportInfoUI.SetActive(false);
        engineerInfoUI.SetActive(false);
        reconInfoUI.SetActive(true);
        returnButton.SetActive(true);
    }

    public void ReturnToLoadOut()
    {
        assaultInfoUI.SetActive(false);
        supportInfoUI.SetActive(false);
        engineerInfoUI.SetActive(false);
        reconInfoUI.SetActive(false);
        initialCanvas.SetActive(true);
        returnButton.SetActive(false);
    }
}
