using Game.Services;
using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.UI
{
    public class UIMainPage : PageBase, ISubscriber
    {
        [SerializeField]
        private Button continueGameButton, newGameButton, loadGameButton, settingsGameButton, quiteGameButton;

        private ISceneManagerService sceneManagerService;
        private IUIPageService uIPageService;

        [Inject]
        void Construct(ISceneManagerService sceneManagerService, IUIPageService uIPageService)
        {
            this.sceneManagerService = sceneManagerService;
            this.uIPageService = uIPageService;

            uIPageService.AddPage(typeof(UIMainPage), this);
        }

        private void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
            Show(0.1f);
        }

        private void Start()
        {
            Subscribe();
        }

        public void Subscribe()
        {
            continueGameButton.onClick.AddListener(() => { });
            newGameButton.onClick.AddListener(() => { NewGame(); });
            loadGameButton.onClick.AddListener(() => { });
            settingsGameButton.onClick.AddListener(() => { });
            quiteGameButton.onClick.AddListener(() => { });
        }

        private void NewGame()
        {
            uIPageService.ShowOnTop(typeof(UIGameDifficultPage));
        }

        public void UnSubscribe()
        {
            continueGameButton.onClick.RemoveAllListeners();
            newGameButton.onClick.RemoveAllListeners();
            loadGameButton.onClick.RemoveAllListeners();
            settingsGameButton.onClick.RemoveAllListeners();
            quiteGameButton.onClick.RemoveAllListeners();
        }

        private void OnDestroy()
        {
            UnSubscribe();
        }
    }
}
