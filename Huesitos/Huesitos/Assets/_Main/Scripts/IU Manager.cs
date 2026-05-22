using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IUManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _PanelDialogo;
    [SerializeField] private TMP_Text _TextDialogo;

    [Header("texto de los botones")]
    [SerializeField] private TMP_Text[] _TextButton;


    private void Start()
    {

        string EscenaActual = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

        switch (EscenaActual)
        {
            case "Introduccion":
                _TextDialogo.text = "Es un dia soleado acabaste de salir de casa y esta de camino a la universidad ";
                _TextButton[0].text = "Salir";
                _TextButton[1].text = "Siguiente";
                break;

            case "Desarrollo":
                _TextDialogo.text = "Llegas a la universidad y cuando estas de camino a tu salon te encuentras con tu crush ¿que vas hacer?";
                _TextButton[0].text = "Ignorarla";
                _TextButton[1].text = "Hablarle";
                _TextButton[2].text = "Besarla";
                _TextButton[3].text = "Salir";
                _TextButton[4].text = "Siguente";
                break;

            case "FinalBueno":
                _TextDialogo.text = "Pasas una Tarde agradable con ella :D";
                _TextButton[0].text = "Salir";
                break;


            case "FinalNeutral":
                _TextDialogo.text = "No sucede nada entre ella y tu :/";
                _TextButton[0].text = "Salir";
                break;

            case "FinalMalo":
                _TextDialogo.text = "Terminas siendo denunciado por acaso :(";
                _TextButton[0].text = "Salir";
                break;


        }

    }
    private void Update()
    {


    }
}