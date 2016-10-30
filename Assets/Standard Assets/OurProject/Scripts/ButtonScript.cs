using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour {
    AudioSource bgm;

    // Use this for initialization
    void Start () {
        AudioSource[] allAudio = GameObject.FindGameObjectWithTag("MainCamera").GetComponents<AudioSource>();
        bgm = allAudio[0];
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
        //Start Button
        if (gObject.tag == "start_button")
        {
            SceneManager.LoadScene("tutorial_level");
        }
        //Option Button
        else if(gObject.tag == "option_button")
        {
            SceneManager.LoadScene("option_scene");
        }
        //Mute Button
        else if (gObject.tag == "toggle_bgm") 
        {
            if (bgm.isPlaying)
                bgm.Pause();
            else
                bgm.UnPause();
        }
    }
}
