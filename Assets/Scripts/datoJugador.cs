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

    public float damage(float dmg){
       return vidaJugador -= dmg;
        
    }
}

