using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {
    void Update() {
        Vector2 mousePos = Input.mousePosition;

        mousePos.x += 100;
        mousePos.y -= 50;
        
        transform.position = mousePos;
    }
}
