using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot1 : MonoBehaviour, IDropHandler {

    public string nameofSlot;
    public List <GameObject> prefabs;
    Vector2 OldPosition;

    void Awake(){
        //OldPosition = this.transform.localPosition;
        nameofSlot = this.gameObject.name.Substring(this.gameObject.name.Length-2, 2);
        for(int i=1;i<=20;i++){
            if(i<10){
                if(PlayerPrefs.HasKey("0"+i)){
                    int index=0;
                    for(int k=0;k<prefabs.Count;k++){
                        if(prefabs[k].name.Substring(0,prefabs[k].name.Length-7) == PlayerPrefs.GetString("0"+i)){
                            index = k;
                            break;
                        }
                    }
                    if(this.gameObject.name == "ShelfSlot0"+i){
                        GameObject ShelfItem = Instantiate(prefabs[index], new Vector2(this.transform.position.x, this.transform.position.y+40), Quaternion.identity) as GameObject;
                        ShelfItem.transform.parent = this.transform;
                        ShelfItem.transform.GetChild(0).gameObject.SetActive(false);
                        ShelfItem.transform.GetChild(1).gameObject.SetActive(false);
                        ShelfItem.GetComponent<RectTransform>().sizeDelta = new Vector2(90, 120);
                        ShelfItem.transform.localScale = new Vector2(1,1);
                    }
                    
                }
            }
            if(i>=10){
                if(PlayerPrefs.HasKey(i.ToString())){
                    int index=0;
                    for(int k=0;k<prefabs.Count;k++){
                        if(prefabs[k].name.Substring(0,prefabs[k].name.Length-7) == PlayerPrefs.GetString(i.ToString())){
                            index = k;
                            break;
                        }
                    }
                    if(this.gameObject.name == "ShelfSlot"+i){
                        GameObject ShelfItem = Instantiate(prefabs[index], new Vector2(this.transform.position.x, this.transform.position.y+40), Quaternion.identity) as GameObject;
                        ShelfItem.transform.parent = this.transform;
                        ShelfItem.transform.GetChild(0).gameObject.SetActive(false);
                        ShelfItem.transform.GetChild(1).gameObject.SetActive(false);
                        ShelfItem.GetComponent<RectTransform>().sizeDelta = new Vector2(90, 120);
                        ShelfItem.transform.localScale = new Vector2(1,1);
                    }
                    
                }
            }
            
        }
    }


    public void OnDrop(PointerEventData eventData) {
        nameofSlot = this.gameObject.name.Substring(this.gameObject.name.Length-2, 2);
        Debug.Log("OnDrop");
        string[] Name = {"Daffodil"};
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.transform.localPosition = new Vector2(this.transform.localPosition.x, this.transform.localPosition.y+40);
            eventData.pointerDrag.transform.parent = this.transform;
            eventData.pointerDrag.GetComponent<RectTransform>().sizeDelta = new Vector2(90,120);
            if(eventData.pointerDrag.name.Substring(eventData.pointerDrag.gameObject.name.Length-7,7) == "(Clone)"){
                PlayerPrefs.SetString(nameofSlot, eventData.pointerDrag.gameObject.name.Substring(0, eventData.pointerDrag.gameObject.name.Length - 14));
            }
            else{
                PlayerPrefs.SetString(nameofSlot, eventData.pointerDrag.gameObject.name.Substring(0, eventData.pointerDrag.gameObject.name.Length - 7));
            }
            PlayerPrefs.SetInt("Task4",1);
            Debug.Log("Name of object: "+PlayerPrefs.GetString(nameofSlot));
        }
        else{
            //eventData.pointerDrag.transform.localPosition = OldPosition;
        }
    }

    public void itemInside(){
        
    }

    void Update(){

    }

}
