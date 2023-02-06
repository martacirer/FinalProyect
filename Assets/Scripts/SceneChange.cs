using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void GoToMainScene(string name)
    {
        //Carga la escena principal
        SceneManager.LoadScene("MainScene");
    }
}
