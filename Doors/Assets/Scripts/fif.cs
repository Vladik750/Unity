using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fif : MonoBehaviour
{
    
    private Rigidbody doorRb;
    private bool isOpened = false;
    private int degrees = 90;
    

    // Start is called before the first frame update
    void Start()
    {
        doorRb = GetComponent<Rigidbody>();
        
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {

         if(!isOpened)
         {
             for (int i = 0; i <= degrees; i++)
             {
                 transform.Rotate(new Vector3(0, 1, 0), -1);

             }
             isOpened = true;
         }
         else
         {
             for (int i = degrees; i >= 0; i--)
             {
                 transform.Rotate(new Vector3(0, 1, 0), 1);

             }
             isOpened = false;
         }

    }
}
