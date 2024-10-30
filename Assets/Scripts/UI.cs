using TMPro;
using UnityEngine;

public class UI:MonoBehaviour {
    [SerializeField] private TextMeshProUGUI pointsText;
    public void UpdatePoints (int points) {
        pointsText.SetText(points.ToString());
    }

}