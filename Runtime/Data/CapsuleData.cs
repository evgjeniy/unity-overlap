using UnityEngine;

namespace Genity
{
    [System.Serializable]
    public class CapsuleData : SphereData
    {
        [SerializeField] private Vector3 end;

        public Vector3 End
        {
            get => Root == null ? end : Root.localToWorldMatrix.MultiplyPoint3x4(end);
            set => end = value;
        }
    }
}