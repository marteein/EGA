using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taskList : MonoBehaviour
{
    public GameObject TaskList;
    public void showTask(){
        Time.timeScale = 0;
        TaskList.SetActive(true);
    }

    public void closeTask(){
        Time. timeScale = 1;
        TaskList.SetActive(false);
    }
}
