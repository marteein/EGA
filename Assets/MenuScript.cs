using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //This script is attached to the Menu in the "Menu" Scene

    //this function is when the continue was called. it will load the "Outside" scene
    public void ContinueGame(){
        SceneManager.LoadScene("Outside", LoadSceneMode.Single);
    }

    //This function will load when the "Boy" button is pushed
    //Will load the "Outside" Scene and will set Gender PlayerPrefs to 0
    //and all the NewGame PlayerPrefs to 1
    //because 1 will equal to new gamers
    public void NewGameBoy(){
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Outside", LoadSceneMode.Single);
        PlayerPrefs.SetInt("Gender", 0);
        PlayerPrefs.SetInt("NewGameOutside", 1);
        PlayerPrefs.SetInt("NewGameGarden", 1);
        PlayerPrefs.SetInt("NewGameBackyard", 1);
    }

    //This function will load when the "Girl" button is pushed
    //Will load the "Outside" Scene and will set Gender PlayerPrefs to 1
    //and all the NewGame PlayerPrefs to 1
    //because 1 will equal to new gamers
    public void NewGameGirl(){
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Outside", LoadSceneMode.Single);
        PlayerPrefs.SetInt("Gender", 1);
        PlayerPrefs.SetInt("NewGameOutside", 1);
        PlayerPrefs.SetInt("NewGameGarden", 1);
        PlayerPrefs.SetInt("NewGameBackyard", 1);
    }
    
    //This function is attached to the quit button and will exit the game when the button is pressed
    public void QuitGame(){
        Application.Quit();
    }

}
