using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StagesPhilippines : MonoBehaviour {
    public void LoadGuagua()
    {
        SceneManager.LoadScene("Guagua");
    }
    public void LoadGuaguaStory()
    {
        SceneManager.LoadScene("Story");
    }
    public void LoadBaguio()
    {
        SceneManager.LoadScene("Baguio");
    }
    public void LoadBaguioStory()
    {
        SceneManager.LoadScene("BaguioStory");
    }
    public void LoadBoracay()
    {
        SceneManager.LoadScene("Boracay");
    }
    public void LoadBoracayStory()
    {
        SceneManager.LoadScene("BoracayStory");
    }
}
