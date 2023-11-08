using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class datoJugador : MonoBehaviour
{
    public int dañoAJugador;
    public int vidaJugador;
    public Slider barraVidaJugador;

    private void Update()
    {
        barraVidaJugador.value = vidaJugador;

        if (vidaJugador <= 0)
        {
            print("Game Over");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            vidaJugador -= dañoAJugador;
        }
    }
}

