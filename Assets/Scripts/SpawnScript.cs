using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    public GameObject[] obj;
    public float spawnMin = 1f;
    public float spawnMax = 2f;

    public ballMove ballIsActive;
	// Use this for initialization
	void Start () {
        Spawn();
    }
	
    void Spawn()
    {
        
            // check if is the first play
            if (!ballIsActive)
            {
                 Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
            }
        
      
    }

	// Update is called once per frame
	void Update () {
        
    }
}
