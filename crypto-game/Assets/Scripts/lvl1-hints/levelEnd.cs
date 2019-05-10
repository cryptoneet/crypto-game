using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelEnd : MonoBehaviour
{
    public SceneTrans transaction;

    public void endLVL()
    {
        if(TextChangeManager.showed)
        {
            Debug.Log("Changing level");
            transaction.setButHit();
        }
    }
}
