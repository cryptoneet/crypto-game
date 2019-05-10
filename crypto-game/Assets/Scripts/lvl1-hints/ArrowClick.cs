using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowClick : MonoBehaviour
{
    public rotCipher cipher;
    void OnMouseDown()
    {
        if(gameObject.tag == "arrow_right")
            cipher.shChangeR();
        else
            cipher.shChangeL();
        Debug.Log("Shift changed to " + cipher.shift);
    }
}
