using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si pulsamos las teclas arriba y abajo asignadas en el eje vertical, el selector se va a mover arriba o abajo
        //if (Input.GetAxis("Vertical") == 1) //Si estamos pulsando Arriba
        //{
        //    //Que el selector vaya a la posición (Coge la posición de este objeto en el transform y lo cambia por el vector que le pasamos)
        //    transform.position = new Vector2(-5f, -2.8f);
        //}
        //else if (Input.GetAxis("Vertical") == -1) //Si estamos pulsando abajo
        //{
        //    // Que el selector vaya a la posición(Coge la posición de este objeto en el transform y lo cambia por el vector que le pasamos)
        //    transform.position = new Vector2(-5f, -4.6f);
        //}

        //Si lo hacemos de esta manera el movimiento, se hace una vez cada bucle total del juego
        //Da igual los Fps, se hará una vez por segundo

        //Si pulsamos las teclas arriba y abajo, el selector se va a mover arriba o abajo
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) //Si estamos pulsando arriba
        {
            //Que el selector vaya a la posición (Coge la posición de este objeto en el transform y lo cambia por el vector que le pasamos)
            transform.position = new Vector2(-5f, -2.8f);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) //Si estamos pulsando abajo
        {
            // Que el selector vaya a la posición(Coge la posición de este objeto en el transform y lo cambia por el vector que le pasamos)
            transform.position = new Vector2(-5f, -4.6f);
        }
    }
}
