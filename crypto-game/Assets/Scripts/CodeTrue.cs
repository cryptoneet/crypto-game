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

    Animator mapAnimator;

    paintingTrig pt1;
    private void Start()
    {
        true_aud.volume = globalVar.volValue;
        //initialize
        pt1 = GameObject.Find("pt1").GetComponent<paintingTrig>();
        mapAnimator = GameObject.Find("paper_map").GetComponent<Animator>();
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
        pt1.trigStatus = true;
        mapAnimator.Play("paperMapShow");
        paintingTrigManager.isChestOpened = true;
    }
}
