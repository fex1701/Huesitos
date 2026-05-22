

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    [SerializeField] private TMP_Text DialogoText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //crearemos un metodo que me permita cambiar el estado del juego
        // pausa
        //play 
        //reiniciar
        //salir 
        //ganar
        //perder

    }
    public void EstadosDelJuego(int numero)
    { 

        switch (numero)
        {
            case 0:
               DialogoText.text = "Bien hecho, estableciste una conversacion con ella toda la tarde";
                break;
            case 1:
                DialogoText.text = "Ella se fue a su casa y tu te quedaste con la duda de que hubiera pasado si le hablabas";
                break;
            case 2:
                DialogoText.text = "Ella se da cuenta de lo que intentas y te dice: ¡Acosador!";  
                break;

        }
    }
}
