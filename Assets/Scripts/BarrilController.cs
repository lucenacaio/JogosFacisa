using UnityEngine;
using System.Collections;

public class BarrilController : MonoBehaviour {

    public Vector3 speed;
    private bool direita = false;


    // Use this for initialization
    void Start () {
        speed = new Vector3((float)0.1, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed);
    }

    void OnCollisionEnter(Collision col)
    {
        if (!direita && col.gameObject.tag == "colliderEsquerda")
        {
            speed = new Vector3((float)0.1, 0, 0);
            transform.Translate(speed);
            direita = true;
            Debug.Log("Aqui");
        }
        else {
            speed = new Vector3((float)-0.1, 0, 0);
            transform.Translate(speed);
            direita = false;
        }
        if (col.gameObject.tag == "colliderFim") {
            Destroy(gameObject);
        }
    }
}
