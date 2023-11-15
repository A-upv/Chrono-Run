using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocionSalud : MonoBehaviour
{
    public float curacion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<DatosJugador>().curarVida(curacion);
        }
    }
}
