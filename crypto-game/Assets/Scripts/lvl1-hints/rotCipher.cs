using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotCipher : MonoBehaviour
{
    private Text hintText;
    private bool changed = false, minigame = false;

    public GameObject arrowL, arrowR;
    public TextChangeManager textManager;
    public int shift = 3;
    public int finShift = -3;
    public int minShift = -6;
    public int maxShift = 6;

    void Awake()
    {
        hintText = gameObject.GetComponent<Text>();
        hintText.text = Caesar(hintText.text, shift);
    }

    public void startMinigame()
    {
        if(changed == false && minigame == false)
        {
            minigame = true;
            arrowL.SetActive(true);
            arrowR.SetActive(true);
            shift = 0;
        }
        if(shift == finShift)
        {
            arrowL.SetActive(false);
            arrowR.SetActive(false);
            textManager.onStickerClueFound();
        }
        else
        {
            Debug.Log("Not correct");
        }
    }

    public void shChangeL()
    {
        hintText.text = Caesar(hintText.text, -shift);
        shift--;
        if (shift < minShift)
            shift++;
        changed = true;
    }

    public void shChangeR()
    {
        hintText.text = Caesar(hintText.text, -shift);
        shift++;
        if (shift > maxShift)
            shift--;
        changed = true;
    }

    static string Caesar(string value, int shift)
    {
        char[] buffer = value.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            // Letter.
            char letter = buffer[i];
            // Add shift to all.
            if (!char.IsWhiteSpace(letter))
            {
                letter = (char)(letter + shift);
                // Subtract 26 on overflow.
                // Add 26 on underflow.
                if (globalVar.lang == "rus")
                {
                    if (letter > 'я')
                    {
                        letter = (char)(letter - 33);
                    }
                    else if (letter < 'а')
                    {
                        letter = (char)(letter + 33);
                    }
                }
                else
                {
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                }
            }
            // Store.
            buffer[i] = letter;
        }
        return new string(buffer);
    }

    void Update()
    {
        if(changed)
        {
            hintText.text = Caesar(hintText.text, shift);
            changed = false;
        }
        if (swipeCake.returnState() == false && minigame)
        {
            arrowL.SetActive(false);
            arrowR.SetActive(false);
        }
        else if (swipeCake.returnState() == true && minigame)
        {
            arrowL.SetActive(true);
            arrowR.SetActive(true);
        }
    }
}
