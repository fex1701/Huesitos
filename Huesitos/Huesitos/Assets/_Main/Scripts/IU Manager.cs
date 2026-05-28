using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Texto diálogo")]
    [SerializeField]
    private TMP_Text dialogueText;

    [Header("Botones")]
    [SerializeField]
    private Button[] buttons;

    [Header("Texto botones")]
    [SerializeField]
    private TMP_Text[] buttonTexts;

    // =========================
    // CAMBIAR TEXTO
    // =========================

    public void SetDialogue(string text)
    {
        dialogueText.text = text;
    }

    // =========================
    // CONFIGURAR BOTONES
    // =========================

    public void SetupButtons(Choice[] choices, System.Action<int> callback)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i < choices.Length)
            {
                buttons[i].gameObject.SetActive(true);

                buttonTexts[i].text = choices[i].buttonText;

                int index = i;

                buttons[i].onClick.RemoveAllListeners();

                buttons[i].onClick.AddListener(() =>
                {
                    callback(index);
                });
            }
            else
            {
                buttons[i].gameObject.SetActive(false);
            }
        }
    }

    // =========================
    // OCULTAR BOTONES
    // =========================

    public void HideButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(false);
        }
    }
}