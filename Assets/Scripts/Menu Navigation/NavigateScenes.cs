using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NavigateScenes : MonoBehaviour
{
    public Animator FadeAnimate;
    public Image BlackIMG;

    public void Navigate()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(Fade());
        //SceneManager.LoadScene("CountrySelection");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator Fade()
    {
        FadeAnimate.SetBool("Fade", true);
        yield return new WaitUntil(() => BlackIMG.color.a == 1);
        
    }

    public void Quit()
    {
        Application.Quit(); 
    }
}
