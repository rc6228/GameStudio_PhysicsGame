using UnityEngine;

public class Bees : MonoBehaviour
{
    

    public AudioClip[] soundClips;
    private AudioSource audioSource;

    public AudioSource audioSourceB;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("chud"))
        {
            Debug.Log("sound should play");
            PlayRandomSound();
        }
    }

    private void PlayRandomSound()
    {
        if (soundClips.Length > 0 && audioSource != null)
        {
            int randomIndex = Random.Range(0, soundClips.Length);
            audioSource.PlayOneShot(soundClips[randomIndex]);
        }
    }
   
}
