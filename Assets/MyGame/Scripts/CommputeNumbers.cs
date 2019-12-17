using UnityEngine;
using UnityEngine.UI;

public class CommputeNumbers : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public Text resultLabel;

    float varA;
    float varB;

    public void SetResult()
    {
        resultLabel.text = SubstractNumbers();
    }

    string SubstractNumbers()
    {
        varA = float.Parse(input1.text);
        varB = float.Parse(input2.text);

        string outputSuccess = (varA - varB).ToString();
        return outputSuccess;
    }

    public void ResetApp()
    {
        input1.text = "";
        input2.text = "";
        resultLabel.text = "Result";
    }
}
