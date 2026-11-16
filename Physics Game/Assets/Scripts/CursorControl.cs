using UnityEngine;
using UnityEngine.InputSystem;

public class CursorControl : MonoBehaviour
{ 
    public LayerMask bodyLayer;

    private Rigidbody2D grabbedObject;

    private Vector2 mousePosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()); //getting the mouse position
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero, 100f, bodyLayer); 
            hit = Physics2D.Raycast(mousePosition, Vector2.zero, 100f, bodyLayer); //is the ray intersecting the body layer
            if (hit.collider != null)
            {
                grabbedObject = hit.rigidbody;
            }

        } else if (Mouse.current.leftButton.wasReleasedThisFrame && grabbedObject != null)
        {
            grabbedObject = null;
        }
    }

    void FixedUpdate() //for physics! because i am grabbing rigidbodies, i need to use fixed update and not try to trnasform position
    {
        if (grabbedObject != null)
        {
            grabbedObject.MovePosition(mousePosition); 
        }
    }

   
}
