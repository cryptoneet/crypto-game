using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class itemDragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler 
{

    //drag part****************************************
    public GameObject itemDragged;
    private GameObject[] allDis;
    private RectTransform draggingPlane;
    public string tagDis;
    Vector3 mainPos;
    public float speedBack = 8.0f;

    void Start()
    {
        mainPos = transform.position;
        allDis = GameObject.FindGameObjectsWithTag(tagDis);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        draggingPlane = GetComponentInParent<Canvas>().transform as RectTransform;
        itemDragged = gameObject;
        foreach (GameObject g in allDis)
            g.GetComponent<Collider2D>().enabled = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        SetDraggedPosition(eventData);
    }

    private void SetDraggedPosition(PointerEventData data)
    {
        Vector3 globalMousePos;
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(draggingPlane, data.position, data.pressEventCamera, out globalMousePos))
        {
            transform.position = globalMousePos;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemDragged = null;
        foreach (GameObject g in allDis)
            g.GetComponent<Collider2D>().enabled = true;
    }
    
    void Update()
    {
        if (itemDragged == null)
        {
            transform.position = Vector3.Lerp(transform.position, mainPos, Time.deltaTime * speedBack);
        }
    }
}
