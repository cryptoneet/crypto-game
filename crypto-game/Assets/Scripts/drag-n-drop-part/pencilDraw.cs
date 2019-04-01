using UnityEngine;
using UnityEngine.UI;

public class pencilDraw : MonoBehaviour
{
    public static GameObject parObj, drawPar;
    private int it = 0;
    private bool act = false;
    Vector3 curPos, lastPos;

    public float width, height;
    
    //Start callded once per run

    void Start()
    {
        parObj = transform.parent.gameObject;
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
            curPos = transform.position;
            if (parObj.GetComponent<itemDragHandler>().itemDragged != null)
            {
                if (curPos != lastPos)
                {
                    NewObj();
                    it++;
                }
            }
            lastPos = curPos;
        }
    }

    void NewObj()
    {
        GameObject obj = new GameObject("px" + it);
        obj.transform.SetParent(drawPar.transform);
        obj.transform.position = transform.position;
        obj.AddComponent<RectTransform>().sizeDelta = new Vector2(width, height);
        obj.AddComponent<Image>().color = new Color32(0, 0, 0, 255);
    }
}
