public class SpeedBuff : Buff {
    public override float Duration => 5f;
    private float speedMultiplier = 2f;

    public override void Apply(Player player) {
        player.SetSpeedMultiplier(speedMultiplier);
    }

    public override void Revert(Player player) {
        player.SetSpeedMultiplier(1 / speedMultiplier);
    }
}
