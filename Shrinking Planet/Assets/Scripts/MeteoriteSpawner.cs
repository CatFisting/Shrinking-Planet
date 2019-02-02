using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteSpawner : MonoBehaviour
{

    [SerializeField] GameObject meteoritePrefab;
    [SerializeField] GameObject planet;

    bool spawning = true;

    [SerializeField] float spawnerRadius = 15f;
    [SerializeField] float meteoriteSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMeteorite());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnMeteorite() {
        while (spawning) {
            Vector3 targetPos = Random.onUnitSphere * spawnerRadius;
            GameObject meteorite = Instantiate(this.meteoritePrefab, targetPos, Quaternion.identity);
            Vector3 direction = planet.transform.position - meteorite.transform.position;
            meteorite.transform.forward = direction;
            Rigidbody rb = meteorite.GetComponent<Rigidbody>();
            rb.velocity = direction * meteoriteSpeed;
            yield return new WaitForSeconds(3f);
        }
    }
}
