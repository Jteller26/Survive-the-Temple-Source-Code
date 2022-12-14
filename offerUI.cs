using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class offerUI : MonoBehaviour
{
    public GameObject textBox;
    public TextMeshProUGUI text;
    public string dialogue;
    public bool playerIsClose;
    public bool itemIsGiven = false;

    private void Awake() {
        textBox.SetActive(false);
        GetComponent<dialogueUI>().enabled = false;
    }
    private void Update() {
        if (playerIsClose && !itemIsGiven) {
            clearText();
            textBox.SetActive(true);
            text.text = dialogue;
        }
    }

    private void clearText() {
        text.text = "";
        textBox.SetActive(false);
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

    public void selectItem(int option) {
        print("Option Selected: " + option);
        itemIsGiven = true;
        textBox.SetActive(false);
        GetComponent<dialogueUI>().enabled = true;
    }
}
