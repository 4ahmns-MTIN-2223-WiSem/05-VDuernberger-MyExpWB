using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kegel : MonoBehaviour
{

    public bool kegelFallen;
    public GameObject playingKegel;
 


    // Start is called before the first frame update
    void Start()
    {
        kegelFallen = false;
        //Debug.Log(playingKegel.transform.rotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(kegelFallen == false)
        {
            if (playingKegel.transform.rotation.z >= 0.001)
            {

                Debug.Log(playingKegel + " fallen");
                kegelFallen = true;
                Manager.kegelCount++;
              
            }
            else
            {
                kegelFallen = false;
                //Debug.Log(playingKegel +"standing at"+ playingKegel.transform.rotation.z);
            }
        }
    }
}
