using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class vdManager : MonoBehaviour
{
    public GameObject[] kegel;
    public GameObject playingSphere;
    public static TMP_Text descriptionText;
    public static int kegelCount;
    //public bool kegelStatus;
    


    // Start is called before the first frame update
    void Start()
    {
        //descriptionText.text = "Wellcome to bowling!";
        kegelCount = 0;
        //kegelStatus = gameObject.GetComponent<Kegel>();
        //Debug.Log(kegelStatus);
    }



    void Update()
    {
        /*if (kegel[0].transform.rotation.z >= 0.45)
        {
            kegelCount++;
            Debug.Log("first one fallen");
        }
        */
        /*if(kegelStatus == true)
        {
            kegelCount++;
        }*/

       /*if(kegel[0].kegelFallen == true)
        {
            kegelCount++;
        }*/
       
        /*if (Input.GetMouseButtonDown(0))
        {
            descriptionText.text = "Congrats! You scored " + kegelCount + " Points";
            Debug.Log(kegelCount);
        }*/

    }
}
