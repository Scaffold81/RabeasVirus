using Game.ScriptableObjects;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Game.Installers
{
    public class ProjectConfigsInstaller : MonoInstaller
    {
        [SerializeField, Required]

        LevelConfigRepositorySO levelConfig;
        public override void InstallBindings()
        {
            Container.BindInstance(levelConfig).AsSingle().NonLazy();
        }
    }
}