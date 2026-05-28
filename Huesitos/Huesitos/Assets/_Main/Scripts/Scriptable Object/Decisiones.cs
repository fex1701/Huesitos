using UnityEngine;

[System.Serializable]
public class Choice
{
    [TextArea]
    public string buttonText;

    public VisualNovelNodeSO nextNode;
}