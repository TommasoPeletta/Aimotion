using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class MouseSens : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider sensitivitySlider;

    public void ApplySensitivity()
    {
        GetComponent<FirstPersonController>().ChangeMouseSensitivity(sensitivitySlider.value, sensitivitySlider.value);
    }


}
