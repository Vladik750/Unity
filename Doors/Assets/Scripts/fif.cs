using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fif : MonoBehaviour
{

    private Rigidbody doorRb;
    private bool isOpened = false;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        doorRb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        anim.SetTrigger("Idle");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (!isOpened)
        {
            anim.SetTrigger("openDoor");
            isOpened = true;
        }
        else
        {
            anim.SetTrigger("closeDoor");
            isOpened = false;
        }

    }
}
