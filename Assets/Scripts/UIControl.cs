using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour {
    public GameObject escapeMenu;
    // Start is called before the first frame update
    void Awake () {
        escapeMenu.SetActive (false);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.Escape) && escapeMenu.activeInHierarchy == false) {
            escapeMenu.SetActive (true);
            print ("show");
            Cursor.lockState = CursorLockMode.None;
        } else if (Input.GetKeyDown (KeyCode.Escape) && escapeMenu.activeInHierarchy == true) {
            escapeMenu.SetActive (false);
            print ("deactive");
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void NotShowing () {

    }

}