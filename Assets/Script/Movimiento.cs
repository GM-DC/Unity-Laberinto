using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    void Update()
    {   
        
        if (Input.GetKey("a"))
        {
            gameObject.transform.Translate(-10f*Time.deltaTime,0,0);
        }

        if (Input.GetKey("d"))
        {
            gameObject.transform.Translate(10f*Time.deltaTime,0,0);
        }
        if (Input.GetKey("w"))
        {
            gameObject.transform.Translate(0,10f*Time.deltaTime,0);
        }
        if (Input.GetKey("s"))
        {
            gameObject.transform.Translate(0,-10f*Time.deltaTime,0);
        }
    }
}
