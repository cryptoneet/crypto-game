using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Animator transitionAnim;
    public bool startButHit;
    public string sceneName;


    void Update()
    {
        if(startButHit == true)
        {
            StartCoroutine(LoadScene());
        }
    }

    public void setButHit()
    {
        startButHit = true;
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}
