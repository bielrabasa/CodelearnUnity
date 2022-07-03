using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class ballBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float maxVelocity = 10.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.y > maxVelocity)
        {
            rb.velocity = new Vector3(0, maxVelocity, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ENEMY")
        {
            transform.SetPositionAndRotation(new Vector3(2.5f, 10.0f, 0.0f), Quaternion.identity);
            rb.velocity = new Vector3(0, 2, 0);
        }
        
        if (collision.gameObject.tag == "END")
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
