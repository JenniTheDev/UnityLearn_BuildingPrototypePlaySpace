using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using UnityEngine;

public class Lootable : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void Loot(int digSwings) {
        if (digSwings > UnityEngine.Random.Range(0, 4)) {
            Instantiate(Resources.Load("Chest"), transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }



}
