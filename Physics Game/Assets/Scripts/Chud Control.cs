using UnityEngine;

public class ChudControl : MonoBehaviour
{
    private bool isOverTrash = false;
    public float requiredCollisionTime = 2f;
    private float collisionTimer = 0f;

    void Update()
    {
        if (isOverTrash == true)
        {
            collisionTimer += Time.deltaTime;
            if (collisionTimer >= requiredCollisionTime)
            {
                Destroy(gameObject); // Or Destroy(collision.gameObject)
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TrashCan"))
        {
            Debug.Log("over trash");
            isOverTrash = true;

           
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("TrashCan"))
        {
            Debug.Log("not over trash");
            isOverTrash = false;
            collisionTimer = 0f;
        }
    }
}
