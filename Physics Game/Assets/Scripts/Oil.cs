using UnityEngine;

public class Oil : MonoBehaviour
{
    public string targetTag = "chud";

    public AudioClip[] soundClips;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
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
