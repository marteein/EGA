using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler {

    [SerializeField] private GameObject canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public GameObject parentShelf;
    public GameObject amount;
    public GameObject itemSlot;
    GameObject thisParent;

    private void Start() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GameObject.FindWithTag("Canvas");
        parentShelf = GameObject.FindWithTag("ShelfSlot");
        itemSlot = GameObject.FindWithTag("InventorySlot");
        thisParent = this.transform.parent.gameObject;
    }

    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("OnBeginDrag");
        if(thisParent.name.Substring(0,7) == "ShelfSl"){
            for(int i=0;i<thisParent.transform.parent.transform.childCount;i++){
                if(thisParent.name == "ShelfSlot0"+i){
                    PlayerPrefs.DeleteKey("0"+i.ToString());
                }
                else if(thisParent.name == "ShelfSlot"+i){
                    PlayerPrefs.DeleteKey(i.ToString());
                }
            }
        }
        
        string[] Name = {"CallaLily","CrownOfThorns","Daffodil","Daisy","Echinacea","FrenchHydrangea","GardenTulip","GlobeAmaranth","Hyacinth","Ivy","OrangeLily","Tulip"};
        if(transform.parent != parentShelf.transform){
            transform.parent = parentShelf.transform;
            for(int i=0;i<Name.Length;i++){
                if(this.gameObject.name.Substring(0, this.gameObject.name.Length-7) == Name[i]){
                    PlayerPrefs.SetInt(Name[i]+"Item", PlayerPrefs.GetInt(Name[i]+"Item")-1);
                    Debug.Log(Name[i]+"Item: "+PlayerPrefs.GetInt(Name[i]+"Item"));
                    amount.SetActive(false);
                }
            }
        }
        
        GetComponent<RectTransform>().sizeDelta = new Vector2(90,120);
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData) {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.GetComponent<Canvas>().scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("OnEndDrag");
        string[] Name = {"CallaLily","CrownOfThorns","Daffodil","Daisy","Echinacea","FrenchHydrangea","GardenTulip","GlobeAmaranth","Hyacinth","Ivy","OrangeLily","Tulip"};
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        for(int i=0;i<Name.Length;i++){
            if(itemSlot.transform.parent.transform.GetChild(i).childCount<=0){
                Debug.Log(eventData.pointerDrag.name.Length-7);
                if(PlayerPrefs.GetInt(Name[i]+"Item")>0 && eventData.pointerDrag.name.Substring(0,eventData.pointerDrag.name.Length-7) == Name[i]){
                    GameObject itemInside = Instantiate(itemSlot.GetComponent<ItemSlot>().ItemsInventory[i], new Vector2(itemSlot.transform.position.x, itemSlot.transform.position.y+10), Quaternion.identity) as GameObject;
                    itemInside.transform.parent = itemSlot.transform.parent.GetChild(i);
                    itemInside.transform.localScale = new Vector2(1,1);
                    itemInside.transform.GetChild(1).GetComponent<Text>().text = PlayerPrefs.GetInt(Name[0]+"Item").ToString();
                }
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("OnPointerDown");
    }

}
