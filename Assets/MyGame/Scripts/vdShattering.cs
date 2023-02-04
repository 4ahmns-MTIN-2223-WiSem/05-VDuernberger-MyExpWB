using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vdShattering : MonoBehaviour
{
    public AudioSource glass;


    void Start()
    {
        glass.playOnAwake = false;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "playingSphere")
        {
            glass.Play();
        }
    }

}
