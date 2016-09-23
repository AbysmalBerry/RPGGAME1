using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {
       

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnMouseUp()
    {
        buttonClicked(gameObject);
    }

    void buttonClicked(GameObject gObject)
    {
        if (gObject.tag == "start_button")
        {
            SceneManager.LoadScene("tutorial_level");
        }
        else if(gObject.tag == "option_button")
        {
            SceneManager.LoadScene("option_scene");
        }
    }
}
