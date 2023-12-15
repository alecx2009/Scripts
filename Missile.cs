using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 2;
    // Update is called once per frame
    void Update()
    {
        transform.position +=
        transform.forward *
        speed * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(other.gameObject);
    }

    void Start()
    {
        Destroy(gameObject, 3);
    }

}
