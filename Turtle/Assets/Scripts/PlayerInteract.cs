using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject currentInterObj = null;

    void Update()
    {
       if(Input.GetButtonDown("Interact") && currentInterObj){
            // Do something with the object
            currentInterObj.SendMessage("DoInteraction");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interact"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
        }
    }

   void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interact"))
        {
            if (other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
            
        }
    }
}
