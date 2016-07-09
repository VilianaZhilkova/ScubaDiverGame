using UnityEngine;
using System.Collections;

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
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            health.CurrentValue -= 2;
        }
	}
}
