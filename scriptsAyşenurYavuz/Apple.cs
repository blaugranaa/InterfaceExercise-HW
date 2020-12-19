using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("u ate the apple. your health increased a little but i think u better look for a potion");
    }
}




    


