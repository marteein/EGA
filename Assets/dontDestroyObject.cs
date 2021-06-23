using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroyObject : MonoBehaviour
{
    public static dontDestroyObject control;
    // Start is called before the first frame update
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
