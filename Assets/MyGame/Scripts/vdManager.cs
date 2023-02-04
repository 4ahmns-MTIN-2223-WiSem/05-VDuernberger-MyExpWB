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


    void Start()
    {
        kegelCount = 0;
    }
}
