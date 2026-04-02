using System;
using System.Xml.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int Vida = 100;
    [SerializeField] private PlayerMovement Jugador;
    [SerializeField] private IUManager IUmanager;



    public void Sumarvida(int heal)
    {
        if (Vida < 100)
        {
            Vida += heal;
            IUmanager.Colorvida(Color.green);

            IUmanager.FillAmount_Colorvida(Vida / 100f);
        }

        else
        {
            Vida = 100;
            Debug.Log("No curo");
        }
    }
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




}