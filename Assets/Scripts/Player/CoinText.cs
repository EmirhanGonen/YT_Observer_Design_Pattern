using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    private TextMeshProUGUI _coinText = null;

    private void Awake() {
        _coinText = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable() {
        PlayerCollect.OnCollectCoin += SetCoinText;
    }
    private void OnDisable() {
        PlayerCollect.OnCollectCoin -= SetCoinText;
    }

    private void SetCoinText(int CoinCount) {
        _coinText.SetText($"Coin: {CoinCount}");
    }
}