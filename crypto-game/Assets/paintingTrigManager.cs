using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintingTrigManager : MonoBehaviour
{

    private static paintingTrig pt1;
    private static paintingTrig pt2;
    private static paintingTrig pt3;
    private static paintingTrig pt4;

    private static Animator animPicture;
    
    //private static AudioSource aud_picture_false;

    private void Start()
    {
        animPicture = GetComponent<Animator>();

        GameObject g_pt1 = GameObject.Find("pt1");
        pt1 = g_pt1.GetComponent<paintingTrig>();

        GameObject g_pt2 = GameObject.Find("pt2");
        pt2 = g_pt2.GetComponent<paintingTrig>();   

        GameObject g_pt3 = GameObject.Find("pt3");
        pt3 = g_pt3.GetComponent<paintingTrig>();

        GameObject g_pt4 = GameObject.Find("pt4");
        pt4 = g_pt4.GetComponent<paintingTrig>();

        pt1.trigStatus = true;
    }
    public static void nameChecker(string name)
    {
        
        switch (name)
        {
            case "pt1":
                pt3.trigStatus = true;
                break;
            case "pt3":
                pt4.trigStatus = true;
                break;
            case "pt4":
                pt2.trigStatus = true;
                break;
            case "pt2":
                animPicture.Play("secret_show");
                break;

        }
        //if(name == "pt1")
        //{
        //    Debug.Log("First one");
        //    pt3.trigStatus = true;
        //}
        //if(name == "pt3")
        //{
        //    Debug.Log("sec one");
        //    pt4.trigStatus = true;
        //}
        //if(name == "pt4")
        //{
        //    pt2.trigStatus = true;
        //}
        //if(name == "pt2")
        //{
        //    Debug.Log("yes");
        //}
    }

    public static void setPtOff()
    {
        pt1.trigStatus = true;
        pt2.trigStatus = false;
        pt3.trigStatus = false;
        pt4.trigStatus = false;
    }

}
