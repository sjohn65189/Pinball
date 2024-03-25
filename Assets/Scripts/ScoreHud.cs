using TMPro;
using UnityEngine;

public enum ScoreType
{
    Current,
    High,
}

public class ShowScore : MonoBehaviour
{
    public ScoreType type;

    // private fields
    private TextMeshProUGUI txt;

    // Life Cycle methods
    private void Start()
    {
        txt = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        if (type == ScoreType.Current)
        {
            txt.text = Game.Instance.CScore.ToString();
        }
        else if (type == ScoreType.High)
        {
            txt.text = Game.Instance.HScore.ToString();
        }
    }
}
