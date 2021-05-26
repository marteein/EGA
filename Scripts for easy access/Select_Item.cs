using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//This script is for buying from the backyard
public class Select_Item : MonoBehaviour
{
    public TMPro.TMP_Text price;
    public GameObject item_in_menu;
    public GameObject item_in_game;
    public TMPro.TMP_Text money;
    public Transform parentOf;
    public GameObject noMoney_Prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        //this is to get the product type of the buttons and the parent of the buttons
        var prodType = transform.parent.parent.parent;
        var directParent = transform.parent;

        //to add listener to button when pressed. function below.
        this.gameObject.GetComponent<Button>().onClick.AddListener(pressedBuy);

        //this for loop is to get the bought product and check if they're placed or select
        //if placed, all the other sibling from the same parent will set their active status to false
        //and only the gameobject will remain
        for(int j=0; j<directParent.childCount;j++){
            if(PlayerPrefs.HasKey(prodType+j.ToString())){
                switch(PlayerPrefs.GetInt(prodType+j.ToString())){
                    case 1:
                        directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                        break;
                    case 2:
                        directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Placed";
                        for (int i=0; i<parentOf.childCount; i++){
                            parentOf.GetChild(i).gameObject.SetActive(false);
                        }
                        parentOf.GetChild(j+1).gameObject.SetActive(true);
                        break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //this will set the money of the player from the Prefs
        PlayerPrefs.SetFloat("Money",float.Parse(money.GetComponent<TMPro.TextMeshProUGUI>().text));

        var prodType = transform.parent.parent.parent;
        var directParent = transform.parent;

        //check if the label is placed or select. store 2 in prefs if placed, 1 for select and 0 for none.
        for(int j=0; j<directParent.childCount;j++){
            if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                PlayerPrefs.SetInt(prodType+j.ToString(), 2);
            }
            else if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Select"){
                PlayerPrefs.SetInt(prodType+j.ToString(), 1);
            }
            else{
                PlayerPrefs.SetInt(prodType+j.ToString(), 0);
            }
        }
    }

    //this function will reduce money and set the bought object's status to active.
    public void pressedBuy(){
        var prodType = transform.parent.parent.parent;
        var directParent = transform.parent;

        //Bush Buy Function
        if(prodType.name == "BushMenu"){
            if(price.text == "Select"){
                for (int j=0; j<parentOf.childCount; j++){
                    parentOf.GetChild(j).gameObject.SetActive(false);
                }
                item_in_game.SetActive(true);
                for(int j=0; j<directParent.childCount;j++){
                    if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                        directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                    }
                }
                price.text = "Placed";
            }
            
            else if(price.text != "Placed" && price.text != "Select"){
                if((float.Parse(money.text))>=500){
                    money.text = (float.Parse(money.text)-500).ToString();
                    for (int j=0; j<parentOf.childCount; j++){
                        parentOf.GetChild(j).gameObject.SetActive(false);
                    }
                    item_in_game.SetActive(true);
                    for(int j=0; j<directParent.childCount;j++){
                        if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                            directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                        }
                    }
                    price.text = "Placed";
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = prodType.transform;
                    Destroy(poor, 1f);
                }
            }
        }

        //Gazebo Buy Function
        if(prodType.name == "GazeboMenu"){
            if(price.text == "Select"){
                for (int j=0; j<parentOf.childCount; j++){
                    parentOf.GetChild(j).gameObject.SetActive(false);
                }
                item_in_game.SetActive(true);
                for(int j=0; j<directParent.childCount;j++){
                    if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                        directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                    }
                }
                price.text = "Placed";
            }
            
            else if(price.text != "Placed" && price.text != "Select"){
                if((float.Parse(money.text))>=5000){
                    money.text = (float.Parse(money.text)-5000).ToString();
                    for (int j=0; j<parentOf.childCount; j++){
                        parentOf.GetChild(j).gameObject.SetActive(false);
                    }
                    item_in_game.SetActive(true);
                    for(int j=0; j<directParent.childCount;j++){
                        if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                            directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                        }
                    }
                    price.text = "Placed";
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = prodType.transform;
                    Destroy(poor, 1f);
                }
            }
        }

        //Fountain Buy Function
        if(prodType.name == "FountainMenu"){
            if(price.text == "Select"){
                for (int j=0; j<parentOf.childCount; j++){
                    parentOf.GetChild(j).gameObject.SetActive(false);
                }
                item_in_game.SetActive(true);
                for(int j=0; j<directParent.childCount;j++){
                    if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                        directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                    }
                }
                price.text = "Placed";
            }
            
            else if(price.text != "Placed" && price.text != "Select"){
                if((float.Parse(money.text))>=15000){
                    money.text = (float.Parse(money.text)-15000).ToString();
                    for (int j=0; j<parentOf.childCount; j++){
                        parentOf.GetChild(j).gameObject.SetActive(false);
                    }
                    item_in_game.SetActive(true);
                    for(int j=0; j<directParent.childCount;j++){
                        if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                            directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                        }
                    }
                    price.text = "Placed";
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = prodType.transform;
                    Destroy(poor, 1f);
                }
            }
        }

        //Animal Buy Function
        if(prodType.name == "AnimalMenu"){
            if(price.text == "Select"){
                for (int j=0; j<parentOf.childCount; j++){
                    parentOf.GetChild(j).gameObject.SetActive(false);
                }
                item_in_game.SetActive(true);
                for(int j=0; j<directParent.childCount;j++){
                    if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                        directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                    }
                }
                price.text = "Placed";
            }
            
            else if(price.text != "Placed" && price.text != "Select"){
                if((float.Parse(money.text))>=50000){
                    money.text = (float.Parse(money.text)-50000).ToString();
                    for (int j=0; j<parentOf.childCount; j++){
                        parentOf.GetChild(j).gameObject.SetActive(false);
                    }
                    item_in_game.SetActive(true);
                    for(int j=0; j<directParent.childCount;j++){
                        if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                            directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                        }
                    }
                    price.text = "Placed";
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = prodType.transform;
                    Destroy(poor, 1f);
                }
            }
        }

        //Bench Buy Function
        if(prodType.name == "BenchMenu"){
            if(price.text == "Select"){
                for (int j=0; j<parentOf.childCount; j++){
                    parentOf.GetChild(j).gameObject.SetActive(false);
                }
                item_in_game.SetActive(true);
                for(int j=0; j<directParent.childCount;j++){
                    if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                        directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                    }
                }
                price.text = "Placed";
            }
            
            else if(price.text != "Placed" && price.text != "Select"){
                if((float.Parse(money.text))>=5000){
                    money.text = (float.Parse(money.text)-5000).ToString();
                    for (int j=0; j<parentOf.childCount; j++){
                        parentOf.GetChild(j).gameObject.SetActive(false);
                    }
                    item_in_game.SetActive(true);
                    for(int j=0; j<directParent.childCount;j++){
                        if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                            directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                        }
                    }
                    price.text = "Placed";
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = prodType.transform;
                    Destroy(poor, 1f);
                }
            }
        }

        //Statue Buy Function
        if(prodType.name == "StatueMenu"){
            if(price.text == "Select"){
                for (int j=0; j<parentOf.childCount; j++){
                    parentOf.GetChild(j).gameObject.SetActive(false);
                }
                item_in_game.SetActive(true);
                for(int j=0; j<directParent.childCount;j++){
                    if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                        directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                    }
                }
                price.text = "Placed";
            }
            
            else if(price.text != "Placed" && price.text != "Select"){
                if((float.Parse(money.text))>=10000){
                    money.text = (float.Parse(money.text)-10000).ToString();
                    for (int j=0; j<parentOf.childCount; j++){
                        parentOf.GetChild(j).gameObject.SetActive(false);
                    }
                    item_in_game.SetActive(true);
                    for(int j=0; j<directParent.childCount;j++){
                        if(directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text == "Placed"){
                            directParent.gameObject.transform.GetChild(j).transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Select";
                        }
                    }
                    price.text = "Placed";
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = prodType.transform;
                    Destroy(poor, 1f);
                }
            }
        }
    }
}
