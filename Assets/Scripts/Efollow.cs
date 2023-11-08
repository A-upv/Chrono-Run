using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efollow : MonoBehaviour
{
    public float speed = 1.0f;
    [SerializeField]public Transform target;
   
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        
    }
}
