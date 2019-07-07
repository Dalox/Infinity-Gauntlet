using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Cursor_Controler : MonoBehaviour {

    public float speed;
    public GameObject tree;
    private SerialPort port;

    // Use this for initialization
    void Start () {
        port = new SerialPort("COM9", 115200);
        port.Open();
        Debug.Log(port);
    }
	
	// Update is called once per frame
	void Update ()
    {
        MPU_Move();
        //Mouse_Move();
    }

    void MPU_Move()
    {
        Vector3 vect;
        string value = port.ReadLine();
        string[] valVec = value.Split(';');
        vect = new Vector3(float.Parse(valVec[0]), float.Parse(valVec[1]), float.Parse(valVec[2]));
        Debug.Log("Vector Recibido: " + value);
        transform.Translate(new Vector3(0, vect.y, vect.z) * speed);
        transform.RotateAround(tree.transform.position, Vector3.up, vect.x * Time.deltaTime * speed);
    }

    void Mouse_Move()
    {
        float moveVer = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, Input.GetAxis("Mouse Y"), moveVer) * speed/speed);
        transform.RotateAround(tree.transform.position, Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * speed);
    }
    
}
