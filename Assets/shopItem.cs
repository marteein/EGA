using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopItem : MonoBehaviour
{
    public GameObject panel;
    public Text Amount;
    public GameObject panelOfFertAndPest;

    void Awake(){
        int amountPlant = 0;
        // PlayerPrefs.SetFloat("Money", 10000);
        if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
            amountPlant = PlayerPrefs.GetInt(this.gameObject.name+"Item");
        }
        else{
            amountPlant = 0;
        }
        Amount.text = "Owned: "+amountPlant;
        
    }

    void Update(){
        if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
            Amount.text = "Owned: "+PlayerPrefs.GetInt(this.gameObject.name+"Item");
        }
        else{
            Amount.text = "Owned: "+PlayerPrefs.GetInt(this.gameObject.name+"Amount");
        }
        if(PlayerPrefs.HasKey("SickleItem")){
            if(PlayerPrefs.GetInt("SickleItem")>=1 && this.gameObject.name == "Sickle"){
                this.gameObject.GetComponent<Button>().interactable = false;
                panelOfFertAndPest.gameObject.SetActive(false);
            }
        }

        if(PlayerPrefs.HasKey("ShovelItem")){
            if(PlayerPrefs.GetInt("ShovelItem")>=1 && this.gameObject.name == "Shovel"){
                this.gameObject.GetComponent<Button>().interactable = false;
                panelOfFertAndPest.gameObject.SetActive(false);
            }
        }
    }

    public void OpenMenu(){
        panel.SetActive(true);
        panel.transform.parent = this.transform.parent.transform.parent.transform.parent;
        this.GetComponent<Button>().interactable = false;

    }
    public void CloseMenu(){
        panel.SetActive(false);
        panel.transform.parent = this.transform;
        this.GetComponent<Button>().interactable = true;
    }

    public void BuyFertilizer(){
        if(PlayerPrefs.GetFloat("Money")>=10){
            PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-10);
            if(PlayerPrefs.HasKey("FertilizerAmount")){
                PlayerPrefs.SetInt("FertilizerAmount",  PlayerPrefs.GetInt("FertilizerAmount")+1);
            }
            else{
                PlayerPrefs.SetInt("FertilizerAmount",  1);
            }
        }
    }

    public void BuyPesticide(){
        if(PlayerPrefs.GetFloat("Money")>=20){
            PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-20);
            if(PlayerPrefs.HasKey("PesticideAmount")){
                PlayerPrefs.SetInt("PesticideAmount",  PlayerPrefs.GetInt("PesticideAmount")+1);
            }
            else{
                PlayerPrefs.SetInt("PesticideAmount",  1);
            }
        }
    }

    public void BuyItem(){
        if(this.gameObject.name == "Fertilizer"){
            if(PlayerPrefs.GetFloat("Money")>=10){
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-10);
            }
        }
        
        if(this.gameObject.name == "Daffodil"){
            if(PlayerPrefs.GetFloat("Money")>=10){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-10);
            }
        }

        if(this.gameObject.name == "GardenTulip"){
            if(PlayerPrefs.GetFloat("Money")>=20){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-20);
            }
        }

        if(this.gameObject.name == "GlobeAmaranth"){
            if(PlayerPrefs.GetFloat("Money")>=40){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-40);
            }
        }

        if(this.gameObject.name == "Tulip"){
            if(PlayerPrefs.GetFloat("Money")>=80){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-80);
            }
        }

        if(this.gameObject.name == "Daisy"){
            if(PlayerPrefs.GetFloat("Money")>=160){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-160);
            }
        }

        if(this.gameObject.name == "CallaLily"){
            if(PlayerPrefs.GetFloat("Money")>=320){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-320);
            }
        }

        if(this.gameObject.name == "FrenchHydrangea"){
            if(PlayerPrefs.GetFloat("Money")>=640){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-640);
            }
        }
        
        if(this.gameObject.name == "CrownOfThorns"){
            if(PlayerPrefs.GetFloat("Money")>=1280){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-1280);
            }
        }

        if(this.gameObject.name == "Echinacea"){
            if(PlayerPrefs.GetFloat("Money")>=2560){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-2560);
            }
        }

        if(this.gameObject.name == "OrangeLily"){
            if(PlayerPrefs.GetFloat("Money")>=5120){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-5120);
            }
        }

        if(this.gameObject.name == "Hyacinth"){
            if(PlayerPrefs.GetFloat("Money")>=10240){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-10240);
            }
        }

        if(this.gameObject.name == "Ivy"){
            if(PlayerPrefs.GetFloat("Money")>=20480){
                PlayerPrefs.SetInt("Task2", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-20480);
            }
        }

        if(this.gameObject.name == "TomatoSeed"){
            if(PlayerPrefs.GetFloat("Money")>=200){
                PlayerPrefs.SetInt("Task14", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-200);
            }
        }

        if(this.gameObject.name == "CabbageSeed"){
            if(PlayerPrefs.GetFloat("Money")>=250){
                PlayerPrefs.SetInt("Task14", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-250);
            }
        }

        if(this.gameObject.name == "CarrotSeed"){
            if(PlayerPrefs.GetFloat("Money")>=250){
                PlayerPrefs.SetInt("Task14", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-250);
            }
        }

        if(this.gameObject.name == "GarlicSeed"){
            if(PlayerPrefs.GetFloat("Money")>=300){
                PlayerPrefs.SetInt("Task14", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-300);
            }
        }

        if(this.gameObject.name == "PotatoSeed"){
            if(PlayerPrefs.GetFloat("Money")>=350){
                PlayerPrefs.SetInt("Task14", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-350);
            }
        }

        if(this.gameObject.name == "OnionSeed"){
            if(PlayerPrefs.GetFloat("Money")>=400){
                PlayerPrefs.SetInt("Task14", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-400);
            }
        }

        if(this.gameObject.name == "TurnipSeed"){
            if(PlayerPrefs.GetFloat("Money")>=450){
                PlayerPrefs.SetInt("Task14", 1);
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-450);
            }
        }

        if(this.gameObject.name == "Shovel"){
            if(PlayerPrefs.GetFloat("Money")>=1000){
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-1000);
            }
        }

        if(this.gameObject.name == "Sickle"){
            if(PlayerPrefs.GetFloat("Money")>=2000){
                if(PlayerPrefs.HasKey(this.gameObject.name+"Item")){
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  PlayerPrefs.GetInt(this.gameObject.name+"Item")+1);
                }
                else{
                    PlayerPrefs.SetInt(this.gameObject.name + "Item",  1);
                }
                Debug.Log(this.gameObject.name+"Item :" + PlayerPrefs.GetInt(this.gameObject.name+"Item"));
                PlayerPrefs.SetFloat("Money",PlayerPrefs.GetFloat("Money")-2000);
            }
        }
    }
}
