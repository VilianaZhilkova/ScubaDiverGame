using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    bool isMute;

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
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }
}
