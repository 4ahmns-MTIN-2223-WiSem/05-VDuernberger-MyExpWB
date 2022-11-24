using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] kegel;
    public GameObject playingSphere;
    

    // Start is called before the first frame update
    void Start()
    {
       // OnCollisionEnter(playingSphere);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kegel")
        {
            Debug.Log("KEGELLLLL !!!");
        }
        Debug.Log("Es geht generell!!!"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
