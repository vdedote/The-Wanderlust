using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionTriggerforBoracay : MonoBehaviour {

    private BoxCollider2D playerCollider;

    [SerializeField]
    private BoxCollider2D Tree;

    [SerializeField]
    private BoxCollider2D TreeTrigger;

    [SerializeField]
    private GameObject Interactbutton;

    // Use this for initialization
    void Start () {
        playerCollider = GameObject.Find("Player").GetComponent<BoxCollider2D>();
        Physics2D.IgnoreCollision(Tree, TreeTrigger, true);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Interactbutton.SetActive(true);
            Physics2D.IgnoreCollision(Tree, playerCollider, true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Interactbutton.SetActive(false);
            Physics2D.IgnoreCollision(Tree, playerCollider, true);
        }
    }
}
