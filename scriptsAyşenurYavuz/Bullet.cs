using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("bullet collected. use it wisely");
    }
}

