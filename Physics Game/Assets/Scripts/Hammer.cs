using UnityEngine;

public class Hammer : MonoBehaviour
{
    public AudioClip sound;
    private AudioSource audioSource;
    
    public float cooldownTime = 0.1f; // Seconds to wait before playing again

    private float nextPlayTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chud") && (Time.time >= nextPlayTime))
        {
            audioSource.PlayOneShot(sound); 
            nextPlayTime = Time.time + cooldownTime;
        }
    }
}
