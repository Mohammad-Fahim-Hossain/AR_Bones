using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void QuitApp() {

        Application.Quit();

    }

    public void MainScene() {

        SceneManager.LoadScene("tabMainScene");
    }
    
    public void MainManu() {

        SceneManager.LoadScene("MainManu");

    }

}
