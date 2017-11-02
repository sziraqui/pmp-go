using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchPokemon : MonoBehaviour {

	public GameObject prefab;
	void Start () {
		prefab = Resources.Load ("PokeBall") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject pokeball = Instantiate (prefab) as GameObject;
			pokeball.transform.position = transform.position + Camera.main.transform.forward * 2;
			Rigidbody rigidBody = pokeball.GetComponent<Rigidbody> ();
			rigidBody.velocity = Camera.main.transform.forward * 40;
		}
	}
}
