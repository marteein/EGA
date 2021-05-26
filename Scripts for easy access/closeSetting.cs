using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class closeSetting : MonoBehaviour
{
    //Used in button to Close the "Setting" Scene
    public void closeSettings(){
        //"Setting" Scene is loaded 'Additively' meaning it will load with the currently loaded scene.
        //This part is for checking the scene that is loaded with the "Setting" scene.
        //The loaded scene will then be called again to close the "Setting" scene.
        if(SceneManager.GetSceneByName("Menu").isLoaded){
            SceneManager.LoadScene("Menu");
        }
        else if(SceneManager.GetSceneByName("Outside").isLoaded){
            SceneManager.LoadScene("Outside", LoadSceneMode.Single);
        }
        else if(SceneManager.GetSceneByName("Garden").isLoaded){
            SceneManager.LoadScene("Garden", LoadSceneMode.Single);
        }
        else if(SceneManager.GetSceneByName("Backyard").isLoaded){
            SceneManager.LoadScene("Backyard", LoadSceneMode.Single);
        }
    }

}
