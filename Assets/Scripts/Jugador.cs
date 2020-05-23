using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{

    public Rigidbody2D cuerpo;
    public float velocidad;
    public float altura;
    public GameObject RecArriba;
    public GameObject RecAbajo;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Construirnivel(); 
    }


    public void Construirnivel()
    {
        Instantiate(RecAbajo, new Vector3(10,-8), transform.rotation);
        Instantiate(RecArriba, new Vector3(10, 8), transform.rotation);

        Instantiate(RecAbajo, new Vector3(17, -10), transform.rotation);
        Instantiate(RecArriba, new Vector3(17, 6), transform.rotation);

        Instantiate(RecAbajo, new Vector3(24, -8), transform.rotation);
        Instantiate(RecArriba, new Vector3(24, 10), transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        cuerpo.velocity = new Vector2(velocidad, cuerpo.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            cuerpo.velocity = new Vector2(cuerpo.velocity.x, altura);
            anim.SetTrigger("Rotacion");
            StartCoroutine(StopMoving());

             
        }

        if (transform.position.y > 13 || transform.position.y < -13)
        {
            Reinicio();
        }
    }

    private IEnumerator StopMoving ()
    {
       yield return new WaitForSeconds(0.5f);
        anim.SetTrigger("Estatico");
    }
    public void Reinicio()
    {
        SceneManager.LoadScene(0);
    }
}
