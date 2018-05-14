using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionManager : MonoBehaviour
{
    public Button[] Collections;

	// Use this for initialization
	void Start ()
    {
        int CollectionsUnlocked = PlayerPrefs.GetInt("CollectionsUnlocked", 0);

        for (int i = 0; i < Collections.Length; i++)
        {
            if (i + 1 > CollectionsUnlocked)
            {
                Collections[i].interactable = false;
            }
           
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
