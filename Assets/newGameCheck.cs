using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newGameCheck : MonoBehaviour
{

    // Update is called once per frame

    //This will set the NewGameOutside prefs to 0 
    void Update()
    {
        PlayerPrefs.SetInt("NewGameOutside", 0);
    }
}
