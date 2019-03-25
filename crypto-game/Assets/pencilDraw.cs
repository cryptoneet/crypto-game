using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pencilDraw : MonoBehaviour
{
    public static GameObject parObj, drawPar;
    private int it = 0;
    Vector3 curPos, lastPos;

    public float width, height;
    

    void Start()
    {
        parObj = this.transform.parent.gameObject;
        drawPar = GameObject.FindGameObjectWithTag("draw_zone");
    }
    
    // Update is called once per frame
    void Update()
    {
        curPos = transform.position;
        if (curPos != lastPos)
        {
            if (parObj.GetComponent<itemDragHandler>().itemDragged != null)
            {
                NewObj();
            }
            it++;
            lastPos = curPos;
        }
    }

    void NewObj()
    {
        GameObject obj = new GameObject("px" + it);
        obj.transform.SetParent(drawPar.transform);
        obj.transform.position = this.transform.position;
        obj.AddComponent<RectTransform>().sizeDelta = new Vector2(width, height);
        obj.AddComponent<Image>().color = new Color32(0, 0, 0, 255);
    }
}
