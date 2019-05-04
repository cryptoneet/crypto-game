using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infInventory : MonoBehaviour
{
    Text infTxt;
    Animator infPanel_animtr;
    GameObject casseteFar;

    bool infShown = false;
    float time = 3f;
    void Start()
    {
        infTxt = GameObject.Find("infTxt").GetComponent<Text>();
        casseteFar = GameObject.Find("casseteFar");
        infPanel_animtr = GetComponent<Animator>();
    }

    void Update()
    {
        if(infShown)
        {
            time -= Time.deltaTime;
            if (time <= 0.0f)
            {
                infPanel_animtr.Play("infHide");
                infShown = false;
            }
        }
        
    }

    public void OnItemAdding(string itemName)
    {
        infTxt.text = ("Предмет добавлен в инвентарь:\n" + itemName);
        infPanel_animtr.Play("infShow");
        casseteFar.SetActive(false);
        infShown = true;
    }
}
