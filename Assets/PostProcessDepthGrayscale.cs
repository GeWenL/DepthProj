using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Camera))]
public class PostProcessDepthGrayscale : MonoBehaviour {

	public Material mMat;  
	private Camera mCamera;
	void Start () {  
		mCamera = gameObject.GetComponent<Camera> ();
		//设置Camera的depthTextureMode,使得摄像机能生成深度图。
		if (mCamera) {
			mCamera.depthTextureMode = DepthTextureMode.Depth;  
		}
	}  

	void OnRenderImage (RenderTexture source, RenderTexture destination){  
		if (null != mMat)
		{
			Graphics.Blit(source, destination, mMat);
		}
		else
		{
			Graphics.Blit(source, destination);
		}
	} 
}

