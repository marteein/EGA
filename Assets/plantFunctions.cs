using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class plantFunctions : MonoBehaviour
{
    public GameObject panel;
    public AudioSource audioData;
    float timer = 0;
    int waterLevel = 0;
    int fertilized = 0;
    int pesticide = 0;
    int plantPrice;
    TMPro.TMP_Text price;
    void Start(){
        price = panel.transform.GetChild(1).transform.GetChild(3).transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        audioData = GameObject.FindWithTag("waterAudio").GetComponent<AudioSource>();
        if(!PlayerPrefs.HasKey("FertilizerAmount")){
            PlayerPrefs.SetInt("FertilizerAmount",0);
        }
        if(!PlayerPrefs.HasKey("PesticideAmount")){
            PlayerPrefs.SetInt("PesticideAmount",0);
        }

        //Debug.Log(this.gameObject.transform.parent.gameObject.name);

        string nameofSlot = this.transform.parent.gameObject.name.Substring(this.transform.parent.gameObject.name.Length-2, 2);
        if(PlayerPrefs.HasKey(nameofSlot+"UpgradeWater")){
            waterLevel = PlayerPrefs.GetInt(nameofSlot+"UpgradeWater");
        }
        else{
            PlayerPrefs.SetInt(nameofSlot+"UpgradeWater",0);
        }

        if(PlayerPrefs.HasKey(nameofSlot+"UpgradeFertilize")){
            fertilized = PlayerPrefs.GetInt(nameofSlot+"UpgradeFertilize");
        }
        else{
            PlayerPrefs.SetInt(nameofSlot+"UpgradeFertilize", 0);
        }

        if(PlayerPrefs.HasKey(nameofSlot+"UpgradePesticide")){
            pesticide = PlayerPrefs.GetInt(nameofSlot+"UpgradePesticide");
        }
        else{
            PlayerPrefs.SetInt(nameofSlot+"UpgradePesticide", 0);
        }

    }

    public void OpenMenu(){
        Debug.Log(this.transform.parent.gameObject.name);
        GameObject[] panels = GameObject.FindGameObjectsWithTag("Panel");
        for(int i=0;i<panels.Length;i++){
            panels[i].gameObject.SetActive(false);
        }
        for(int i = 0;i<this.transform.parent.transform.parent.transform.childCount;i++){
            if(this.transform.parent.transform.parent.transform.GetChild(i).transform.childCount>0){
                this.transform.parent.transform.parent.transform.GetChild(i).transform.GetChild(0).GetComponent<Button>().interactable = true;
                this.transform.parent.transform.parent.transform.GetChild(i).transform.GetChild(0).GetComponent<DragDrop>().enabled = true;
            }
            
        }
        panel.transform.parent = this.transform.parent.transform.parent.transform.parent.transform.parent;
        panel.SetActive(true);
        this.GetComponent<Button>().interactable = false;
        this.GetComponent<DragDrop>().enabled = false;
        //Debug.Log(this.gameObject.transform.parent.gameObject.name);

    }

    public void CloseMenu(){
        panel.transform.parent = this.transform;
        for(int i = 20;i<this.transform.parent.transform.childCount;i++){

            // this.transform.parent.transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(false);
            this.transform.parent.transform.GetChild(i).GetComponent<Button>().interactable = true;
        }
        panel.SetActive(false);
        this.GetComponent<Button>().interactable = true;
        this.GetComponent<DragDrop>().enabled = true;
    }

    public IEnumerator AnimationPlay(int animPlayer){
        if(animPlayer == 1){
            this.GetComponent<Animator>().SetBool("isWatering", true);
            yield return new WaitForSeconds(1);
            this.GetComponent<Animator>().SetBool("isWatering", false);
        }
        else if(animPlayer == 2){
            this.GetComponent<Animator>().SetBool("isFertilize", true);
            yield return new WaitForSeconds(1);
            this.GetComponent<Animator>().SetBool("isFertilize", false);
        }
        else if(animPlayer == 3){
            this.GetComponent<Animator>().SetBool("isPesticide", true);
            yield return new WaitForSeconds(1);
            this.GetComponent<Animator>().SetBool("isPesticide", false);
        }
    }

    public void WaterPlants(){
        audioData.Play(0);
        waterLevel++;
        string nameofSlot = this.transform.parent.gameObject.name.Substring(this.transform.parent.gameObject.name.Length-2, 2);
        if(waterLevel==1){
            if(this.gameObject.name.Substring(this.gameObject.name.Length-7,7) == "(Clone)"){
                PlayerPrefs.SetInt(nameofSlot+"UpgradeWater", 1);
            }
            else{
                PlayerPrefs.SetInt(nameofSlot+"UpgradeWater", 1);
            }
            timer=45;
        }
        else if(waterLevel==2){
            if(this.gameObject.name.Substring(this.gameObject.name.Length-7,7) == "(Clone)"){
                PlayerPrefs.SetInt(nameofSlot+"UpgradeWater", 2);
            }
            else{
                PlayerPrefs.SetInt(nameofSlot+"UpgradeWater", 2);
            }
            timer=90;
        }
        else if(waterLevel>=3){
            if(this.gameObject.name.Substring(this.gameObject.name.Length-7,7) == "(Clone)"){
                PlayerPrefs.SetInt(nameofSlot+"UpgradeWater", 3);
            }
            else{
                PlayerPrefs.SetInt(nameofSlot+"UpgradeWater", 3);
            }
            timer=180;
        }
        StartCoroutine(AnimationPlay(1));
        PlayerPrefs.SetInt("Task5",1);
    }

    public void FertilizePlant(){
        StartCoroutine(AnimationPlay(2));
        PlayerPrefs.SetInt("FertilizerAmount", PlayerPrefs.GetInt("FertilizerAmount") - 1);
        fertilized++;
        string nameofSlot = this.transform.parent.gameObject.name.Substring(this.transform.parent.gameObject.name.Length-2, 2);
        if(fertilized>=1){
            if(this.gameObject.name.Substring(this.gameObject.name.Length-7,7) == "(Clone)"){
                PlayerPrefs.SetInt(nameofSlot+"UpgradeFertilize", 1);
            }
            else{
                PlayerPrefs.SetInt(nameofSlot+"UpgradeFertilize", 1);
            }
        }
    }

    public void PesticidePlant(){
        StartCoroutine(AnimationPlay(3));
        PlayerPrefs.SetInt("PesticideAmount", PlayerPrefs.GetInt("PesticideAmount") - 1);
        pesticide++;
        string nameofSlot = this.transform.parent.gameObject.name.Substring(this.transform.parent.gameObject.name.Length-2, 2);
        if(pesticide>=1){
            if(this.gameObject.name.Substring(this.gameObject.name.Length-7,7) == "(Clone)"){
                PlayerPrefs.SetInt(nameofSlot+"UpgradePesticide", 1);
            }
            else{
                PlayerPrefs.SetInt(nameofSlot+"UpgradePesticide", 1);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(waterLevel==1){
            this.GetComponent<Animator>().SetBool("isSeed", true);
        }
        else if(waterLevel==2){
            this.GetComponent<Animator>().SetBool("isMedium",true);
            this.GetComponent<Animator>().SetBool("isSeed",false);
        }
        else if(waterLevel>=3){
            this.GetComponent<Animator>().SetBool("isMedium",false);
            this.GetComponent<Animator>().SetBool("isLarge",true);
        }
        timer = timer - Time.deltaTime;
        if(this.transform.parent.tag == "InventorySlot"){
            this.GetComponent<Button>().enabled = false;
        }
        else{
            this.GetComponent<Button>().enabled = true;
        }
        if(timer<=0){
            timer=0;
            panel.transform.GetChild(1).transform.GetChild(0).GetComponent<Button>().interactable = true;
        }
        else{
            panel.transform.GetChild(1).transform.GetChild(0).GetComponent<Button>().interactable = false;
        }
        panel.transform.GetChild(1).transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = FormatTime(timer);
        panel.transform.GetChild(1).transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = PlayerPrefs.GetInt("FertilizerAmount").ToString();
        panel.transform.GetChild(1).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = PlayerPrefs.GetInt("PesticideAmount").ToString();
        if(fertilized >= 1){
            panel.transform.GetChild(1).transform.GetChild(1).GetComponent<Button>().interactable = false;
        }
        if(pesticide >= 1){
            panel.transform.GetChild(1).transform.GetChild(2).GetComponent<Button>().interactable = false;
        }
        if(PlayerPrefs.GetInt("FertilizerAmount")<=0){
            panel.transform.GetChild(1).transform.GetChild(1).gameObject.SetActive(false);
        }
        else{
            panel.transform.GetChild(1).transform.GetChild(1).gameObject.SetActive(true);
        }

        if(PlayerPrefs.GetInt("PesticideAmount")<=0){
           panel.transform.GetChild(1).transform.GetChild(2).gameObject.SetActive(false);
        }
        else{
            panel.transform.GetChild(1).transform.GetChild(2).gameObject.SetActive(true);
        }


        string nameOfItem = this.gameObject.name.Substring(0, 7);
        if(nameOfItem == "Daffodi"){
            plantPrice = 10 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        else if(nameOfItem == "GardenT"){
            plantPrice = 20 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        else if(nameOfItem == "GlobeAm"){
            plantPrice = 40 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        else if(nameOfItem == "TulipSa"){
            plantPrice = 80 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        else if(nameOfItem == "DaisySa"){
            plantPrice = 160 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        else if(nameOfItem == "CallaLi"){
            plantPrice = 320 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        else if(nameOfItem == "FrenchH"){
            plantPrice = 640 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        else if(nameOfItem == "CrownOf"){
            plantPrice = 1280 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        else if(nameOfItem == "Echinac"){
            plantPrice = 2560 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        else if(nameOfItem == "OrangeL"){
            plantPrice = 5120 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        else if(nameOfItem == "Hyacint"){
            plantPrice = 10240 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        else if(nameOfItem == "IvySapl"){
            plantPrice = 20480 +(waterLevel*2) + (fertilized * 13) + (pesticide*23);
        }
        price.text = plantPrice.ToString()+"Php";

    }

    public string FormatTime( float time )
    {
        int minutes = (int) time / 60 ;
        int seconds = (int) time - 60 * minutes;
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void sellPlant(){
        string nameofSlot = this.transform.parent.gameObject.name.Substring(this.transform.parent.gameObject.name.Length-2, 2);
        PlayerPrefs.DeleteKey(nameofSlot+"UpgradePesticide");
        PlayerPrefs.DeleteKey(nameofSlot+"UpgradeFertilize");
        PlayerPrefs.DeleteKey(nameofSlot);
        PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money")+plantPrice);
        Destroy(panel);
        Destroy(this.gameObject);
        
    }
}
