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
        arrow.SetActive(false);
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
                else StartCoroutine(Scene_change());
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
    private IEnumerator Scene_change()
    {
        if (SceneManager.GetActiveScene().name == "SlideScene_1")
        {
            obj.SetTrigger("Clicked");
            arrow.SetActive(false);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("level_1");

        }
        else if (SceneManager.GetActiveScene().name == "SlideScene_2")
        {
            obj.SetTrigger("Clicked");
            arrow.SetActive(false);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("level_2");
        }
    }
}
