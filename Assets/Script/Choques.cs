using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choques : MonoBehaviour
{
    public float colisiontipo=0f;
    public GameObject fruta2;
    public GameObject fruta3;
    
     public string[] tagsObjetosADestruir = { "fruta1", "fruta2", "fruta3"}; // Tags de los objetos que deseas destruir

    public void DestruirObjetosPorTags()
    {
        GameObject[] todosLosObjetos = GameObject.FindObjectsOfType<GameObject>();

        foreach (GameObject objeto in todosLosObjetos)
        {
            foreach (string tag in tagsObjetosADestruir)
            {
                if (objeto.CompareTag(tag))
                {
                    Destroy(objeto);
                    break; // Salir del bucle al destruir el objeto
                }
            }
        }
    }
        
    
    public void RecibirChoque(Vector2 punto, Quaternion rotacion){
       
        if(colisiontipo==1f){
            Instantiate(fruta2, punto, rotacion);
            colisiontipo=0f;
        }
        if(colisiontipo==2.2f){
            Instantiate(fruta3, punto, rotacion);
            colisiontipo=0f;
        }
        
    }
}
