using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts.Player;

public class PlayerHealth : MonoBehaviour {
    [SerializeField]
    private Stat health;

    private void Awake()
    {
        health.Initialize();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Update ()
    {
       
	}


    public void UpdateStat(float dmg)
    {
        this.health.CurrentValue -= dmg;

    }

    public void CheckForEnd()
    {
        if (this.health.CurrentValue<=0)
        {
            var player = new PlayerController();
            player.Weapon.KillCount = 0;
            //TODO end game
            //Debug.Log("Game ended....");
            SceneManager.LoadScene("GameOver");
        }
    }
    
}
