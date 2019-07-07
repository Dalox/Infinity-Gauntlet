using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Orbit : MonoBehaviour {

    public GameObject player;
    public float speed;
    public float s_Speed;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
        //MoveAround();
	}

    void MoveAround()
    {
        //transform.RotateAround(player.transform.position, Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * speed);
        //transform.Rotate(Vector3.up,);
        transform.Translate(new Vector3(0,Input.GetAxis("Mouse Y"),0));
        transform.Translate(new Vector3(0,0, Input.GetAxis("Vertical"))* s_Speed);
    }
}
