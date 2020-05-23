using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectanguloAbajo : MonoBehaviour
{
    private Jugador Jugador;
    public GameObject RecArriba;
    private Score Score;

    // Start is called before the first frame update
    void Start()
    {
        Jugador = FindObjectOfType<Jugador>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Jugador.transform.position.x - transform.position.x > 12)
        {
            float yRandom = Random.Range(-3, 3);
            float RandomEspacio = Random.Range(0, 3);

            Instantiate(gameObject, new Vector2(Jugador.transform.position.x + 10, -7 + yRandom), transform.rotation);
            Instantiate(RecArriba, new Vector2(Jugador.transform.position.x + 10, 7 + yRandom + RandomEspacio), transform.rotation);
            Destroy(gameObject);
          //  FindObjectOfType<Score>().Contador();
        }


        if (Jugador.transform.position.x > transform.position.x)
        {
            FindObjectOfType<Score>().Contador();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Jugador.Reinicio();
    }



}
