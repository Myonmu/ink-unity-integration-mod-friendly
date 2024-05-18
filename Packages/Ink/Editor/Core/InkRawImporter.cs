using System.IO;
using UnityEditor.AssetImporters;
using UnityEngine;
namespace InkSystem.Editor
{
    [ScriptedImporter(1,"ink")]
    public class InkRawImporter: ScriptedImporter
    {

        public override void OnImportAsset(AssetImportContext ctx)
        {
            var textAsset = new TextAsset(File.ReadAllText(ctx.assetPath));
            ctx.AddObjectToAsset("text",textAsset);
        }
    }
}