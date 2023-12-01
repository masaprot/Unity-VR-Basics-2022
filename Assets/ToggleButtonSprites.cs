using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonSprites : MonoBehaviour
{
    private Button button;
    private Image buttonImage;
    public Sprite firstSprite;  // Assign the first sprite in the inspector
    public Sprite secondSprite; // Assign the second sprite in the inspector
    private bool isToggle = false;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Button component from the GameObject
        button = GetComponent<Button>();

        // Get the Image component from the GameObject
        buttonImage = GetComponent<Image>();

        // Add a listener to the button click event
        button.onClick.AddListener(ToggleSprites);
    }



    // Function to be called when the button is clicked
    void ToggleSprites()
    {
        // Toggle the boolean flag
        isToggle = !isToggle;

        // Change the sprite of the button's Image component based on the toggle state
        if (isToggle)
        {
            if (secondSprite != null)
            {
                buttonImage.sprite = secondSprite;
            }
        }
        else
        {
            if (firstSprite != null)
            {
                buttonImage.sprite = firstSprite;
            }
        }
    }
}