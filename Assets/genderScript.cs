using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genderScript : MonoBehaviour
{
    public GameObject Girl;
    public GameObject Boy;
    public GameObject Intro;
    public GameObject Intro_Garden;
    public GameObject Intro_Backyard;
    // Start is called before the first frame update
    void Start()
    {
        int gender = PlayerPrefs.GetInt("Gender");
        int newgameOut = PlayerPrefs.GetInt("NewGameOutside");
        int newgameBack = PlayerPrefs.GetInt("NewGameBackyard");
        int newgameGarden = PlayerPrefs.GetInt("NewGameGarden");

        if(gender == 0){
            Girl.SetActive(false);
        }
        else if(gender == 1){
            Boy.SetActive(false);
        }

        if(newgameOut == 0){
            Intro.SetActive(false);
        } 
        else if(newgameOut == 1){
            Intro.SetActive(true);
        }

        if(newgameBack == 0){
            Intro_Backyard.SetActive(false);
        }
        else if(newgameBack == 1){
            Intro_Backyard.SetActive(true);
        }

        if(newgameGarden == 0){
            Intro_Garden.SetActive(false);
        }
        else if(newgameGarden == 1){
            Intro_Garden.SetActive(true);
        }

        Debug.Log(newgameGarden);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
