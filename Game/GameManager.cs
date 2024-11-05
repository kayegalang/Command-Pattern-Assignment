using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isGameRunning;

    private void Awake()
    {
        isGameRunning = true;
    }

    public bool GetIsGameRunning()
    {
        return isGameRunning;
    }

    public void SetIsGameRunning(bool isGameRunning)
    {
        this.isGameRunning = isGameRunning;
    }

    public void StopGame()
    {
        SetIsGameRunning(false);
        StartCoroutine(WaitToRestart());
    }
    
    IEnumerator WaitToRestart()
    {
        yield return new WaitForSeconds(2f);
        Restart();
    }

    private void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    

}
