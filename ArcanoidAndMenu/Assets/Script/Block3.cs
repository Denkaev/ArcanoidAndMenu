using UnityEngine;
using System.Collections;

public class Block3 : MonoBehaviour {

 public GameObject destroyed_ob;

    void OnCollisionEnter2D(Collision2D collisionInfo) {
         GameObject destroy_ob = Instantiate (destroyed_ob, this.transform.position, this.transform.rotation) as GameObject;
         Destroy(gameObject);
    }

}

