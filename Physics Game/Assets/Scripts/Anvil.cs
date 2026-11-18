using UnityEngine;

public class Anvil : MonoBehaviour
{
    

    public AudioClip sound;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chud"))
        {
            audioSource.PlayOneShot(sound); 
        }
    }

   
}
