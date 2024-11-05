using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        SwitchToGameScene();
    }

    public void SwitchToGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
