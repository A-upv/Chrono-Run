using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hitboxe : MonoBehaviour
{
    public GameObject barravida;
    public float dmg;

    private float itime;
    public Vector3 knockback;
    
    // Start is called before the first frame update
   
    public datoJugador dato;
    void Start(){
        
        dato = barravida.GetComponent<datoJugador>();
        
    }

    private void Update(){
        

    }
    private void OnTriggerEnter(Collider other) {
        print(other.tag);
         if(other.tag == "enemy"){
            print(other.tag);
            print( dato.damage(dmg));
            dato.damage(dmg);
            transform.position = transform.position + knockback;
          
         }
    }
    
}

