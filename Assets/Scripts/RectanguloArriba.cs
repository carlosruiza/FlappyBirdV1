using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectanguloArriba : MonoBehaviour
{
    private Jugador Jugador;

    // Start is called before the first frame update
    void Start()
    {
        Jugador = FindObjectOfType<Jugador>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Jugador.transform.position.x - transform.position.x >12)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Jugador.Reinicio();
    }

}
