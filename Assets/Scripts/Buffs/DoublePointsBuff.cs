public class DoublePointsBuff : Buff {
    public override float Duration => 5f;

    public override void Apply(Player player) {
        player.PointsMultiplier = 2;
    }

    public override void Revert(Player player) {
        player.PointsMultiplier = 1;
    }
}
