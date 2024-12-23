﻿using UnityEngine;

namespace Genity
{
    public static class SphereOverlapExtensions
    {
        public static bool Check(this SphereData sphere, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.CheckSphere
        (
            sphere.Center, sphere.Radius, sphere.LayerMask.value, qti
        );

        public static bool Check(this SphereData sphere, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.CheckSphere
        (
            sphere.Center, sphere.Radius, mask.value, qti
        );

        public static Collider[] Overlap(this SphereData sphere, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.OverlapSphere
        (
            sphere.Center, sphere.Radius, sphere.LayerMask.value, qti
        );

        public static Collider[] Overlap(this SphereData sphere, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.OverlapSphere
        (
            sphere.Center, sphere.Radius, mask.value, qti
        );

        public static int OverlapNonAlloc(this SphereData sphere, Collider[] colliders, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.OverlapSphereNonAlloc
        (
            sphere.Center, sphere.Radius, colliders, sphere.LayerMask.value, qti
        );

        public static int OverlapNonAlloc(this SphereData sphere, Collider[] colliders, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.OverlapSphereNonAlloc
        (
            sphere.Center, sphere.Radius, colliders, mask.value, qti
        );

        public static bool Cast(this SphereData sphere, Vector3 direction, out RaycastHit hit, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.SphereCast
        (
            sphere.Center, sphere.Radius, direction, out hit, direction.magnitude, sphere.LayerMask.value, qti
        );

        public static bool Cast(this SphereData sphere, Vector3 direction, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.SphereCast
        (
            sphere.Center, sphere.Radius, direction, out hit, direction.magnitude, mask.value, qti
        );

        public static RaycastHit[] CastAll(this SphereData sphere, Vector3 direction, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.SphereCastAll
        (
            sphere.Center, sphere.Radius, direction, direction.magnitude, sphere.LayerMask.value, qti
        );

        public static RaycastHit[] CastAll(this SphereData sphere, Vector3 direction, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.SphereCastAll
        (
            sphere.Center, sphere.Radius, direction, direction.magnitude, mask.value, qti
        );

        public static int CastAllNonAlloc(this SphereData sphere, Vector3 direction, RaycastHit[] hits, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.SphereCastNonAlloc
        (
            sphere.Center, sphere.Radius, direction, hits, direction.magnitude, sphere.LayerMask.value, qti
        );

        public static int CastAllNonAlloc(this SphereData sphere, Vector3 direction, RaycastHit[] hits, LayerMask mask, QueryTriggerInteraction qti = QueryTriggerInteraction.UseGlobal) => Physics.SphereCastNonAlloc
        (
            sphere.Center, sphere.Radius, direction, hits, direction.magnitude, mask.value, qti
        );
    }
}