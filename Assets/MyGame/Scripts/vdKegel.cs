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


    void Start()
    {
        descriptionText.text = "Wellcome to bowling!";
        kegelFallen = false;
    }

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
            }
        }
    }
}
