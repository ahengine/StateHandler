using UnityEngine;

namespace StateHandler
{
    public record TransformState : State
    {
        public Vector3 position { get; }
        public Quaternion rotation { get; }
        public Vector3 scale { get; }

        public TransformState(Vector3 position, Quaternion rotation, Vector3 scale)
        {
            this.position = position;
            this.rotation = rotation;
            this.scale = scale;
        }
    }
}