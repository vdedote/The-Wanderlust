using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    [SerializeField]
    private GameObject PauseMenuUi;

    [SerializeField]
    private GameObject PauseButton;

    [SerializeField]
    private GameObject WalkRight;

    [SerializeField]
    private GameObject WalkLeft;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }	
	}

    public void Resume()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        PauseButton.SetActive(true);
        WalkLeft.SetActive(true);
        WalkRight.SetActive(true);
    }

    public void Pause()
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

        PauseButton.SetActive(false);
        WalkLeft.SetActive(false);
        WalkRight.SetActive(false);
        
    }

    public void Reload()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/Philippines");
    }

}

