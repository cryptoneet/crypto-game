using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class itemDragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler 
{

    //drag part****************************************
    public static GameObject itemDragged;
    Vector3 mainPos;
    public float speedBack = 8.0f;


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

    
    void Update()
    {
        if (itemDragged == null)
        {
            transform.position = Vector3.Lerp(transform.position, mainPos, Time.deltaTime * speedBack);
        }
    }
}
