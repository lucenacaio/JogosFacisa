using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {


	public KeyCode direita;
	public KeyCode esquerda;
	public KeyCode espaco;

    public Vector3 speed;

    public Rigidbody avatar;
	public GameObject objetos;

	public float velocidade;

	private bool indoEsquerda;
	private bool indoDireita;


	private bool pulando;
	public Vector3 jumpForce;

	// Use this for initialization
	void Start () {
        avatar = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (direita)) {
			indoDireita = true;
		} else {
			indoDireita = false;
		}

		if (Input.GetKey (esquerda)) {
			indoEsquerda = true;
		} else {
			indoEsquerda = false;
		}// End if

		if (Input.GetKey (espaco)) {
			pulando = true;
		} else {
			pulando = false;
		}

	}

	void FixedUpdate(){

		if (indoDireita) {
			avatar.velocity = new Vector2 (velocidade,0);
		} else if (indoEsquerda) {
			avatar.velocity = new Vector2 (-velocidade,0);
		} else if(pulando) {
			avatar.useGravity = true;

			avatar.AddForce(jumpForce,ForceMode.Force);
		}//End if
		else {
			avatar.velocity = new Vector2 (0, 0);
		}//End if

	}

}
