using UnityEngine;

namespace Genity
{
    [System.Serializable]
    public class SphereData : OverlapData
    {
        [SerializeField, Min(0.0f)] private float radius = 1.0f;

        public float Radius
        {
            get => radius;
            set { if (value >= 0) radius = value; }
        }
    }
}