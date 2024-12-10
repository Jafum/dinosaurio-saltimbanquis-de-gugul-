using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] Animator animator;
    [SerializeField] float altura;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("parametro1", true);
            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(Vector2.up * altura);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("parametro1", false);
    }
 
}