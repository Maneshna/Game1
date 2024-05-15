using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Update is called once per frame
    private void OnTriggeringEnter2D(Collider2D collision){
        if(collision.tag == "Border"){
            Destroy(this.gameObject);
        }
    }
}
