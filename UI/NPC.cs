using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public GameObject textBox;
    public TextMeshProUGUI text;
    public string dialogue;
    public string itemDialogue;
    public bool offeringItem;
    private bool playerIsClose;
    public GameObject offers;

    private void Awake() {
        textBox.SetActive(false);
    }
    private void Update() {
        if (playerIsClose) {
            clearText();
            clearItem();
            textBox.SetActive(true);
            if (offeringItem) {
                text.text = itemDialogue;
                offers.SetActive(true);
            }
            else {
                text.text = dialogue;
            }
        }
    }
    private void clearText() {
        text.text = "";
        textBox.SetActive(false);
    }

    private void clearItem() {
        if (offers != null)
            offers.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            playerIsClose = false;
            textBox.SetActive(false);
        }
    }

    public void offerTaken() {
        offeringItem = false;
    }
}
