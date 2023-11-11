using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class datoEnemigo : MonoBehaviour
{
    public int dañoAEnemigo;
    public int vidaEnemigo;
    public Slider barraVidaEnemigo;

    private void Update()
    {
        barraVidaEnemigo.value = vidaEnemigo;

        if (vidaEnemigo <= 0)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            vidaEnemigo -= dañoAEnemigo;
        }
    }
}

