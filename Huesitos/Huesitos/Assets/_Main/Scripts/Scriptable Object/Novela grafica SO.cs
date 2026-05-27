using UnityEngine;

[CreateAssetMenu(
    fileName = "New Visual Novel Node",
    menuName = "Visual Novel/Node"
)]
public class VisualNovelNodeSO : ScriptableObject
{
    [Header("Texto principal")]
    [TextArea(3, 8)]
    public string sceneText;

    [Header("Botones")]
    [Range(0, 3)]
    public int buttonAmount;

    public string[] buttonNames = new string[3];

    [Header("Textos finales")]
    [TextArea(2, 5)]
    public string[] finalTexts = new string[3];
}
