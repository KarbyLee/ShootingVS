using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startUI : MonoBehaviour
{
    [SerializeField] GameObject option;

    void Start()
    {
        option.SetActive(false);
    }
    
    public void optionOpen()
    {
        option.SetActive(true);
    }

    public void optionClose()
    {
        option.SetActive(false);
    }

    public void gameExit()
    {
        Application.Quit();
    }

    public void gameStart()
    {
        SceneManager.LoadScene("gamePlay");
    }
}
