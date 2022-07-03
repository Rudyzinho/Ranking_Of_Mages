using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterC : MonoBehaviour
{

    //Variáveis
    private Rigidbody2D rb2D;
    [SerializeField]
    private float jumForce;
    [SerializeField]
    private float moveSpeed;
    private bool isJumping;
    private float moveX;
 

    public Animator anim;


    
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        isJumping = false;
        
    }

    //Chama as animações e recebe os inputs de movimentação, além de ativar um impulso de pulo
    private void Update()
    {
        Animations();

        moveX = Input.GetAxisRaw("Horizontal");

        if (Input.GetButton("Jump") && Mathf.Abs(rb2D.velocity.y) < 0.001f)
        {
            rb2D.AddForce(new Vector2(0, jumForce), ForceMode2D.Impulse);
        }
    }

    //Movimentação do personagem no eixo X
    void FixedUpdate()
    {

        transform.position += new Vector3(moveX, 0, 0) * Time.deltaTime * moveSpeed;

        if (!Mathf.Approximately(0, moveX))
        {
            transform.rotation = moveX < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }


    }


    //verifica quando o player está em contato com a plataforma e define isJuping como false
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
    }

    //verifica quando o player não está em contato com a plataforma e define isJuping como true
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
    }


    //Ativa as animações respectivas a cada condicional
    public void Animations()
    {
        

        if (moveX != 0)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }


        anim.SetBool("Jump", isJumping);

    }
}