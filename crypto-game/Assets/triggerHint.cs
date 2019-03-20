using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerHint : MonoBehaviour
{

    //trigger part*************************************
    //for timer
    public float targTime = 0.0f;

    Animator blick_vis;
    AudioSource blick_aud;
    bool onTrigTimer = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
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
            onTrigTimer = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "clue_blick")
        {
            blick_vis = collision.GetComponent<Animator>();
            blick_vis.Play("blick_hide");
            onTrigTimer = false;
        }
    }
    void Update()
    {
        if (onTrigTimer)
        {

            targTime -= Time.deltaTime;
            if (targTime <= 0.0f)
            {
                onTrigTimer = false;
                blick_vis.Play("blick_hide");

            }
        }
    }
}
