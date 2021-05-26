using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    public float money;
    GameObject Money1;
    //Not being used but safe not to delete.
    // Start is called before the first frame update
    void Awake()
    {
        if(control == null){
            DontDestroyOnLoad(gameObject);
            control=this;
        }
        else if(control != this){
            Destroy(gameObject);
        }
        Money1 = GameObject.FindWithTag("Money");
    }

    // Update is called once per frame
    void Update()
    {
        
        money = float.Parse(Money1.GetComponent<TMPro.TextMeshProUGUI>().text);
        Money1.GetComponent<TMPro.TextMeshProUGUI>().text = money.ToString();
    }
}
