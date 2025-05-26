using UnityEngine;

namespace Game.ScriptableObjects
{
    [CreateAssetMenu(fileName = "LevelConfig", menuName = "Configs/LevelConfig")]
    [System.Serializable]
    public class LevelConfigSO : ScriptableObject
    {
        public readonly int startEnemies;
        public readonly int maxEnemies;
    }
}
