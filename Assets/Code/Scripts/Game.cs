using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Librer�a para acceder a los componentes de la UI
using TMPro; //Librer�a para acceder a los TextMeshPro
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // Con esto podemos acceder al Texto de TextMeshPro de la UI

    [SerializeField] TextMeshProUGUI textComponent;

    //Referencia de tipo State (de la clase State), que usamos para poder acceder a las variables y m�todos del script State

    State stateRef; //Este estado ir� cambiando conforme avanza el juego

    //Ser� el estado inicial en el que empieza el juego

    [SerializeField] State startingState;

    public GameObject fondo;

    public Image imagenFondo;

    // Start is called before the first frame update
    void Start()
    {
        //El estado actual ser� el estado inicial del juego
        stateRef = startingState;
        //Accedemos al componente text dentro del textComponent y metemos lo que haya dentro del campo storyText del estado actual
        textComponent.text = stateRef.GetStateText();

        imagenFondo = fondo.GetComponent<Image>();

        imagenFondo.sprite = stateRef.GetStateImage();

    }

    // Update is called once per frame
    void Update()
    {
        //Hacemos la llamada al m�todo
        ManageStates();

        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    //M�todo para manejar el cambio de estados
    void ManageStates()
    {
        //Creamos un array de estados a los que podemos ir desde el estado actual en el que estamos
        State[] nextStates = stateRef.GetNextStates();

        //Si pulsamos la tecla X pasamos al siguiente estado
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Del estado en el que est� pasa al siguiente estado que est� en la posici�n del array 0
            stateRef = nextStates[0];            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Del estado en el que est� pasa al siguiente estado que est� en la posici�n del array 0
            stateRef = nextStates[1];
        }

        //Accedemos al componente text dentro del textComponent y metemos lo que haya dentro del campo storyText del estado actual
        textComponent.text = stateRef.GetStateText();

        imagenFondo.sprite = stateRef.GetStateImage();
    }
}
