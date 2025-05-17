using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class button : MonoBehaviour
{
    public GameObject obj;

    void Start()
    {
        obj = GameObject.Find("Untitled");
        Debug.Log("start");
    }
    public void OnButtonClicked()
    {
        obj.transform.position = Vector3.zero;

    }
    

    

}
