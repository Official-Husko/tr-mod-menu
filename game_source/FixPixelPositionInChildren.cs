using UnityEngine;

public class FixPixelPositionInChildren : MonoBehaviour
{
	public void EDCMIPKDMOC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		EBJODLPLABM(((Component)this).transform);
	}

	public void PIDMFPLIKBC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		DKDGMFCBNNN(((Component)this).transform);
	}

	public void OCOICJIBABJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private Vector3 MMDGMAGBBCD(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	private Vector3 FHNPDKEBNIO(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	private void KIJBOACDAOA(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(FHNPDKEBNIO(Vector2.op_Implicit(val.anchoredPosition)));
			PCONHEPFEII(val);
		}
	}

	public void BFOCKOPOBAP()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(LBHHBNPCOCE(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		JPFNPLEODDO(((Component)this).GetComponent<RectTransform>());
	}

	private void EODFAANCAMP(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			EODFAANCAMP(val);
		}
	}

	public void PDAPPLCPMCI()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(LBPBJHPLHND(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		EOLENPOKMIL(((Component)this).GetComponent<RectTransform>());
	}

	private void EOLENPOKMIL(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(BCDMOJKBICK(Vector2.op_Implicit(val.anchoredPosition)));
			EOLENPOKMIL(val);
		}
	}

	private void GECMIHGNOFO(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			CMPJDLHMLLB(val);
		}
	}

	public void BCLNFNBHEGF()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(DLDMFINKMPF(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		FGBNDEBFGDJ(((Component)this).GetComponent<RectTransform>());
	}

	private void PKOOANFNKKH(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			CJLOMNAKNIJ(val);
		}
	}

	private void JPFNPLEODDO(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(HAAGFIMMGHC(Vector2.op_Implicit(val.anchoredPosition)));
			KGKHKBLJDJA(val);
		}
	}

	private void HGIEFKMNKLO(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(ENFEFAHFOBM(Vector2.op_Implicit(val.anchoredPosition)));
			GAGPAEAIIJI(val);
		}
	}

	private Vector3 LABGFPKMJMO(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void FixPositionChildrenUI()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(BCDMOJKBICK(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		EOLENPOKMIL(((Component)this).GetComponent<RectTransform>());
	}

	public void JPEPGDIMNJE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		GIADJJBDHPG(((Component)this).transform);
	}

	private Vector3 BCDMOJKBICK(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	private Vector3 NFCJLHFNDIG(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void MAHBHHOLFLH()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(GLPKNKEJLIP(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		FIEHEJHHBNK(((Component)this).GetComponent<RectTransform>());
	}

	private void BODCBFCJOBJ(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(PIBIDGABLGB(Vector2.op_Implicit(val.anchoredPosition)));
			JPFNPLEODDO(val);
		}
	}

	public void NKHKLBLBGPH()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(NFCJLHFNDIG(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		OACEDOFCAOP(((Component)this).GetComponent<RectTransform>());
	}

	public void DPALIGJFMJF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void DKONJLIIGKD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		FPPFGBGOLNF(((Component)this).transform);
	}

	private void MEBJPKAONNP(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(FJGNLFDAGJG(Vector2.op_Implicit(val.anchoredPosition)));
			HGIEFKMNKLO(val);
		}
	}

	private void BKILIEAILLH(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			GECMIHGNOFO(val);
		}
	}

	public void NKHBIGKPJGN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		BJKEKFHNPKL(((Component)this).transform);
	}

	public void EMHPNLENANC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void KIOPLMJFDDD()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(DLDMFINKMPF(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		HGIEFKMNKLO(((Component)this).GetComponent<RectTransform>());
	}

	public void CCOHJDKCIPC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void BDPLBBFNOKC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		CMPJDLHMLLB(((Component)this).transform);
	}

	public void BKINMEBDINP()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(GLPKNKEJLIP(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		MEBJPKAONNP(((Component)this).GetComponent<RectTransform>());
	}

	public void BINHOFBDLAL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		PKOOANFNKKH(((Component)this).transform);
	}

	public void BCLMHOPKPKE()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(EFHAGGAEIHH(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		HGIEFKMNKLO(((Component)this).GetComponent<RectTransform>());
	}

	public void KBNALAMAEOA()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(ENFEFAHFOBM(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		FIEHEJHHBNK(((Component)this).GetComponent<RectTransform>());
	}

	private Vector3 EFHAGGAEIHH(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	private void KMCOGPFDKIP(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			KMCOGPFDKIP(val);
		}
	}

	public void BEBMFPPEFGH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private void OAGDFONMEFM(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			GECMIHGNOFO(val);
		}
	}

	private void LPIEPOJCHAA(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(MMDGMAGBBCD(Vector2.op_Implicit(val.anchoredPosition)));
			MEBJPKAONNP(val);
		}
	}

	public void DDGAOOJMAPP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private void DBONFBOCJCM(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(LBPBJHPLHND(Vector2.op_Implicit(val.anchoredPosition)));
			PGEDEMPBNKN(val);
		}
	}

	public void OOAEGDJJEKP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		GECMIHGNOFO(((Component)this).transform);
	}

	private void ANKPAFGCPMJ(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(LBHHBNPCOCE(Vector2.op_Implicit(val.anchoredPosition)));
			ELJHJNPCHIP(val);
		}
	}

	private void PGEDEMPBNKN(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(LBHHBNPCOCE(Vector2.op_Implicit(val.anchoredPosition)));
			JPFNPLEODDO(val);
		}
	}

	private Vector3 FJGNLFDAGJG(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void DBLLBCOOOIK()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(AJPGFOEBPBJ(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		FGBNDEBFGDJ(((Component)this).GetComponent<RectTransform>());
	}

	public void JPOBOJBBKCA()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(FHNPDKEBNIO(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		PGEDEMPBNKN(((Component)this).GetComponent<RectTransform>());
	}

	public void LLFKOOBGKFD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private void KGKHKBLJDJA(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(LBPBJHPLHND(Vector2.op_Implicit(val.anchoredPosition)));
			PGEDEMPBNKN(val);
		}
	}

	public void NHPODHCJODF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void HPBHBIBDGEL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private void ELJHJNPCHIP(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(GLPKNKEJLIP(Vector2.op_Implicit(val.anchoredPosition)));
			HGIEFKMNKLO(val);
		}
	}

	public void JHNKECMKCEN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private Vector3 HAAGFIMMGHC(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	private void DKDGMFCBNNN(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			BKILIEAILLH(val);
		}
	}

	private void PCONHEPFEII(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(BOFHPLKNMNN(Vector2.op_Implicit(val.anchoredPosition)));
			OACEDOFCAOP(val);
		}
	}

	private Vector3 KPKFOMLFMLH(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void PMGHEMPMPJO()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(LBHHBNPCOCE(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		ELJHJNPCHIP(((Component)this).GetComponent<RectTransform>());
	}

	public void GNANGEKHKJJ()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(NFCJLHFNDIG(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		OACEDOFCAOP(((Component)this).GetComponent<RectTransform>());
	}

	public void PBNDFLMJLKJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private void FPPFGBGOLNF(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			EODFAANCAMP(val);
		}
	}

	public void PGGJAIODEGI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void HCHFKDLFJNB()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(LABGFPKMJMO(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		KGKHKBLJDJA(((Component)this).GetComponent<RectTransform>());
	}

	private void GAGPAEAIIJI(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(LBPBJHPLHND(Vector2.op_Implicit(val.anchoredPosition)));
			HGIEFKMNKLO(val);
		}
	}

	private void BJKEKFHNPKL(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			BJKEKFHNPKL(val);
		}
	}

	public void BDDIPGEFGEM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		GECMIHGNOFO(((Component)this).transform);
	}

	private void CJLOMNAKNIJ(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			OAGDFONMEFM(val);
		}
	}

	private void EBJODLPLABM(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			GIADJJBDHPG(val);
		}
	}

	public void MNFBIJBEHCO()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(PIBIDGABLGB(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		FIEHEJHHBNK(((Component)this).GetComponent<RectTransform>());
	}

	private void FIEHEJHHBNK(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(BCDMOJKBICK(Vector2.op_Implicit(val.anchoredPosition)));
			EOLENPOKMIL(val);
		}
	}

	public void AEBDCEOIHPK()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(LABGFPKMJMO(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		PGEDEMPBNKN(((Component)this).GetComponent<RectTransform>());
	}

	public void BHKHEJAEBAP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		GIADJJBDHPG(((Component)this).transform);
	}

	private Vector3 APHCHKMINMI(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void HOEBALAOIHI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private void CMPJDLHMLLB(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			CMPJDLHMLLB(val);
		}
	}

	public void LGJKLMBKPHA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		OAGDFONMEFM(((Component)this).transform);
	}

	private void GKELMFAFKBP(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			BJKEKFHNPKL(val);
		}
	}

	private void GIADJJBDHPG(Transform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		foreach (Transform item in DCGBADKLANM)
		{
			Transform val = item;
			if (val.lossyScale == Vector3.one)
			{
				((Component)val).transform.localPosition = Utils.BMBMPKNANAC(((Component)val).transform.localPosition);
			}
			else
			{
				((Component)val).transform.position = Utils.BMBMPKNANAC(((Component)val).transform.position);
			}
			GKELMFAFKBP(val);
		}
	}

	public void EFJLNNLLCGD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void IOGALEJNPOD()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(APHCHKMINMI(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		KIJBOACDAOA(((Component)this).GetComponent<RectTransform>());
	}

	private Vector3 LBHHBNPCOCE(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void FKJFPLBNBCP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void ENAJLINIADP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void CKFDGDIGOEG()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(LABGFPKMJMO(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		OACEDOFCAOP(((Component)this).GetComponent<RectTransform>());
	}

	public void DMMNOJOOMPP()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(LBPBJHPLHND(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		PGEDEMPBNKN(((Component)this).GetComponent<RectTransform>());
	}

	public void CHNHOLCOKFA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private Vector3 BOFHPLKNMNN(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void HKBMNMAPDNB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void EPCOKAPGDAG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void ELJKHGAFLKB()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(DLDMFINKMPF(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		FGBNDEBFGDJ(((Component)this).GetComponent<RectTransform>());
	}

	public void IJJCGAOGAJC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		BKILIEAILLH(((Component)this).transform);
	}

	public void FixPositionChildren()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		EODFAANCAMP(((Component)this).transform);
	}

	public void FIHFGENMBNA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		GECMIHGNOFO(((Component)this).transform);
	}

	private Vector3 AJPGFOEBPBJ(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void IHIMJKFPAEO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private Vector3 PIBIDGABLGB(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void EPGILAOENFF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		CMPJDLHMLLB(((Component)this).transform);
	}

	public void FELKFGHMCJK()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(LABGFPKMJMO(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		LPIEPOJCHAA(((Component)this).GetComponent<RectTransform>());
	}

	public void HAFLCJHGAFN()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(LBPBJHPLHND(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		OACEDOFCAOP(((Component)this).GetComponent<RectTransform>());
	}

	public void AEJCEBJFPHB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void AKPEKDMOICI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	public void NFFILIMALJC()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(AJPGFOEBPBJ(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		FBBCDJJEOAM(((Component)this).GetComponent<RectTransform>());
	}

	public void EFJDBGCHHPB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		FPPFGBGOLNF(((Component)this).transform);
	}

	public void FixPosition()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private Vector3 LBPBJHPLHND(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	private void OACEDOFCAOP(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(BCDMOJKBICK(Vector2.op_Implicit(val.anchoredPosition)));
			GAGPAEAIIJI(val);
		}
	}

	public void BHPFHABEJIL()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(APHCHKMINMI(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		PGEDEMPBNKN(((Component)this).GetComponent<RectTransform>());
	}

	private Vector3 DLDMFINKMPF(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void PEALJLMNPLG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}

	private Vector3 ENFEFAHFOBM(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void CADFEIMJFDN()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).GetComponent<RectTransform>().anchoredPosition = Vector2.op_Implicit(LBPBJHPLHND(Vector2.op_Implicit(((Component)this).GetComponent<RectTransform>().anchoredPosition)));
		FBBCDJJEOAM(((Component)this).GetComponent<RectTransform>());
	}

	private Vector3 GLPKNKEJLIP(Vector3 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3((float)Mathf.RoundToInt(DPNLDLEHMHO.x), (float)Mathf.RoundToInt(DPNLDLEHMHO.y));
	}

	public void HGOJLGFNHOG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
		DKDGMFCBNNN(((Component)this).transform);
	}

	private void FGBNDEBFGDJ(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(LBPBJHPLHND(Vector2.op_Implicit(val.anchoredPosition)));
			GAGPAEAIIJI(val);
		}
	}

	private void FBBCDJJEOAM(RectTransform DCGBADKLANM)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (RectTransform item in (Transform)DCGBADKLANM)
		{
			RectTransform val = item;
			val.anchoredPosition = Vector2.op_Implicit(NFCJLHFNDIG(Vector2.op_Implicit(val.anchoredPosition)));
			GAGPAEAIIJI(val);
		}
	}

	public void ANICBBFNODE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.localPosition = Utils.BMBMPKNANAC(((Component)this).transform.localPosition);
	}
}
