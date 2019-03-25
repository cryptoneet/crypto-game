using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideTrigger : MonoBehaviour
{
    public Animator obj;
    public float startTime;
    public float EndTime;
    // Start is called before the first frame update
    bool coroutine = false;
    void Start()
    {
        obj = GetComponent<Animator>();
        StartCoroutine(Example());
    }

    // Update is called once per frame
    void Update()
    {
        if (coroutine)
        {
            // StartCoroutine(Example());
            if (Input.GetMouseButtonDown(0))
            {
                // obj.Play("Slide1move");
                obj.GetComponent<Animator>().SetTrigger("Clicked");
                
                StartCoroutine(Example());

            }
        }
    }
    private IEnumerator Example()
    {
        coroutine = false;
        yield return new WaitForSeconds(5);
        coroutine = true;
    }
}
