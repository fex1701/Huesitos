using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Nodo actual")]
    [SerializeField]
    private VisualNovelNodeSO currentNode;

    [Header("UI")]
    [SerializeField]
    private UIManager uiManager;

    [Header("Personaje Izquierdo")]
    [SerializeField]
    private SpriteCharacterController leftCharacter;

    [Header("Personaje Derecho")]
    [SerializeField]
    private SpriteCharacterController rightCharacter;

    private void Start()
    {
        LoadNode(currentNode);
    }

    public void LoadNode(VisualNovelNodeSO node)
    {
        currentNode = node;

        // TEXTO
        uiManager.SetDialogue(node.sceneText);

        // =========================
        // LEFT CHARACTER
        // =========================

        if (node.useLeftCharacter)
        {
            leftCharacter.gameObject.SetActive(true);

            leftCharacter.ApplyCharacter(
                node.leftCharacterExpression
            );
        }
        else
        {
            leftCharacter.gameObject.SetActive(false);
        }

        // =========================
        // RIGHT CHARACTER
        // =========================

        if (node.useRightCharacter)
        {
            rightCharacter.gameObject.SetActive(true);

            rightCharacter.ApplyCharacter(
                node.rightCharacterExpression
            );
        }
        else
        {
            rightCharacter.gameObject.SetActive(false);
        }

        // =========================
        // BOTONES
        // =========================

        uiManager.SetupButtons(node.choices, NextNode);
    }

    private void NextNode(int index)
    {
        VisualNovelNodeSO nextNode =
            currentNode.choices[index].nextNode;

        if (nextNode != null)
        {
            LoadNode(nextNode);
        }
        else
        {
            uiManager.HideButtons();
        }
    }
}