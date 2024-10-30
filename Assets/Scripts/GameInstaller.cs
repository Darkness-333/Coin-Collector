using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller {
    [SerializeField] private Coin coinPrefab;
    [SerializeField] private GameObject[] buffPrefabs;

    public override void InstallBindings() {
        Container.Bind<GameController>().FromComponentInHierarchy().AsSingle();

        Container.Bind<UI>().FromComponentInHierarchy().AsSingle();

        Container.BindFactory<Coin, CoinFactory>().FromComponentInNewPrefab(coinPrefab);

        Container.Bind<BuffFactory>().AsSingle().WithArguments(buffPrefabs);

    }
}
