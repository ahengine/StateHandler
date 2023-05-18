using UnityEngine;

namespace StateHandler
{
    public record InstantiateState : State
    {
        public GameObject Prefab { get; }
        public TransformState TransformProperty { get; }

        public InstantiateState(GameObject prefab, TransformState transformState)
        {
            Prefab = prefab;
            this.TransformProperty = transformState;
        }
    }
}