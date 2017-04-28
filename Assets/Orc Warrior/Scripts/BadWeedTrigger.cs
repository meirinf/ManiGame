using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BadWeedTrigger : MonoBehaviour {

	private static int count;
	public Text text;

	void OnTriggerEnter2D(Collider2D theObject){
		if(theObject.tag == "Player"){
			Destroy(gameObject);
		 	count ++;
		}
		text.text = "Puntuacion:"+ count;
	}
}
