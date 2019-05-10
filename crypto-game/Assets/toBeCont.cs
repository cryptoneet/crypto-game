using UnityEngine;
using UnityEngine.UI;

public class toBeCont : MonoBehaviour
{
    bool isCasseteClicked = false;
    public float timeOfDelay = 2.0f;
    Image contImg;
    Animator contAnimator;
    private void Start()
    {
        contImg = GameObject.Find("toBeCont_trans").GetComponent<Image>();
        contAnimator = GameObject.Find("toBeCont_trans").GetComponent<Animator>();
    }
    private void Update()
    {
        if (isCasseteClicked)
        {
            timeOfDelay -= Time.deltaTime;
            if(timeOfDelay <= 0)
            {
                contImg.raycastTarget = true;
                contAnimator.Play("toBe_show");
                isCasseteClicked = false;
            }
        }
    }
    public void onCasseteClicked()
    {
        isCasseteClicked = true;
    }
}
