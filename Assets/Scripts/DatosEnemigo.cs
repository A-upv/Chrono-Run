using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosEnemigos : MonoBehaviour
{
    public float danoEnemigo;
    public float vidaEnemigo;
    private float vidaActualEnemigo;
    public Slider barraVidaEnemigo;

    private DatosJugador datoJugador;

    [SerializeField] private float tiempoEntreDano;
    private float tiempoSiguienteDano;

    private void Start()
    {
        vidaActualEnemigo = vidaEnemigo;
    }

    private void Update()
    {
        tiempoSiguienteDano -= Time.deltaTime;
        barraVidaEnemigo.value = vidaActualEnemigo;
    }

    // CUANDO ESTEN LAS ANIMACIONES EL DA�O SE HAR� DESDE EL SCRIPT DEL JUGADOR

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            datoJugador = other.GetComponent<DatosJugador>();

            if (tiempoSiguienteDano <= 0 && datoJugador != null)
            {
                datoJugador.recibirDano(15);
                tiempoSiguienteDano = tiempoEntreDano;
                Debug.Log("Da�o aplicado desde el enemigo: " + datoJugador.vidaActual);
            }
        }

        if (other.CompareTag("ArmaPlayer"))
        {
            // Recoger la variable da�o del jugador
            float da�o = 10;

            recibirDa�o(da�o);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            datoJugador = null;
        }
    }

    public void recibirDa�o(float da�o)
    {
        vidaActualEnemigo -= da�o;

        if(vidaActualEnemigo <= 0)
        {
            Destroy(gameObject);
        }
    }
}

