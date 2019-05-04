using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour
{
    public Animator transitionAnim;
    public bool startButHit;
    public string sceneName;

    public void setButHit()
    {
        startButHit = true;
    }

    void Update()
    {
        if(startButHit == true)
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
    
    public void toEnScene()
    {
        SceneManager.LoadScene("MainMenu_en");
    }

    public void toRuScene()
    {
        SceneManager.LoadScene("MainMenu_ru");
    }


}
