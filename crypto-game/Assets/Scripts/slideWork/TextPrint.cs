using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextPrint : MonoBehaviour
{
    public Text mytext;
    string slidetext;
    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        slidetext = mytext.text;
        mytext.text = null;
        StartCoroutine(TextCoroutine(slidetext));
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    IEnumerator TextCoroutine(string text)
    {
        yield return new WaitForSeconds(2.5f);
        for (int i = 0; i < text.Length; i++)
        {
            mytext.text = text.Substring(0, i);
            yield return new WaitForSeconds(0.075f);
        }
        arrow.SetActive(true);
    }
}
