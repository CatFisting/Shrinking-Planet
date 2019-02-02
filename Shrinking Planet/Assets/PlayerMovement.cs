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

        transform.position += transform.forward * speed * Time.deltaTime;

        Debug.DrawRay(transform.position, transform.forward * 5, Color.red);
    }

    public void AdjustPosition()
    {
        LayerMask mask = LayerMask.GetMask("Planet");
        if (Physics.Raycast(transform.position, -transform.up, .1f, mask))
        {

        }
    }
}
