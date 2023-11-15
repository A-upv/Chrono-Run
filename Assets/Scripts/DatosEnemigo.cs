using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosEnemigos : MonoBehaviour
{
    public float danoEnemigo;
    public float vidaEnemigo;
    public Slider barraVidaEnemigo;

    private void Update()
    {
        if (vidaEnemigo <= 0)
        {
            Destroy(gameObject);
        }
    }
}

