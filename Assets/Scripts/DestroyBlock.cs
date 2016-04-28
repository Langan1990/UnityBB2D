using UnityEngine;
using System.Collections;

public class DestroyBlock : MonoBehaviour {


    public Rigidbody2D ball;

	// Use this for initialization
	void Start () {
        ball = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Debug.Log("Hit block");
           
            //score++;
            Destroy(gameObject);
        }
    }

}
