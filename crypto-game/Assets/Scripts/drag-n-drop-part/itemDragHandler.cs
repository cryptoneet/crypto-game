using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class itemDragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler 
{
    public static GameObject itemDragged;
    Vector3 mainPos;
    public float speedBack = 8.0f;
    //for timer
    public float targTime = 0.0f;

    void Start()
    {
        mainPos = transform.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemDragged = gameObject;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition; 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemDragged = null;
    }

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
            


            targTime = 1.5f;
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
            if(targTime <= 0.0f)
            {
                Debug.Log("Timer ended");
            }
        }

        if (itemDragged == null)
        {
            transform.position = Vector3.Lerp(transform.position, mainPos, Time.deltaTime * speedBack);
        }
    }
}
