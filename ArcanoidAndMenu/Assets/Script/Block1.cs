using UnityEngine;
using System.Collections;

public class Block1 : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        // Destroy the whole Block
        Destroy(gameObject);
    }
}