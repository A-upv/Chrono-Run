using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hitboxe : MonoBehaviour
{
    public GameObject barravida;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        print(other.tag);
        //if(other.tag == "Player"){
        //    barravida.datoJugador.vidaJugador -= barravida.datoJugador.dañoAJugador;
       // }
    }
}
