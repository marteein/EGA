using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class taskComplete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i=1;i<=18;i++){
            if(!PlayerPrefs.HasKey("Task"+i)){
                PlayerPrefs.SetInt("Task"+i, 0);
            }
        }
        
        this.GetComponent<Toggle>().interactable = false;
        this.gameObject.GetComponent<Toggle>().isOn=false;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=1;i<=18;i++){
            if(this.transform.parent.gameObject.name == "Task"+i){
                if(PlayerPrefs.HasKey("Task"+i)){
                    int task1 = PlayerPrefs.GetInt("Task"+i);
                    if(task1>0){
                        this.gameObject.GetComponent<Toggle>().isOn=true;
                        this.transform.parent.transform.SetSiblingIndex(this.transform.parent.transform.parent.transform.childCount);
                    }
                    else{
                        this.gameObject.GetComponent<Toggle>().isOn=false;
                    }
                }
            }
        }
        
        
    }
}
