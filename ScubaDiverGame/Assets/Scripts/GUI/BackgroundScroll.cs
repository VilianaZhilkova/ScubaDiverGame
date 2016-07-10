using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

    public float speed = 0.2f;

    
	void Start () {
    }
	
	void Update () {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
