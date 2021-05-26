using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroyObject : MonoBehaviour
{
    public static dontDestroyObject control;
    // Start is called before the first frame update
    //This script was created so that gameobjects within the current 
    //scene will not be destroyed when another scene is loaded.

    //Currently not being used by any gameObjects
    void Awake()
    {
        if(control == null){
            DontDestroyOnLoad(gameObject);
            control=this;
        }
        else if(control != this){
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
