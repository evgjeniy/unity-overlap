using UnityEngine;

namespace Genity
{
    public static class CapsuleOverlapExtensions
    {
        public static bool Check(this CapsuleData capsule, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.CheckCapsule
        (
            capsule.Center, capsule.End, capsule.Radius, capsule.LayerMask.value, qti
        );

        public static bool Check(this CapsuleData capsule, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.CheckCapsule
        (
            capsule.Center, capsule.End, capsule.Radius, mask.value, qti
        );

        public static Collider[] Overlap(this CapsuleData capsule, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.OverlapCapsule
        (
            capsule.Center, capsule.End, capsule.Radius, capsule.LayerMask.value, qti
        );

        public static Collider[] Overlap(this CapsuleData capsule, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.OverlapCapsule
        (
            capsule.Center, capsule.End, capsule.Radius, mask.value, qti
        );

        public static int OverlapNonAlloc(this CapsuleData capsule, Collider[] colliders, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.OverlapCapsuleNonAlloc
        (
            capsule.Center, capsule.End, capsule.Radius, colliders, capsule.LayerMask.value, qti
        );

        public static int OverlapNonAlloc(this CapsuleData capsule, Collider[] colliders, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.OverlapCapsuleNonAlloc
        (
            capsule.Center, capsule.End, capsule.Radius, colliders, mask.value, qti
        );

        public static bool Cast(this CapsuleData capsule, Vector3 direction, out RaycastHit hit, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.CapsuleCast
        (
            capsule.Center, capsule.End, capsule.Radius, direction, out hit, direction.magnitude, capsule.LayerMask.value, qti
        );

        public static bool Cast(this CapsuleData capsule, Vector3 direction, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.CapsuleCast
        (
            capsule.Center, capsule.End, capsule.Radius, direction, out hit, direction.magnitude, mask.value, qti
        );

        public static RaycastHit[] CastAll(this CapsuleData capsule, Vector3 direction, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.CapsuleCastAll
        (
            capsule.Center, capsule.End, capsule.Radius, direction, direction.magnitude, capsule.LayerMask.value, qti
        );

        public static RaycastHit[] CastAll(this CapsuleData capsule, Vector3 direction, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.CapsuleCastAll
        (
            capsule.Center, capsule.End, capsule.Radius, direction, direction.magnitude, mask.value, qti
        );

        public static int CastAllNonAlloc(this CapsuleData capsule, Vector3 direction, RaycastHit[] hits, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.CapsuleCastNonAlloc
        (
            capsule.Center, capsule.End, capsule.Radius, direction, hits, direction.magnitude, capsule.LayerMask.value, qti
        );

        public static int CastAllNonAlloc(this CapsuleData capsule, Vector3 direction, RaycastHit[] hits, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.CapsuleCastNonAlloc
        (
            capsule.Center, capsule.End, capsule.Radius, direction, hits, direction.magnitude, mask.value, qti
        );
    }
}