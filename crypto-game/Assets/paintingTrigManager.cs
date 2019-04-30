using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintingTrigManager : MonoBehaviour
{

    private static paintingTrig pt1;
    private static paintingTrig pt2;
    private static paintingTrig pt3;
    private static paintingTrig pt4;

    private void Awake()
    {
        GameObject g_pt1 = GameObject.Find("pt1");
        pt1 = g_pt1.GetComponent<paintingTrig>();

        GameObject g_pt2 = GameObject.Find("pt2");
        pt2 = g_pt1.GetComponent<paintingTrig>();   

        GameObject g_pt3 = transform.Find("pt3").gameObject;
        pt3 = g_pt1.GetComponent<paintingTrig>();

        GameObject g_pt4 = transform.Find("pt4").gameObject;
        pt4 = g_pt1.GetComponent<paintingTrig>();

        pt1.trigStatus = true;
    }
    public static void nameChecker(string name)
    {
        if(name == "pt1")
        {
            Debug.Log("First one");
            pt3.trigStatus = true;
        }
        if(name == "pt3")
        {
            Debug.Log("sec one");
            pt4.trigStatus = true;
        }
        if(name == "pt4")
        {
            pt2.trigStatus = true;
        }
        if(name == "pt2")
        {
            Debug.Log("yes");
        }
    }

    public static void setPtOff()
    {
        pt1.trigStatus = true;
        pt2.trigStatus = false;
        pt3.trigStatus = false;
        pt4.trigStatus = false;
    }

}
