using UnityEngine;
using UnityEditor;
public class PlayerScript : MonoBehaviour
{

    public Rigidbody2D rb;
    [SerializeField] private float _jumpForce = 10f;


    // [SerializeField] private
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("KeyCode.Space"))
        {
            rb.AddForce(Vector2.up * _jumpForce,ForceMode2D.Impulse);  
        }
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        
    }
}
