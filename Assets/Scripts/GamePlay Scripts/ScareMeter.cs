using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScareMeter : MonoBehaviour
{
    public Image point1;
    public Image point2;
    public Image point3;
    public Image point4;
    public Image point5;
    public Image point6;
    public Image point7;
    public Image point8;
    public Image point9;
    public Image point10;

    // Start is called before the first frame update
    void Start()
    {
        point1.enabled = false;
        point2.enabled = false;
        point3.enabled = false;
        point4.enabled = false;
        point5.enabled = false;
        point6.enabled = false;
        point7.enabled = false;
        point8.enabled = false;
        point9.enabled = false;
        point10.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    public void ScareEvent()
    {
        Debug.Log("in scare event");
        
            point1.enabled = true;

        if (point1.enabled == true)
        {
            Debug.Log("enabled");

        }
        else
        {
            Debug.Log("not enabled");

        }


    }


}