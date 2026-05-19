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



    //[SerializeField] private Image Contadordevida;

    //private void Start()

    //{
    //Contadordevida.color = Color.cyan;
    //Contadordevida.fillAmount = 1;
    //}
    //public void Colorvida(Color color)
    //{
    //Contadordevida.color = color;

    //}

    // public void FillAmount_Colorvida(float fillAmount)
    //{
    //Contadordevida.fillAmount = fillAmount;
    //}

    private void Awake()
    {
        
    }
    private void Start()
    {
        _TextDialogo.text = "Te encuentras con tu crush ¿que vas hacer?";
        _TextButton[0].text = "Ignorarla";
        _TextButton[1].text = "Hablarle";
        _TextButton[2].text = "Besarla";
    }
    private void Update()
    {

    }

    private void FixedUpdate()
    {
        
    }
}
