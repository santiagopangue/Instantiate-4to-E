using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public Text txtUserCloneAmount;
    public GameObject objectToClone;
    public int cloneAmount;
    GameObject clon;
    
    public void MultiInstantiate()
    {
        if (txtUserCloneAmount.text != "")
        {
            cloneAmount = int.Parse(txtUserCloneAmount.text);
        }
        else
        {
            Debug.Log("El campo no puede estar vacio");
        }

        for (int i = 0; i<cloneAmount; i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon,2);
        }
    }
}
