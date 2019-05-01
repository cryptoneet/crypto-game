using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintingTrig : MonoBehaviour
{
    public bool trigStatus;
    string nameTrig;
    private AudioSource aud_picture;
    public AudioClip[] audioClips = new AudioClip[2];

    void Awake()
    {
        nameTrig = gameObject.name;
        trigStatus = false;

        GameObject g_aud = GameObject.Find("painting");
        aud_picture = g_aud.GetComponent<AudioSource>();
        aud_picture.volume = globalVar.volValue;
    }

    void OnMouseDown()
    {
        if (trigStatus)
        {
            aud_picture.clip = audioClips[1];
            aud_picture.Play();
            paintingTrigManager.nameChecker(nameTrig);
        }
        else
        {
            aud_picture.clip = audioClips[0];
            aud_picture.Play();
            paintingTrigManager.setPtOff();
        }
    }
}
