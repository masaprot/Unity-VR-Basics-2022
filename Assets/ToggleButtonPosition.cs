using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonPosition : MonoBehaviour
{
    private Button button;
    private RectTransform rectTransform;
    private bool isToggle = false;

    // Start is called before the first frame update
    void Start()
    {
        
        // Get the Button component from the GameObject
        button = GetComponent<Button>();

        // Get the RectTransform component from the GameObject
        rectTransform = GetComponent<RectTransform>();

        // Add a listener to the button click event
        button.onClick.AddListener(TogglePosition);
    }

    // Function to be called when the button is clicked
    void TogglePosition()
    {
        // Toggle the boolean flag
        isToggle = !isToggle;

        // Set the button's position based on the toggle state
        if (isToggle)
        {
            // Move to position 1
            rectTransform.anchoredPosition = new Vector3(-100f, 100f, 0f);
        }
        else
        {
            // Move to position 2
            rectTransform.anchoredPosition = new Vector3(0f, -100f, 0f);
        }
    }
}