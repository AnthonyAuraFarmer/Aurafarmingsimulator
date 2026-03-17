using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody2D Auraplayer;

    public float speed;

    public float jumpForce;

    public bool Grounded = true;

    public TMP_Text AuraText;
    
    public int aura = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Auraplayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Grounded)
        {
            Auraplayer.AddForce(Vector2.up * jumpForce);
            Grounded = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Auraplayer.AddForce(Vector2.left * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Auraplayer.AddForce(Vector2.right * speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Grounded = true;
    }

    
    private void OnTriggerEnter2D(Collider2D other)
     {
        aura++;
        AuraText.text = aura.ToString();
     } 
         
}