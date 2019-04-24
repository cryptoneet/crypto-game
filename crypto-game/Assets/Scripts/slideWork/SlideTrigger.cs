using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SlideTrigger : MonoBehaviour
{
    public Animator obj;
    public GameObject arrow;
    public float startTime;
    public float EndTime;
    private AudioSource audioSource;
    private int counter;
    // Start is called before the first frame update
    bool coroutine = false;
    void Start()
    {
        obj = GetComponent<Animator>();
        StartCoroutine(Example());
        audioSource = GetComponent<AudioSource>();
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (coroutine)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (counter < 2)
                {
                    obj.SetTrigger("Clicked");
                    counter++;
                    arrow.SetActive(false);
                    audioSource.Play();
                    StartCoroutine(Example());
                    coroutine = false;
                }
                else SceneManager.LoadScene("level_1");
            }
        }
    }
    private IEnumerator Example()
    {
        coroutine = false;
        yield return new WaitForSeconds(5);
        arrow.SetActive(true);
        coroutine = true;
    }
}
