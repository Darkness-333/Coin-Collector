using Zenject;

public class CoinShrinkDebuff : Buff {
    public override float Duration => 5f;

    [Inject] private GameController gameController;

    public override void Apply(Player player) {
        gameController.ActivateCoinShrink();
    }

    public override void Revert(Player player) {
        gameController.DeactivateCoinShrink();
    }
}
