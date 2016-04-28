using UnityEngine;
using System.Collections;

public class moveobject : MonoBehaviour {
    private float moveSpeed = 0.1f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -moveSpeed);
    }
}
