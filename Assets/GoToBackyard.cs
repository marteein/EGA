using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GoToBackyard : MonoBehaviour
{
    GameObject Money1;
    public Animator animator;
    public GameObject transition;

    void Awake(){
        animator.SetBool("stay", true);
        animator.SetBool("close", false);
    }
    public void BackyardScene(){
        Money1 = GameObject.FindWithTag("Money");
        PlayerPrefs.SetFloat("Money",float.Parse(Money1.GetComponent<TMPro.TextMeshProUGUI>().text));
        transition.SetActive(true);
        animator.SetBool("close", true);
        animator.SetBool("stay", false);
        StartCoroutine(DelayLoadBackyard());
    }

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
        SceneManager.LoadScene("Shop", LoadSceneMode.Single);
    }

    IEnumerator DelayLoadOutside() {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Outside", LoadSceneMode.Single);
    }
}
