using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCrater : MonoBehaviour
{
    [SerializeField] GameObject craterPrefab;
    [SerializeField] GameObject planet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Planet")) {
            GameObject crater = Instantiate(craterPrefab, collision.GetContact(0).point, Quaternion.identity);
            crater.transform.forward = collision.GetContact(0).normal;
            Vector3 direction = crater.transform.position - planet.transform.position;
            crater.transform.position = direction * 0.1f;
            Destroy(gameObject);
        }
    }
}
