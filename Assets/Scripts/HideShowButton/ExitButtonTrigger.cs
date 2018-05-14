using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButtonTrigger : MonoBehaviour {


    [SerializeField]
    private GameObject Exitbutton;

    [SerializeField]
    private GameObject objective;

    // Use this for initialization
    void Start ()
    {  	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (objective.activeInHierarchy == false)
        {
            Exitbutton.SetActive(value: true);
        }
    }
}
