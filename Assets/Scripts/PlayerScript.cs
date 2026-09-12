using UnityEngine;
using UnityEditor;
using TMPro;
public class PlayerScript : MonoBehaviour
{

    public Rigidbody2D rb;
    [SerializeField] private float _jumpForce = 10f;
    private bool _isGrounded;
    [SerializeField] private TMP_Text _score;
    private float _currentScore;


    private void _CollectCoin()
    {
        _currentScore += 1;
        _score.text = "Score - " + _currentScore;
    }

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    void Start()
    {   _currentScore = 0;
        _score.text = "Score - " + _currentScore;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetButtonDown("Jump") && _isGrounded == true)
        {
            rb.AddForce(Vector2.up * _jumpForce,ForceMode2D.Impulse);  
        }
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        _CollectCoin();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        _isGrounded = true;
        Debug.Log("Grounded");
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
        Debug.Log("Not Grounded");
    }
}
