using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler {
    Vector2 rect;
    public List <GameObject> ItemsInventory;
    int itemListIndex;
    public Text countOfChild;
    GameObject thisParent;
    Vector2 OldPosition;
    
    void Awake(){
      // OldPosition = this.transform.localPosition;
      
        for(int i=0;i<ItemsInventory.Count;i++){
            if(ItemsInventory[i].gameObject.name.Substring(0, ItemsInventory[i].gameObject.name.Length-7) == this.gameObject.name.Substring(0, this.gameObject.name.Length-4)){
                itemListIndex = i;
            }
        }
        for(int i=0;i<PlayerPrefs.GetInt(this.gameObject.name);i++){
            GameObject itemInside = Instantiate(ItemsInventory[itemListIndex], new Vector2(this.transform.position.x, this.transform.position.y+10), Quaternion.identity) as GameObject;
            itemInside.name = ItemsInventory[itemListIndex].name;
            itemInside.transform.SetParent(this.transform);
            itemInside.transform.localScale = new Vector2(1,1);
        }
        
    }

    void Update(){
        if(this.transform.childCount>0 && PlayerPrefs.GetInt(this.gameObject.name)>0){
            //this.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
            this.transform.GetChild(0).transform.localScale = new Vector2(1,1);
            countOfChild.text = (this.transform.childCount-2).ToString();
            //this.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = PlayerPrefs.GetInt(this.gameObject.name).ToString();
        }
        else{
            this.gameObject.SetActive(false);
        }
        // for(int i=0;i<Name.Length;i++){
        //     if(PlayerPrefs.HasKey(Name[i]+"Item") && PlayerPrefs.GetInt(Name[i]+"Item")>0 && this.transform.childCount == 0){
        //         GameObject itemInside = Instantiate(ItemsInventory[i], new Vector2(this.transform.position.x, this.transform.position.y+10), Quaternion.identity) as GameObject;
        //         itemInside.transform.SetParent(this.transform.parent.transform.GetChild(i));
        //         itemInside.transform.localScale = new Vector2(1,1);
        //         itemInside.transform.GetChild(1).GetComponent<Text>().text = PlayerPrefs.GetInt(Name[i]+"Item").ToString();
        //     } 
        // }
    }

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        string[] Name = {"CallaLily","CrownOfThorns","Daffodil","Daisy","Echinacea","FrenchHydrangea","GardenTulip","GlobeAmaranth","Hyacinth","Ivy","OrangeLily","Tulip"};
        if(eventData.pointerDrag != null){
            eventData.pointerDrag.transform.SetParent(this.transform);
            eventData.pointerDrag.transform.localPosition = new Vector2(0,9);
            eventData.pointerDrag.GetComponent<RectTransform>().sizeDelta = new Vector2(60,70);
            for(int i=0;i<Name.Length;i++){
                if(this.transform.GetChild(0).name == eventData.pointerDrag.name){
                    PlayerPrefs.SetInt(Name[i]+"Item",PlayerPrefs.GetInt(Name[i]+"Item")+1);
                    Debug.Log(Name[i]+"Item:"+PlayerPrefs.GetInt(Name[i]+"Item"));
                    eventData.pointerDrag.transform.GetChild(1).GetComponent<Text>().text = PlayerPrefs.GetInt(Name[i]+"Item").ToString();
                }
            }
            
        }
        else{
           // eventData.pointerDrag.transform.localPosition = OldPosition;
        }
    }

    public void itemInside(){
        
    }

}
