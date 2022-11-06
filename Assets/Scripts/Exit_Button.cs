using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit_Button : MonoBehaviour
{
    Button myButton;

    void Start() {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(ExitFunction);
    }

    void ExitFunction() {
        Application.Quit();
    }
}
