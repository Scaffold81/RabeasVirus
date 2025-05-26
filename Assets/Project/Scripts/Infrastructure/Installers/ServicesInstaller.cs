using Game.Services;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
namespace Game.Installers
{
    public class ServicesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<SceneManagerService>().AsSingle().NonLazy();
            Container.BindInterfacesTo<SaveService>().AsSingle().NonLazy();
                Container.BindInterfacesTo<MapService>().AsSingle().NonLazy();
        }
    }
}