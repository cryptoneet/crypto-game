using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class itemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler 
{
    Vector3 mainPos;
    bool dragHandleEnd = false;

    public float speedBack = 8.0f;

    void Start()
    {
        mainPos = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition; 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragHandleEnd = true;
        // transform.Translate(mainPos - transform.position * Time.deltaTime * speedBack);
        // transform.position = Vector3.Lerp(transform.position, mainPos, Time.deltaTime * speedBack);
    }

    //handling the collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    void Update()
    {
        if (dragHandleEnd)
        {
            transform.position = Vector3.Lerp(transform.position, mainPos, Time.deltaTime * speedBack);
            if (transform.position == mainPos)
                dragHandleEnd = false;
        }
       
    }
}
