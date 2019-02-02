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

        AdjustPosition();
    }

    public void AdjustPosition()
    {
        //LayerMask mask = LayerMask.GetMask("Planet");
        if (!Physics.Raycast(transform.position - new Vector3(0f,GetComponent<BoxCollider>().bounds.extents.y), -transform.up, .1f))
        {
            transform.position += -transform.up * .1f;
        }
    }
}
