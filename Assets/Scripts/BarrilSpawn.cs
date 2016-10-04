using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BarrilSpawn : MonoBehaviour {
    public GameObject barrilPreFab;

    public Vector3 speed;

    public Vector3 offset;
    public float coolDown = 2;
    public float accel = 1;
    public float forca;
    private bool stop = false;

    IEnumerator Spawn()
    {
        while (!stop)
        {
            Vector3 position = new Vector3(10, 5, 0);

            GameObject barril = (GameObject)Instantiate(barrilPreFab, position, Quaternion.identity);
            


            yield return new WaitForSeconds(coolDown);
        }
    }


    void Stop()
    {
        stop = true;
    }

    // Use this for initialization
    void Start()
    {

        StartCoroutine(Spawn());

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
