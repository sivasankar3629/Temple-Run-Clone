using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementSccript : MonoBehaviour
{
    Rigidbody rb;
    float forward;
    float sideWays;
    float speed = 5;
    [SerializeField] private Text scoreText;
    float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        forward = Input.GetAxis("Vertical");
        sideWays = Input.GetAxis("Horizontal");
        rb.transform.Translate(new Vector3(sideWays, 0, forward) * Time.deltaTime * speed);
    }

    void OnCollisionEnter (Collision collision){
        if (collision.collider.tag == "Obs"){
            Debug.Log("obstacle hit");
            score++;
            Destroy(collision.collider);
            scoreText.text = score.ToString();
        }

        if (collision.collider.tag == "Boundary"){
            Debug.Log("Game Over");
            
        }
    }
}
