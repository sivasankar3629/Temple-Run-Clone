using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    [SerializeField] GameObject player;


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 9);
    }
    void OnTriggerEnter(Collider collider)
    {
        
        if (collider.tag == "Segment")
        {
            Destroy(collider.gameObject);
            Debug.Log("Collided");
        }
    }
}
