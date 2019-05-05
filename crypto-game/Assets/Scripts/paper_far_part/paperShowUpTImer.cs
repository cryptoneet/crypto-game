using UnityEngine;
using UnityEngine.UI;

public class paperShowUpTImer : MonoBehaviour
{
    //btns state
    public Button btnState;
    public Button btnHint;
    //animators
    public Animator animatorPaper;
    public Animator hintShowAnimtr;
    //delays
    public float showDelay = 3f;
    float timerHold = 4f;
    //for hint text 
    public Text hintText;
    //boolean statements for 
    bool btnClicked = false;
    bool paperHoldState = false;

    void Update()
    {
        if (btnClicked)
        {
            showDelay -= 1 * Time.deltaTime;
            if(showDelay < 0)
            {
                
                animatorPaper.Play("paper_showup");
                btnState.enabled = false;
                paperHoldState = true;
                //event destructor
                btnClicked = false;
            }
        }

        if (paperHoldState)
        {
            timerHold -= 1 * Time.deltaTime;

            if(timerHold < 0)
            {
                hintChangeNShow();
                paperHoldState = false;
            }
            
        }
    }

    void hintChangeNShow()
    {
        if (globalVar.lang == "rus")
            hintText.text = "Хмм, кажется ваш коллега бросил вам листок! Что бы это могло значить? \n Давайте изучим объект поближе - тапните на него.";
        else
            hintText.text = "Hmm, seems your colleague threw you a paper! What it could mean? \n Let's examine it closer - tap on it.";
        hintShowAnimtr.GetComponent<Animator>().Play("showHint");
        btnHint.GetComponent<Button>().onClick.AddListener(clickingAllow);
    }

    void clickingAllow()
    {
        btnState.enabled = true;
    }

    public void timerShowStart()
    {
        btnClicked = true;
    }
}
