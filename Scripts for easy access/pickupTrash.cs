using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//This is connected to the player Object
//This function will record the money gathered when picking up trash
public class pickupTrash : MonoBehaviour
{
    // Start is called before the first frame update

    //this object is connected to the money ui to check the 
    //money gathered
    public TMPro.TMP_Text Money;
    void Start()
    {
        //this line will check if TrashMoney Prefs is null and will create a Pref iF it is  
        if(!PlayerPrefs.HasKey("TrashMoney")){
            PlayerPrefs.SetFloat("TrashMoney",0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //This line will display the money gathered which is the data fetched from the Prefs
        Money.text = "Money: "+PlayerPrefs.GetFloat("TrashMoney").ToString();
    }


    //this function will detect collision between the player and the Trash
    //If the object that the player collided has a tag "Trash", it will be destroyed
    //it will also add 10 to the TrashMoney Prefs
    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Trash"){
            Destroy(col.gameObject);
            PlayerPrefs.SetFloat("TrashMoney", PlayerPrefs.GetFloat("TrashMoney") + 10);
        }
    }
}
