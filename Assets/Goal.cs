using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public GameObject UItext;

    void OnTriggerEvent(Collider other)
    {
        UItext.GetComponent<Text>().text = "T H E   E N D";
    }
}