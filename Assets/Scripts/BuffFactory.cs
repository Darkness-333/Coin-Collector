using UnityEngine;
using Zenject;

public class BuffFactory : IFactory<GameObject> {
    private DiContainer _container;
    private GameObject[] _buffPrefabs;

    public BuffFactory(DiContainer container, GameObject[] buffPrefabs) {
        _container = container;
        _buffPrefabs = buffPrefabs;
    }

    public GameObject Create() {
        var randomPrefab = _buffPrefabs[Random.Range(0, _buffPrefabs.Length)];

        return _container.InstantiatePrefab(randomPrefab);
    }
}
