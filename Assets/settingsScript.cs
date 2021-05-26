using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class settingsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //will get the audio source
        AudioSource audioSrc = GameObject.Find("Audio Source").GetComponent<AudioSource> ();
        //check if audio source is playing. it will change the toggle image depending on the condition
        if(audioSrc.isPlaying){
            this.gameObject.GetComponent<Toggle>().isOn=true;
        }
        else{
            this.gameObject.GetComponent<Toggle>().isOn=false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //will load Setting scene
    public void loadSetting(){
        SceneManager.LoadScene("Setting", LoadSceneMode.Additive);
    }

    //will load trash scene
    public void loadTrash(){
        SceneManager.LoadScene("Trash", LoadSceneMode.Single);
    }

    //will load Outside scene
    public void loadOutside(){
        SceneManager.LoadScene("Outside", LoadSceneMode.Single);
    }

    //will load Menu Scene
    public void loadMenu(){
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    //When toggle is changed, this function will start
    public void music_off(){
        //when toggle is not set to On, the audio source will be paused. 
        //if the toggle is set to On, the audio source will play
        if(!this.gameObject.GetComponent<Toggle>().isOn){
            AudioSource audioSrc = GameObject.Find("Audio Source").GetComponent<AudioSource> ();
            audioSrc.Pause ();
        }
        else{
            AudioSource audioSrc = GameObject.Find("Audio Source").GetComponent<AudioSource> ();
            audioSrc.Play ();
        }
        
    }
}
