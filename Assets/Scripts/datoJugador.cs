using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class datoJugador : MonoBehaviour
{
    public float vidaJugador;
    public Slider barraVidaJugador;
   
    private void Update()
    {
        barraVidaJugador.value = vidaJugador;
        
        if (vidaJugador <= 0)
        {
            print("Game Over");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyScript enemyScript = other.GetComponent<EnemyScript>();

            if (enemyScript != null)
            {
                recibirDano(10);
            }
        }
    }

    public void recibirDano(float dmg)
    {
        vidaJugador = vidaJugador - dmg;
    }


    public float damage(float dmg){
       return vidaJugador -= dmg;
    }
}

