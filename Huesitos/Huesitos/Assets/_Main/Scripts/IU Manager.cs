using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Nodo")]
    [SerializeField]
    private VisualNovelNodeSO _node;

    [Header("Texto diálogo")]
    [SerializeField]
    private TMP_Text _dialogueText;

    [Header("Botones")]
    [SerializeField]
    private Button[] _buttons;

    [Header("Texto botones")]
    [SerializeField]
    private TMP_Text[] _buttonTexts;

    private void Start()
    {
        LoadNode();
    }

    private void LoadNode()
    {
        // TEXTO PRINCIPAL
        _dialogueText.text = _node.sceneText;

        // ACTIVAR BOTONES
        for (int i = 0; i < _buttons.Length; i++)
        {
            bool showButton = i < _node.buttonAmount;

            _buttons[i].gameObject.SetActive(showButton);

            if (showButton)
            {
                // TEXTO BOTÓN
                _buttonTexts[i].text = _node.buttonNames[i];

                // GUARDAR ÍNDICE
                int index = i;

                // LIMPIAR EVENTOS
                _buttons[i].onClick.RemoveAllListeners();

                // AGREGAR EVENTO
                _buttons[i].onClick.AddListener(() =>
                {
                    SelectFinal(index);
                });
            }
        }
    }

    private void SelectFinal(int index)
    {
        // CAMBIAR TEXTO
        _dialogueText.text = _node.finalTexts[index];

        // DESAPARECER BOTONES
        for (int i = 0; i < _buttons.Length; i++)
        {
            _buttons[i].gameObject.SetActive(false);
        }
    }
}