using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Librería para acceder a los componentes de la UI
using TMPro; //Librería para acceder a los TextMeshPro

public class Game : MonoBehaviour
{
    // Con esto podemos acceder al Texto de TextMeshPro de la UI

    [SerializeField] TextMeshProUGUI textComponent;

    //Referencia de tipo State (de la clase State), que usamos para poder acceder a las variables y métodos del script State

    State stateRef; //Este estado irá cambiando conforme avanza el juego

    //Será el estado inicial en el que empieza el juego

    [SerializeField] State startingState;

    // Start is called before the first frame update
    void Start()
    {
        //El estado actual será el estado inicial del juego
        stateRef = startingState;
        //Accedemos al componente text dentro del textComponent y metemos lo que haya dentro del campo storyText del estado actual
        textComponent.text = stateRef.GetStateText();
    }

    // Update is called once per frame
    void Update()
    {
        //Hacemos la llamada al método
        ManageStates();
    }

    //Método para manejar el cambio de estados
    void ManageStates()
    {
        //Creamos un array de estados a los que podemos ir desde el estado actual en el que estamos
        State[] nextStates = stateRef.GetNextStates();

        //Si pulsamos la tecla X pasamos al siguiente estado
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Del estado en el que esté pasa al siguiente estado que está en la posición del array 0
            stateRef = nextStates[0];            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Del estado en el que esté pasa al siguiente estado que está en la posición del array 0
            stateRef = nextStates[1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Del estado en el que esté pasa al siguiente estado que está en la posición del array 0
            stateRef = nextStates[2];
        }

        //Accedemos al componente text dentro del textComponent y metemos lo que haya dentro del campo storyText del estado actual
        textComponent.text = stateRef.GetStateText();
    }
}
