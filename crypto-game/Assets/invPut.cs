using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class invPut : MonoBehaviour
{
    //for nb showup(inventory zone)
    Animator infPanel_anim;
    infInventory infInventScript;

    void Start()
    {
        infPanel_anim = GameObject.Find("InfPanel").GetComponent<Animator>();
        infInventScript = GameObject.Find("InfPanel").GetComponent<infInventory>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "inventoryZone")
        {
            infInventScript.OnItemAdding("Кассета");
        }
    }
    
    void Update()
    {
        
    }
}
