using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TextUpdate : MonoBehaviour
{
    private Text titleText;
    private float timer;
    private int animNum;
    public float transTime = 1.5f;
    public float animStart = 0.99f;
    public float timeDiff = 0.09f;
    public float animEnd = 3.24f;
    public float sceneEnd = 4f;
    public float transEnd = 1f;
    public Animator transitionAnim;


    private System.Random rnd = new System.Random();
    
    // Start is called before the first frame update
    void Start()
    {
        titleText = gameObject.GetComponent<Text>();
        timer = 0.0f;
        animNum = 1;
    }

    public void trans()
    {
        transitionAnim.SetTrigger("end");
        StartCoroutine(TimeDel(transEnd));
    }

    IEnumerator TimeDel(float t)
    {
        yield return new WaitForSeconds(t);
        if (globalVar.lang == "rus")
            SceneManager.LoadScene("MainMenu_ru");
        else
            SceneManager.LoadScene("MainMenu_en");
    }

    // Update is called once per frame
    void Update()
    {
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789?!@#$&()*=";
        char[] text = { 'C', 'r', 'y', 'p', 't', 'o', 'N', 'E', 'E', 'T', ' ', 'T', 'e', 'a', 'm', '\n', 'P', 'r', 'e', 's', 'e', 'n', 't', 's' };

        timer += Time.deltaTime;

        if (timer >= animStart + timeDiff * animNum && timer <= animEnd)
            animNum++;

        if (timer < animStart)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n')
                    text[i] = text[i];
                else
                    text[i] = chars[rnd.Next(chars.Length)];
            }
        }
        else if (timer >= (animStart + timeDiff * (animNum - 1)) && timer < (animStart + timeDiff * animNum))
        {
            for (int i = animNum; i < text.Length; i++)
            {
                if (text[i] == '\n')
                    text[i] = text[i];
                else
                    text[i] = chars[rnd.Next(chars.Length)];
            }
        }
        else if (timer >= sceneEnd)
            trans();
        titleText.text = new string(text);
    }
}
