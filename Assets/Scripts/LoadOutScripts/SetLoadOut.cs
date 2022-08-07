using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLoadOut : MonoBehaviour
{
    public TMPro.TMP_Dropdown myDrop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUnitToLoadOut(string individualloudout)
    {

        if(individualloudout == "A1")
        {
            if (myDrop.value == 0)
            {
                DataPersistScript.Instance.loadoutA1 = "NONE";
                DataPersistScript.Instance.loadout1[0] = "NONE";
            }
            else if (myDrop.value == 1)
            {
                DataPersistScript.Instance.loadoutA1 = "ASSAULT";
                DataPersistScript.Instance.loadout1[0] = "ASSAULT";
            }
            else if (myDrop.value == 2)
            {
                DataPersistScript.Instance.loadoutA1 = "SUPPORT";
                DataPersistScript.Instance.loadout1[0] = "SUPPORT";
            }
            else if (myDrop.value == 3)
            {
                DataPersistScript.Instance.loadoutA1 = "ENGINEER";
                DataPersistScript.Instance.loadout1[0] = "ENGINEER";
            }
            else if (myDrop.value == 4)
            {
                DataPersistScript.Instance.loadoutA1 = "RECON";
                DataPersistScript.Instance.loadout1[0] = "RECON";
            }

        }
        else if(individualloudout == "A2")
        {
            if (myDrop.value == 0)
            {
                DataPersistScript.Instance.loadoutA2 = "NONE";
                DataPersistScript.Instance.loadout1[1] = "NONE";
            }
            else if (myDrop.value == 1)
            {
                DataPersistScript.Instance.loadoutA2 = "ASSAULT";
                DataPersistScript.Instance.loadout1[1] = "ASSAULT";
            }
            else if (myDrop.value == 2)
            {
                DataPersistScript.Instance.loadoutA2 = "SUPPORT";
                DataPersistScript.Instance.loadout1[1] = "SUPPORT";
            }
            else if (myDrop.value == 3)
            {
                DataPersistScript.Instance.loadoutA2 = "ENGINEER";
                DataPersistScript.Instance.loadout1[1] = "ENGINEER";
            }
            else if (myDrop.value == 4)
            {
                DataPersistScript.Instance.loadoutA2 = "RECON";
                DataPersistScript.Instance.loadout1[1] = "RECON";
            }
        }
        else if(individualloudout == "A3")
        {
            if (myDrop.value == 0)
            {
                DataPersistScript.Instance.loadoutA3 = "NONE";
                DataPersistScript.Instance.loadout1[2] = "NONE";
            }
            else if (myDrop.value == 1)
            {
                DataPersistScript.Instance.loadoutA3 = "ASSAULT";
                DataPersistScript.Instance.loadout1[2] = "ASSAULT";
            }
            else if (myDrop.value == 2)
            {
                DataPersistScript.Instance.loadoutA3 = "SUPPORT";
                DataPersistScript.Instance.loadout1[2] = "SUPPORT";
            }
            else if (myDrop.value == 3)
            {
                DataPersistScript.Instance.loadoutA3 = "ENGINEER";
                DataPersistScript.Instance.loadout1[2] = "ENGINEER";
            }
            else if (myDrop.value == 4)
            {
                DataPersistScript.Instance.loadoutA3 = "RECON";
                DataPersistScript.Instance.loadout1[2] = "RECON";
            }
        }
        else if(individualloudout == "A4")
        {
            if (myDrop.value == 0)
            {
                DataPersistScript.Instance.loadoutA4 = "NONE";
                DataPersistScript.Instance.loadout1[3] = "NONE";
            }
            else if (myDrop.value == 1)
            {
                DataPersistScript.Instance.loadoutA4 = "ASSAULT";
                DataPersistScript.Instance.loadout1[3] = "ASSAULT";
            }
            else if (myDrop.value == 2)
            {
                DataPersistScript.Instance.loadoutA4 = "SUPPORT";
                DataPersistScript.Instance.loadout1[3] = "SUPPORT";
            }
            else if (myDrop.value == 3)
            {
                DataPersistScript.Instance.loadoutA4 = "ENGINEER";
                DataPersistScript.Instance.loadout1[3] = "ENGINEER";
            }
            else if (myDrop.value == 4)
            {
                DataPersistScript.Instance.loadoutA4 = "RECON";
                DataPersistScript.Instance.loadout1[3] = "RECON";
            }
        }
        else if(individualloudout == "B1")
        {
            if (myDrop.value == 0)
            {
                DataPersistScript.Instance.loadoutB1 = "NONE";
                DataPersistScript.Instance.loadout2[0] = "NONE";
            }
            else if (myDrop.value == 1)
            {
                DataPersistScript.Instance.loadoutB1 = "ASSAULT";
                DataPersistScript.Instance.loadout2[0] = "ASSAULT";
            }
            else if (myDrop.value == 2)
            {
                DataPersistScript.Instance.loadoutB1 = "SUPPORT";
                DataPersistScript.Instance.loadout2[0] = "SUPPORT";
            }
            else if (myDrop.value == 3)
            {
                DataPersistScript.Instance.loadoutB1 = "ENGINEER";
                DataPersistScript.Instance.loadout2[0] = "ENGINEER";
            }
            else if (myDrop.value == 4)
            {
                DataPersistScript.Instance.loadoutB1 = "RECON";
                DataPersistScript.Instance.loadout2[0] = "RECON";
            }
        }
        else if (individualloudout == "B2")
        {
            if (myDrop.value == 0)
            {
                DataPersistScript.Instance.loadoutB2 = "NONE";
                DataPersistScript.Instance.loadout2[1] = "NONE";
            }
            else if (myDrop.value == 1)
            {
                DataPersistScript.Instance.loadoutB2 = "ASSAULT";
                DataPersistScript.Instance.loadout2[1] = "ASSAULT";
            }
            else if (myDrop.value == 2)
            {
                DataPersistScript.Instance.loadoutB2 = "SUPPORT";
                DataPersistScript.Instance.loadout2[1] = "SUPPORT";
            }
            else if (myDrop.value == 3)
            {
                DataPersistScript.Instance.loadoutB2 = "ENGINEER";
                DataPersistScript.Instance.loadout2[1] = "ENGINEER";
            }
            else if (myDrop.value == 4)
            {
                DataPersistScript.Instance.loadoutB2 = "RECON";
                DataPersistScript.Instance.loadout2[1] = "RECON";
            }
        }
        else if(individualloudout == "B3")
        {
            if (myDrop.value == 0)
            {
                DataPersistScript.Instance.loadoutB3 = "NONE";
                DataPersistScript.Instance.loadout2[2] = "NONE";
            }
            else if (myDrop.value == 1)
            {
                DataPersistScript.Instance.loadoutB3 = "ASSAULT";
                DataPersistScript.Instance.loadout2[2] = "ASSAULT";
            }
            else if (myDrop.value == 2)
            {
                DataPersistScript.Instance.loadoutB3 = "SUPPORT";
                DataPersistScript.Instance.loadout2[2] = "SUPPORT";
            }
            else if (myDrop.value == 3)
            {
                DataPersistScript.Instance.loadoutB3 = "ENGINEER";
                DataPersistScript.Instance.loadout2[2] = "ENGINEER";
            }
            else if (myDrop.value == 4)
            {
                DataPersistScript.Instance.loadoutB3 = "RECON";
                DataPersistScript.Instance.loadout2[2] = "RECON";
            }
        }
        else if(individualloudout == "B4")
        {
            if (myDrop.value == 0)
            {
                DataPersistScript.Instance.loadoutB4 = "NONE";
                DataPersistScript.Instance.loadout2[3] = "NONE";
            }
            else if (myDrop.value == 1)
            {
                DataPersistScript.Instance.loadoutB4 = "ASSAULT";
                DataPersistScript.Instance.loadout2[3] = "ASSAULT";
            }
            else if (myDrop.value == 2)
            {
                DataPersistScript.Instance.loadoutB4 = "SUPPORT";
                DataPersistScript.Instance.loadout2[3] = "SUPPORT";
            }
            else if (myDrop.value == 3)
            {
                DataPersistScript.Instance.loadoutB4 = "ENGINEER";
                DataPersistScript.Instance.loadout2[3] = "ENGINEER";
            }
            else if (myDrop.value == 4)
            {
                DataPersistScript.Instance.loadoutB4 = "RECON";
                DataPersistScript.Instance.loadout2[3] = "RECON";
            }
        }

    }
}
