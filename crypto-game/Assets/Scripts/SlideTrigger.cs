using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideTrigger : MonoBehaviour
{
    public Animator obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           // obj.Play("Slide1move");
            obj.GetComponent<Animator>().SetTrigger("Clicked");
        }
    }
}
