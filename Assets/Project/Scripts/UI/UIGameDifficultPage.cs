using Game.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.UI
{
    public class UIGameDifficultPage : PageBase, ISubscriber
    {
        [SerializeField]
        private Button nextButton;

        private ISceneManagerService sceneManagerService;
        private IUIPageService uIPageService;

        [Inject]
        void Construct(ISceneManagerService sceneManagerService, IUIPageService uIPageService)
        {
            this.sceneManagerService = sceneManagerService;
            this.uIPageService = uIPageService;

            uIPageService.AddPage(typeof(UIGameDifficultPage), this);
        }

        private void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
            Hide(0);
        }

        private void Start()
        {
            Subscribe();
        }

        public void Subscribe()
        {
            nextButton.onClick.AddListener(NextPage);
        }

        private void NextPage()
        {
            sceneManagerService.LoadSceneAsync(Enums.SceneId.NewGameScene);
        }

        public void UnSubscribe()
        {
            nextButton.onClick.RemoveAllListeners();
        }

        private void OnDestroy()
        {
            UnSubscribe();
        }
    }
}
