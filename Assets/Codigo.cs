using UnityEngine;
using UnityEngine.UIElements;

public class Codigo : MonoBehaviour
{
    UIDocument miMenu;
    Label miTexto;
    Button miBoton;

    private void OnEnable()
    {
        //miMenu = GetComponent<UIDocument>();
        //VisualElement root = miMenu.rootVisualElement;

        ////miTexto = root.Q<Label>(className:"clase");
        ////miTexto = root.Query<Label>("nombre").First();
        ////                                     .Last()
        ////                                     .Hovered()
        ////                                     .Active()
        //miTexto = root.Q<Label>("nombre");
        ////Inline Styles
        //miTexto.style.fontSize = 55;
        //miTexto.style.color = Color.red;
        //miTexto.style.width = 1000;
        ////USS Classes
        //miTexto.AddToClassList("Clase"); //Agregar Clase
        //miTexto.RemoveFromClassList("Clase");//Quitar Clase 


    }
}
