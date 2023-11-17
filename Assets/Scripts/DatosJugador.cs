using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosJugador : MonoBehaviour
{
    public float vidaJugadorInicial;
    public float vidaActual;
    public Slider barraVidaJugador;
   
    private void Start()
    {
        vidaActual = vidaJugadorInicial;
        //barraVidaJugador.value = vidaActual;
    }

    private void Update()
    {
        //barraVidaJugador.value = vidaActual;
    }

    public void recibirDano(float dmg)
    {
        vidaActual -= dmg;
        Debug.Log(vidaActual);
        //barraVidaJugador.value = vidaActual;

        if (vidaActual <= 0)
        {
            //Código para la muerte
            //Destroy(gameObject);
        }
    }

    public void curarVida(float cura)
    {
        vidaActual += cura;

        if (vidaActual > vidaJugadorInicial)
        {
            vidaActual = vidaJugadorInicial;
        }
        //barraVidaJugador.value = vidaActual;        
    }
}

