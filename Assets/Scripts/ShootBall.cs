using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    [SerializeField] private float force;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
              GetComponent<Rigidbody>().AddRelativeForce(force, 0, 0);
        }

    }
}
