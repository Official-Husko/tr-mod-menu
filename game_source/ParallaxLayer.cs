using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
	public float parallaxMultiplier = 0.5f;

	private ParallaxBackground KCLJHBJDIGO;

	private Vector2 IJBCANJOBNN;

	private Vector2 FIFONOEDBCD;

	public void AIDDACIFBHD(ParallaxBackground EEEGADJMFKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		KCLJHBJDIGO = EEEGADJMFKP;
		IJBCANJOBNN = Vector2.op_Implicit(((Component)this).transform.localPosition - Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
		FIFONOEDBCD = Vector2.op_Implicit(((Component)this).transform.localPosition + Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
	}

	public void CAHCABKPNIM(ParallaxBackground EEEGADJMFKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		KCLJHBJDIGO = EEEGADJMFKP;
		IJBCANJOBNN = Vector2.op_Implicit(((Component)this).transform.localPosition - Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
		FIFONOEDBCD = Vector2.op_Implicit(((Component)this).transform.localPosition + Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
	}

	public void FFOAMPLJKLJ(ParallaxBackground EEEGADJMFKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		KCLJHBJDIGO = EEEGADJMFKP;
		IJBCANJOBNN = Vector2.op_Implicit(((Component)this).transform.localPosition - Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
		FIFONOEDBCD = Vector2.op_Implicit(((Component)this).transform.localPosition + Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
	}

	public void MIKJBOBFNPO(float OLLBKGHNHNC, float JLLLGPGBCOK, int JIIGOACEIKL)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(Mathf.Lerp(IJBCANJOBNN.x, FIFONOEDBCD.x, OLLBKGHNHNC), Mathf.Lerp(IJBCANJOBNN.y, FIFONOEDBCD.y, JLLLGPGBCOK))), JIIGOACEIKL);
	}

	public void JICPPABIGCG(float OLLBKGHNHNC, float JLLLGPGBCOK, int JIIGOACEIKL)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(Mathf.Lerp(IJBCANJOBNN.x, FIFONOEDBCD.x, OLLBKGHNHNC), Mathf.Lerp(IJBCANJOBNN.y, FIFONOEDBCD.y, JLLLGPGBCOK))), JIIGOACEIKL);
	}

	public void SetupParallaxLayer(ParallaxBackground EEEGADJMFKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		KCLJHBJDIGO = EEEGADJMFKP;
		IJBCANJOBNN = Vector2.op_Implicit(((Component)this).transform.localPosition - Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
		FIFONOEDBCD = Vector2.op_Implicit(((Component)this).transform.localPosition + Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
	}

	public void JIPOPPJMCLH(float OLLBKGHNHNC, float JLLLGPGBCOK, int JIIGOACEIKL)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(Mathf.Lerp(IJBCANJOBNN.x, FIFONOEDBCD.x, OLLBKGHNHNC), Mathf.Lerp(IJBCANJOBNN.y, FIFONOEDBCD.y, JLLLGPGBCOK))), JIIGOACEIKL);
	}

	public void OAIKEDAADGM(float OLLBKGHNHNC, float JLLLGPGBCOK, int JIIGOACEIKL)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(Mathf.Lerp(IJBCANJOBNN.x, FIFONOEDBCD.x, OLLBKGHNHNC), Mathf.Lerp(IJBCANJOBNN.y, FIFONOEDBCD.y, JLLLGPGBCOK))), JIIGOACEIKL);
	}

	public void LJAFDIBDPME(ParallaxBackground EEEGADJMFKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		KCLJHBJDIGO = EEEGADJMFKP;
		IJBCANJOBNN = Vector2.op_Implicit(((Component)this).transform.localPosition - Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
		FIFONOEDBCD = Vector2.op_Implicit(((Component)this).transform.localPosition + Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
	}

	public void GAAPJFFAEMI(float OLLBKGHNHNC, float JLLLGPGBCOK, int JIIGOACEIKL)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(Mathf.Lerp(IJBCANJOBNN.x, FIFONOEDBCD.x, OLLBKGHNHNC), Mathf.Lerp(IJBCANJOBNN.y, FIFONOEDBCD.y, JLLLGPGBCOK))), JIIGOACEIKL);
	}

	public void LBNJDMPILCP(float OLLBKGHNHNC, float JLLLGPGBCOK, int JIIGOACEIKL)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(Mathf.Lerp(IJBCANJOBNN.x, FIFONOEDBCD.x, OLLBKGHNHNC), Mathf.Lerp(IJBCANJOBNN.y, FIFONOEDBCD.y, JLLLGPGBCOK))), JIIGOACEIKL);
	}

	public void IOJDHGLJGLH(float OLLBKGHNHNC, float JLLLGPGBCOK, int JIIGOACEIKL)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(Mathf.Lerp(IJBCANJOBNN.x, FIFONOEDBCD.x, OLLBKGHNHNC), Mathf.Lerp(IJBCANJOBNN.y, FIFONOEDBCD.y, JLLLGPGBCOK))), JIIGOACEIKL);
	}

	public void MMPKDEKLMNG(float OLLBKGHNHNC, float JLLLGPGBCOK, int JIIGOACEIKL)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(Mathf.Lerp(IJBCANJOBNN.x, FIFONOEDBCD.x, OLLBKGHNHNC), Mathf.Lerp(IJBCANJOBNN.y, FIFONOEDBCD.y, JLLLGPGBCOK))), JIIGOACEIKL);
	}

	public void BIPCDIOMAOK(ParallaxBackground EEEGADJMFKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		KCLJHBJDIGO = EEEGADJMFKP;
		IJBCANJOBNN = Vector2.op_Implicit(((Component)this).transform.localPosition - Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
		FIFONOEDBCD = Vector2.op_Implicit(((Component)this).transform.localPosition + Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
	}

	public void EHJHLCFEJNG(ParallaxBackground EEEGADJMFKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		KCLJHBJDIGO = EEEGADJMFKP;
		IJBCANJOBNN = Vector2.op_Implicit(((Component)this).transform.localPosition - Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
		FIFONOEDBCD = Vector2.op_Implicit(((Component)this).transform.localPosition + Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
	}

	public void DGOPHOOPGOM(ParallaxBackground EEEGADJMFKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		KCLJHBJDIGO = EEEGADJMFKP;
		IJBCANJOBNN = Vector2.op_Implicit(((Component)this).transform.localPosition - Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
		FIFONOEDBCD = Vector2.op_Implicit(((Component)this).transform.localPosition + Vector2.op_Implicit(KCLJHBJDIGO.maxParallaxDisplacement * parallaxMultiplier));
	}

	public void SetParallaxMovement(float OLLBKGHNHNC, float JLLLGPGBCOK, int JIIGOACEIKL)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(Mathf.Lerp(IJBCANJOBNN.x, FIFONOEDBCD.x, OLLBKGHNHNC), Mathf.Lerp(IJBCANJOBNN.y, FIFONOEDBCD.y, JLLLGPGBCOK))), JIIGOACEIKL);
	}
}
