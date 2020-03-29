using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player")) {
            anim.SetTrigger("move");
        }
    }
}
