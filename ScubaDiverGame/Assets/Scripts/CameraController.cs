using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    //Currently using Unity build-in CameraFollow2D
    public GameObject player;
    private double offsetX;
    
	void Start () {
        this.offsetX = this.transform.position.x
            - this.player.transform.position.x;
	}
	
	void Update () {
        var position = this.transform.position;
        position.x = this.player.transform.position.x;
        this.transform.position = position;
	}
}
