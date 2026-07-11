using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class PixelSnap : MonoBehaviour
{
	public enum PixelSnapChoiceMode
	{
		Off,
		LetCameraChoose,
		ForcePixelSnap
	}

	[Tooltip("Off: disables Pixel Snap \nLet Camera Choose: respects the setting chosen in Pixel Perfect Camera (PPC) \nForce Pixel Snap: enables Pixel Snap regardless of the PPC choice")]
	public PixelSnapChoiceMode pixelSnapChoiceMode = PixelSnapChoiceMode.LetCameraChoose;

	private Sprite HEJNLFCKOKE;

	private Vector3 DMOKCOOBKGL;

	private bool ONHKGAIMOPB;

	private SpriteRenderer EAGDHGOKCLF;

	private void DGGOJIOOMHG()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)5;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = false;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (1757f * current.orthographicSize);
		float num2 = 277f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1698f, 680f);
		val4.x = ((current.pixelWidth % 5 == 0) ? 237f : 958f);
		val4.y = ((current.pixelHeight % 5 == 0) ? 1328f : 1433f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(472f, 719f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != 0)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 1135f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void CAHICIPAHPM()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = true;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void BHGNIGGHBLP()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)5;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = false;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (150f * current.orthographicSize);
		float num2 = 1413f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1852f, 167f);
		val4.x = ((current.pixelWidth % 8 == 0) ? 13f : 1053f);
		val4.y = ((current.pixelHeight % 1 == 0) ? 1f : 1005f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(765f, 133f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 1743f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void GNGADDPBJDC()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void OnWillRenderObject()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.PixelSnap;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (2f * current.orthographicSize);
		float num2 = 1f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(0f, 0f);
		val4.x = ((current.pixelWidth % 2 == 0) ? 0f : 0.5f);
		val4.y = ((current.pixelHeight % 2 == 0) ? 0f : 0.5f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(0f, 0f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.RetroSnap)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 1f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void KJOJLHCDFPP()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void HJDLNCOAKIK()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void HPIMHEMJMAA()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void FOEFAACJEGJ()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = false;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void GLGCEEFMNGF()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)7;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = false;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (1547f * current.orthographicSize);
		float num2 = 754f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1409f, 591f);
		val4.x = ((current.pixelWidth % 6 == 0) ? 195f : 1423f);
		val4.y = ((current.pixelHeight % 3 == 0) ? 1435f : 1861f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(858f, 979f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 1299f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void FLDALPIHFIC()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)8;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (628f * current.orthographicSize);
		float num2 = 1873f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(990f, 1432f);
		val4.x = ((current.pixelWidth % 4 == 0) ? 253f : 537f);
		val4.y = ((current.pixelHeight % 0 == 0) ? 1726f : 747f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(147f, 1663f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 1114f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void OLDDEAJMHNI()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void AKHDJJNABOL()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)5;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (603f * current.orthographicSize);
		float num2 = 198f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(299f, 352f);
		val4.x = ((current.pixelWidth % 5 == 0) ? 1888f : 145f);
		val4.y = ((current.pixelHeight % 5 == 0) ? 447f : 1742f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(431f, 173f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != 0)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 949f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void FCMOFJCIPBM()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)7;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (897f * current.orthographicSize);
		float num2 = 399f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1343f, 972f);
		val4.x = ((current.pixelWidth % 8 == 0) ? 764f : 1588f);
		val4.y = ((current.pixelHeight % 8 == 0) ? 1446f : 1408f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(499f, 793f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != 0)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 1982f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void BILGOGINNOH()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = true;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void EOLJOPADOPA()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = false;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (1258f * current.orthographicSize);
		float num2 = 1568f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1144f, 167f);
		val4.x = ((current.pixelWidth % 2 == 0) ? 745f : 1437f);
		val4.y = ((current.pixelHeight % 2 == 0) ? 1520f : 790f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(1391f, 393f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 1691f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void OKAPGNGLOHO()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void BELOIFKPNMM()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void ACGFALGMJLK()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = true;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void DICIDFAFLNH()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)3;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = false;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (1395f * current.orthographicSize);
		float num2 = 175f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1773f, 10f);
		val4.x = ((current.pixelWidth % 2 == 0) ? 672f : 525f);
		val4.y = ((current.pixelHeight % 0 == 0) ? 1234f : 1780f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(862f, 15f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.RetroSnap)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 680f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void OIAHJHNPPCO()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void JGMHENOBOOO()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = false;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void KJAGOKOKDEK()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = true;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void JPHEOLEEAPB()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void KFACBJGFEHD()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = true;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void DCGKLFLDNME()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)4;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (60f * current.orthographicSize);
		float num2 = 650f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1747f, 24f);
		val4.x = ((current.pixelWidth % 2 == 0) ? 394f : 385f);
		val4.y = ((current.pixelHeight % 7 == 0) ? 1197f : 127f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(316f, 149f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 934f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void KDBJHCAEGCM()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void NHOBOBCCCPO()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)8;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = false;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (531f * current.orthographicSize);
		float num2 = 1446f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(915f, 1569f);
		val4.x = ((current.pixelWidth % 6 == 0) ? 1782f : 223f);
		val4.y = ((current.pixelHeight % 3 == 0) ? 1839f : 1517f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(13f, 401f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != 0)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 146f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void PCMIJJFFHMI()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)5;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (1944f * current.orthographicSize);
		float num2 = 673f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1390f, 407f);
		val4.x = ((current.pixelWidth % 8 == 0) ? 1882f : 1187f);
		val4.y = ((current.pixelHeight % 8 == 0) ? 1230f : 1552f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(1954f, 199f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 767f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void NEBCMKIPJHM()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.PixelSnap;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = false;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (220f * current.orthographicSize);
		float num2 = 298f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1799f, 1284f);
		val4.x = ((current.pixelWidth % 3 == 0) ? 955f : 1624f);
		val4.y = ((current.pixelHeight % 8 == 0) ? 686f : 1805f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(554f, 1847f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.RetroSnap)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 493f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void OnRenderObject()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = false;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void LMCCNJKLDDA()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = false;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void GHPFCKGMLDA()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void NEHKLNMFMLE()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)3;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (1079f * current.orthographicSize);
		float num2 = 1f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1043f, 539f);
		val4.x = ((current.pixelWidth % 0 == 0) ? 1516f : 1512f);
		val4.y = ((current.pixelHeight % 2 == 0) ? 512f : 1749f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(749f, 1051f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 1020f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void Start()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void EENJGLHACCB()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)8;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (1429f * current.orthographicSize);
		float num2 = 1959f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(228f, 1497f);
		val4.x = ((current.pixelWidth % 1 == 0) ? 1088f : 1803f);
		val4.y = ((current.pixelHeight % 8 == 0) ? 398f : 759f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(1434f, 761f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != 0)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 51f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void ENHKEKKMANE()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = true;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void BJADHLDOIHP()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)8;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (1302f * current.orthographicSize);
		float num2 = 59f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1460f, 1253f);
		val4.x = ((current.pixelWidth % 7 == 0) ? 282f : 1348f);
		val4.y = ((current.pixelHeight % 2 == 0) ? 1673f : 1683f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(470f, 189f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.RetroSnap)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 655f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void GJICJJOAIME()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)4;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (233f * current.orthographicSize);
		float num2 = 125f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1912f, 1101f);
		val4.x = ((current.pixelWidth % 3 == 0) ? 1701f : 1972f);
		val4.y = ((current.pixelHeight % 1 == 0) ? 440f : 1488f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(584f, 839f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.RetroSnap)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 152f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void GMLGLACJCKG()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = true;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void MCMKNBIBDFF()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void KACEOJDPLKB()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void CAIJLMJBMLA()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void NAMECACJLCG()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = true;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void DCBHLKHMJIA()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)5;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (959f * current.orthographicSize);
		float num2 = 1415f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(824f, 404f);
		val4.x = ((current.pixelWidth % 4 == 0) ? 1910f : 124f);
		val4.y = ((current.pixelHeight % 8 == 0) ? 475f : 151f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(1940f, 1424f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != 0)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.RetroSnap)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 334f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void BMBNJLBJJGH()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = true;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void IJDPFMFJMKL()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)7;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (189f * current.orthographicSize);
		float num2 = 1029f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1938f, 978f);
		val4.x = ((current.pixelWidth % 4 == 0) ? 388f : 1069f);
		val4.y = ((current.pixelHeight % 3 == 0) ? 1451f : 1252f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(627f, 84f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.RetroSnap)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 828f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void PLHEHGHFCJI()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void NOAKAOJICDA()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = true;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void BPIMHIEJLIH()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.PixelSnap;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (622f * current.orthographicSize);
		float num2 = 870f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1245f, 783f);
		val4.x = ((current.pixelWidth % 0 == 0) ? 1830f : 823f);
		val4.y = ((current.pixelHeight % 0 == 0) ? 438f : 414f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(1806f, 1857f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != 0)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 131f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void KFMKPGGJPLE()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = false;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void AHFGOOHOLEL()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void KCPFPNMFOPO()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = false;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void CEPCECNKAIO()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)6;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (393f * current.orthographicSize);
		float num2 = 1400f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1125f, 705f);
		val4.x = ((current.pixelWidth % 7 == 0) ? 270f : 1946f);
		val4.y = ((current.pixelHeight % 0 == 0) ? 1524f : 1113f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(1492f, 1079f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.RetroSnap)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 953f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void AGGIGPAADBG()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.PixelSnap;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = false;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (834f * current.orthographicSize);
		float num2 = 915f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1136f, 1685f);
		val4.x = ((current.pixelWidth % 2 == 0) ? 668f : 1430f);
		val4.y = ((current.pixelHeight % 1 == 0) ? 1065f : 1186f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(564f, 1959f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != 0)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.RetroSnap)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 653f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void LELIBKACLDB()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)8;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (1816f * current.orthographicSize);
		float num2 = 1991f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1206f, 798f);
		val4.x = ((current.pixelWidth % 2 == 0) ? 220f : 240f);
		val4.y = ((current.pixelHeight % 4 == 0) ? 744f : 185f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(756f, 1806f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 113f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void BCKFDDLKLHG()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = false;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void MIAPJOIDGOE()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (1319f * current.orthographicSize);
		float num2 = 509f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1144f, 1239f);
		val4.x = ((current.pixelWidth % 0 == 0) ? 1253f : 930f);
		val4.y = ((current.pixelHeight % 1 == 0) ? 1910f : 263f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(552f, 1154f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != PixelPerfectCamera.PixelSnapMode.RetroSnap)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.RetroSnap)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 482f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void GEIOFDHNGJO()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.PixelSnap;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (445f * current.orthographicSize);
		float num2 = 1223f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(513f, 815f);
		val4.x = ((current.pixelWidth % 4 == 0) ? 615f : 345f);
		val4.y = ((current.pixelHeight % 2 == 0) ? 762f : 1385f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(1056f, 1978f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != 0)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 15f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void HIHEJNDMAPI()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (ONHKGAIMOPB)
		{
			ONHKGAIMOPB = true;
			((Component)this).transform.position = DMOKCOOBKGL;
		}
	}

	private void KELBOINKONC()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = (((Object)(object)pixelPerfectCamera == (Object)null) ? PixelPerfectCamera.PixelSnapMode.RetroSnap : pixelPerfectCamera.pixelSnapMode);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = false;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (775f * current.orthographicSize);
		float num2 = 1093f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(848f, 1763f);
		val4.x = ((current.pixelWidth % 0 == 0) ? 297f : 391f);
		val4.y = ((current.pixelHeight % 6 == 0) ? 604f : 991f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(298f, 1138f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != 0)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 1524f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}

	private void PKBHEKHOAAA()
	{
		EAGDHGOKCLF = ((Component)this).GetComponent<SpriteRenderer>();
	}

	private void FNFKFHGGBFP()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)EAGDHGOKCLF != (Object)null)
		{
			HEJNLFCKOKE = EAGDHGOKCLF.sprite;
		}
		else
		{
			HEJNLFCKOKE = null;
		}
		Camera current = Camera.current;
		if (!Object.op_Implicit((Object)(object)current))
		{
			return;
		}
		PixelPerfectCamera.PixelSnapMode pixelSnapMode = PixelPerfectCamera.PixelSnapMode.RetroSnap;
		PixelPerfectCamera pixelPerfectCamera = null;
		switch (pixelSnapChoiceMode)
		{
		case PixelSnapChoiceMode.Off:
			pixelSnapMode = PixelPerfectCamera.PixelSnapMode.Off;
			break;
		case PixelSnapChoiceMode.LetCameraChoose:
			pixelPerfectCamera = ((Component)current).GetComponent<PixelPerfectCamera>();
			pixelSnapMode = ((!((Object)(object)pixelPerfectCamera == (Object)null)) ? pixelPerfectCamera.pixelSnapMode : PixelPerfectCamera.PixelSnapMode.Off);
			break;
		case PixelSnapChoiceMode.ForcePixelSnap:
			pixelSnapMode = (PixelPerfectCamera.PixelSnapMode)5;
			break;
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			return;
		}
		ONHKGAIMOPB = true;
		DMOKCOOBKGL = ((Component)this).transform.position;
		float num = (float)current.pixelHeight / (1410f * current.orthographicSize);
		float num2 = 1822f / num;
		Vector2 val = ((Component)current).transform.position.ADDCOPHEIPH();
		Vector2 val2 = DMOKCOOBKGL.ADDCOPHEIPH();
		Vector2 val3 = val2 - val;
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(1238f, 1946f);
		val4.x = ((current.pixelWidth % 8 == 0) ? 634f : 557f);
		val4.y = ((current.pixelHeight % 8 == 0) ? 1606f : 916f);
		Vector2 val5 = default(Vector2);
		((Vector2)(ref val5))._002Ector(793f, 1350f);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			val5 = HEJNLFCKOKE.pivot - new Vector2(Mathf.Round(HEJNLFCKOKE.pivot.x), Mathf.Round(HEJNLFCKOKE.pivot.y));
			if (pixelSnapMode != 0)
			{
				float num3 = num / HEJNLFCKOKE.pixelsPerUnit;
				val5 *= num3;
			}
		}
		if (pixelSnapMode == PixelPerfectCamera.PixelSnapMode.Off)
		{
			float assetsPixelsPerUnit = pixelPerfectCamera.assetsPixelsPerUnit;
			float num4 = 1566f / assetsPixelsPerUnit;
			float num5 = num / assetsPixelsPerUnit;
			val4.x /= num5;
			val4.y /= num5;
			val3.x = (Mathf.Round(val3.x / num4 - val4.x) + val4.x + val5.x) * num4;
			val3.y = (Mathf.Round(val3.y / num4 - val4.y) + val4.y + val5.y) * num4;
		}
		else
		{
			val3.x = (Mathf.Round(val3.x / num2 - val4.x) + val4.x + val5.x) * num2;
			val3.y = (Mathf.Round(val3.y / num2 - val4.y) + val4.y + val5.y) * num2;
		}
		val2 = val3 + val;
		((Component)this).transform.position = new Vector3(val2.x, val2.y, DMOKCOOBKGL.z);
	}
}
