using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
			Destroy (gameObject);
	}

}
