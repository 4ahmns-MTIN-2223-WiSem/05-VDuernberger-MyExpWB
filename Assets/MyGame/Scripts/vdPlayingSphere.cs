using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vdPlayingSphere : MonoBehaviour
{
    public GameObject playingSphere;
    public Rigidbody rb;
    public float speed;
    public bool uPLaying;


    void Start()
    {
        rb.useGravity = false;
        uPLaying = false;
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "grenze")
        {
            Debug.Log("outside");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("player touched" + playingSphere);
            rb.useGravity = true;
            uPLaying = true;
        }
    }


    void Update()
    {
        if (uPLaying)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.AddForce(Vector3.left * speed);
            }
        }

    }
}

