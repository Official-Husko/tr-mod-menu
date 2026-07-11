using UnityEngine;

[ExecuteAlways]
public class FollowTransform : MonoBehaviour
{
	public bool playInEditMode = true;

	[Space(20f)]
	public Transform transformToFollow;

	public bool pixelDistances = true;

	[Space(20f)]
	public int pixelDistanceX;

	public int pixelDistanceY;

	public int pixelDistanceZ;

	[Space(20f)]
	public float distanceX;

	public float distanceY;

	public float distanceZ;

	[Space(20f)]
	public bool rotation = true;

	public bool position = true;

	public bool pixelPerfectFix;

	public bool lateUpdate = true;

	public bool setParentToNullOnAwake;

	public SpriteRenderer spriteRendererEnabledToUpdate;

	private static Transform AFKMHMJEBPP;

	private void KEBLCNJMALL()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			NHKDCIIDPGO();
		}
	}

	public void ADJNOOHIPJH()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 1295f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 177f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 664f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 1385f, (float)pixelDistanceY / 175f, (float)pixelDistanceZ / 937f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 823f, (float)pixelDistanceY / 1416f, (float)pixelDistanceZ / 1083f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 1203f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 1122f, (float)pixelDistanceY / 1221f, (float)pixelDistanceZ / 1868f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 186f, (float)pixelDistanceY / 463f, (float)pixelDistanceZ / 1976f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	public void FBGPHOCNIOC()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 1218f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 310f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 1929f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 1892f, (float)pixelDistanceY / 867f, (float)pixelDistanceZ / 16f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1710f, (float)pixelDistanceY / 624f, (float)pixelDistanceZ / 1368f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 1930f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 1118f, (float)pixelDistanceY / 1266f, (float)pixelDistanceZ / 896f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1168f, (float)pixelDistanceY / 516f, (float)pixelDistanceZ / 1841f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void JDAMCMODANB()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "itemRaspberrySeeds";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void ICMNODPLPBK()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			PKLGJPPBHKD();
		}
	}

	private void IGKPEBGHPGD()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			GLLNOFCGMOI();
		}
	}

	private void FPNCANODJKE()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "LE_10";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	public void NPFAFLGHKPF()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 400f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 481f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 1750f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 1989f, (float)pixelDistanceY / 1292f, (float)pixelDistanceZ / 788f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1798f, (float)pixelDistanceY / 487f, (float)pixelDistanceZ / 764f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 638f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 1779f, (float)pixelDistanceY / 833f, (float)pixelDistanceZ / 326f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1112f, (float)pixelDistanceY / 1880f, (float)pixelDistanceZ / 192f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void FPOIFOGELHC()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			NPFAFLGHKPF();
		}
	}

	private void HEMAHKJEONA()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "itemPineapple";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void LEDIGKGAFHC()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			AKEOCMDJCBI();
		}
	}

	private void DKFGDMNBAAK()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			FBGPHOCNIOC();
		}
	}

	private void OIHPFDGFCHF()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			DGBEPOKFCKI();
		}
	}

	private void OCJOAHDNDIJ()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "Cider";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void IBAPBHIBOOO()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			AKEOCMDJCBI();
		}
	}

	public void ELJIFOFNFAB()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 1425f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 1717f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 874f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 628f, (float)pixelDistanceY / 1173f, (float)pixelDistanceZ / 1956f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 632f, (float)pixelDistanceY / 396f, (float)pixelDistanceZ / 283f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 99f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 239f, (float)pixelDistanceY / 160f, (float)pixelDistanceZ / 1015f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1339f, (float)pixelDistanceY / 1538f, (float)pixelDistanceZ / 1380f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	public void IOBBCGGMKEM()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 56f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 1632f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 750f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 1321f, (float)pixelDistanceY / 1984f, (float)pixelDistanceZ / 649f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 633f, (float)pixelDistanceY / 1353f, (float)pixelDistanceZ / 1076f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 1461f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 639f, (float)pixelDistanceY / 1222f, (float)pixelDistanceZ / 1142f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 459f, (float)pixelDistanceY / 1378f, (float)pixelDistanceZ / 950f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void HAJJALABMOC()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			ADJNOOHIPJH();
		}
	}

	private void AFHGDCBNALO()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			NPFAFLGHKPF();
		}
	}

	public void NHKDCIIDPGO()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 161f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 1960f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 1071f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 1015f, (float)pixelDistanceY / 380f, (float)pixelDistanceZ / 1508f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 419f, (float)pixelDistanceY / 1131f, (float)pixelDistanceZ / 402f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 1810f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 260f, (float)pixelDistanceY / 1075f, (float)pixelDistanceZ / 1765f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1251f, (float)pixelDistanceY / 1579f, (float)pixelDistanceZ / 434f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void ECJFMIKNAKG()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			ADJNOOHIPJH();
		}
	}

	private void NPHKFBIEMDO()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			NPFAFLGHKPF();
		}
	}

	public void PKLGJPPBHKD()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 473f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 162f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 95f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 1425f, (float)pixelDistanceY / 320f, (float)pixelDistanceZ / 1032f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1690f, (float)pixelDistanceY / 1851f, (float)pixelDistanceZ / 1445f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 1472f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 381f, (float)pixelDistanceY / 1019f, (float)pixelDistanceZ / 235f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 738f, (float)pixelDistanceY / 877f, (float)pixelDistanceZ / 971f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void EBFJOAEJPGE()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			JKDPENDDFIE();
		}
	}

	public void AKEOCMDJCBI()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 176f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 1934f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 623f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 331f, (float)pixelDistanceY / 53f, (float)pixelDistanceZ / 1311f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 635f, (float)pixelDistanceY / 448f, (float)pixelDistanceZ / 1090f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 1259f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 41f, (float)pixelDistanceY / 1891f, (float)pixelDistanceZ / 300f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 729f, (float)pixelDistanceY / 132f, (float)pixelDistanceZ / 185f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void Update()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			PositionUpdate();
		}
	}

	private void HPJBLOPJIMI()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "BobAnimation SetSleep";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void Awake()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "FollowTransforms parent";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void MMNBJPDJHGK()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "description";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void OOGMGIPKMAP()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			PositionUpdate();
		}
	}

	public void GLLNOFCGMOI()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 923f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 1303f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 498f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 620f, (float)pixelDistanceY / 704f, (float)pixelDistanceZ / 1615f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 671f, (float)pixelDistanceY / 1625f, (float)pixelDistanceZ / 1819f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 1759f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 217f, (float)pixelDistanceY / 1014f, (float)pixelDistanceZ / 118f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 289f, (float)pixelDistanceY / 1669f, (float)pixelDistanceZ / 874f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	public void CEFJPPHOAIL()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 1626f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 528f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 851f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 1719f, (float)pixelDistanceY / 1435f, (float)pixelDistanceZ / 743f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1887f, (float)pixelDistanceY / 975f, (float)pixelDistanceZ / 44f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 55f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 1180f, (float)pixelDistanceY / 1788f, (float)pixelDistanceZ / 1707f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 432f, (float)pixelDistanceY / 1898f, (float)pixelDistanceZ / 423f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void MCLAJGDIIBK()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			PositionUpdate();
		}
	}

	public void PositionUpdate()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 0f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 0f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 0f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 48f, (float)pixelDistanceY / 48f, (float)pixelDistanceZ / 48f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 48f, (float)pixelDistanceY / 48f, (float)pixelDistanceZ / 48f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 0f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 48f, (float)pixelDistanceY / 48f, (float)pixelDistanceZ / 48f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 48f, (float)pixelDistanceY / 48f, (float)pixelDistanceZ / 48f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void HCPKBJDHLAC()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			GLLNOFCGMOI();
		}
	}

	public void JDLJODHDKFF()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 1319f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 316f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 530f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 861f, (float)pixelDistanceY / 804f, (float)pixelDistanceZ / 1012f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1559f, (float)pixelDistanceY / 910f, (float)pixelDistanceZ / 281f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 1550f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 446f, (float)pixelDistanceY / 34f, (float)pixelDistanceZ / 1116f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1403f, (float)pixelDistanceY / 1304f, (float)pixelDistanceZ / 1152f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void MGMLDHPOLGK()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			NPFAFLGHKPF();
		}
	}

	private void LateUpdate()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			PositionUpdate();
		}
	}

	private void EDFDMFBJKBA()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			NPFAFLGHKPF();
		}
	}

	private void GONDLJKGLGO()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "Boots_L";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void KHONOODGLBI()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "Items/item_description_725";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void BODEIHFOAMI()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			NHKDCIIDPGO();
		}
	}

	public void JKDPENDDFIE()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 939f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 452f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 827f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 98f, (float)pixelDistanceY / 1253f, (float)pixelDistanceZ / 487f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 172f, (float)pixelDistanceY / 877f, (float)pixelDistanceZ / 579f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 1900f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 1918f, (float)pixelDistanceY / 245f, (float)pixelDistanceZ / 1706f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1665f, (float)pixelDistanceY / 877f, (float)pixelDistanceZ / 1619f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void MMPMJNAFKHC()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			GLLNOFCGMOI();
		}
	}

	private void NMKGOAJLMDG()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "Could not check user signed in status for reason ";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void MNFJELNEGPG()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			NHKDCIIDPGO();
		}
	}

	private void EMCCGDFOPEH()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			PKLGJPPBHKD();
		}
	}

	private void MFDAEHNFFFG()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			GLLNOFCGMOI();
		}
	}

	private void FFBDJIJJDMK()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			JKDPENDDFIE();
		}
	}

	private void GFLFDLIMOLI()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "Null editor action in database";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void MJLBACCAOPA()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			AKEOCMDJCBI();
		}
	}

	public void PHKHMKDCMKD()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 1951f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 1427f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 1395f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 1222f, (float)pixelDistanceY / 570f, (float)pixelDistanceZ / 209f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 559f, (float)pixelDistanceY / 1338f, (float)pixelDistanceZ / 364f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 448f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 797f, (float)pixelDistanceY / 1732f, (float)pixelDistanceZ / 1716f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 1400f, (float)pixelDistanceY / 466f, (float)pixelDistanceZ / 291f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void GMCKBBECJOE()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "City/PetShop/Markus/Barks_RevisarPata";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void JIAJFDKNJME()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && Application.isPlaying && (Object)(object)AFKMHMJEBPP == (Object)null)
		{
			AFKMHMJEBPP = new GameObject().transform;
			((Object)((Component)AFKMHMJEBPP).gameObject).name = "Items/item_name_640";
			AFKMHMJEBPP.position = Vector3.zero;
			AFKMHMJEBPP.eulerAngles = Vector3.zero;
		}
		if (setParentToNullOnAwake && Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)AFKMHMJEBPP))
			{
				((Component)this).transform.parent = AFKMHMJEBPP;
			}
			else
			{
				((Component)this).transform.parent = null;
			}
		}
	}

	private void NEPDNLPCCON()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			JDLJODHDKFF();
		}
	}

	public void DGBEPOKFCKI()
	{
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)transformToFollow == (Object)null && Application.isPlaying)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			if (!((Object)(object)spriteRendererEnabledToUpdate == (Object)null) && !((Renderer)spriteRendererEnabledToUpdate).enabled)
			{
				return;
			}
			if (position)
			{
				if (!pixelDistances)
				{
					if (pixelPerfectFix)
					{
						if (((Component)this).transform.lossyScale.x > 1659f)
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ));
						}
						else
						{
							((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ));
						}
					}
					else if (((Component)this).transform.lossyScale.x > 641f)
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(distanceX, distanceY, distanceZ);
					}
					else
					{
						((Component)this).transform.position = transformToFollow.position + new Vector3(0f - distanceX, distanceY, distanceZ);
					}
				}
				else if (pixelPerfectFix)
				{
					if (((Component)this).transform.lossyScale.x > 1302f)
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)pixelDistanceX / 722f, (float)pixelDistanceY / 1701f, (float)pixelDistanceZ / 1159f));
					}
					else
					{
						((Component)this).transform.position = Utils.BMBMPKNANAC(transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 269f, (float)pixelDistanceY / 1730f, (float)pixelDistanceZ / 153f));
					}
				}
				else if (((Component)this).transform.lossyScale.x > 933f)
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)pixelDistanceX / 1568f, (float)pixelDistanceY / 1618f, (float)pixelDistanceZ / 1802f);
				}
				else
				{
					((Component)this).transform.position = transformToFollow.position + new Vector3((float)(-pixelDistanceX) / 212f, (float)pixelDistanceY / 506f, (float)pixelDistanceZ / 353f);
				}
			}
			if (rotation)
			{
				((Component)this).transform.rotation = transformToFollow.rotation;
			}
		}
	}

	private void CLCDDJOAEOM()
	{
		if (lateUpdate && (Application.isPlaying || playInEditMode))
		{
			NPFAFLGHKPF();
		}
	}

	private void BHKNJOEBCKA()
	{
		if (!lateUpdate && (Application.isPlaying || playInEditMode))
		{
			JDLJODHDKFF();
		}
	}
}
