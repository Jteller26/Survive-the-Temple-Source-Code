using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDisableOnStart : MonoBehaviour
{
    public GameObject obj;
    private void Awake() {
        obj.SetActive(false);
    }
}
