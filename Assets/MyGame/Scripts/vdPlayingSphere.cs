using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vdPlayingSphere : MonoBehaviour
{
    public GameObject playingSphere;
    public Rigidbody rb;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        //playingSphere = gameObject.Getcomponent();
        
    }

    private void OnCollisionStart(Collision collision)
    {
        if (collision.gameObject.tag == "button")
        {
            Debug.Log("StartButton");

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       /*if (collision.gameObject.tag == "kegel")
        {
            Debug.Log("touched a Kegel");

        }*/
        // Debug.Log("Es geht generell");
        if (collision.gameObject.tag == "grenze")
        {
            Debug.Log("outside");
            Destroy(gameObject);

        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector3.left * speed);
            

        }
        
    }
}

