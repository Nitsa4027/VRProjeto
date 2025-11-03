using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    [SerializeField] private GameObject vrHand;

    private bool clicked;

    void SwitchDoor()
    {
        bool isOpen = doorAnimator.GetBool("isOpen");

        doorAnimator.SetBool("isOpen", !isOpen);
    }

    public void OnPointerEnter()
    {
        vrHand.SetActive(true);
    }
    
    public void OnPointerClick()
    {   
        if(clicked == true) return;
        
        SwitchDoor();

        clicked = true;
    }

    public void OnPointerExit()
    {
        vrHand.SetActive(false);

        clicked = false;
    }
}
