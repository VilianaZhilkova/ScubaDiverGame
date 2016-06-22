using UnityEngine;
using System.Collections;
using Assets.Scripts.Interfaces;

public class Trigger : MonoBehaviour, IGameObject {

    private BoxCollider2D boxColl;
    private bool isTriggered;

	public void Start () {
        this.boxColl = GetComponent<BoxCollider2D>();
	}

    public void Update()
    {

    }
    public void FixedUpdate()
    {

    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        var go = collider.gameObject;
        var ogirinalPossition = go.transform.position;

        ogirinalPossition.x
            += 3 * 35;

        go.transform.position = ogirinalPossition;
    }
}
