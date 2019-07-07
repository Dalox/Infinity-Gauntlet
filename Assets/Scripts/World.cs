using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World : MonoBehaviour {

    public string scene;
    public GameObject Gem;
    public GameObject PreGem;
    private bool preState;
    //private bool GemState;
    
	// Use this for initialization
	void Start () {
        //GemState = gem.GetComponent<Gem>().state;
        preState = PreGem.GetComponent<Gem>().state;
        /*Debug.Log(scene + " : Gemas:" + Gem.GetComponent<Gem>().state);
        Debug.Log(PreGem.GetComponent<Gem>().state);*/

    }

    private void Awake()
    {

    }

    // Update is called once per frame
    void Update ()
    {

        preState = PreGem.GetComponent<Gem>().state;

    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("To..." + scene);
        //GemState = true;
        if(preState == true)
        {
            Gem.GetComponent<Gem>().state = true;
            //Application.LoadLevel(scene);
            SceneManager.LoadSceneAsync(scene);
            //SceneManager.LoadScene(scene);
        }
        else if (preState == false)
        {
            Debug.Log("Faltan Gemas");
        }
    }
}
