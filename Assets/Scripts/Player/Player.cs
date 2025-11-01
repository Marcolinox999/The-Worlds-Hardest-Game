using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    //creates a varieble to hold the initial position
    private Vector3 initialPosition;
    //Number of coins
    private int coins;
    [SerializeField] private TMP_Text Scoreboard;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite Ying;
    [SerializeField] private Sprite Yang;
    [SerializeField] private string nextLevel;
    
    
    
    private bool isInMirrorWorld=false;
    float mirrorTimer = 0;
    public float hInput = 0;
    public float vInput = 0;
    
    
    
    
    // a way of call an object :[SerializeField] private GameObject Example;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float speed = 1;
    void Start()
    {
        //at the start the initial position variable is saved as the coordinates the player starts
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mirrorTimer += Time.deltaTime;
        Movement();
        if (coins == 4)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

    private void Movement()
    {
        if (isInMirrorWorld == false)
        {
            //Movement();
             hInput = Input.GetAxisRaw("Horizontal"); //-1 or 1 depending on the axes
             vInput = Input.GetAxisRaw("Vertical");
            //normalized: make the vector to have a magnitude of 1.
            Vector3 movementDirection = new Vector3(hInput, vInput, 0).normalized;

            //gameObject.transform.position +=  movementDirection * speed * Time.deltaTime; (space.world for world parameters
            transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
        }
        else
        {


            //Movement();
             hInput = Input.GetAxisRaw("Horizontal"); //-1 or 1 depending on the axes
             vInput = Input.GetAxisRaw("Vertical");
            //normalized: make the vector to have a magnitude of 1.
            Vector3 movementDirection = new Vector3(-hInput, -vInput, 0).normalized;
            //gameObject.transform.position +=  movementDirection * speed * Time.deltaTime; (space.world for world parameters
            transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
        }
    }

    //YOU NEED both of the objects have a collider. MANDATORY
    //for an ontrigger works at least one of the objects need to be checked as istriggered
    // at least one of them should have a rigidbody
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Checks if the tags is coin and the one triggered
        if (other.gameObject.CompareTag("Coin"))
        {
            UpdateCoins(other);
        }

        if (other.gameObject.CompareTag("Trap"))
        {
            Debug.Log("ouch!!");
            //destroys the gameObject, if you only use other it will destroy the collider2D
            //Destroy(this.gameObject);
            this.gameObject.transform.position = initialPosition;
        }

        if (other.gameObject.CompareTag("Mirror"))
        {
            mirrorTimer = 0;
        }

        if (other.gameObject.CompareTag("Inverted"))
        {
            if (hInput != 0 || vInput != 0)
            {
                Debug.Log("inverted");
                gameObject.transform.position = initialPosition;
            }
        }

        if (other.gameObject.CompareTag("Reality"))
        {
            mirrorTimer = 0;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Mirror"))
        {
            if (mirrorTimer >= 0.3f )
            {
                spriteRenderer.sprite = Yang;
                isInMirrorWorld = true; 
            }
        }
        if (other.gameObject.CompareTag("Inverted"))
        {
            if (hInput != 0 || vInput != 0)
            {
                Debug.Log("inverted");
                gameObject.transform.position = initialPosition;
            }
        }
        if (other.gameObject.CompareTag("Reality"))
        {
            if (mirrorTimer >= 0.3f)
            {
                isInMirrorWorld = false;
                spriteRenderer.sprite = Ying;
            }
        }
    }

    
    private void UpdateCoins(Collider2D other)
    {
        Debug.Log("chicling!");
        coins++; // adds a coin for each collision
        //destroys the gameObject that THIS OBJECT IS TOUCHING (The coin not the player), if you only use other it will destroy the collider2D
        Destroy(other.gameObject);
        // updates the scoreboard  adding a coin each time the player gets one
        Scoreboard.text = "Score: " + coins;
    }

    void Movement2()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position += new Vector3(0, 5, 0) * Time.deltaTime;;
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position += new Vector3(-5, 0, 0)* Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position += new Vector3(0, -5, 0)* Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(5, 0, 0)* Time.deltaTime;
        }
    }
}
