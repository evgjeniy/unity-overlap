using UnityEngine;

namespace Genity
{
    [System.Serializable]
    public class BoxData : OverlapData
    {
        [SerializeField, Min(0.0f)] private Vector3 size = Vector3.one;

        public Vector3 Size
        {
            get => Root == null ? size : Vector3.Scale(Root.lossyScale, size);
            set { if (value is { x: >= 0, y: >= 0, z: >= 0 }) size = value; }
        }

        public Quaternion Orientation
        {
            get => Root == null ? Quaternion.identity : Root.rotation;
            set { if (Root != null) Root.rotation = value; }
        }
    }
}