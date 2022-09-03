using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowText : MonoBehaviour
{
    public GameObject textObject;
    public bool isActive;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(!isActive)
            {
                textObject.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            textObject.SetActive(false);
        }
    }
}

