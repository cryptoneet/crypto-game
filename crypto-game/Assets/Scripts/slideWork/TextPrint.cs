using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextPrint : MonoBehaviour
{
    public Text mytext;
    string slidetext;
    public GameObject arrow, panel;
    // Start is called before the first frame update
    void Start()
    {
        slidetext = mytext.text;
        mytext.text = null;
        panel.GetComponent<Image>().color = new Color32(17, 17, 17, 0);
        StartCoroutine(TextCoroutine(slidetext));
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    IEnumerator TextCoroutine(string text)
    {
        yield return new WaitForSeconds(2f);
        for (int i = 1; i < 33; i++)
        {
            byte a = (byte)(4 * i);
            panel.GetComponent<Image>().color = new Color32(17, 17, 17, a);
            yield return new WaitForSeconds(0.005f);
        }
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < text.Length; i++)
        {
            mytext.text = text.Substring(0, i);
            yield return new WaitForSeconds(0.04f);
        }
        arrow.SetActive(true);
    }
}
