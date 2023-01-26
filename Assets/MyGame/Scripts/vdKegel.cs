using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class vdKegel : MonoBehaviour
{

    public bool kegelFallen;
    public GameObject playingKegel;
    public TMP_Text descriptionText;



    // Start is called before the first frame update
    void Start()
    {
        descriptionText.text = "Wellcome to bowling!";
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
                vdManager.kegelCount++;
                descriptionText.text = "Congrats! You scored " + vdManager.kegelCount + " Points";
                Debug.Log(vdManager.kegelCount);


            }
            else
            {
                kegelFallen = false;
                //Debug.Log(playingKegel +"standing at"+ playingKegel.transform.rotation.z);
            }
        }
    }
}
