Shader "Shader Forge/unlit_gold" {
	Properties {
		_base ("base", 2D) = "white" {}
		_eye ("eye", 2D) = "white" {}
		_main_color ("main_color", Vector) = (1,1,1,1)
		_fresnel ("fresnel", Range(0, 5)) = 5
		_node_8724 ("node_8724", Vector) = (1,1,1,1)
		_cubemap ("cubemap", Cube) = "_Skybox" {}
		_frnel ("frnel", Vector) = (1,1,1,1)
		_node_5847 ("node_5847", Range(0, 1)) = 1
		_node_1253 ("node_1253", Range(0, 1)) = 0.5
		_specular ("specular", 2D) = "white" {}
		_specular_color ("specular_color", Vector) = (1,1,1,1)
		_node_8675 ("node_8675", Range(0, 1)) = 0
		_node_6771 ("node_6771", 2D) = "white" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
	//CustomEditor "ShaderForgeMaterialInspector"
}