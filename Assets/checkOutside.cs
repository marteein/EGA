using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkOutside : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("WaterItem",0);
        for(int i=0;i<this.transform.GetChild(0).transform.childCount;i++){
            if(!PlayerPrefs.HasKey(this.transform.GetChild(0).transform.GetChild(i).gameObject.name)){
                this.transform.GetChild(0).GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<this.transform.GetChild(0).transform.childCount;i++){
            if(this.transform.GetChild(0).GetChild(i).transform.childCount>1){
                if(PlayerPrefs.GetInt(this.transform.GetChild(0).transform.GetChild(i).gameObject.name)>0){
                    this.transform.GetChild(0).GetChild(i).GetChild(1).GetComponent<Text>().text = PlayerPrefs.GetInt(this.transform.GetChild(0).transform.GetChild(i).gameObject.name).ToString();
                }
                else{
                    this.transform.GetChild(0).GetChild(i).gameObject.SetActive(false);
                }
            }
        }
    }
}
