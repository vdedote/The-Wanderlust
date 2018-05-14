using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionTriggerforGuagua : MonoBehaviour {

    private BoxCollider2D playerCollider;

    [SerializeField]
    private BoxCollider2D Object;

    [SerializeField]
    private BoxCollider2D ObjectTrigger;

    [SerializeField]
    private GameObject Pickupbutton;

    // Use this for initialization
    void Start () {
        playerCollider = GameObject.Find("Player").GetComponent<BoxCollider2D>();
        Physics2D.IgnoreCollision(Object, ObjectTrigger, true);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Pickupbutton.SetActive(true);
            Physics2D.IgnoreCollision(Object, playerCollider, true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Pickupbutton.SetActive(false);
            Physics2D.IgnoreCollision(Object, playerCollider, true);
        }
    }
}
