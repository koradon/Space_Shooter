using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {
	public float tumble;

	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		if (tumble == 0) {
			tumble = Random.Range (0.1f, 6f);
		}
		rb.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
