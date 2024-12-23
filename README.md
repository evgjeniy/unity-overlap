# Unity Overlap
[![License](https://img.shields.io/github/license/evgjeniy/unity-overlap?color=318CE7&style=flat-square)](LICENSE.md)
[![Version](https://img.shields.io/github/package-json/v/evgjeniy/unity-overlap?color=318CE7&style=flat-square)](package.json)

<h3>Useful extensions for physical overlap in Unity Engine</h3>

# Navigation
- [Get Started](#get-started)
- [How to use](#how-to-use)
- [Gizmos Package](#gizmos-package)
- [Extensions API](#extensions-api)
  - [Sphere Overlap Extensions](#sphere-overlap-extensions)
  - [Capsule Overlap Extensions](#capsule-overlap-extensions)
  - [Box Overlap Extensions](#box-overlap-extensions)
  - [Raycast Extension](#raycast-extensions)

# Get Started
**Installation options:**
- Copy git URL `https://github.com/evgjeniy/unity-overlap.git` in the **Unity Package Manager**
- Add `"com.genity.overlap": "https://github.com/evgjeniy/unity-overlap.git"` in `Packages/manifest.json`

# How to use
- Declare the serialized `SphereData`, `CapsuleData`, `BoxData` or `RayData` fields
- Setup them from **Unity Inspector**
- Use Overlap Extensions instead of `Physics` methods with help of configured Overlap Data

```csharp
public class OverlapExample : MonoBehaviour
{
    [SerializeField] private SphereData sphere;
    [SerializeField] private BoxData box;
    [SerializeField] private RayData ray;

    private RaycastHit[] _hits = new RaycastHit[32];
    
    public void TestOverlap()
    {
        // instead of Physics.CheckSphere(...)
        bool checkResult = sphere.Check();
        Debug.Log(checkResult);

        // instead of Physics.OverlapBox(...)
        foreach (var overlappedCollider in box.Overlap())
            Debug.Log(overlappedCollider.name);

        // instead of Physics.RaycastNonAlloc(...)
        int nonAllocSize = ray.RaycastNonAlloc(_hits);
        for (int i = 0; i < nonAllocSize; i++)
            Debug.Log(_hits[i].point);
    }
}
```

# Gizmos Package

- You can install the [unity-gizmos](https://github.com/evgjeniy/unity-gizmos.git) package to display overlap data in scene

```csharp
public class GizmosOverlapExample : MonoBehaviour
{
    [SerializeField] private GizmosData gizmosData;
    [SerializeField] private BoxData boxData;

    private void OnDrawGizmos()
    {
        gizmosData.Draw(boxData);
    }
}
```

Preview:
![gizmos-preview](https://github.com/user-attachments/assets/d1724a8c-febb-4a73-8457-cdc11f013255)

# Extensions API

## Sphere Overlap Extensions

```csharp
public static bool Check(this SphereData sphere, QueryTriggerInteraction qti);

public static bool Check(this SphereData sphere, LayerMask mask, QueryTriggerInteraction qti);

public static Collider[] Overlap(this SphereData sphere, QueryTriggerInteraction qti);

public static Collider[] Overlap(this SphereData sphere, LayerMask mask, QueryTriggerInteraction qti);

public static int OverlapNonAlloc(this SphereData sphere, Collider[] colliders, QueryTriggerInteraction qti);

public static int OverlapNonAlloc(this SphereData sphere, Collider[] colliders, LayerMask mask, QueryTriggerInteraction qti);

public static bool Cast(this SphereData sphere, Vector3 direction, out RaycastHit hit, QueryTriggerInteraction qti);

public static bool Cast(this SphereData sphere, Vector3 direction, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti);

public static RaycastHit[] CastAll(this SphereData sphere, Vector3 direction, QueryTriggerInteraction qti);

public static RaycastHit[] CastAll(this SphereData sphere, Vector3 direction, LayerMask mask, QueryTriggerInteraction qti);

public static int CastAllNonAlloc(this SphereData sphere, Vector3 direction, RaycastHit[] hits, QueryTriggerInteraction qti);

public static int CastAllNonAlloc(this SphereData sphere, Vector3 direction, RaycastHit[] hits, LayerMask mask, QueryTriggerInteraction qti);
```

## Capsule Overlap Extensions

```csharp
public static bool Check(this CapsuleData capsule, QueryTriggerInteraction qti);

public static bool Check(this CapsuleData capsule, LayerMask mask, QueryTriggerInteraction qti);

public static Collider[] Overlap(this CapsuleData capsule, QueryTriggerInteraction qti);

public static Collider[] Overlap(this CapsuleData capsule, LayerMask mask, QueryTriggerInteraction qti);

public static int OverlapNonAlloc(this CapsuleData capsule, Collider[] colliders, QueryTriggerInteraction qti);

public static int OverlapNonAlloc(this CapsuleData capsule, Collider[] colliders, LayerMask mask, QueryTriggerInteraction qti);

public static bool Cast(this CapsuleData capsule, Vector3 direction, out RaycastHit hit, QueryTriggerInteraction qti);

public static bool Cast(this CapsuleData capsule, Vector3 direction, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti);

public static RaycastHit[] CastAll(this CapsuleData capsule, Vector3 direction, QueryTriggerInteraction qti);

public static RaycastHit[] CastAll(this CapsuleData capsule, Vector3 direction, LayerMask mask, QueryTriggerInteraction qti);

public static int CastAllNonAlloc(this CapsuleData capsule, Vector3 direction, RaycastHit[] hits, QueryTriggerInteraction qti);

public static int CastAllNonAlloc(this CapsuleData capsule, Vector3 direction, RaycastHit[] hits, LayerMask mask, QueryTriggerInteraction qti);
```

## Box Overlap Extensions

```csharp
public static bool Check(this BoxData box, QueryTriggerInteraction qti);

public static bool Check(this BoxData box, LayerMask mask, QueryTriggerInteraction qti);

public static Collider[] Overlap(this BoxData box, QueryTriggerInteraction qti);

public static Collider[] Overlap(this BoxData box, LayerMask mask, QueryTriggerInteraction qti);

public static int OverlapNonAlloc(this BoxData box, Collider[] colliders, QueryTriggerInteraction qti);

public static int OverlapNonAlloc(this BoxData box, Collider[] colliders, LayerMask mask, QueryTriggerInteraction qti);

public static bool Cast(this BoxData box, Vector3 direction, out RaycastHit hit, QueryTriggerInteraction qti);

public static bool Cast(this BoxData box, Vector3 direction, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti);

public static RaycastHit[] CastAll(this BoxData box, Vector3 direction, QueryTriggerInteraction qti);

public static RaycastHit[] CastAll(this BoxData box, Vector3 direction, LayerMask mask, QueryTriggerInteraction qti);

public static int CastAllNonAlloc(this BoxData box, Vector3 direction, RaycastHit[] hits, QueryTriggerInteraction qti);

public static int CastAllNonAlloc(this BoxData box, Vector3 direction, RaycastHit[] hits, LayerMask mask, QueryTriggerInteraction qti);
```

## Raycast Extensions

```csharp
public static bool Raycast(this RayData ray, out RaycastHit hit, QueryTriggerInteraction qti);

public static bool Raycast(this RayData ray, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti);

public static bool Raycast(this OverlapData overlapData, Vector3 direction, out RaycastHit hit, QueryTriggerInteraction qti);

public static bool Raycast(this OverlapData overlapData, Vector3 direction, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti);

public static RaycastHit[] RaycastAll(this RayData ray, QueryTriggerInteraction qti);

public static RaycastHit[] RaycastAll(this RayData ray, LayerMask mask, QueryTriggerInteraction qti);

public static RaycastHit[] RaycastAll(this OverlapData overlapData, Vector3 direction, QueryTriggerInteraction qti);

public static RaycastHit[] RaycastAll(this OverlapData overlapData, Vector3 direction, LayerMask mask, QueryTriggerInteraction qti);

public static int RaycastNonAlloc(this RayData ray, RaycastHit[] hits, QueryTriggerInteraction qti);

public static int RaycastNonAlloc(this RayData ray, RaycastHit[] hits, LayerMask mask, QueryTriggerInteraction qti);

public static int RaycastNonAlloc(this OverlapData overlapData, Vector3 direction, RaycastHit[] hits, QueryTriggerInteraction qti);

public static int RaycastNonAlloc(this OverlapData overlapData, Vector3 direction, RaycastHit[] hits, LayerMask mask, QueryTriggerInteraction qti);

public static bool Linecast(this OverlapData overlapData, Vector3 endPoint, out RaycastHit hit, QueryTriggerInteraction qti);

public static bool Linecast(this OverlapData overlapData, Vector3 endPoint, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti);

public static bool Linecast(this RayData ray, out RaycastHit hit, QueryTriggerInteraction qti);

public static bool Linecast(this RayData ray, out RaycastHit hit, LayerMask mask, QueryTriggerInteraction qti);
```