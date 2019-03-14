using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextUpdate : MonoBehaviour
{
    private Text titleText;
    private int level = 1;
    private float timer;
    private int set = 1;
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
            float time = 0.0f;
            timer += Time.deltaTime;
            if (timer >= 8.0f)
                time += Time.deltaTime;
            if (time % 0.72f == 0 && time <= 17.28f)
                set++;
            switch (set)
            {
                case 1:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 5)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 3:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 4:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 5:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 6:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 7:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 8:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 9:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 10:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 11:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 12:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 13:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 14:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 15:
                    {
                        for (int i = set - 1; i < text.Length; i++)
                        {
                            if (i == 15)
                                text[i] = text[i];
                            else
                                text[i] = chars[rnd.Next(chars.Length)];
                        }
                        break;
                    }
                case 16:
                    {
                        for (int i = set; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
                        break;
                    }
                case 17:
                    {
                        for (int i = set; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
                        break;
                    }
                case 18:
                    {
                        for (int i = set; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
                        break;
                    }
                case 19:
                    {
                        for (int i = set; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
                        break;
                    }
                case 20:
                    {
                        for (int i = set; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
                        break;
                    }
                case 21:
                    {
                        for (int i = set; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
                        break;
                    }
                case 22:
                    {
                        for (int i = set; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
                        break;
                    }
                case 23:
                    {
                        for (int i = set; i < text.Length; i++)
                            text[i] = chars[rnd.Next(chars.Length)];
                        break;
                    }
            }
            titleText.text = new string(text);
            if (timer == 5.0f)
                SceneManager.LoadScene(level, LoadSceneMode.Single);
        }
    }
}