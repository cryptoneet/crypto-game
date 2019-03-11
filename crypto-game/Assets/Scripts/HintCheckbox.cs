using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintCheckbox : MonoBehaviour
{
    public GameObject hint;
    public GameObject checkBox;
    public void CheckBoxExec(bool IsActive)
    {
        if (IsActive) hint.SetActive(true);
        else hint.SetActive(false);
    }
}
