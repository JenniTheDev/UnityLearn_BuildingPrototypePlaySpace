using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootable : MonoBehaviour {

    public int minSwingsNeeded = 2;
    public int maxSwingsNeeded = 6;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void Loot(int digSwings) {
        Instantiate(Resources.Load("DirtEffect"), transform.position, transform.rotation);
        if (digSwings > Random.Range(minSwingsNeeded, maxSwingsNeeded)) {
            Instantiate(Resources.Load("Chest"), transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    /*
	public void Loot(int digSwings)
	{
		if(digSwings > Random.Range(0,4)){
			Destroy (gameObject);
			Instantiate (Resources.Load ("Chest"), transform.position, transform.rotation);
		}
	}
	*/
}
