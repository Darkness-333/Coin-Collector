using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour {
    [Inject] private CoinFactory coinFactory;
    [Inject] private UI ui;

    private float spawnInterval = 2f;
    private int points = 0;

    public bool IsCoinShrinkingActive { get; private set; } = false;

    private void Start() {
        InvokeRepeating("SpawnCoin", 0, spawnInterval);
    }

    private void SpawnCoin() {
        Coin coin = coinFactory.Create();
        coin.Init();
        if (IsCoinShrinkingActive) {
            coin.Shrink();
        }
    }

    public void AddPoint(int multiplier) {
        points+= multiplier;
        ui.UpdatePoints(points);
    }

    public void ActivateCoinShrink() {
        IsCoinShrinkingActive = true;
    }

    public void DeactivateCoinShrink() {
        IsCoinShrinkingActive = false;
    }
}
