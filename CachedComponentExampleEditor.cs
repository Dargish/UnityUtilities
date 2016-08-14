#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CachedComponentExample))]
public class CachedComponentExampleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        CachedComponentExample cacheComponentExample = (CachedComponentExample)target;

        EditorGUI.BeginChangeCheck();
        GameObject targetObj = (GameObject)EditorGUILayout.ObjectField(new GUIContent("Target", "The target GameObject"), cacheComponentExample.targetRigidbody.gameObject, typeof(GameObject), true);
        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(cacheComponentExample, "Target");
            EditorUtility.SetDirty(cacheComponentExample);
            cacheComponentExample.targetRigidbody.gameObject = targetObj;
        }
    }
}
#endif