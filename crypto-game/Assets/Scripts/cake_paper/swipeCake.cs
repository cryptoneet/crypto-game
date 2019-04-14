using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class swipeCake : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public bool isTurned = false;
    public GameObject paperCake;
    Animator animatorCake;
    void Start()
    {
        animatorCake = paperCake.GetComponent<Animator>();
    }

    //getting the state of animator
    public bool IsAnimationPlaying(string animName)
    {
        //state info
        var animatorStateInfo = animatorCake.GetCurrentAnimatorStateInfo(0);
        //get the name of anim running
        if (animatorStateInfo.IsName(animName))
            return true;

        return false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
            if ((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y)))
            {
                if (eventData.delta.x > 0)
                {
                    if (isTurned == false)
                    {
                        animatorCake.Play("cakeTurn");
                        if (!IsAnimationPlaying("cakeTurn"))
                        {
                            isTurned = true;
                        }

                }
                }
                else
                {
                    if(isTurned == true)
                        {
                            animatorCake.Play("cakeUnturn");
                            if (!IsAnimationPlaying("cakeUnturn"))
                            {
                                isTurned = false;
                            }
                        }
                    
                    //if (isTurned == true)
                    //{
                    //    isTurned = false;
                    //}

                }
            }       
    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}
