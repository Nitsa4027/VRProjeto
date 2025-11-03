using NUnit.Framework;
using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour
{
    [SerializeField] private Light targetLight;
    [SerializeField] private Material bulbMaterial;

    private bool clicked;

    void SwitchLight()
    {
        bool isActive = targetLight.enabled;

        targetLight.enabled = !isActive;

        if(isActive)
        {
            bulbMaterial.SetColor("_EmissionColor", Color.black);
        }
        else
        {
            bulbMaterial.SetColor("_EmissionColor", Color.white);
        }
    }
    
    public void OnPointerClick()
    {
        if(clicked == true) return;
        
        SwitchLight();

        clicked = true;
    }

    public void OnPointerExit()
    {
        clicked = false;
    }
}
