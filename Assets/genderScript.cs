//Script for selecting gender
//also added the script for dialogue prompts for new gamers

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genderScript : MonoBehaviour
{
    //Declare Variable
    public GameObject Girl;
    public GameObject Boy;
    public GameObject Intro;
    public GameObject Intro_Garden;
    public GameObject Intro_Backyard;
    // Start is called before the first frame update
    void Start()
    {
        //Getting the saved data from PlayerPrefs
        int gender = PlayerPrefs.GetInt("Gender");
        int newgameOut = PlayerPrefs.GetInt("NewGameOutside");
        int newgameBack = PlayerPrefs.GetInt("NewGameBackyard");
        int newgameGarden = PlayerPrefs.GetInt("NewGameGarden");

        //When PlayerPrefs have the gender set to 0, the Character will be a guy
        //Else, the gender will be a girl
        if(gender == 0){
            Girl.SetActive(false);
        }
        else if(gender == 1){
            Boy.SetActive(false);
        }

        //When the NewGameOutside is 0, this means that the
        //Dialogue will not prompt
        //But it is 1, the Dialogue will prompt,
        //Meaning 1 is equal to New Game clickers
        if(newgameOut == 0){
            Intro.SetActive(false);
        } 
        else if(newgameOut == 1){
            Intro.SetActive(true);
        }

        //Same with this from the previous comment.
        //the only difference is that the player can press
        //continue and still get the dialogue if the player
        //wasn't able to get the dialogue the first time.
        //which is possible if the player didn't go to the backyard
        //the first time they played
        if(newgameBack == 0){
            Intro_Backyard.SetActive(false);
        }
        else if(newgameBack == 1){
            Intro_Backyard.SetActive(true);
        }

        //Also here but garden
        if(newgameGarden == 0){
            Intro_Garden.SetActive(false);
        }
        else if(newgameGarden == 1){
            Intro_Garden.SetActive(true);
        }

    }
}
