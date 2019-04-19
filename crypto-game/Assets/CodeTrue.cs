using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeTrue : MonoBehaviour
{

    public Text codeTxt1;
    public Text codeTxt2;
    public Text codeTxt3;

    public int codeTrue1;
    public int codeTrue2;
    public int codeTrue3;

    public AudioSource true_aud;
    public TextChangeManager txtMngr;

    private void Start()
    {
        true_aud.volume = globalVar.volValue;
    }

    int count = 0;
    void Update()
    {
        if(codeTxt1.text == codeTrue1.ToString())
        {
            if(codeTxt2.text == codeTrue2.ToString())
            {
                if(codeTxt3.text == codeTrue3.ToString())
                {
                    if(count == 0)
                    {
                        isTrueCode();
                        count++;
                    }
                }
            }
        }
    }
    void isTrueCode()
    {
        txtMngr.onTrueCodeEntered();
        true_aud.Play();
    }
}
