using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

//script used for going to the Backyard and outside from the garden 
public class GoToBackyard : MonoBehaviour
{
    GameObject Money1;
    public Animator animator;
    public GameObject transition;

    //this part is to set the animator so that the transition object won't
    //be triggered
    void Awake(){
        animator.SetBool("stay", true);
        animator.SetBool("close", false);
    }

    //this part will get the money stored in the Money variable
    //then it will be transfered to the PlayerPrefs to save the data
    //
    //The transition will also start when the function is called
    //and will start the Coroutine that will Delay the loading of scene
    //so the transition have time to animate
    public void BackyardScene(){
        Money1 = GameObject.FindWithTag("Money");
        PlayerPrefs.SetFloat("Money",float.Parse(Money1.GetComponent<TMPro.TextMeshProUGUI>().text));
        transition.SetActive(true);
        animator.SetBool("close", true);
        animator.SetBool("stay", false);
        StartCoroutine(DelayLoadBackyard());
    }

    //This is the same as the previous function but going outside.
    public void OutsideScene(){
        Money1 = GameObject.FindWithTag("Money");
        PlayerPrefs.SetFloat("Money",float.Parse(Money1.GetComponent<TMPro.TextMeshProUGUI>().text));
        transition.SetActive(true);
        animator.SetBool("close", true);
        animator.SetBool("stay", false);
        StartCoroutine(DelayLoadOutside());
    }

    IEnumerator DelayLoadBackyard() {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Backyard", LoadSceneMode.Single);
    }

    IEnumerator DelayLoadOutside() {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Outside", LoadSceneMode.Single);
    }
}
