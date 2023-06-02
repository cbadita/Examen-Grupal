using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefeatScreenManager : MonoBehaviour
{
    private int defeatCount;

    private void Start()
    {
        defeatCount = PlayerPrefs.GetInt("DefeatCount", 0);
        defeatCount++;
        PlayerPrefs.SetInt("DefeatCount", defeatCount);
        Debug.Log("Defeat count: " + defeatCount);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}