using UnityEngine;
using UnityEngine.UI;

public class inventoryScript : MonoBehaviour
{
    public bool cassete = false;
    Image casseteInv;
    bool invActive = false;

    private void Start()
    {
        casseteInv = GameObject.Find("casseteInvLook").GetComponent<Image>();
        casseteInv.enabled = false;
    }

    private void Update()
    {
        if(invActive)
        { 
            if (cassete)
            {
                casseteInv.enabled = true;
            }
            else if (!cassete)
            {
                casseteInv.enabled = false;
            }
        }
        else
        {
            casseteInv.enabled = false;
        }
        
    }

    public void onInvActive()
    {
        invActive = true;
    }
    public void onInvUNactive()
    {
        invActive = false;
    }
}
