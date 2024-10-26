using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    PlayerMovement player;
    private void Start(){
        GameObject gob = GameObject.FindWithTag("play");
        player = gob.GetComponent<PlayerMovement>();
    }
    int hitCount = 0;
    private void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "play"){
            GetComponent<MeshRenderer>().material.color = Color.red;
            player.hitCount++;
            Debug.Log("HIT: " + player.hitCount);
        }
    }
}