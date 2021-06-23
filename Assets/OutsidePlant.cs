using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsidePlant : MonoBehaviour
{

    public GameObject panel;
    public Animator anim;
    public GameObject chara;
    public void closePlantAndCultivate(){
        Time.timeScale = 1;
        panel.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("Money")){
            PlayerPrefs.SetFloat("Money", 100000);
        }

        if(PlayerPrefs.HasKey(this.gameObject.name+"isCultivated")){
            if(PlayerPrefs.GetInt(this.gameObject.name+"isCultivated")==1){
                anim.SetBool("isCultivated", true);
                anim.SetBool("isHarvested", false);
            }
        }

        if(PlayerPrefs.HasKey(this.gameObject.name+"isSeeded")){
            if(PlayerPrefs.GetInt(this.gameObject.name+"isSeeded")==1){
                anim.SetBool("isSeeded", true);
                anim.SetBool("isCultivated", false);
            }
        }

        if(PlayerPrefs.HasKey(this.gameObject.name+"isTomato")){
            if(PlayerPrefs.GetInt(this.gameObject.name+"isTomato")==1){
                anim.SetBool("isTomato", true);
            }
        }

        if(PlayerPrefs.HasKey(this.gameObject.name+"isCabbage")){
            if(PlayerPrefs.GetInt(this.gameObject.name+"isCabbage")==1){
                anim.SetBool("isCabbage", true);
            }
        }
        
        if(PlayerPrefs.HasKey(this.gameObject.name+"isPotato")){
            if(PlayerPrefs.GetInt(this.gameObject.name+"isPotato")==1){
                anim.SetBool("isPotato", true);
            }
        }

        if(PlayerPrefs.HasKey(this.gameObject.name+"isGarlic")){
            if(PlayerPrefs.GetInt(this.gameObject.name+"isGarlic")==1){
                anim.SetBool("isGarlic", true);
            }
        }

        if(PlayerPrefs.HasKey(this.gameObject.name+"isCarrot")){
            if(PlayerPrefs.GetInt(this.gameObject.name+"isCarrot")==1){
                anim.SetBool("isCarrot", true);
            }
        }

        if(PlayerPrefs.HasKey(this.gameObject.name+"isOnion")){
            if(PlayerPrefs.GetInt(this.gameObject.name+"isOnion")==1){
                anim.SetBool("isOnion", true);
            }
        }

        if(PlayerPrefs.HasKey(this.gameObject.name+"isTurnip")){
            if(PlayerPrefs.GetInt(this.gameObject.name+"isTurnip")==1){
                anim.SetBool("isTurnip", true);
            }
        }

        if(PlayerPrefs.HasKey(this.gameObject.name+"isTurnip")){
            if(PlayerPrefs.GetInt(this.gameObject.name+"isTurnip")==1){
                anim.SetBool("isTurnip", true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {
                if(hit.collider.gameObject.name == this.gameObject.name){
                    Time.timeScale = 0;
                    panel.gameObject.SetActive(true);
                }
            }
        }

        if(panel.gameObject.activeSelf){
            chara.gameObject.SetActive(false);
        }
        else{
            chara.gameObject.SetActive(true);
        }
    }

    public void CultivateField(){
        anim.SetBool("isCultivated", true);
        anim.SetBool("isHarvested", false);
        Time.timeScale = 1;
        panel.gameObject.SetActive(false);
        PlayerPrefs.SetInt(this.gameObject.name+"isCultivated",1);
        PlayerPrefs.SetInt(this.gameObject.name+"isHarvested",0);
    }
    
    public void SeedField(){
        if(anim.GetBool("isCultivated")==true){
            anim.SetBool("isSeeded", true);
            PlayerPrefs.SetInt(this.gameObject.name+"isSeeded",1);
            anim.SetBool("isCultivated", false);
            PlayerPrefs.SetInt(this.gameObject.name+"isCultivated",0);
            Time.timeScale = 1;
            panel.gameObject.SetActive(false);
        }
    }

    public void plantTomato(){
        if(anim.GetBool("isSeeded")==true){
            anim.SetBool("isTomato", true);
            PlayerPrefs.SetInt(this.gameObject.name+"isTomato",1);
            Time.timeScale = 1;
            panel.gameObject.SetActive(false);
            PlayerPrefs.SetInt("TomatoSeedItem", PlayerPrefs.GetInt("TomatoSeedItem")-1);
        }
        
    }

    public void plantCabbage(){
        if(anim.GetBool("isSeeded")==true){
            anim.SetBool("isCabbage", true);
            PlayerPrefs.SetInt(this.gameObject.name+"isCabbage",1);
            Time.timeScale = 1;
            panel.gameObject.SetActive(false);
            PlayerPrefs.SetInt("CabbageSeedItem", PlayerPrefs.GetInt("CabbageSeedItem")-1);
        }
    }

    public void plantPotato(){
        if(anim.GetBool("isSeeded")==true){
            anim.SetBool("isPotato", true);
            PlayerPrefs.SetInt(this.gameObject.name+"isPotato",1);
            Time.timeScale = 1;
            panel.gameObject.SetActive(false);
            PlayerPrefs.SetInt("PotatoSeedItem", PlayerPrefs.GetInt("PotatoSeedItem")-1);
        }
    }

    public void plantGarlic(){
        if(anim.GetBool("isSeeded")==true){
            anim.SetBool("isGarlic", true);
            PlayerPrefs.SetInt(this.gameObject.name+"isGarlic",1);
            Time.timeScale = 1;
            panel.gameObject.SetActive(false);
            PlayerPrefs.SetInt("GarlicSeedItem", PlayerPrefs.GetInt("GarlicSeedItem")-1);
        }
    }

    public void plantCarrot(){
        if(anim.GetBool("isSeeded")==true){
            anim.SetBool("isCarrot", true);
            PlayerPrefs.SetInt(this.gameObject.name+"isCarrot",1);
            Time.timeScale = 1;
            panel.gameObject.SetActive(false);
            PlayerPrefs.SetInt("CarrotSeedItem", PlayerPrefs.GetInt("CarrotSeedItem")-1);
        }
    }

    public void plantOnion(){
        if(anim.GetBool("isSeeded")==true){
            anim.SetBool("isOnion", true);
            PlayerPrefs.SetInt(this.gameObject.name+"isOnion",1);
            Time.timeScale = 1;
            panel.gameObject.SetActive(false);
            PlayerPrefs.SetInt("OnionSeedItem", PlayerPrefs.GetInt("OnionSeedItem")-1);
        }
    }

    public void plantTurnip(){
        if(anim.GetBool("isSeeded")==true){
            anim.SetBool("isTurnip", true);
            PlayerPrefs.SetInt(this.gameObject.name+"isTurnip",1);
            Time.timeScale = 1;
            panel.gameObject.SetActive(false);
            PlayerPrefs.SetInt("TurnipSeedItem", PlayerPrefs.GetInt("TurnipSeedItem")-1);
        }
    }
    

    public void WaterField(){
        anim.SetBool("isSeeded", false);
        PlayerPrefs.SetInt(this.gameObject.name+"isSeeded",0);
        Time.timeScale = 1;
        panel.gameObject.SetActive(false);
    }

    public void HarvestField(){
        Time.timeScale = 1;
        if(anim.GetBool("isTomato")==true){
            PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money")+1000);
        }
        else if(anim.GetBool("isCabbage")==true || anim.GetBool("isCarrot")==true){
            PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money")+1250);
        }
        else if(anim.GetBool("isGarlic")==true){
            PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money")+1500);
        }
        else if(anim.GetBool("isPotato")==true){
            PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money")+1000);
        }
        else if(anim.GetBool("isOnion")==true){
            PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money")+1750);
        }
        else if(anim.GetBool("isTurnip")==true){
            PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money")+2000);
        }


        anim.SetBool("isTurnip", false);
        anim.SetBool("isOnion", false);
        anim.SetBool("isCarrot", false);
        anim.SetBool("isGarlic", false);
        anim.SetBool("isPotato", false);
        anim.SetBool("isCabbage", false);
        anim.SetBool("isTomato", false);
        anim.SetBool("isHarvested", true);
        PlayerPrefs.SetInt(this.gameObject.name+"isTurnip",0);
        PlayerPrefs.SetInt(this.gameObject.name+"isOnion",0);
        PlayerPrefs.SetInt(this.gameObject.name+"isCarrot",0);
        PlayerPrefs.SetInt(this.gameObject.name+"isGarlic",0);
        PlayerPrefs.SetInt(this.gameObject.name+"isPotato",0);
        PlayerPrefs.SetInt(this.gameObject.name+"isCabbage",0);
        PlayerPrefs.SetInt(this.gameObject.name+"isTomato",0);
        PlayerPrefs.SetInt(this.gameObject.name+"isHarvested",0);
        panel.gameObject.SetActive(false);
        //anim.SetBool("isHarvested", false);
    }
}
