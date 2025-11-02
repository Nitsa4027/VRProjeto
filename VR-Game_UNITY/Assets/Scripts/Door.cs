using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;

    void SwitchDoor()
    {
        bool isOpen = doorAnimator.GetBool("isOpen");

        doorAnimator.SetBool("isOpen", !isOpen);
    }
    
    public void OnPointerClick()
    {
        SwitchDoor();
    }
}
