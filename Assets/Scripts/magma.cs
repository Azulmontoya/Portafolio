using UnityEngine;
using System.Collections.Generic;


public class movTexture : MonoBehaviour

{
    public float scrollSpeed = 0.1f;
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void Update()
    {
        float moveThis = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new
            Vector2(0, moveThis));
    }

}