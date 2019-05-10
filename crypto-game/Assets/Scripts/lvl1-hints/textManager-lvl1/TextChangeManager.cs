using UnityEngine;
using UnityEngine.UI;

public class TextChangeManager : MonoBehaviour
{

    public Text txtHint;
    public Animator animForHint;
    //counter for paper far click
    int cHint = 0;
    //counter for paper cake click
    int cCake = 0;

    public static bool showed = false;

    public void onPaperClickChange()
    {
        if(cHint < 1)
        {
            if(globalVar.lang == "rus")
                txtHint.text = "Хмм.. Скрытое послание \nДавайте используем лупу чтобы обнаружить мелочи. \nБудьте внимательны!";
            else
                txtHint.text = "Hmm.. Hidden message \nLet's try to use magnifier to discover details. \nBe careful!";
            animForHint.Play("showHint");
            cHint++;
        }
       
    }
    public void onClueFoundChange()
    {
        if(globalVar.lang == "rus")
            txtHint.text = "*на бумаге найдены неровности* \nВидимо на бумагу преднамеренно было нанесено какое-то вещество. Нужно придумать, как с ним взаимодействовать.";
        else
            txtHint.text = "*there are some bumps* \nMaybe paper was intentionally covered with some substance. I need to find how to interact with it.";
        animForHint.Play("showHint");   
    }
    public void onPaperCake()
    {
        if(cCake < 1)
        {
            if (globalVar.lang == "rus")
                txtHint.text = "Некоторые объекты можно рассматривать более детально. \nРазверните листок свайпом чтобы исследовать его детальнее.";
            else
                txtHint.text = "Some objects could be viewed more detailed. \nTurn sticker by swiping right to explore it properly.";
            animForHint.Play("showHint");
            cCake++;
        }
    }
    public void onStickerClueFound()
    {
        //Change text
        if (globalVar.lang == "rus")
            txtHint.text = "Получилось разгадать шифр! \nНу что ж, отправимся по следу и посмотрим, куда он нас приведет.";
        else
            txtHint.text = "Got it! I cracked the code!. \n.Let's go getting the trail of it!";
        animForHint.Play("showHint");
        showed = true;
    }
    public void onSymbFound()
    {
        if (globalVar.lang == "rus")
            txtHint.text = "Странный символ.\nНебрежно написан. \nМне кажется, похожий я где-то уже видел...";
        else
            txtHint.text = "Strange symbol.\nCasually written. \nSomehow, the symbol is familiar to me...";
        animForHint.Play("showHint");
    }
    public void onTrueCodeEntered()
    {
        if (globalVar.lang == "rus")
            txtHint.text = "\nЕсть!!! Получилось открыть! Что же внутри?";
        else
            txtHint.text = "\nGreat! Managed to open it! What's inside?";
        animForHint.Play("showHint");
    }
    int counterItemFirst = 0;
    public void onItemFirstAdding()
    {
        if (counterItemFirst < 1)
        {
            if (globalVar.lang == "rus")
                txtHint.text = "Чтобы поместить предмет в инвентарь - перетащите его на записную книгу \nОн поместится в свободный слот";
            else
                txtHint.text = "To put item to inventory you need to move it to the note book.\n It will be placed in empty slot";
            animForHint.Play("showHint");
            counterItemFirst++;
        }
    }
}
