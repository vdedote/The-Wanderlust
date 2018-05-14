using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObjective : MonoBehaviour {

    [SerializeField]
    private Button Pickup;

    [SerializeField]
    private GameObject check;

    [SerializeField]
    private GameObject objective;

    [SerializeField]
    private GameObject guides;

    [SerializeField]
    private GameObject Exitbutton;

    // Use this for initialization
    void Start ()
    {
        Button pickupbtn = Pickup.GetComponent<Button>();
        pickupbtn.onClick.AddListener(PickObjective);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (objective.activeInHierarchy == false)
        {
            print("Button Exit Activated");
            Exitbutton.SetActive(true);
        }
    }

    void PickObjective()
    {
        check.SetActive(true);
        objective.SetActive(false);
        guides.SetActive(false);
    }
}
