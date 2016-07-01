using UnityEngine;

/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{

    private GUISkin skin;

    public void Start()
    {
        skin = Resources.Load("GUISkin") as GUISkin;
    }

    public void OnGUI()
    {
        GUI.skin = skin;
        const int buttonWidth = 84;
        const int buttonHeight = 60;

        if (
            GUI.Button(
                new Rect(
                    Screen.width / 2 - (buttonWidth / 2),
                (2 * Screen.height / 3) - (buttonHeight / 3),
                buttonWidth,
                buttonHeight
                ),
                "Start!"
                )
            )
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("Stage1");
    }
}