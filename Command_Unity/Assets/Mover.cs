using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed = 1;
	public float jumpForce = 3;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void moverDerecha(){
		transform.Translate(transform.right * speed * Time.deltaTime);
	}

	public void moverIzquierda(){
		transform.Translate(-transform.right * speed * Time.deltaTime);
	}

	public void moverFrente(){
		transform.Translate(transform.forward * speed * Time.deltaTime);
	}

	public void moverAtras(){
		transform.Translate(-transform.forward * speed * Time.deltaTime);
	}

	public void saltar(){
		rigidbody.AddForce(transform.up * jumpForce);
	}
}
