using Game.Services;
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
            Container.BindInterfacesTo<UIPageService>().AsSingle().NonLazy();
        }
    }
}