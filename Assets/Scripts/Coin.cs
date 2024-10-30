using UnityEngine;

public class Coin : MonoBehaviour {
    private float lifeTime = 4f;
    private Vector3 originalScale;

    public void Init() {
        transform.position = new Vector3(Random.Range(-5f, 5f), -0.5f, Random.Range(-5f, 5f));
        originalScale = transform.localScale;
        Invoke(nameof(DestroyAfterTime), lifeTime);
    }

    public void Shrink() {
        transform.localScale = originalScale * 0.5f;
    }

    private void DestroyAfterTime() {
        Destroy(gameObject);
    }
}
