using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoEnemigo : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDano;
    [SerializeField] public Transform target;

    private float tiempoSiguienteDano;
    private DatosJugador datoJugador;


    public float seguimientoRango = 10f;
    public float velocidadMovimiento = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        tiempoSiguienteDano -= Time.deltaTime;
        float distanciaAlJugador = Vector3.Distance(transform.position, target.position);

        if (distanciaAlJugador < seguimientoRango)
        {
            Vector3 direccionAlJugador = (target.position - transform.position);
            direccionAlJugador.y = 0f;
            direccionAlJugador.Normalize();

            //transform.Translate(direccionAlJugador * velocidadMovimiento * Time.deltaTime, Space.World);
            rb.AddForce(direccionAlJugador * velocidadMovimiento * Time.deltaTime, ForceMode.Force);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            datoJugador = other.GetComponent<DatosJugador>();

            if (tiempoSiguienteDano <= 0 && datoJugador != null)
            {
                datoJugador.recibirDano(15);
                tiempoSiguienteDano = tiempoEntreDano;
                Debug.Log("Daño aplicado desde el enemigo: " + datoJugador.vidaActual);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            datoJugador = null;
        }
    }
}
