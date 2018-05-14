using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PhilippineMainMenu : MonoBehaviour {

    public Button[] levelButtons;

	// Use this for initialization
	void Start ()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached",1);

        for (int i = 0; i < levelButtons.Length ; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
            }
            
        }	
	}
	
    public void resetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    public void LoadGuaguaStory()
    {
        SceneManager.LoadScene("Story");
    }
    public void LoadBaguioStory()
    {
        SceneManager.LoadScene("BaguioStory");
    }
    public void LoadBoracayStory()
    {
        SceneManager.LoadScene("BoracayStory");
    }
}
