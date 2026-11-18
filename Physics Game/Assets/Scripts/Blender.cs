using UnityEngine;

public class Blender : MonoBehaviour
{
   
    public AudioClip[] soundClips;
    private AudioSource audioSource;
    public AudioClip[] audioClips;
    public AudioSource audioSourceB;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Script is alive on: " + gameObject.name);
        audioSource = GetComponent<AudioSource>();
        audioSourceB = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chud"))
        {
            Debug.Log("sound should play");
            PlayRandomSound();
        }
    }

    private void PlayRandomSound()
    {
        if (audioClips.Length > 0 && audioSource != null)
        {
            int randomIndex = Random.Range(0, soundClips.Length);
            audioSource.PlayOneShot(soundClips[randomIndex]);
            
        }

        if (soundClips.Length > 0 && audioSourceB != null)
        {
            int randomIndex = Random.Range(0, audioClips.Length);
            audioSource.PlayOneShot(audioClips[randomIndex]);
        }
    }
}
