using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RetainCoints : MonoBehaviour
{
    GameObject Money1;
    // Start is called before the first frame update
    //this script is to retain the coins when changing from scene to scene
    //using PlayerPrefs
    void Awake()
    {
        Money1 = GameObject.FindWithTag("Money");
        if(PlayerPrefs.HasKey("Money")){
            PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")+PlayerPrefs.GetFloat("TrashMoney"));
            Money1.GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetFloat("Money").ToString();
        }
        else{
            Money1.GetComponent<TMPro.TextMeshProUGUI>().text = 50.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
