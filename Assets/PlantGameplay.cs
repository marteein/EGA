using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class PlantGameplay : MonoBehaviour
{
    public GameObject PlantButton;
    public GameObject WaterButton;
    public GameObject FertilizeButton;
    public GameObject PesticideButton;
    public GameObject SellButton;
    public GameObject noMoney_Prefab;
    public GameObject coin_add_Prefab;
    public TMPro.TMP_Text SellText;
    public TMPro.TMP_Text PlantText;
    public GameObject Plant;
    public GameObject Prefab_Plant;
    [SerializeField] 
    private TMPro.TMP_Text level;
    public TMPro.TMP_Text Money;
    float timer = 0;
    bool hasPlant = false;
    
    // Start is called before the first frame update
    void Start()
    {
        PlantButton.SetActive(true);
        WaterButton.SetActive(false);
        FertilizeButton.SetActive(false);
        PesticideButton.SetActive(false);
        SellButton.SetActive(false);

        PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")+PlayerPrefs.GetFloat("TrashMoney"));
        Debug.Log(PlayerPrefs.GetFloat("TrashMoney"));

        PlantButton.GetComponent<Button>().onClick.AddListener(pressedPlant);
        WaterButton.GetComponent<Button>().onClick.AddListener(pressedWater);
        FertilizeButton.GetComponent<Button>().onClick.AddListener(pressedFertilize);
        PesticideButton.GetComponent<Button>().onClick.AddListener(pressedPesticide);
        SellButton.GetComponent<Button>().onClick.AddListener(pressedSell);

        if(PlayerPrefs.HasKey("Daffodil")||PlayerPrefs.HasKey("Globe")||PlayerPrefs.HasKey("Calla")||
        PlayerPrefs.HasKey("Crown")||PlayerPrefs.HasKey("Daisy")||PlayerPrefs.HasKey("Echinacea")||
        PlayerPrefs.HasKey("French")||PlayerPrefs.HasKey("Garden")||PlayerPrefs.HasKey("Hyacinth")||
        PlayerPrefs.HasKey("Ivy")||PlayerPrefs.HasKey("Orange")||PlayerPrefs.HasKey("Tulip")){
            hasPlant = true;
        }

        if(hasPlant){
            switch(Plant.name){
                case "Daffodil": 
                    switch(PlayerPrefs.GetInt("Daffodil")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
                case "Globe Amaranth": 
                    switch(PlayerPrefs.GetInt("Globe")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
                case "Calla Lily": 
                    switch(PlayerPrefs.GetInt("Calla")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
                case "Crown-of-thorns": 
                    switch(PlayerPrefs.GetInt("Crown")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
                case "Daisy": 
                    switch(PlayerPrefs.GetInt("Daisy")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
                case "Echinacea": 
                    switch(PlayerPrefs.GetInt("Echinacea")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
                case "French Hydrangea": 
                    switch(PlayerPrefs.GetInt("French")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
                case "Garden Tulip": 
                    switch(PlayerPrefs.GetInt("Garden")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
                case "Hyacinth": 
                    switch(PlayerPrefs.GetInt("Hyacinth")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
                case "Ivy": 
                    switch(PlayerPrefs.GetInt("Ivy")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
                case "Orange Lily": 
                    switch(PlayerPrefs.GetInt("Orange")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
                case "Tulip": 
                    switch(PlayerPrefs.GetInt("Tulip")){
                        case 0: level.text = "Buy?"; break;
                        case 1: level.text = "Small"; break;
                        case 2: level.text = "Medium"; break;
                        case 3: level.text = "Large"; break;
                        case 4: level.text = "Sell?"; break;
                    }
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update(){
        PlayerPrefs.SetFloat("TrashMoney",0);
        float money1 = int.Parse(Money.text);  
        PlayerPrefs.SetFloat("Money",money1);
        timer = timer + Time.deltaTime;
        switch(Plant.name){
            case "Daffodil": 
                PlantText.text = "Plant for 20 php";
                SellText.text = "Sell for "+(20*3).ToString()+" php";
                break;
            case "Globe Amaranth": 
                PlantText.text = "Plant for 50 php";
                SellText.text = "Sell for "+(50*2).ToString()+" php";
                break;
            case "Calla Lily": 
                PlantText.text = "Plant for 80 php";
                SellText.text = "Sell for "+(80*2).ToString()+" php";
                break;
            case "Crown-of-thorns": 
                PlantText.text = "Plant for 110 php";
                SellText.text = "Sell for "+(110*2).ToString()+" php";
                break;
            case "Daisy": 
                PlantText.text = "Plant for 200 php";
                SellText.text = "Sell for "+(200*1.8f).ToString()+" php";
                break;
            case "Echinacea": 
                PlantText.text = "Plant for 300 php";
                SellText.text = "Sell for "+(300*1.8f).ToString()+" php";
                break;
            case "French Hydrangea": 
                PlantText.text = "Plant for 500 php";
                SellText.text = "Sell for "+(500*1.8f).ToString()+" php";
                break;
            case "Garden Tulip": 
                PlantText.text = "Plant for 800 php";
                SellText.text = "Sell for "+(800*1.8f).ToString()+" php";
                break;
            case "Hyacinth": 
                PlantText.text = "Plant for 1400 php";
                SellText.text = "Sell for "+(1400*1.7f).ToString()+" php";
                break;
            case "Ivy": 
                PlantText.text = "Plant for 2350 php";
                SellText.text = "Sell for "+(2350*1.6f).ToString()+" php";
                break;
            case "Orange Lily": 
                PlantText.text = "Plant for 3700 php";
                SellText.text = "Sell for "+(3700*1.5f).ToString()+" php";
                break;
            case "Tulip": 
                PlantText.text = "Plant for 5500 php";
                SellText.text = "Sell for "+(5500*1.5f).ToString()+" php";
                break;
        }
        
        
        if(Plant.activeSelf == true || hasPlant == true){
            switch(Plant.name){
                case "Daffodil": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("Daffodil")==1){
                        Plant.SetActive(true);
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 1;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("Daffodil")==2){
                        PlayerPrefs.SetInt("Daffodil", 2);
                        Plant.SetActive(true);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 1;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("Daffodil")==3){
                        PlayerPrefs.SetInt("Daffodil", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 1;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("Daffodil")==4){
                        PlayerPrefs.SetInt("Daffodil", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 1;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    
                    break;
                case "Globe Amaranth": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("Globe")==1){
                        Plant.SetActive(true);
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 2;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("Globe")==2){
                        PlayerPrefs.SetInt("Globe", 2);
                        Plant.SetActive(true);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 2;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("Globe")==3){
                        PlayerPrefs.SetInt("Globe", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 2;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("Globe")==4){
                        PlayerPrefs.SetInt("Globe", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 2;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    break;
                case "Calla Lily": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("Calla")==1){
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        Plant.SetActive(true);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 3;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("Calla")==2){
                        PlayerPrefs.SetInt("Calla", 2);
                        Plant.SetActive(true);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 3;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("Calla")==3){
                        PlayerPrefs.SetInt("Calla", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 3;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("Calla")==4){
                        PlayerPrefs.SetInt("Calla", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 3;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    break;
                case "Crown-of-thorns": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("Crown")==1){
                        Plant.SetActive(true);
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 4;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("Crown")==2){
                        PlayerPrefs.SetInt("Crown", 2);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        Plant.SetActive(true);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 4;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("Crown")==3){
                        PlayerPrefs.SetInt("Crown", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 4;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("Crown")==4){
                        PlayerPrefs.SetInt("Crown", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 4;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    break;
                case "Daisy": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("Daisy")==1){
                        Plant.SetActive(true);
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 5;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("Daisy")==2){
                        PlayerPrefs.SetInt("Daisy", 2);
                        Plant.SetActive(true);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 5;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("Daisy")==3){
                        PlayerPrefs.SetInt("Daisy", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 5;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("Daisy")==4){
                        PlayerPrefs.SetInt("Daisy", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 5;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    break;
                case "Echinacea": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("Echinacea")==1){
                        Plant.SetActive(true);
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 6;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("Echinacea")==2){
                        PlayerPrefs.SetInt("Echinacea", 2);
                        Plant.SetActive(true);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 6;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("Echinacea")==3){
                        PlayerPrefs.SetInt("Echinacea", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 6;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("Echinacea")==4){
                        PlayerPrefs.SetInt("Echinacea", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 6;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    break;
                case "French Hydrangea": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("French")==1){
                        Plant.SetActive(true);
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 7;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("French")==2){
                        PlayerPrefs.SetInt("French", 2);
                        Plant.SetActive(true);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 7;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("French")==3){
                        PlayerPrefs.SetInt("French", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 7;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("French")==4){
                        PlayerPrefs.SetInt("French", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 7;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    break;
                case "Garden Tulip": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("Garden")==1){
                        Plant.SetActive(true);
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 8;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("Garden")==2){
                        PlayerPrefs.SetInt("Garden", 2);
                        Plant.SetActive(true);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 8;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("Garden")==3){
                        PlayerPrefs.SetInt("Garden", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 8;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("Garden")==4){
                        PlayerPrefs.SetInt("Garden", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 8;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    break;
                case "Hyacinth": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("Hyacinth")==1){
                        Plant.SetActive(true);
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 9;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("Hyacinth")==2){
                        PlayerPrefs.SetInt("Hyacinth", 2);
                        Plant.SetActive(true);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 9;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("Hyacinth")==3){
                        PlayerPrefs.SetInt("Hyacinth", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 9;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("Hyacinth")==4){
                        PlayerPrefs.SetInt("Hyacinth", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 9;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    break;
                case "Ivy": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("Ivy")==1){
                        Plant.SetActive(true);
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 10;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("Ivy")==2){
                        PlayerPrefs.SetInt("Ivy", 2);
                        Plant.SetActive(true);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 10;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("Ivy")==3){
                        PlayerPrefs.SetInt("Ivy", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 10;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("Ivy")==4){
                        PlayerPrefs.SetInt("Ivy", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 10;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    break;
                case "Orange Lily": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("Orange")==1){
                        Plant.SetActive(true);
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 12;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("Orange")==2){
                        PlayerPrefs.SetInt("Orange", 2);
                        Plant.SetActive(true);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 12;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("Orange")==3){
                        PlayerPrefs.SetInt("Orange", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 12;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("Orange")==4){
                        PlayerPrefs.SetInt("Orange", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 12;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    break;
                case "Tulip": 
                    if(level.text == "Small" || PlayerPrefs.GetInt("Tulip")==1){
                        Plant.SetActive(true);
                        WaterButton.SetActive(true);
                        PlantButton.SetActive(false);
                        if(timer>=2){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 15;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Medium" || PlayerPrefs.GetInt("Tulip")==2){
                        PlayerPrefs.SetInt("Tulip", 2);
                        Plant.SetActive(true);
                        FertilizeButton.SetActive(true);
                        WaterButton.SetActive(false);
                        if(timer>=1.5f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 15;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Large" || PlayerPrefs.GetInt("Tulip")==3){
                        PlayerPrefs.SetInt("Tulip", 3);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(true);
                        FertilizeButton.SetActive(false);
                        if(timer>=1){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 15;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    if(level.text == "Sell?" || PlayerPrefs.GetInt("Tulip")==4){
                        PlayerPrefs.SetInt("Tulip", 4);
                        Plant.SetActive(true);
                        PesticideButton.SetActive(false);
                        SellButton.SetActive(true);
                        if(timer>=0.8f){
                            GameObject add_coin = Instantiate(coin_add_Prefab, Plant.transform.position , Quaternion.identity) as GameObject;
                            add_coin.transform.parent = Plant.transform;
                            Destroy(add_coin, 1f);
                            money1 = money1 + 15;
                            Money.text = money1.ToString();
                            timer=0;
                        }
                    }
                    break;
            }
        }
        if(Plant.activeSelf == true){
            PlantButton.SetActive(false);
        }
    }

    public void pressedPlant(){
        int money1 = int.Parse(Money.text);
        switch (Plant.name){
            case "Daffodil": 
                if(money1>=20){
                    money1 = money1-20;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("Daffodil", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
            case "Globe Amaranth": 
                if(money1>=50){
                    money1 = money1-50;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("Globe", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
            case "Calla Lily": 
                if(money1>=80){
                    money1 = money1-80;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("Calla", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
            case "Crown-of-thorns": 
                if(money1>=110){
                    money1 = money1-110;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("Crown", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
            case "Daisy": 
                if(money1>=200){
                    money1 = money1-200;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("Daisy", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
            case "Echinacea": 
                if(money1>=300){
                    money1 = money1-300;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("Echinacea", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
            case "French Hydrangea": 
                if(money1>=500){
                    money1 = money1-500;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("French", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
            case "Garden Tulip": 
                if(money1>=800){
                    money1 = money1-800;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("Garden", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
            case "Hyacinth": 
                if(money1>=1400){
                    money1 = money1-1400;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("Hyacinth", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
            case "Ivy": 
                if(money1>=2350){
                    money1 = money1-2350;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("Ivy", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
            case "Orange Lily": 
                if(money1>=3700){
                    money1 = money1-3700;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("Orange", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
            case "Tulip": 
                if(money1>=5500){
                    money1 = money1-5500;
                    Plant.SetActive(true);
                    WaterButton.SetActive(true);
                    PlantButton.SetActive(false);
                    level.text = "Small";
                    PlayerPrefs.SetInt("Tulip", 1);
                }
                else{
                    GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
                    poor.transform.parent = PlantButton.transform;
                    Destroy(poor, 1f);
                }
                break;
        }
        
        Money.text = money1.ToString();
        
    }

    public void pressedWater(){ 
        int money1 = int.Parse(Money.text);
        if(money1>=10){
            money1 = money1-10;
            FertilizeButton.SetActive(true);
            WaterButton.SetActive(false);
            level.text = "Medium";
        }
        else{
            GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
            poor.transform.parent = WaterButton.transform;
            Destroy(poor, 1f);
        }
        Money.text = money1.ToString();
    }

    public void pressedFertilize(){
        int money1 = int.Parse(Money.text);
        if(money1>=10){
            money1 = money1-10;
            PesticideButton.SetActive(true);
            FertilizeButton.SetActive(false);
            level.text = "Large";
        }
        else{
            GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
            poor.transform.parent = FertilizeButton.transform;
            Destroy(poor, 1f);
        }
        Money.text = money1.ToString();
    }

    public void pressedPesticide(){
        int money1 = int.Parse(Money.text);
        if(money1>=10){
            money1 = money1-10;
            PesticideButton.SetActive(false);
            SellButton.SetActive(true);
            level.text = "Sell?";
        }
        else{
            GameObject poor = Instantiate(noMoney_Prefab, new Vector3(150, -350, 0), Quaternion.identity) as GameObject;
            poor.transform.parent = PesticideButton.transform;
            Destroy(poor, 1f);
        }
        Money.text = money1.ToString();
    }

    public void pressedSell(){
        SellButton.SetActive(false);
        PlantButton.SetActive(true);
        level.text = "Buy?";
        float money1 = float.Parse(Money.text);
        switch (Plant.name){
            case "Daffodil": 
                money1 = money1+(20*3);
                PlayerPrefs.SetInt("Daffodil", 0);
                break;
            case "Globe Amaranth": 
                money1 = money1+(50*2);
                PlayerPrefs.SetInt("Globe", 0);
                break;
            case "Calla Lily": 
                money1 = money1+(80*2);
                PlayerPrefs.SetInt("Calla", 0);
                break;
            case "Crown-of-thorns": 
                money1 = money1+(110*2);
                PlayerPrefs.SetInt("Crown", 0);
                break;
            case "Daisy": 
                money1 = money1+(200*1.8f);
                PlayerPrefs.SetInt("Daisy", 0);
                break;
            case "Echinacea": 
                money1 = money1+(300*1.8f);
                PlayerPrefs.SetInt("Echinacea", 0);
                break;
            case "French Hydrangea": 
                money1 = money1+(500*1.8f);
                PlayerPrefs.SetInt("French", 0);
                break;
            case "Garden Tulip": 
                money1 = money1+(800*1.8f);
                PlayerPrefs.SetInt("Garden", 0);
                break;
            case "Hyacinth": 
                money1 = money1+(1400*1.7f);
                PlayerPrefs.SetInt("Hyacinth", 0);
                break;
            case "Ivy": 
                money1 = money1+(2350*1.6f);
                PlayerPrefs.SetInt("Ivy", 0);
                break;
            case "Orange Lily": 
                money1 = money1+(3700*1.5f);
                PlayerPrefs.SetInt("Orange", 0);
                break;
            case "Tulip": 
                money1 = money1+(5500*1.5f);
                PlayerPrefs.SetInt("Tulip", 0);
                break;
        }
        Money.text = money1.ToString();
        Plant.SetActive(false);
    }

    public void spawnPlant(){

    }


}
