using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using System;
using System.Globalization;

public class ClockScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currentTime;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        currentTime.text = DateTime.Now.ToString();
    }

    
}
