using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private Texture newTexture;

    private void Update()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Renderer>().material.mainTexture = newTexture;
        GetComponent<Rigidbody>().useGravity = true;
        Destroy(other.gameObject);
    }
}
