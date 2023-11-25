using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    float posicionY = 2.8f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(-5f, -2.8f);
    }

    // Update is called once per frame
    void Update()
    {
        posicionY = transform.position.y;
        
        //Si pulsamos las teclas arriba y abajo asignadas en el eje vertical, el selector se va a mover arriba o abajo
        //if (Input.GetAxis("Vertical") == 1) //Si estamos pulsando Arriba
        //{
        //    //Que el selector vaya a la posici�n (Coge la posici�n de este objeto en el transform y lo cambia por el vector que le pasamos)
        //    transform.position = new Vector2(-5f, -2.8f);
        //}
        //else if (Input.GetAxis("Vertical") == -1) //Si estamos pulsando abajo
        //{
        //    // Que el selector vaya a la posici�n(Coge la posici�n de este objeto en el transform y lo cambia por el vector que le pasamos)
        //    transform.position = new Vector2(-5f, -4.6f);
        //}

        //Si lo hacemos de esta manera el movimiento, se hace una vez cada bucle total del juego
        //Da igual los Fps, se har� una vez por segundo

        //Si pulsamos las teclas arriba y abajo, el selector se va a mover arriba o abajo
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) //Si estamos pulsando arriba
        {
            //Que el selector vaya a la posici�n (Coge la posici�n de este objeto en el transform y lo cambia por el vector que le pasamos)
            transform.position = new Vector2(-5f, -2.8f);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) //Si estamos pulsando abajo
        {
            // Que el selector vaya a la posici�n(Coge la posici�n de este objeto en el transform y lo cambia por el vector que le pasamos)
            transform.position = new Vector2(-5f, -4.2f);
        }

        if (posicionY == -2.8f && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }

        if (posicionY == -4.2f && Input.GetKeyDown(KeyCode.Space))
        {
            Application.Quit();
        }
    }
}
