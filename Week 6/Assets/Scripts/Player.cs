using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Movement
    Rigidbody character;
    float playerSpeed = 9;
    float jumpPower = 9;
    float sideWays;

    public bool canMove = true;

    // Coin audio
    [SerializeField] AudioSource coinAudio;
    [SerializeField] AudioClip clip;

    [SerializeField] Animator animator;

    Vector3 movement;

    // Declaring Score variable
    public float score = 0;
    [SerializeField] Text scoreText;


    void Start()
    {
        // Getting Rigidbody
        character = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movement
        if (canMove)
        {
            sideWays = Input.GetAxis("Horizontal");
            movement = new Vector3(sideWays, 0, 0);
            if (Input.GetKey(KeyCode.Space))
            {
                movement.y = 2f;
                animator.SetBool("Jump", true);
            }
            else
            {
                movement.y = 0;
                animator.SetBool("Jump", false);
            }
            character.transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
            character.transform.Translate(movement * Time.deltaTime * jumpPower);

        }


        // Update score

        scoreText.text = score.ToString();



    }

    // Coin collision script

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Coin")
        {
            coinAudio.PlayOneShot(clip, 0.5f);
            Destroy(collider.gameObject);
            score++;

            // Increasing speed
            if (score % 2 != 0 && score < 150)
            {
                playerSpeed += 0.05f;
                //Debug.Log(playerSpeed);
            }
        }
    }
}
