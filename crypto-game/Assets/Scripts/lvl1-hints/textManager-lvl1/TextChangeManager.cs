using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChangeManager : MonoBehaviour
{

    public Text txtHint;
    public Animator animForHint;
    //counter for paper far click
    int cHint = 0;

    public void onPaperClickChange()
    {
        if(cHint < 1)
        {
            txtHint.text = "Хмм.. Скрытое послание \nДавайте используем лупу чтобы обнаружить мелочи. \nБудьте внимательны!";
            animForHint.Play("showHint");
            cHint++;
        }
       
    }
    public void onClueFoundChange()
    {
        txtHint.text = "*на бумаге найдены неровности* \nВидимо на бумагу преднамеренно было нанесено какое-то вещество. Нужно придумать, как с ним взаимодействовать.";
        animForHint.Play("showHint");   
    }
}
