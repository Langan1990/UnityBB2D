using UnityEngine;
using System.Collections;

public class ballMove : MonoBehaviour {
    public static bool ballIsActive;
    public  Vector2 ballPosition;
    private Vector2 ballInitialForce;

    public GameObject player;


    // Use this for initialization
    void Start () {

        // create the force
        ballInitialForce = new Vector2(100.0f, 300.0f);

        // set to inactive
        ballIsActive = false;

        // ball position
        ballPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // check if is the first play
            if (!ballIsActive)
            {
                // add a force
               // GetComponent<Rigidbody>().AddForce(ballInitialForce);
                GetComponent<Rigidbody2D>().AddForce(ballInitialForce);
                // set ball active
                ballIsActive = !ballIsActive;
            }
        }
        if (!ballIsActive && player != null)
        {
            // get and use the player position
            ballPosition.x = player.transform.position.x;

            // apply player X position to the ball
            player.transform.position = ballPosition;
        }

    }

    /*
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Block")
        {
            Debug.Log("Hit block");
            //score++;
         //  GetComponent<Rigidbody2D>().AddRelativeForce(ballPosition.x, ballPosition.y);
            Destroy(other.gameObject);
        }
    }
    */
}
