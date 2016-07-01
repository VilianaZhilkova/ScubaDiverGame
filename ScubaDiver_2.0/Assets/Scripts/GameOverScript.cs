using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Start or quit the game
/// </summary>
public class GameOverScript : MonoBehaviour
{

    public void OnGUI()
    {

        const int buttonWidth = 120;
        const int buttonHeight = 60;

        if (
            GUI.Button(
                new Rect(
                    Screen.width / 2 - (buttonWidth / 2),
                (1 * Screen.height / 3) - (buttonHeight / 3),
                buttonWidth,
                buttonHeight
                ),
                "Retry!"
                )
            )
            // "Stage1" is the name of the first scene we created.
            Application.LoadLevel("Stage1");

        if (
           GUI.Button(
               new Rect(
                   Screen.width / 2 - (buttonWidth / 2),
               (2 * Screen.height / 3) - (buttonHeight / 3),
               buttonWidth,
               buttonHeight
               ),
               "Back to menu"
               )
           )
            // "Stage1" is the name of the first scene we created.
            Application.LoadLevel("Menu");
    }

    private Button[] buttons;

    void Awake()
    {
        // Get the buttons
        buttons = GetComponentsInChildren<Button>();

        // Disable them
        HideButtons();
    }

    public void HideButtons()
    {
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(false);
        }
    }

    public void ShowButtons()
    {
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(true);
        }
    }

    public void ExitToMenu()
    {
        // Reload the level
        Application.LoadLevel("Menu");
    }

    public void RestartGame()
    {
        // Reload the level
        Application.LoadLevel("Stage1");
    }
}