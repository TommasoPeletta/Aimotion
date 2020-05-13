using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class TextSlider : MonoBehaviour
{
    public Slider sensitivitySlider;
    private Text textSlider;

    public void Start()
    {
        textSlider = GetComponent<Text>();
        ShowSliderValue();
    }
    public void Update()
    {
        ShowSliderValue();
    }
    public void ShowSliderValue()
    {
        string sliderMessage = "Mouse Sens. : " + (Mathf.Round(sensitivitySlider.value*10) / 10);
        textSlider.text = sliderMessage;
    }
}
