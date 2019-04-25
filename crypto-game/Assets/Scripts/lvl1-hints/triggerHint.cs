using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerHint : MonoBehaviour
{

    //trigger part*************************************
    //for timer
    public float targTime = 0.0f;

    //for blick
    Animator blick_vis;
    AudioSource blick_aud;
    bool onBlickTrig = false;
    //for symb
    AudioSource symb_aud;
    bool onSymbTrig = false;
    public bool isSymbClueFound = false;
    //for letter to burn
    AudioSource letter_aud;
    Animator letter_animator;
    bool onLetterTrig = false;
    public static bool onWindowOpened = false;
    public GameObject letterBurned_sprite;
    public GameObject codeBurned;
    //for textChangeManager
    public TextChangeManager txtMngr;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "active_letter")
        {
            if(isSymbClueFound)
            {
                if (onWindowOpened)
                {
                    letter_aud = collision.GetComponent<AudioSource>();
                    letter_animator = collision.GetComponent<Animator>();
                    targTime = 2f;
                    onLetterTrig = true;
                }
                
            }
        }
        if(collision.tag == "clue_symb")
        {
            symb_aud = collision.GetComponent<AudioSource>();
            symb_aud.volume = globalVar.volValue;
            if (!symb_aud.isPlaying)
            {
                symb_aud.Play();
            }
            targTime = 2f;
            onSymbTrig = true;
            
        }
        if (collision.tag == "clue_blick")
        {
            blick_vis = collision.GetComponent<Animator>();
            blick_aud = collision.GetComponent<AudioSource>();
            blick_vis.Play("blick_hint");
            if (!blick_aud.isPlaying)
            {
                blick_aud.Play();
            }
            targTime = 2f;
            onBlickTrig = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "active_letter")
        {
            onLetterTrig = false;
        }
        if(collision.tag == "clue_symb")
        {
            onSymbTrig = false;
        }
        if (collision.tag == "clue_blick")
        {
            blick_vis = collision.GetComponent<Animator>();
            blick_vis.Play("blick_hide");
            onBlickTrig = false;
        }
    }
    void Update()
    {
        if (onLetterTrig)
        {
            targTime -= Time.deltaTime;
            if(targTime <= 0.0f)
            {
                onLetterTrig = false;
                letter_animator.Play("burnAnim");
                letterBurned_sprite.SetActive(true);
                codeBurned.SetActive(true);
            }
        }
        if (onSymbTrig)
        {
            targTime -= Time.deltaTime;
            if (targTime <= 0.0f)
            {
                isSymbClueFound = true;
                onSymbTrig = false;
                txtMngr.onSymbFound();
                
            }
        }
        if (onBlickTrig)
        {
            targTime -= Time.deltaTime;
            if (targTime <= 0.0f)
            {
                onBlickTrig = false;
                blick_vis.Play("blick_hide");
                txtMngr.onClueFoundChange();
            }
        }
    }
}
