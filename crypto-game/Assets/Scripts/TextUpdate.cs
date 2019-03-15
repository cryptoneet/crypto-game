using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextUpdate : MonoBehaviour
{
    private Text titleText;
    private readonly int level = 1;
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

            if (timer < 0.99f)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 0.99f && timer < 1.08f)
            {
                for (int i = 1; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 1.08f && timer < 1.17f)
            {
                for (int i = 2; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }

            }
            else if (timer >= 1.17f && timer < 1.26f)
            {
                for (int i = 3; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 1.26f && timer < 1.35f)
            {
                for (int i = 4; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 1.44f && timer < 1.53f)
            {
                for (int i = 5; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 1.62f && timer < 1.71f)
            {
                for (int i = 6; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 1.71f && timer < 1.8f)
            {
                for (int i = 7; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 1.8f && timer < 1.89f)
            {
                for (int i = 8; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 1.89f && timer < 1.98f)
            {
                for (int i = 9; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 1.98f && timer < 2.07f)
            {
                for (int i = 10; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 2.16f && timer < 2.25f)
            {
                for (int i = 11; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 2.25f && timer < 2.34f)
            {
                for (int i = 12; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 2.34f && timer < 2.43f)
            {
                for (int i = 13; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 2.43f && timer < 2.52f)
            {
                for (int i = 14; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 2.52f && timer < 2.61f)
            {
                for (int i = 15; i < text.Length; i++)
                {
                    if (i == 15)
                        text[i] = text[i];
                    else
                        text[i] = chars[rnd.Next(chars.Length)];
                }
            }
            else if (timer >= 2.61f && timer < 2.7f)
            {
                for (int i = 17; i < text.Length; i++)
                    text[i] = chars[rnd.Next(chars.Length)];
            }
            else if (timer >= 2.7f && timer < 2.79f)
            {
                for (int i = 18; i < text.Length; i++)
                    text[i] = chars[rnd.Next(chars.Length)];
            }
            else if (timer >= 2.79f && timer < 2.88f)
            {
                for (int i = 19; i < text.Length; i++)
                    text[i] = chars[rnd.Next(chars.Length)];
            }
            else if (timer >= 2.88f && timer < 2.97f)
            {
                for (int i = 20; i < text.Length; i++)
                    text[i] = chars[rnd.Next(chars.Length)];
            }
            else if (timer >= 2.97f && timer < 3.06f)
            {
                for (int i = 21; i < text.Length; i++)
                    text[i] = chars[rnd.Next(chars.Length)];
            }
            else if (timer >= 3.06f && timer < 3.15f)
            {
                for (int i = 22; i < text.Length; i++)
                    text[i] = chars[rnd.Next(chars.Length)];
            }
            else if (timer >= 3.15f && timer < 3.24f)
            {
                for (int i = 23; i < text.Length; i++)
                    text[i] = chars[rnd.Next(chars.Length)];
            }
            else if(timer >= 4f)
                SceneManager.LoadScene(level, LoadSceneMode.Single);
            titleText.text = new string(text);
        }
    }
}