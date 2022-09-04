using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class ShowText : MonoBehaviour
{
    public GameObject textObject;
    public bool isActive;
    public bool isSit = false;

    /*private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!isSit)
            {
                isSit = true;
                Vector3 newPos = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
                Animator anim = other.GetComponent<Animator>();
                anim.SetBool("isSit", true);
                other.transform.position = newPos;
            }
            else if (isSit)
            {
                isSit = false;
                Vector3 newPos = new Vector3(transform.position.x + 0.5f, 0.1f, transform.position.z);
                Animator anim = other.GetComponent<Animator>();
                anim.SetBool("isSit", false);
                other.transform.position = newPos;
            }

        }

        if(isSit)
        {
            
        }
    }*/

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

