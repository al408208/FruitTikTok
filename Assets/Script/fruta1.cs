using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruta1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Choques i;
    void Start()
    {
        i=FindObjectOfType<Choques>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.CompareTag("fruta1") && collision.gameObject.CompareTag("fruta1"))
        {
            
            ContactPoint2D puntoDeContacto = collision.GetContact(0);
            Vector2 puntoMedio = (puntoDeContacto.point + (Vector2)transform.position) / 2f;
            i.colisiontipo+=0.5f;
            i.RecibirChoque(puntoMedio, Quaternion.identity);
            
            Destroy(gameObject);
        }
        if (this.gameObject.CompareTag("fruta2") && collision.gameObject.CompareTag("fruta2"))
        {
            
            ContactPoint2D puntoDeContacto = collision.GetContact(0);
            Vector2 puntoMedio = (puntoDeContacto.point + (Vector2)transform.position) / 2f;
            i.colisiontipo+=1.1f;
            i.RecibirChoque(puntoMedio, Quaternion.identity);
            
            Destroy(gameObject);
        }
        if (this.gameObject.CompareTag("fruta3") && collision.gameObject.CompareTag("fruta3"))
        {
            
            Destroy(gameObject);
        }
    }

}
