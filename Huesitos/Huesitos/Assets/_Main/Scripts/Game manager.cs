using System;
using System.Xml.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Rendering.MaterialUpgrader;

public class GameManager : MonoBehaviour

{

    /*
    [SerializeField] private int Vida = 100;
    [SerializeField] private PlayerMovement Jugador;
    [SerializeField] private IUManager IUmanager;


    public void RestarVida(int _Damage)

    {
        if (Vida > 0)

        {


            Vida -= _Damage;
            IUmanager.Colorvida(Color.red);
            Debug.Log(" restar " + _Damage + " puntos de vida ");
            IUmanager.FillAmount_Colorvida(Vida / 100f);

        }

        if (Vida <= 0)
        {
            Destroy(Jugador.gameObject);
            Debug.Log("Se muriooo");
        }
        if (Vida >= 80)
        {
            IUmanager.Colorvida(Color.green);
        }

        if (Vida < 80)

        {
            IUmanager.Colorvida(Color.orange);

        }

        if (Vida == 20)
        {

            IUmanager.Colorvida(Color.orange);
        }

        if (Vida < 20)
        {
            IUmanager.Colorvida(Color.darkRed);
        }
    }

  */

    public void Escenas(int escena)
    {

        switch (escena)
        {

            case 1:
                SceneManager.LoadScene("Assets/_Main/Level/Scenes/Introduccion.unity");
                break;

            case 2:
                int escenaActual = SceneManager.GetActiveScene().buildIndex;

                SceneManager.LoadScene(escenaActual + 1);
                break;
            case 3:
                SceneManager.LoadScene("Assets/_Main/Level/Scenes/Menu.unity");
                break;


        }


    }
    private void Start()
    {
        
    }


    public void Finales(int Finales)

    {
        switch (Finales)
        {
            case 1:
                SceneManager.LoadScene("Assets/_Main/Level/Scenes/FinalBueno.unity");
                break;
            case 2:
                SceneManager.LoadScene("Assets/_Main/Level/Scenes/FinalMalo.unity");
              
                break;
            case 3:
                SceneManager.LoadScene("Assets/_Main/Level/Scenes/FinalNuetral.unity");
               
                break;
        }

    }
}

