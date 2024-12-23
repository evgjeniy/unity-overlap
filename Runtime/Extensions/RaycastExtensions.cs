using UnityEngine;

namespace Genity
{
    public static class RaycastExtensions
    {
        public static bool Raycast(this RayData ray, out RaycastHit hit, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.Raycast
        (
            ray.Center, ray.Direction, out hit, ray.MaxDistance, ray.LayerMask.value, qti
        );

        public static bool Raycast(this RayData ray, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.Raycast
        (
            ray.Center, ray.Direction, out hit, ray.MaxDistance, mask.value, qti
        );

        public static bool Raycast(this OverlapData overlapData, Vector3 direction, out RaycastHit hit, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.Raycast
        (
            overlapData.Center, direction, out hit, direction.magnitude, overlapData.LayerMask.value, qti
        );

        public static bool Raycast(this OverlapData overlapData, Vector3 direction, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.Raycast
        (
            overlapData.Center, direction, out hit, direction.magnitude, mask.value, qti
        );

        public static RaycastHit[] RaycastAll(this RayData ray, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.RaycastAll
        (
            ray.Center, ray.Direction, ray.MaxDistance, ray.LayerMask.value, qti
        );

        public static RaycastHit[] RaycastAll(this RayData ray, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.RaycastAll
        (
            ray.Center, ray.Direction, ray.MaxDistance, mask.value, qti
        );

        public static RaycastHit[] RaycastAll(this OverlapData overlapData, Vector3 direction, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.RaycastAll
        (
            overlapData.Center, direction, direction.magnitude, overlapData.LayerMask.value, qti
        );

        public static RaycastHit[] RaycastAll(this OverlapData overlapData, Vector3 direction, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.RaycastAll
        (
            overlapData.Center, direction, direction.magnitude, mask.value, qti
        );

        public static int RaycastNonAlloc(this RayData ray, RaycastHit[] hits, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.RaycastNonAlloc
        (
            ray.Center, ray.Direction, hits, ray.MaxDistance, ray.LayerMask.value, qti
        );

        public static int RaycastNonAlloc(this RayData ray, RaycastHit[] hits, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.RaycastNonAlloc
        (
            ray.Center, ray.Direction, hits, ray.MaxDistance, mask.value, qti
        );

        public static int RaycastNonAlloc(this OverlapData overlapData, Vector3 direction, RaycastHit[] hits, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.RaycastNonAlloc
        (
            overlapData.Center, direction, hits, direction.magnitude, overlapData.LayerMask.value, qti
        );

        public static int RaycastNonAlloc(this OverlapData overlapData, Vector3 direction, RaycastHit[] hits, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.RaycastNonAlloc
        (
            overlapData.Center, direction, hits, direction.magnitude, mask.value, qti
        );

        public static bool Linecast(this OverlapData overlapData, Vector3 endPoint, out RaycastHit hit, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.Linecast
        (
            overlapData.Center, endPoint, out hit, overlapData.LayerMask.value, qti
        );

        public static bool Linecast(this OverlapData overlapData, Vector3 endPoint, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.Linecast
        (
            overlapData.Center, endPoint, out hit, mask.value, qti
        );

        public static bool Linecast(this RayData ray, out RaycastHit hit, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.Linecast
        (
            ray.Center, ray.Center + ray.Direction * ray.MaxDistance, out hit, ray.LayerMask.value, qti
        );

        public static bool Linecast(this RayData ray, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.Linecast
        (
            ray.Center, ray.Center + ray.Direction * ray.MaxDistance, out hit, mask.value, qti
        );
    }
}