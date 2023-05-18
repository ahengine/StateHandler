using UnityEngine;

namespace StateHandler
{
    public class TransformStateHandler : BaseStateHandler
    {
        private Transform tr;

        private Vector3 position;
        private Quaternion rotation;
        private Vector3 scale;

        private void Awake()
        {
            tr = transform;
            SetData();
        }

        private void Update()
        {
            if (Input.anyKey)
                return;

            if (tr.position != position ||
              tr.rotation != rotation ||
              tr.localScale != scale)
            {
                AddState();
                SetData();
            }
        }

        private void AddState()
        {

        }

        private void SetData()
        {
            position = transform.position;
            rotation = transform.rotation;
            scale = transform.localScale;
        }
    }
}