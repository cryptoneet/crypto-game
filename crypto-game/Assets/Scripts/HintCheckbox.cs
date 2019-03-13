using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintCheckbox : MonoBehaviour
{
    public GameObject hint;
    public GameObject checkBox;
    public Animation animation1,animation2;
    public void CheckBoxExec(bool IsActive)
    {
        if (IsActive)
        {
            hint.SetActive(true);
            animation1.Play();
            animation2.Play();
        }
        else
        {
            hint.SetActive(false);
        }
    }
}
