using Game.DataProvders;
using Game.Services;
using Zenject;

namespace Game.Installers
{
    public class ProvidersInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<UIDataProvider>().AsSingle().NonLazy();
        }
    }
}