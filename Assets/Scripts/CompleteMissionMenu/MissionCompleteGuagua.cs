using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionCompleteGuagua : MonoBehaviour {

    public static bool GameComplete = false;

    [SerializeField]
    private GameObject MissionCompleteUI;

    [SerializeField]
    private GameObject WalkRight;

    [SerializeField]
    private GameObject WalkLeft;

    [SerializeField]
    private GameObject PauseButton;

    public string nextLevel = "BaguioStory";
    public int leveltoUnlock = 2;

    public void MissionCompleteUi()
    {
        MissionCompleteUI.SetActive(true);
        Time.timeScale = 0f;
        GameComplete = true;

        PauseButton.SetActive(false);
        WalkLeft.SetActive(false);
        WalkRight.SetActive(false);

    }

    public void WinLevel()
    {
        PlayerPrefs.SetInt("levelReached", leveltoUnlock);
        PlayerPrefs.SetInt("CollectionsUnlocked",1);
    }

    public void NextStage()
    {
        PlayerPrefs.SetInt("levelReached", leveltoUnlock);
        PlayerPrefs.SetInt("CollectionsUnlocked",1);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/StagesInPhilippines/Boracay/BoracayStory");
    }

    public void Reload()
    {
        PlayerPrefs.SetInt("levelReached", leveltoUnlock);
        PlayerPrefs.SetInt("CollectionsUnlocked",1);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        PlayerPrefs.SetInt("levelReached", leveltoUnlock);
        PlayerPrefs.SetInt("CollectionsUnlocked",1);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/Philippines");
    }
}
