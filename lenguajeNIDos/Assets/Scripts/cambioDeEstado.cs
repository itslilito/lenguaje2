using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioDeEstado : MonoBehaviour
{
    //Declaraci�n de variables
    public KeyCode click;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Si se hace presiona y se suelta el input designado por la variable "click" (el bot�n izquierdo del
         mouse en este caso), se activa el trigger "clickIzquierdo" del animator designado por la variable
        "anim"
         */
        if (Input.GetKeyUp(click)) {
            anim.SetTrigger("clickIzquierdo");
        }
    }
}
