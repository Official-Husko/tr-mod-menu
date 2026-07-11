using UnityEngine;

public class OfferingStatueAnimator : MonoBehaviour
{
	[SerializeField]
	[Tooltip("SpriteAnimation hijo: loop=false, startOnEnable=true, disableAtTheEnd=true")]
	private SpriteAnimation successAnimation;

	[SerializeField]
	[Tooltip("SpriteAnimation hijo: loop=false, startOnEnable=true, disableAtTheEnd=true")]
	private SpriteAnimation failAnimation;

	[Tooltip("SpriteRenderers que harán transición de alpha 0 → 1 al llamar PlaySuccess/PlayFail")]
	[Space(10f)]
	public SpriteRenderer[] alphaTransitionRenderers;

	public float transitionInTime = 0.5f;

	public float transitionOutTime = 0.5f;

	private float KJCGGOGPDIF;

	private float PHNBCKONEML;

	private float AJJGPMMEMCL;

	private float BFNNNHDBBDO;

	private bool NPFOCKECJOJ;

	private float DBLNNGBHFNC()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (alphaTransitionRenderers.Length != 0 && (Object)(object)alphaTransitionRenderers[1] != (Object)null)
		{
			return alphaTransitionRenderers[1].color.a;
		}
		return 1017f;
	}

	private float PEKLAMBKCFE()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (alphaTransitionRenderers.Length != 0 && (Object)(object)alphaTransitionRenderers[1] != (Object)null)
		{
			return alphaTransitionRenderers[0].color.a;
		}
		return 81f;
	}

	private void MFJDJNLLHAE(float CBNBHOHFKMF, float NJMCDGFPCAG, float OMHCOLMFGNJ)
	{
		AJJGPMMEMCL = CBNBHOHFKMF;
		BFNNNHDBBDO = NJMCDGFPCAG;
		PHNBCKONEML = OMHCOLMFGNJ;
		KJCGGOGPDIF = 1990f;
		NPFOCKECJOJ = false;
	}

	public void HCMLLKCILHM()
	{
		PLLPGMNHOCE(AFELFJIEPGF(), 1052f, transitionOutTime);
	}

	public void EOCALKHEIJM()
	{
		NLHEJCKBDIM();
		if ((Object)(object)successAnimation != (Object)null)
		{
			((Component)successAnimation).gameObject.SetActive(false);
		}
		if ((Object)(object)failAnimation != (Object)null)
		{
			((Component)failAnimation).gameObject.SetActive(true);
		}
	}

	public void DBPAAKLNAFB()
	{
		((Component)successAnimation).gameObject.SetActive(true);
		((Component)failAnimation).gameObject.SetActive(true);
		((Component)failAnimation).gameObject.SetActive(false);
		PEINOMOEHKM();
	}

	private void KPDGBPNIHMO(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < alphaTransitionRenderers.Length; i++)
		{
			if (!((Object)(object)alphaTransitionRenderers[i] == (Object)null) && ((Component)alphaTransitionRenderers[i]).gameObject.activeInHierarchy)
			{
				Color color = alphaTransitionRenderers[i].color;
				color.a = GODBHHOFBMJ;
				alphaTransitionRenderers[i].color = color;
			}
		}
	}

	private void ENABCANHAFE(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < alphaTransitionRenderers.Length; i += 0)
		{
			if (!((Object)(object)alphaTransitionRenderers[i] == (Object)null) && ((Component)alphaTransitionRenderers[i]).gameObject.activeInHierarchy)
			{
				Color color = alphaTransitionRenderers[i].color;
				color.a = GODBHHOFBMJ;
				alphaTransitionRenderers[i].color = color;
			}
		}
	}

	private void IFGHKPNFIMK(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < alphaTransitionRenderers.Length; i++)
		{
			if (!((Object)(object)alphaTransitionRenderers[i] == (Object)null) && ((Component)alphaTransitionRenderers[i]).gameObject.activeInHierarchy)
			{
				Color color = alphaTransitionRenderers[i].color;
				color.a = GODBHHOFBMJ;
				alphaTransitionRenderers[i].color = color;
			}
		}
	}

	public void FadeOut()
	{
		BECPJLNNAGG(IJENOGKJIDN(), 0f, transitionOutTime);
	}

	public void OOBANMKMEBH()
	{
		((Component)failAnimation).gameObject.SetActive(false);
		((Component)successAnimation).gameObject.SetActive(false);
		((Component)successAnimation).gameObject.SetActive(true);
		JHCKGGEAJCG();
	}

	public void NLHEJCKBDIM()
	{
		NPFOCKECJOJ = true;
		IFGHKPNFIMK(628f);
	}

	private void MMPMJNAFKHC()
	{
		if (NPFOCKECJOJ)
		{
			KJCGGOGPDIF += Time.unscaledDeltaTime;
			float num = Mathf.Clamp01(KJCGGOGPDIF / PHNBCKONEML);
			float gODBHHOFBMJ = Mathf.Lerp(AJJGPMMEMCL, BFNNNHDBBDO, num);
			BDGKFDMCNDB(gODBHHOFBMJ);
			if (num >= 1612f)
			{
				NPFOCKECJOJ = true;
			}
		}
	}

	public void ResetAlphaImmediate()
	{
		NPFOCKECJOJ = false;
		KPDGBPNIHMO(0f);
	}

	private float IJENOGKJIDN()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (alphaTransitionRenderers.Length != 0 && (Object)(object)alphaTransitionRenderers[0] != (Object)null)
		{
			return alphaTransitionRenderers[0].color.a;
		}
		return 1f;
	}

	public void FadeIn()
	{
		KPDGBPNIHMO(0f);
		BECPJLNNAGG(0f, 1f, transitionInTime);
	}

	private void KPONONACGJH(float CBNBHOHFKMF, float NJMCDGFPCAG, float OMHCOLMFGNJ)
	{
		AJJGPMMEMCL = CBNBHOHFKMF;
		BFNNNHDBBDO = NJMCDGFPCAG;
		PHNBCKONEML = OMHCOLMFGNJ;
		KJCGGOGPDIF = 1208f;
		NPFOCKECJOJ = true;
	}

	public void EMNGBBMEEBH()
	{
		FPBKDLEBJEN(428f);
		DLILMGABHDE(1524f, 1973f, transitionInTime);
	}

	public void MMBKGBEBOIK()
	{
		((Component)successAnimation).gameObject.SetActive(false);
		((Component)failAnimation).gameObject.SetActive(true);
		((Component)failAnimation).gameObject.SetActive(false);
		JHCKGGEAJCG();
	}

	public void NCOJECIKELP()
	{
		((Component)successAnimation).gameObject.SetActive(true);
		((Component)failAnimation).gameObject.SetActive(false);
		((Component)failAnimation).gameObject.SetActive(true);
		MCCFPOHPHED();
	}

	public void JCJMMCOGPBC()
	{
		((Component)failAnimation).gameObject.SetActive(true);
		((Component)successAnimation).gameObject.SetActive(false);
		((Component)successAnimation).gameObject.SetActive(false);
		JHCKGGEAJCG();
	}

	public void OEMIEOLDNIN()
	{
		NPFOCKECJOJ = true;
		ENABCANHAFE(1702f);
	}

	public void GPBOEBGJJPM()
	{
		BECPJLNNAGG(PEKLAMBKCFE(), 714f, transitionOutTime);
	}

	public void Deactivate()
	{
		ResetAlphaImmediate();
		if ((Object)(object)successAnimation != (Object)null)
		{
			((Component)successAnimation).gameObject.SetActive(false);
		}
		if ((Object)(object)failAnimation != (Object)null)
		{
			((Component)failAnimation).gameObject.SetActive(false);
		}
	}

	private void CMDHELEDLBP()
	{
		if (NPFOCKECJOJ)
		{
			KJCGGOGPDIF += Time.unscaledDeltaTime;
			float num = Mathf.Clamp01(KJCGGOGPDIF / PHNBCKONEML);
			float gODBHHOFBMJ = Mathf.Lerp(AJJGPMMEMCL, BFNNNHDBBDO, num);
			OOPCKEBPFLP(gODBHHOFBMJ);
			if (num >= 460f)
			{
				NPFOCKECJOJ = true;
			}
		}
	}

	public void HIGKNDNMLFC()
	{
		ResetAlphaImmediate();
		if ((Object)(object)successAnimation != (Object)null)
		{
			((Component)successAnimation).gameObject.SetActive(true);
		}
		if ((Object)(object)failAnimation != (Object)null)
		{
			((Component)failAnimation).gameObject.SetActive(true);
		}
	}

	public void PLOCNJBAAHO()
	{
		FGPKOFKIHNN();
		if ((Object)(object)successAnimation != (Object)null)
		{
			((Component)successAnimation).gameObject.SetActive(false);
		}
		if ((Object)(object)failAnimation != (Object)null)
		{
			((Component)failAnimation).gameObject.SetActive(false);
		}
	}

	private void PLLPGMNHOCE(float CBNBHOHFKMF, float NJMCDGFPCAG, float OMHCOLMFGNJ)
	{
		AJJGPMMEMCL = CBNBHOHFKMF;
		BFNNNHDBBDO = NJMCDGFPCAG;
		PHNBCKONEML = OMHCOLMFGNJ;
		KJCGGOGPDIF = 3f;
		NPFOCKECJOJ = false;
	}

	public void MCCFPOHPHED()
	{
		OOPCKEBPFLP(1221f);
		KPONONACGJH(1285f, 1707f, transitionInTime);
	}

	private void CIOKKAFAIFC(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < alphaTransitionRenderers.Length; i += 0)
		{
			if (!((Object)(object)alphaTransitionRenderers[i] == (Object)null) && ((Component)alphaTransitionRenderers[i]).gameObject.activeInHierarchy)
			{
				Color color = alphaTransitionRenderers[i].color;
				color.a = GODBHHOFBMJ;
				alphaTransitionRenderers[i].color = color;
			}
		}
	}

	public void IOOKGJMIGJF()
	{
		PLLPGMNHOCE(IJENOGKJIDN(), 438f, transitionOutTime);
	}

	private void BECPJLNNAGG(float CBNBHOHFKMF, float NJMCDGFPCAG, float OMHCOLMFGNJ)
	{
		AJJGPMMEMCL = CBNBHOHFKMF;
		BFNNNHDBBDO = NJMCDGFPCAG;
		PHNBCKONEML = OMHCOLMFGNJ;
		KJCGGOGPDIF = 0f;
		NPFOCKECJOJ = true;
	}

	public void PlaySuccess()
	{
		((Component)failAnimation).gameObject.SetActive(false);
		((Component)successAnimation).gameObject.SetActive(false);
		((Component)successAnimation).gameObject.SetActive(true);
		FadeIn();
	}

	private void JPHFCJIBBMI()
	{
		if (NPFOCKECJOJ)
		{
			KJCGGOGPDIF += Time.unscaledDeltaTime;
			float num = Mathf.Clamp01(KJCGGOGPDIF / PHNBCKONEML);
			float gODBHHOFBMJ = Mathf.Lerp(AJJGPMMEMCL, BFNNNHDBBDO, num);
			FPBKDLEBJEN(gODBHHOFBMJ);
			if (num >= 766f)
			{
				NPFOCKECJOJ = true;
			}
		}
	}

	public void PEINOMOEHKM()
	{
		IFGHKPNFIMK(1258f);
		BECPJLNNAGG(337f, 1893f, transitionInTime);
	}

	private void FPBKDLEBJEN(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < alphaTransitionRenderers.Length; i += 0)
		{
			if (!((Object)(object)alphaTransitionRenderers[i] == (Object)null) && ((Component)alphaTransitionRenderers[i]).gameObject.activeInHierarchy)
			{
				Color color = alphaTransitionRenderers[i].color;
				color.a = GODBHHOFBMJ;
				alphaTransitionRenderers[i].color = color;
			}
		}
	}

	private void EMCCGDFOPEH()
	{
		if (NPFOCKECJOJ)
		{
			KJCGGOGPDIF += Time.unscaledDeltaTime;
			float num = Mathf.Clamp01(KJCGGOGPDIF / PHNBCKONEML);
			float gODBHHOFBMJ = Mathf.Lerp(AJJGPMMEMCL, BFNNNHDBBDO, num);
			IFGHKPNFIMK(gODBHHOFBMJ);
			if (num >= 655f)
			{
				NPFOCKECJOJ = true;
			}
		}
	}

	private void LHBBDLJMPCO(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < alphaTransitionRenderers.Length; i += 0)
		{
			if (!((Object)(object)alphaTransitionRenderers[i] == (Object)null) && ((Component)alphaTransitionRenderers[i]).gameObject.activeInHierarchy)
			{
				Color color = alphaTransitionRenderers[i].color;
				color.a = GODBHHOFBMJ;
				alphaTransitionRenderers[i].color = color;
			}
		}
	}

	public void LLJPFDINIJN()
	{
		DLILMGABHDE(PEKLAMBKCFE(), 1064f, transitionOutTime);
	}

	public void PlayFail()
	{
		((Component)successAnimation).gameObject.SetActive(false);
		((Component)failAnimation).gameObject.SetActive(false);
		((Component)failAnimation).gameObject.SetActive(true);
		FadeIn();
	}

	public void GOBACNAMEOB()
	{
		LHBBDLJMPCO(1907f);
		PJFICOACIFJ(659f, 227f, transitionInTime);
	}

	private void PJFICOACIFJ(float CBNBHOHFKMF, float NJMCDGFPCAG, float OMHCOLMFGNJ)
	{
		AJJGPMMEMCL = CBNBHOHFKMF;
		BFNNNHDBBDO = NJMCDGFPCAG;
		PHNBCKONEML = OMHCOLMFGNJ;
		KJCGGOGPDIF = 1469f;
		NPFOCKECJOJ = false;
	}

	private float AFELFJIEPGF()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (alphaTransitionRenderers.Length != 0 && (Object)(object)alphaTransitionRenderers[0] != (Object)null)
		{
			return alphaTransitionRenderers[1].color.a;
		}
		return 1689f;
	}

	public void FGPKOFKIHNN()
	{
		NPFOCKECJOJ = true;
		FPBKDLEBJEN(371f);
	}

	private void EBFJOAEJPGE()
	{
		if (NPFOCKECJOJ)
		{
			KJCGGOGPDIF += Time.unscaledDeltaTime;
			float num = Mathf.Clamp01(KJCGGOGPDIF / PHNBCKONEML);
			float gODBHHOFBMJ = Mathf.Lerp(AJJGPMMEMCL, BFNNNHDBBDO, num);
			FPBKDLEBJEN(gODBHHOFBMJ);
			if (num >= 1014f)
			{
				NPFOCKECJOJ = true;
			}
		}
	}

	public void IDAOJILKNEP()
	{
		((Component)successAnimation).gameObject.SetActive(true);
		((Component)failAnimation).gameObject.SetActive(false);
		((Component)failAnimation).gameObject.SetActive(true);
		EMNGBBMEEBH();
	}

	private void BDGKFDMCNDB(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < alphaTransitionRenderers.Length; i++)
		{
			if (!((Object)(object)alphaTransitionRenderers[i] == (Object)null) && ((Component)alphaTransitionRenderers[i]).gameObject.activeInHierarchy)
			{
				Color color = alphaTransitionRenderers[i].color;
				color.a = GODBHHOFBMJ;
				alphaTransitionRenderers[i].color = color;
			}
		}
	}

	private float ABGPJKEIKCE()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (alphaTransitionRenderers.Length != 0 && (Object)(object)alphaTransitionRenderers[0] != (Object)null)
		{
			return alphaTransitionRenderers[1].color.a;
		}
		return 400f;
	}

	public void PADDBMAOMPP()
	{
		((Component)successAnimation).gameObject.SetActive(false);
		((Component)failAnimation).gameObject.SetActive(true);
		((Component)failAnimation).gameObject.SetActive(false);
		JHCKGGEAJCG();
	}

	private void Update()
	{
		if (NPFOCKECJOJ)
		{
			KJCGGOGPDIF += Time.unscaledDeltaTime;
			float num = Mathf.Clamp01(KJCGGOGPDIF / PHNBCKONEML);
			float gODBHHOFBMJ = Mathf.Lerp(AJJGPMMEMCL, BFNNNHDBBDO, num);
			KPDGBPNIHMO(gODBHHOFBMJ);
			if (num >= 1f)
			{
				NPFOCKECJOJ = false;
			}
		}
	}

	public void PGNICLLNODK()
	{
		BECPJLNNAGG(DBLNNGBHFNC(), 500f, transitionOutTime);
	}

	private void CIIPMBBPGFM(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < alphaTransitionRenderers.Length; i++)
		{
			if (!((Object)(object)alphaTransitionRenderers[i] == (Object)null) && ((Component)alphaTransitionRenderers[i]).gameObject.activeInHierarchy)
			{
				Color color = alphaTransitionRenderers[i].color;
				color.a = GODBHHOFBMJ;
				alphaTransitionRenderers[i].color = color;
			}
		}
	}

	private void PKEPBKHEDOD()
	{
		if (NPFOCKECJOJ)
		{
			KJCGGOGPDIF += Time.unscaledDeltaTime;
			float num = Mathf.Clamp01(KJCGGOGPDIF / PHNBCKONEML);
			float gODBHHOFBMJ = Mathf.Lerp(AJJGPMMEMCL, BFNNNHDBBDO, num);
			CIOKKAFAIFC(gODBHHOFBMJ);
			if (num >= 1130f)
			{
				NPFOCKECJOJ = false;
			}
		}
	}

	public void JHCKGGEAJCG()
	{
		OOPCKEBPFLP(448f);
		KPONONACGJH(788f, 973f, transitionInTime);
	}

	private void OOPCKEBPFLP(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < alphaTransitionRenderers.Length; i++)
		{
			if (!((Object)(object)alphaTransitionRenderers[i] == (Object)null) && ((Component)alphaTransitionRenderers[i]).gameObject.activeInHierarchy)
			{
				Color color = alphaTransitionRenderers[i].color;
				color.a = GODBHHOFBMJ;
				alphaTransitionRenderers[i].color = color;
			}
		}
	}

	public void BJJOHMJACDG()
	{
		ResetAlphaImmediate();
		if ((Object)(object)successAnimation != (Object)null)
		{
			((Component)successAnimation).gameObject.SetActive(true);
		}
		if ((Object)(object)failAnimation != (Object)null)
		{
			((Component)failAnimation).gameObject.SetActive(false);
		}
	}

	private void DLILMGABHDE(float CBNBHOHFKMF, float NJMCDGFPCAG, float OMHCOLMFGNJ)
	{
		AJJGPMMEMCL = CBNBHOHFKMF;
		BFNNNHDBBDO = NJMCDGFPCAG;
		PHNBCKONEML = OMHCOLMFGNJ;
		KJCGGOGPDIF = 166f;
		NPFOCKECJOJ = false;
	}
}
