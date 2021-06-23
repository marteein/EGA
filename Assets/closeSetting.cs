using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class closeSetting : MonoBehaviour
{
    public void closeSettings(){
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
