using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintingTrig : MonoBehaviour
{
    public bool trigStatus = false;
    string nameTrig;

    void Start()
    {
        nameTrig = gameObject.name;
    }

    private void OnMouseDown()
    {
        if (trigStatus)
        {
            paintingTrigManager.nameChecker(nameTrig);
            Debug.Log(nameTrig);
        }
        else
        {
            paintingTrigManager.setPtOff();
        }
    }

    void Update()
    {
        
    }
}
