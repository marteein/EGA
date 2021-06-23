using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class spawnPlant : MonoBehaviour  {

     public Transform prefab ;
     public GameObject prefabCoin;
     public GameObject Plant;
     
     private Transform spawn;
     private Rect rect = new Rect(0,0,100,50);
     
     void  Update() {
         
         
         if (Input.GetMouseButton(0) && spawn != null) {
             var pos = Input.mousePosition;
             pos.z = -Camera.main.transform.position.z;
             spawn.transform.position = Camera.main.ScreenToWorldPoint(pos);
         }
         
         if (Input.GetMouseButtonUp(0)) {
             spawn = null;
         }
     }
 
     public void InstantiateThem() {
         if (Input.GetMouseButtonDown(0)) {
            var pos = Input.mousePosition;
            pos.z = -Camera.main.transform.position.z;
            pos = Camera.main.ScreenToWorldPoint(pos);
            spawn = Instantiate(prefab, pos, Quaternion.identity) as Transform;
            
            GameObject add_coin = Instantiate(prefabCoin, Plant.transform.position , Quaternion.identity) as GameObject;
            add_coin.transform.parent = prefab;
         }
         
      
     }
 }
