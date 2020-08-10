using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelPowerup : MonoBehaviour {

	private GameObject popupText;

	// Use this for initialization
	void Start () {
		popupText = GameObject.FindGameObjectWithTag ("Boost");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		popupText.GetComponent<RectTransform>().position = Camera.main.WorldToScreenPoint (GameObject.FindGameObjectWithTag ("HeroHead").transform.position);
		popupText.GetComponent<AudioSource> ().Play ();
		popupText.GetComponent<Animator> ().SetTrigger ("Popup");
		if (other.tag == "Player") {
			other.GetComponent<HeroController> ().baseDigSwings = 6;
			Destroy (gameObject);
		}
	}
}
