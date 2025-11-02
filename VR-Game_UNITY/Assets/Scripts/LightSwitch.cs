using NUnit.Framework;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField] private Light targetLight;
    [SerializeField] private Material bulbMaterial;

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
        SwitchLight();
    }
}
