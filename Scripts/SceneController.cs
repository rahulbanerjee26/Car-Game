using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void sceneChange(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void endGame()
    {
        Application.Quit();
    }
}
