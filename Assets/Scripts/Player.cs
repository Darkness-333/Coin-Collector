using System.Collections;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour {
    [SerializeField] private float speed = 3;
    [Inject] private GameController gameManager;
    public int PointsMultiplier { get; set; } = 1;

    void Update() {
        float hor = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(hor, 0, vert).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    public void SetSpeedMultiplier(float multiplier) {
        speed*=multiplier;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.TryGetComponent(out Buff buff)) {
            StartCoroutine(ApplyBuff(buff));
            Destroy(buff.gameObject);
        }
        else if (other.GetComponent<Coin>()) {
            Destroy(other.gameObject);
            gameManager.AddPoint(PointsMultiplier);
        }
    }

    private IEnumerator ApplyBuff(Buff buff) {
        buff.Apply(this);
        yield return new WaitForSeconds(buff.Duration);
        buff.Revert(this);
    }
}
