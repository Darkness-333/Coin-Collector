using UnityEngine;
using Zenject;

public class BuffSpawner : MonoBehaviour {
    [Inject] private BuffFactory _buffFactory;

    [SerializeField] private float spawnInterval = 5f;

    private void Start() {
        InvokeRepeating(nameof(SpawnRandomBuff), spawnInterval, spawnInterval);
    }

    private void SpawnRandomBuff() {
        var buffObject = _buffFactory.Create();
        buffObject.transform.position = new Vector3(Random.Range(-5f, 5f), -.5f, Random.Range(-5f, 5f));
    }
}
