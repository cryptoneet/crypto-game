using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextUpdate : MonoBehaviour
{
    private Text titleText;
    private int level = 1;
    private float timer;
    private System.Random rnd = new System.Random();
    public bool Active = false;

    // Start is called before the first frame update
    void Start()
    {
        titleText = gameObject.GetComponent<Text>();
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Active)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789?!@#$&";
            char[] text = { 'C', 'r', 'y', 'p', 't', 'o', 'N', 'E', 'E', 'T', ' ', 'T', 'e', 'a', 'm', '\n', 'P', 'r', 'e', 's', 'e', 'n', 't', 's' };
            timer += Time.deltaTime;
            if (timer < 2.16f)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >=2.16f && timer < 2.52f)
            {
                for (int i = 1; i < text.Length; i++)
                {
                    if (i == 5)
                        text[i] = text[i];
                    else
                     text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if(timer >= 2.52f && timer < 2.88f)
            {
                for (int i = 2; i < text.Length; i++)
                {
                    if (i == 15)
                       text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
                    
            }
            else if(timer >= 2.88f && timer < 3.24f)
            {
                for (int i = 3; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }  
            }
            else if(timer >= 3.24 && timer < 3.6){
                for (int i = 4; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if(timer >= 3.6f && timer < 3.96f)
            {
                        for (int i = 5; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
            }
            else if(timer >= 3.96f && timer < 4.32)
            {
                        for (int i = 6; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
            }
            else if(timer >= 4.32f && timer < 4.68f)
            {
                        for (int i = 7; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
            }
            else if(timer >= 4.68f && timer < 5.04f)
            {
                        for (int i = 8; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
            }
            else if(timer >= 5.04f && timer < 5.4f)
            {
                        for (int i = 9; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
            }
            else if(timer >= 5.4f && timer < 6.12f)
            {
                        for (int i = 10; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
            }
            else if(timer >= 6.12f && timer < 6.48f)
            {
                        for (int i = 11; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
            }
            else if(timer >=6.48f && timer < 6.84f)
            {
                        for (int i = 12; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
            }
            else if(timer >= 6.84f && timer < 7.2f)
            {
                        for (int i = 13; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
            }
            else if(timer >= 7.2f && timer < 7.56f)
            {
                        for (int i = 14; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
            }
            else if(timer >= 7.56f && timer < 7.92f)
            {
                    for (int i = 15; i < text.Length; i++)
                        text[i] = chars[rnd.Next(chars.Length)];
            }
            else if(timer >= 7.92f && timer < 8.28f)
            {
                    for (int i = 17; i < text.Length; i++)
                        text[i] = chars[rnd.Next(chars.Length)];
            }
            else if(timer >= 8.28f && timer < 8.64f)
            {
                        for (int i = 18; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
            }
            else if(timer >= 8.64f && timer < 9f)
            {
                        for (int i = 19; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
            }
            else if(timer >=9f && timer < 9.36f)
            {
                        for (int i = 20; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
            }
            else if(timer >= 9.36f && timer < 9.72f)
            {
                        for (int i = 21; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
            }
            else if(timer >= 9.72f && timer < 10.08f)
            {
                        for (int i = 22; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
            }
            else if(timer >= 10.08f && timer < 11.5f)
            {
                        for (int i = 23; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
            }
            else
                SceneManager.LoadScene(level, LoadSceneMode.Single);
            titleText.text = new string(text);
        }
    }
}