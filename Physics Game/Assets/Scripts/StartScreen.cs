using UnityEngine;
using UnityEngine.UI;
public class StartScreen : MonoBehaviour
{
    [SerializeField] private Button myButton;
public GameObject startScreen;
    void Start()
    {
        // Subscribe to the click event
        myButton.onClick.AddListener(OnButtonPressed);
    }

    void OnButtonPressed()
    {
        Debug.Log("UI Button was clicked!");
        Destroy(startScreen);
    }

    void OnDestroy()
    {
        // Clean up listener to avoid memory leaks
        myButton.onClick.RemoveListener(OnButtonPressed);
    }
}
