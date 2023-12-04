using TMPro;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    private int _coinCount = 0;

    public static event System.Action<int> OnCollectCoin = null;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (!collision.CompareTag("Coin"))
            return;

        Destroy(collision.gameObject);
        OnCollectCoin?.Invoke(++_coinCount);
        //_coinText.SetText($"Coin: {++_coinCount}");
    }
}