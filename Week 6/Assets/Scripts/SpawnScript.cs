using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScripty : MonoBehaviour
{
    [SerializeField] GameObject player;
    

    [SerializeField] GameObject segment;

    Vector3 pos;
    

    // Spawning Segments

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            
            pos = new Vector3(0, 0, transform.position.z + 280);
            Instantiate(segment, pos, Quaternion.identity);

        }
    }

    
}
