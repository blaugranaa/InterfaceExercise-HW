using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    private Rigidbody rigidbody;
    public Rigidbody Rigidbody 
    {
        get 
        { 
           // return (rigidbody == null) ? rigidb  ody = GetComponent<Rigidbody>() : rigidbody; burası alttaki if kısmının tek satırlık hali
           if(rigidbody ==null)
            {
                rigidbody = GetComponent<Rigidbody>();
            }
            return rigidbody;
        } 
    }

    public float MoveSpeed;
    private void Update()


    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Rigidbody.AddForce(input * MoveSpeed * Time.deltaTime);

        
    }

    private void OnTriggerEnter(Collider other)
    {
        IInteractable obj = other.GetComponent<IInteractable>();
        if (obj != null)
        {
            obj.Interact();
        }
    }

}
