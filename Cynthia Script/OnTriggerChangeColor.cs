using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerChangeColor : MonoBehaviour
{

    public Renderer rend;

    private void OnTriggerEnter(Collider other)
    {
        if(rend != null)
        {
            rend.material.color = Color.black;
        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (rend != null)
        {
            rend.material.color = Color.blue;
        }
    }
}
