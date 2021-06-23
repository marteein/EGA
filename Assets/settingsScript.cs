using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class settingsScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    void Start()
    {
        AudioSource audioSrc = GameObject.Find("Audio Source").GetComponent<AudioSource> ();
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

    public void loadSetting(){
        SceneManager.LoadScene("Setting", LoadSceneMode.Additive);
    }

    public void loadTrash(){
        SceneManager.LoadScene("Trash", LoadSceneMode.Single);
    }

    public void loadOutside(){
        SceneManager.LoadScene("Outside", LoadSceneMode.Single);
    }

    public void loadMenu(){
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void music_off(){
        if(!this.gameObject.GetComponent<Toggle>().isOn){
            AudioSource audioSrc = GameObject.Find("Audio Source").GetComponent<AudioSource> ();
            audioSrc.Pause ();
        }
        else{
            AudioSource audioSrc = GameObject.Find("Audio Source").GetComponent<AudioSource> ();
            audioSrc.Play ();
        }
        
    }

    public void openHelp(){
        panel.gameObject.SetActive(true);
    }

    public void closeHelp(){
        panel.gameObject.SetActive(false);
    }
}
