using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectanguloAbajo : MonoBehaviour
{
    private Jugador Jugador;
    public GameObject RecArriba;
    private Score Score;

    private GameObject[] tubos = new GameObject[3];
    private GameObject tubo;

    // Start is called before the first frame update
    void Start()
    {
        Jugador = FindObjectOfType<Jugador>();
        tubos = Jugador.getTubos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Jugador.transform.position.x - transform.position.x > 12)
        {
            float yRandom = Random.Range(-3, 3);
            float RandomEspacio = Random.Range(0, 3);

            tubo = Instantiate(gameObject, new Vector2(Jugador.transform.position.x + 10, -7 + yRandom), transform.rotation);
            Instantiate(RecArriba, new Vector2(Jugador.transform.position.x + 10, 7 + yRandom + RandomEspacio), transform.rotation);
            Destroy(gameObject);

            addTubos(tubo);
        }

        if (tubos[0] && Jugador.transform.position.x > tubos[0].transform.position.x)
        {
            FindObjectOfType<Score>().Contador();
            shiftTubosArray();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Jugador.Reinicio();
    }

    private void shiftTubosArray()
    {
        tubos[0] = tubos[1];
        tubos[1] = tubos[2];
        tubos[2] = null;
    }

    private void addTubos(GameObject tubo)
    {
        if (!tubos[0])
        {
            tubos[0] = tubo;
        }
        else if (!tubos[1])
        {
            tubos[1] = tubo;
        }
        else
        {
            tubos[2] = tubo;
        }
    }
}
