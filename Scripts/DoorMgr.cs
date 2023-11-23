using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMgr : MonoBehaviour
{
    public Animator anim;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("character_nearby", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("character_nearby", false);
        }
    }
}
