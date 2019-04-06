using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineDraw : MonoBehaviour
{
    public static GameObject parObj, drawPar;
    private int it = 0;
    private bool act = false;
    Vector3 curPos, lastPos;

    //Start callded once per run

    void Start()
    {
        parObj = this.transform.parent.gameObject;
        drawPar = GameObject.FindGameObjectWithTag("draw_zone");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "draw_zone")
            act = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "draw_zone")
            act = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (act)
        {
            curPos = this.transform.position;
            if (parObj.GetComponent<itemDragHandler>().itemDragged != null)
            {
                if (curPos != lastPos)
                {
                    NewLine();
                    it++;
                }
            }
            lastPos = curPos;
        }
    }

    void NewLine()
    {
        Vector3 lVec = curPos;
        if(it == 0)
            lVec.z = -1;
        //lVec.x -= 500;
        //lVec.y -= 100;
        drawPar.GetComponent<LineRenderer>().positionCount = it + 1;
        drawPar.GetComponent<LineRenderer>().SetPosition(it, lVec);
    }
}
