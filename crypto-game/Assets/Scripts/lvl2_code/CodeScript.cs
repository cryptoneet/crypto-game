using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CodeScript : MonoBehaviour
{
    public Text codeTxt;
    int codeCounter = 0;
    public AudioSource click_aud;
    private void OnMouseDown()
    {
        click_aud.volume = globalVar.volValue;
        codeCounter++;
        click_aud.Play();
    }
    public void toNullClick()
    {
        codeCounter = 0;
    }

    void Update()
    {
        if (codeCounter >= 10)
        {
            codeCounter = 0;
        }
            

        codeTxt.text = codeCounter.ToString();
        
    }
}
