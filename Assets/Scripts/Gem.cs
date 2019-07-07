using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public Material mtr;
    public bool state;

    private void Awake()
    {
        Debug.Log(gameObject.GetComponent<Gem>());
        //DontDestroyOnLoad(gameObject.GetComponent<Gem>());
        DontDestroyOnLoad(gameObject);

        if (state == true)
        {
            gameObject.GetComponent<Renderer>().sharedMaterial = mtr;
        }

    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (state == true)
        {
            gameObject.GetComponent<Renderer>().sharedMaterial = mtr;
        }
    }
}
