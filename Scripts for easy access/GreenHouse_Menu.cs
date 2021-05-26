using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenHouse_Menu : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //Make player not a new gamer and disable dialogue
        PlayerPrefs.SetInt("NewGameGarden", 0);

        //check if Prefs "Money" is null, create when true
        if(!PlayerPrefs.HasKey("Money")){
            PlayerPrefs.SetFloat("Money",50);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //when the player hits the screen, it will check the position of the mouse
        //if the player hit a Raycast2D with a collider on them, it will check its name
        //wether it is the name of the button when opening a menu or not,
        //if so, then the animation will take place and the player see the menu pop up
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {
                if(hit.collider.gameObject.name == "Character"){
                    animator.SetBool("OpenMenu", true);
                    animator.SetBool("CloseMenu", false);
                }
            }
        }
    }

    //set animation parameters for closing menu
    public void closeMenu(){
        animator.SetBool("CloseMenu", true);
        animator.SetBool("OpenMenu", false);
    }
}
