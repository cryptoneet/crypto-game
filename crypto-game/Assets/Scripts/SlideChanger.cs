using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myCanvas;
    public GameObject screenSlide1;
    public GameObject screenSlide2;
    public Animation slide1Anim;
    public Animation slide1Remove;
    public Animation slide2Anim;
    public Animation slide2Remove;
    void Start()
    {
    }
    int slidePlayed = 1;
    public void moveSlide()
    {
        if (slidePlayed < 5)
        {
            switch (slidePlayed)
            {
                case 1:
                    {
                        slide1Anim.Play();
                        break;
                    }
                case 2:
                    {
                        slide2Anim.Play();
                        break;
                    }
            }
            slidePlayed += 1;
        }
    }
    //Update is called once per frame
    bool started = false;
    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                moveSlide();
                started = true;
            }
        }
    }
}
