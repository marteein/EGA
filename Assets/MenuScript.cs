using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Animator newGameAnimator;
    public Animator newGameAnimatorBoy;
    public Animator newGameAnimatorGirl;
    public Animator MenuAnim;
    public void ContinueGame(){
        SceneManager.LoadScene("Outside", LoadSceneMode.Single);
    }

    public void NewGame(){
        newGameAnimator.SetBool("newGame", true);
        newGameAnimatorGirl.SetBool("newGame", true);
        newGameAnimatorBoy.SetBool("newGame", true);
        MenuAnim.SetBool("newGame", true);

    }

    public void BackMenu(){
        newGameAnimator.SetBool("newGame", false);
        newGameAnimatorGirl.SetBool("newGame", false);
        newGameAnimatorBoy.SetBool("newGame", false);
        MenuAnim.SetBool("newGame", false);
    }

    public void NewGameBoy(){
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Outside", LoadSceneMode.Single);
        PlayerPrefs.SetInt("Gender", 0);
        PlayerPrefs.SetInt("NewGameOutside", 1);
        PlayerPrefs.SetInt("NewGameGarden", 1);
        PlayerPrefs.SetInt("NewGameBackyard", 1);
    }

    public void NewGameGirl(){
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Outside", LoadSceneMode.Single);
        PlayerPrefs.SetInt("Gender", 1);
        PlayerPrefs.SetInt("NewGameOutside", 1);
        PlayerPrefs.SetInt("NewGameGarden", 1);
        PlayerPrefs.SetInt("NewGameBackyard", 1);
    }
    
    public void QuitGame(){
        Application.Quit();
    }

}
