using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenHouse_Menu1 : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("NewGameBackyard", 0);
        if(!PlayerPrefs.HasKey("Money")){
            PlayerPrefs.SetFloat("Money",50);
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
                if(hit.collider.gameObject.name == "Character1"){
                    animator.SetBool("OpenMenu", true);
                    animator.SetBool("CloseMenu", false);
                }
            }
        }
    }

    public void closeMenu(){
        animator.SetBool("CloseMenu", true);
        animator.SetBool("OpenMenu", false);
    }
}
