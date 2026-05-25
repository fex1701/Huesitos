using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject panelDialogo;

    [SerializeField]
    private TMP_Text _textDialogo;

    [Header("Buttons")]

    [SerializeField]
    private TMP_Text[] _textButton;

    

    private void Start()
    {
        _textDialogo.text = "Te encuentras a una persona misteriosa, parece que la has asustado.";
        _textButton[0].text = "Saludar";
        _textButton[1].text = "Ignorar";
        _textButton[2].text = "Gritar";
        _textButton[3].text = "Atacar";
    }

   

}
