using UnityEngine;

public class Swicht : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text Dialogotexto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //crearemos un metodo que nos permita cambiar los estados del juego 
        //pausa
        //salir
        //reiniciar
        //perder
        //play
        //
    }

    public void EstadosDelJuego(int numero)
    {
        switch (numero)
        {
            case 0:
                Dialogotexto.text = "eres un mal amigo, porque no?";
                break;
            case 1:
                Dialogotexto.text = "Dale espera a que regrese mi internet y jugamos";
                break;
            case 2: 
                Dialogotexto.text = "No w mas tarde viene mi novia";
                break;






        }
    }
}


