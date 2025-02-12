using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatePlatform : MonoBehaviour
{
    public Slider rotationSlider;
    public Transform platform;
    // Start is called before the first frame update
    void Start()
    {
        rotationSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnSliderValueChanged(float value)
    {
        Vector3 platformRotation = new Vector3(platform.rotation.eulerAngles.x, value, platform.rotation.eulerAngles.z);
        platform.rotation = Quaternion.Euler(platformRotation);
    }
}
