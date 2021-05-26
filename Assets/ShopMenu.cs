using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script will open the shop menu per item when the object or the plus symbol is pressed
public class ShopMenu : MonoBehaviour
{
    public Animator animator_menu;
    public Animator animator_money;
    public GameObject AddButton;
    public GameObject Money;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this will set the backyard new gamers to no
        PlayerPrefs.SetInt("NewGameBackyard",0);

        //when the player hits the screen, it will check the position of the mouse
        //if the player hit a Raycast2D with a collider on them, it will check its name
        //wether it is the name of the button for adding a product or not,
        //if so, then the animation will take place and the player can click on the items they
        //want to buy
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {
                Debug.Log(AddButton.name);
                Debug.Log(hit.collider.gameObject.name);
                if(hit.collider.gameObject.name == AddButton.name){
                    animator_menu.SetBool("OpenMenu", true);
                    animator_menu.SetBool("CloseMenu", false);
                    animator_money.SetBool("OpenMenu", true);
                    animator_money.SetBool("CloseMenu", false);
                }
            }
        }
    }

    public void closeMenu(){
        animator_money.SetBool("CloseMenu", true);
        animator_money.SetBool("OpenMenu", false);
        animator_menu.SetBool("OpenMenu", false);
        animator_menu.SetBool("CloseMenu", true);
    }
}
