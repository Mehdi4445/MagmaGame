using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouv : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Animator anim;
    public bool walk;
    public bool hurt;
    public bool jump;
    public bool die;
    public bool win;

    public GameObject WinUI;
    public GameObject LostUI;



    Rigidbody2D rb;
    private bool isGrounded;








    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        walk = false;
        jump = false;
        Time.timeScale = 1;

        WinUI.SetActive(false);
        LostUI.SetActive(false);




    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(win);
        walk = false;
        jump = false;
        die = false;

        walking();
        jumping();

 

        if (LostUI.activeSelf==true)
        {
            Time.timeScale = 0;
        }



        if (WinUI.activeSelf == true)
        {
            Time.timeScale = 0;
        }
    }

    public void walking()
    {
        if (Input.GetKey(KeyCode.LeftArrow) )
        {
            walk = true;
            transform.eulerAngles = new Vector3(0, 180, 0);
            transform.Translate(transform.right * -1 * Time.deltaTime * speed);

        }

        if (Input.GetKey(KeyCode.RightArrow) )
        {
            walk = true;
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.Translate(transform.right * 1 * Time.deltaTime * speed);
        }
        anim.SetBool("run", walk);
    }

    public void jumping()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {

            jump = true;
            rb.velocity += Vector2.up * jumpForce;
            anim.SetBool("jump", jump);
            isGrounded = false;


        }
        anim.SetBool("jump", jump);

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGrounded = true;

        }
        else
        {
            isGrounded = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag == "Fire")
        {
            Debug.Log("fire");
            anim.SetBool("death", die);
            LostUI.SetActive(true);
            
            Debug.Log(Time.timeScale);
            Time.timeScale = 0;

        }
        if (other.tag == "win")
        {
            Debug.Log(win);
            WinUI.SetActive(true);
            Debug.Log(Time.timeScale);
        }


    }
}
