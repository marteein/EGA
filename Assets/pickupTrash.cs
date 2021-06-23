using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pickupTrash : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TMP_Text Money;
    void Start()
    {
        if(!PlayerPrefs.HasKey("TrashMoney")){
            PlayerPrefs.SetFloat("TrashMoney",0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Money.text = "Money: "+PlayerPrefs.GetFloat("TrashMoney").ToString();
    }

    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Trash"){
            Destroy(col.gameObject);
            PlayerPrefs.SetFloat("TrashMoney", PlayerPrefs.GetFloat("TrashMoney") + 10);
            Debug.Log(PlayerPrefs.GetFloat("TrashMoney"));
            PlayerPrefs.SetInt("Task1", 1);
        }
    }
}
