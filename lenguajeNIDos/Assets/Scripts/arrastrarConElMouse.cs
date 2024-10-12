using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrastrarConElMouse : MonoBehaviour
{
    Vector2 distancia = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Cuando se hace click
    private void OnMouseDown()
    {
        // Calcula la distancia entre la posici�n original del objeto y el lugar donde hacemos click
        distancia = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    // Cuando se arrastra el click (?
    private void OnMouseDrag()
    {
        /* Cambia la posici�n del objeto a la posici�n del mouse constantemente, restando la variable distancia
         para que se pueda arrastrar el objeto desde cualquier punto de su collider*/
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition)-distancia;
    }
}
