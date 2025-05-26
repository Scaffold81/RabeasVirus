using Cysharp.Threading.Tasks;
using Game.Enums;
using UnityEngine.SceneManagement;
using Zenject;

namespace Game.Services
{
    public class SceneManagerService : ISceneManagerService
    {
        private ISaveService saveService;

        public SceneId TargetSceneId { get; private set; } = SceneId.Main;


        public int TargetSceneIndex { get; set; }

        [Inject]
        void Construct(ISaveService saveService)
        {
            this.saveService = saveService;
        }

        public void LoadSceneAsync(SceneId scene)
        {
            SceneManager.LoadSceneAsync(scene.ToString());
        }

        public void LoadSceneIntersitialAsync(SceneId targetScene = SceneId.Main)
        {
            TargetSceneId = targetScene;
            SceneManager.LoadSceneAsync(SceneId.Interstitial.ToString());
        }
    }
}
