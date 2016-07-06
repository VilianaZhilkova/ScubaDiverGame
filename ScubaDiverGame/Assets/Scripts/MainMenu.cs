using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayButton()
    {
        SceneManager.LoadScene("ScubaDiverGame");
    }

    public void MuteMusic()
    {
        Debug.Log("Music muted");
    }

    public void MuteSounds()
    {
        Debug.Log("Sounds muted");
    }
}
