using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamaraJugador : MonoBehaviour
{
    public Rigidbody2D cuerpo;
    public float velocidad;
    public float altura;

    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        cuerpo.velocity = new Vector2(velocidad, cuerpo.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            cuerpo.velocity = new Vector2(cuerpo.velocity.x, altura);
        }

    }
}
