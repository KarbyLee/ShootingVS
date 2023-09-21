using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingUI : MonoBehaviour
{
    public void loadingExit()
    {
        SceneManager.LoadScene("start");
    }
}
