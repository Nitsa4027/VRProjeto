using UnityEngine;
using TMPro;

public class ShowTextOnClick : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI feedbackText; 

    private bool clicked = false;

    void Start()
    {

        if (feedbackText != null)
        {
            feedbackText.gameObject.SetActive(false);
        }
    }

    public void OnPointerClick()
    {   

        if(clicked) return;
        clicked = true;
    }

    public void OnPointerExit()
    {   
        clicked = false;
    }
}