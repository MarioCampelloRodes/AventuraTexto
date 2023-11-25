using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Es un atributo de la clase que nos permite crear scriptable objects de tipo state desde la ventana Project

[CreateAssetMenu(menuName = "State")]

//Esta clase deriva ahora de los ScriptableObjects

public class State : ScriptableObject
{
    //Genero un campo de strings con un tamaño específico

    //[(TextArea(,))] -> Atributo que permite crear un cuadro de texto con la cantidad de líneas escalable
    //[SerializedField] -> Atributo que permite que una variable o referencia siga siendo privada pero accesible desde el editor de Unity

    [TextArea(14, 10)] [SerializeField] string storyText;

    [SerializeField] Sprite imagenFondo;
        
    [SerializeField] State[] nextStates; //Array de estados a los que podemos ir desde el estado actual

    //Método que nos devuelve el contenido de la caja de texto del ScriptableObject
    public string GetStateText()
    {
        return storyText;
    }

    public Sprite GetStateImage()
    {
        return imagenFondo;
    }

    //Método quen nos devuelve los estados a los que podemos ir desde el estado actual
    public State[] GetNextStates()
    {
        return nextStates;
    }
}
