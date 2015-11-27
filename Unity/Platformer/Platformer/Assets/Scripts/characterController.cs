using UnityEngine;

public class characterController : MonoBehaviour 
{
    public float maxSpeed = 10f;
    public float jumpForce = 700f;
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float score;
    public float move;
    public bool facingRight = true;
    public bool grounded = false;

    private GameObject star;

    void Start () 
    {
        Debug.Log("Script is alive!");
    }

    private void FixedUpdate () 
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        move = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    private void Update()
    {
        if (grounded && (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow))) 
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        if (move > 0 && !facingRight)
        {
            Flip();
        }
        else if (move < 0 && facingRight)
        {
            Flip();
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "star")
        {
            score++;
            Destroy(col.gameObject);
        }
        else if ((col.gameObject.name == "dieCollider") || (col.gameObject.name == "saw"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        else if (col.gameObject.name == "endLevel") 
        {
            if (!(GameObject.Find("star")))
            {
                Application.LoadLevel("scene2");
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.name == "saw")
        {
            
        }
    }

    public void OnGUI()
    {
        GUI.Box (new Rect (0, 0, 100, 100), "Stars: " + score);
    }
}
