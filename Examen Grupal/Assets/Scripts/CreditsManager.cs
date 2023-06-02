using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CreditsManager : MonoBehaviour
{
    public TextMeshProUGUI creditsText;
    public float nameDisplayInterval = 2f;
    public string[] groupMembers;

    private int creditsCount;
    private float elapsedTime;
    private int currentMemberIndex;

    private void Start()
    {
        creditsCount = PlayerPrefs.GetInt("CreditsCount", 0);
        creditsCount++;
        PlayerPrefs.SetInt("CreditsCount", creditsCount);
        Debug.Log("Credits count: " + creditsCount);

        currentMemberIndex = 0;
        elapsedTime = 0f;
        DisplayNextMember();
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= nameDisplayInterval)
        {
            elapsedTime = 0f;
            DisplayNextMember();
        }
    }

    private void DisplayNextMember()
    {
        if (currentMemberIndex < groupMembers.Length)
        {
            creditsText.text = groupMembers[currentMemberIndex];
            currentMemberIndex++;
        }
        else
        {
            creditsText.text = "Créditos completos";
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
