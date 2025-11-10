using UnityEngine;

public class ClickSoundPlayer : MonoBehaviour
{
    private AudioSource audioSource; 
    [SerializeField] private AudioClip clickSound;
    
    private bool hasPlayed = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    public void OnPointerClick()
    {   
        if(hasPlayed) return;
        
        audioSource.PlayOneShot(clickSound);
        hasPlayed = true;
    }

    public void OnPointerExit()
    {
        hasPlayed = false;
    }
    
}
