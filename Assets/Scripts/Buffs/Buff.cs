using UnityEngine;

public abstract class Buff:MonoBehaviour {
    public abstract void Apply(Player player);
    public abstract void Revert(Player player);
    public abstract float Duration { get; }

    private void Start() {
        Invoke(nameof(DestroyAfterTime),5);
    }

    private void DestroyAfterTime() {
        Destroy(gameObject);
    }


}
