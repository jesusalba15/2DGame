using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score Instance;

    [Header("Textos en el PanelScore")]
    public TextMeshProUGUI cherriesCount;
    public TextMeshProUGUI kiwisCount;

    private int cherries = 0;
    private int kiwis = 0;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void AddItem(string itemName, int value)
    {
        switch (itemName)
        {
            case "Cherry":
                cherries += value;
                cherriesCount.text = cherries.ToString();
                break;

            case "Kiwi":
                kiwis += value;
                kiwisCount.text = kiwis.ToString();
                break;

            
        }
    }
}
