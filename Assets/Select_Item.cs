using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
        var prodType = transform.parent.parent.parent;
        var directParent = transform.parent;
        Debug.Log(directParent);

        this.gameObject.GetComponent<Button>().onClick.AddListener(pressedBuy);
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
        PlayerPrefs.SetFloat("Money",float.Parse(money.GetComponent<TMPro.TextMeshProUGUI>().text));
        var prodType = transform.parent.parent.parent;
        var directParent = transform.parent;
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
