using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton instance for easy access
    // To hold the same single object
    public static GameManager instance;

    // References to enemy groups and player
    public GameObject enemiesTop;

    public GameObject enemiesMid;
    public GameObject enemiesBot;
    public GameObject player;

    // TextMeshPro UI element for displaying the score
    public TMP_Text scoreTxt;

    // Variables for tracking the score
    //store the amount of score set from the inspector
    private int score;

    // how much score you want to give to player
    public int scoreAmount;

    // UI panels for Win and Lose scenarios
    public GameObject WinPannel;

    public GameObject losePannel;

    // Called when the script instance is being loaded
    private void Start()
    {
        // Set the instance to this script, creating a singleton
        // only for object on which the script is applied on (Game manager)
        instance = this;

        // Initialize UI and state
        scoreTxt.text = "Score:00";
        WinPannel.SetActive(false);
        losePannel.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        // Check if all enemy groups are destroyed to show the Win panel
        if (enemiesTop.transform.childCount == 0 &&
            enemiesMid.transform.childCount == 0 &&
            enemiesBot.transform.childCount == 0)
        {
            WinPannel.SetActive(true);
        }
        // Check if the player is null (destroyed) to show the Lose panel
        else if (player == null)
        {
            losePannel.SetActive(true);
        }
    }

    // Method to add score and update the score UI
    public void AddScore()
    {
        // stores the score amount in the variable 
        score += scoreAmount;
        // updating UI score
        scoreTxt.text = "Score:" + score;
    }

    // Method to load the restart level 
    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
}