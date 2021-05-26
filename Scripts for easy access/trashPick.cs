using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is for the trash prefabs to spawn at a random location
public class trashPick : MonoBehaviour
{
    public GameObject[] trashPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < trashPrefabs.Length; i++)
        {
            float spawnY = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, 350)).y);
            float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(-8, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
    
            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(trashPrefabs[i], spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
