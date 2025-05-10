using UnityEngine;
using UnityEngine.UIElements;

public class MiPrimeraUI : MonoBehaviour
{
    UIDocument menu;
    //Pincipal
    Button hangar_button;
    //Hangar
    VisualElement hangar;
    Button nave_01_button;
    Button nave_02_button;
    Button nave_03_button;
    Button nave_04_button;
    Button nave_05_button;
    Button nave_06_button;
    Label nave_nombre;
    ProgressBar nave_velocidad;
    ProgressBar nave_estabilidad;
    ProgressBar nave_resistencia;
    ProgressBar nave_potencia;
    Button volver_button;

    private void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        VisualElement root = menu.rootVisualElement;
        //Principal
        hangar_button = root.Q<Button>("Hangar-Button");
        //Hangar
        hangar = root.Q<VisualElement>("Derecha");
        nave_01_button = root.Q<Button>("Nave01");
        nave_02_button = root.Q<Button>("Nave02");
        nave_03_button = root.Q<Button>("Nave03");
        nave_04_button = root.Q<Button>("Nave04");
        nave_05_button = root.Q<Button>("Nave05");
        nave_06_button = root.Q<Button>("Nave06");
        nave_nombre = root.Q<Label>("Nave-nombre");
        nave_velocidad = root.Q<ProgressBar>("Velocidad");
        nave_estabilidad = root.Q<ProgressBar>("Estabilidad");
        nave_resistencia = root.Q<ProgressBar>("Resistencia");
        nave_potencia = root.Q<ProgressBar>("Potencia");
        volver_button = root.Q<Button>("Hangar-volver");
        //Calbacks
        hangar_button.RegisterCallback<ClickEvent>(abrirHangar);
        nave_01_button.RegisterCallback<ClickEvent, int>(seleccionarNave, 1);
        nave_02_button.RegisterCallback<ClickEvent, int>(seleccionarNave, 2);
        nave_03_button.RegisterCallback<ClickEvent, int>(seleccionarNave, 3);
        nave_04_button.RegisterCallback<ClickEvent, int>(seleccionarNave, 4);
        nave_05_button.RegisterCallback<ClickEvent, int>(seleccionarNave, 5);
        nave_06_button.RegisterCallback<ClickEvent, int>(seleccionarNave, 6);
        volver_button.RegisterCallback<ClickEvent>(cerrarHangar);
    }

    void abrirHangar(ClickEvent evt)
    {
        hangar.AddToClassList("derecha-activo");
    }
    void cerrarHangar(ClickEvent evt)
    {
        hangar.RemoveFromClassList("derecha-activo");
    }
    void seleccionarNave(ClickEvent evt, int modelo)
    {
        switch (modelo)
        {
            case 1:
                nave_nombre.text = "Halcón Milenario";
                nave_velocidad.lowValue = 88;
                nave_estabilidad.lowValue = 47;
                nave_resistencia.lowValue = 65;
                nave_potencia.lowValue = 29;
                break;
            case 2:
                nave_nombre.text = "Ragnarok";
                nave_velocidad.lowValue = 72;
                nave_estabilidad.lowValue = 38;
                nave_resistencia.lowValue = 54;
                nave_potencia.lowValue = 49;
                break;
            case 3:
                nave_nombre.text = "F16";
                nave_velocidad.lowValue = 95;
                nave_estabilidad.lowValue = 53;
                nave_resistencia.lowValue = 42;
                nave_potencia.lowValue = 78;
                break;
            case 4:
                nave_nombre.text = "DHS45";
                nave_velocidad.lowValue = 61;
                nave_estabilidad.lowValue = 69;
                nave_resistencia.lowValue = 48;
                nave_potencia.lowValue = 55;
                break;
            case 5:
                nave_nombre.text = "Death Star";
                nave_velocidad.lowValue = 28;
                nave_estabilidad.lowValue = 90;
                nave_resistencia.lowValue = 99;
                nave_potencia.lowValue = 88;
                break;
            case 6:
                nave_nombre.text = "HTrad";
                nave_velocidad.lowValue = 75;
                nave_estabilidad.lowValue = 63;
                nave_resistencia.lowValue = 52;
                nave_potencia.lowValue = 44;
                break;
        }
    }
    
}
