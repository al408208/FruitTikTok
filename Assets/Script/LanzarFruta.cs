using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarFruta : MonoBehaviour
{
    public GameObject[] misobjs;
    public GameObject fruta1;
    public GameObject fruta2;
    public GameObject fruta3;
    private int indiceAleatorio=0;
    
    void Start()
    {
        fruta1.SetActive(false);
        fruta2.SetActive(false);
        fruta3.SetActive(false);
        GenerarFruta();
        
    }
     void OnMouseDown()
    {
        Vector2 posicionClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       
        // Instanciar el objeto de fruta en la posición convertida
        Instantiate(misobjs[indiceAleatorio], posicionClick, Quaternion.identity);
        GenerarFruta();
    }

    void GenerarFruta()
    {
        if (misobjs.Length > 0)
        {
            float random = Random.Range(0f, 100f);
            if(random<=59f){
                indiceAleatorio=0;
            }else if(random>=60f && random<90f){
                indiceAleatorio=1;
            }else{
                indiceAleatorio=2;
            }
            // Elegir un índice aleatorio del array
            //int indiceAleatorio = Random.Range(0, misobjs.Length);

            next(indiceAleatorio);
            
        }
        else
        {
            Debug.LogWarning("¡No hay frutas en el array!");
        }
    }

    private void next(int sigue){
        if(sigue==0){

        fruta1.SetActive(true);
        fruta2.SetActive(false);
        fruta3.SetActive(false);
        }else if(sigue==1){
            
        fruta1.SetActive(false);
        fruta2.SetActive(true);
        fruta3.SetActive(false);
        }else{

        fruta1.SetActive(false);
        fruta2.SetActive(false);
        fruta3.SetActive(true);
        }
    }
}
