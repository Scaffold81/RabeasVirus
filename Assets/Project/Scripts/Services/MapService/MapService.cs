using Game.Enums;
using Game.ScriptableObjects;
using R3;
using UnityEngine;
using Zenject;

namespace Game.Services
{
    public interface IMapService
    {
        ReactiveProperty<LevelConfigRepositorySO> Levels { get; }
    }
    public class MapService : IMapService
    {
        private ISaveService saveService;
        public ReactiveProperty< LevelConfigRepositorySO> Levels { get; private set; }= new ReactiveProperty<LevelConfigRepositorySO>();

        [Inject]
        void Construct(ISaveService saveService, LevelConfigRepositorySO levelConfig)
        {
            this.saveService = saveService;
        }
    }
}
