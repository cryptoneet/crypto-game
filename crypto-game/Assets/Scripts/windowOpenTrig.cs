using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowOpenTrig : MonoBehaviour
{
    public GameObject wind_open;

    private void Update()
    {
        if (wind_open.activeSelf)
        {
            triggerHint.onWindowOpened = true;
        }
        else
        {
            triggerHint.onWindowOpened = false;
        }
    }


}
