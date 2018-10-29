namespace MainContents.Editor
{
    using UnityEngine;
    using UnityEditor;

    public sealed class AnimationTextureGenerator
    {
        [MenuItem("Texture Generator/Generate")]
        static void Generate()
        {
            float[] Animation = new float[]
            {
                0f,
                6f,
                12f,
                18f,
                24f,
                30f,
                36f,
                42f,
                48f,
                54f,
                60f,
                66f,
                72f,
                78f,
                84f,
                90f,
            };

            Texture2D texture = new Texture2D(Animation.Length, 1, TextureFormat.ARGB32, false);
            for (int i = 0; i < texture.width; i++)
            {
                texture.SetPixel(i, 1, new Color(Animation[i] / 255f, 0.0f, 0.0f, 1.0f));
            }
            texture.Apply();

            var png = texture.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.dataPath + "/../DokabenAnimation.png", png);

            Debug.Log("Complete !");
        }
    }
}
