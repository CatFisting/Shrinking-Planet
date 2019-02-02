using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject planet;
    public float speed = 10f;

    void Update()
    {
        transform.up = -(planet.transform.position - transform.position).normalized;

        transform.position += -transform.right * speed * Time.deltaTime;
    }
}
