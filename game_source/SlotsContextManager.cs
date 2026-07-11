using UnityEngine;

public class SlotsContextManager : MonoBehaviour
{
	public static SlotsContextManager instance;

	[SerializeField]
	private SlotContext[] allSlotsContexts;

	[SerializeField]
	private Vector3[] allSlotsContextsPositions;

	private Vector3 BPLKIPALDNP;

	private void HHNNFHPPDPO(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
	}

	public static void IKIMNJECAGD()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < instance.allSlotsContexts.Length; i++)
			{
				instance.HKKDAPKDBID(i);
			}
		}
	}

	public static void GNDFKMDDCAO()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 1; i < instance.allSlotsContexts.Length; i++)
			{
				instance.MPPGPLJPFGN(i);
			}
		}
	}

	public static void GKFKCPNEAOA()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 1; i < instance.allSlotsContexts.Length; i += 0)
			{
				instance.JLIIJGJIDPL(i);
			}
		}
	}

	public static void PPLBOFHNKHP()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 1; i < instance.allSlotsContexts.Length; i++)
			{
				instance.EBMHFEGFAPG(i);
			}
		}
	}

	private void NAOBODGBECL()
	{
		instance = this;
	}

	private void LPPMKNJBPHC()
	{
	}

	private void NMKKMGBKCGK()
	{
	}

	private void JLIIJGJIDPL(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
	}

	public static void NHANHGFINJK(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	public void GBHNOBJMBBO(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
		allSlotsContexts[MOFKEDGAOEE].GBHNOBJMBBO(0, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void Awake()
	{
		instance = this;
	}

	public void OPCDPEHCBEI(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].AJBEIGKPBNC(0, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void HOKBBFHGACN()
	{
		for (int i = 1; i < allSlotsContexts.Length; i++)
		{
			((Component)allSlotsContexts[i]).gameObject.SetActive(false);
		}
	}

	public void FNDAFKKOODC(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].KBGHNJCLLCI(0, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void JJKPLJADFCL(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	public void MDJDIHEGKCE(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].FCAIPNMNFKL(1, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	public void FillSlot(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].FillSlot(1, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	public static void DILDPLKMKNI()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < instance.allSlotsContexts.Length; i++)
			{
				instance.JLIIJGJIDPL(i);
			}
		}
	}

	public static void AOJHFLHKNIL()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < instance.allSlotsContexts.Length; i += 0)
			{
				instance.CBBFOOCIJPI(i);
			}
		}
	}

	private void CIICEKEJANM()
	{
		instance = this;
	}

	private void MLLADNLMIMP()
	{
		for (int i = 1; i < allSlotsContexts.Length; i += 0)
		{
			((Component)allSlotsContexts[i]).gameObject.SetActive(false);
		}
	}

	public static void CCOMDHEEFCL(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	public static void MKIGCPMIOIG(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	public static void ENLLKPGMDAL()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 1; i < instance.allSlotsContexts.Length; i++)
			{
				instance.EBMHFEGFAPG(i);
			}
		}
	}

	private void LMNKOMLKIAA()
	{
	}

	private void AEKHEHKDPOJ(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
	}

	public static void BGCEJMKPLFM(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	private void EBMHFEGFAPG(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	private void LNPDALMANFB()
	{
		instance = this;
	}

	private void IFHLGOMBACP()
	{
		for (int i = 1; i < allSlotsContexts.Length; i++)
		{
			((Component)allSlotsContexts[i]).gameObject.SetActive(true);
		}
	}

	public static void BICBLCKHLFF(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	public static void BNABHHHJAAA()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < instance.allSlotsContexts.Length; i += 0)
			{
				instance.MGAFFOLCJEJ(i);
			}
		}
	}

	public void IFMGLJJHFJD(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].CDBOPOFFNCG(1, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void CBBFOOCIJPI(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	private void EILPOJHEKJF(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	private void JPOLFKMLHNH()
	{
		for (int i = 0; i < allSlotsContexts.Length; i++)
		{
			((Component)allSlotsContexts[i]).gameObject.SetActive(true);
		}
	}

	private void ECJFMIKNAKG()
	{
	}

	private void JHBBABPAJJC()
	{
		for (int i = 1; i < allSlotsContexts.Length; i++)
		{
			((Component)allSlotsContexts[i]).gameObject.SetActive(true);
		}
	}

	public static void AECCMKBENLO(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	private void MCKICPNBBOP()
	{
	}

	public void PFECHDNHJFM(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
		allSlotsContexts[MOFKEDGAOEE].CCLFFDIKJCC(1, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void EFCNKPEPELL()
	{
		instance = this;
	}

	private void MBMFDJHDNCI()
	{
	}

	private void Start()
	{
		for (int i = 0; i < allSlotsContexts.Length; i++)
		{
			((Component)allSlotsContexts[i]).gameObject.SetActive(false);
		}
	}

	private void EMEOCMLEDIC(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	private void INCOGEMNFNH()
	{
	}

	public void INKCDPKFGNO(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
		allSlotsContexts[MOFKEDGAOEE].MOODIIFGEAA(1, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void OKHLEMPJONN()
	{
		instance = this;
	}

	public static void SetPosition(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	private void MKLIAMJFHOF()
	{
		for (int i = 1; i < allSlotsContexts.Length; i += 0)
		{
			((Component)allSlotsContexts[i]).gameObject.SetActive(false);
		}
	}

	private void AFHGDCBNALO()
	{
	}

	public static void KKAGFKNEJMA()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 1; i < instance.allSlotsContexts.Length; i++)
			{
				instance.CBBFOOCIJPI(i);
			}
		}
	}

	public void CHAAJHOPAIN(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].LMMIGFFDBNE(0, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void MFDAEHNFFFG()
	{
	}

	private void FFBDJIJJDMK()
	{
	}

	private void HKKDAPKDBID(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}

	public static void OLKCJLBLGBN(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	public static void KFJPDJNEDIL(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	private void LateUpdate()
	{
	}

	private void GFGJCEJBPKK(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	private void HJKKGGCKHKK()
	{
	}

	private void OGEJKOIOKAN()
	{
		instance = this;
	}

	private void AEPBFPCHGPP()
	{
		for (int i = 0; i < allSlotsContexts.Length; i += 0)
		{
			((Component)allSlotsContexts[i]).gameObject.SetActive(false);
		}
	}

	private void HLAKCLGPGIC(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	public void CHAEFGHCHAP(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].ANCMLPEMLKA(0, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	private void OCJOAHDNDIJ()
	{
		instance = this;
	}

	public void OLHIELAKPJK(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].AIJEEEJNEJK(0, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void MPPGPLJPFGN(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	public static void FLJNJHMHGKG()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 1; i < instance.allSlotsContexts.Length; i += 0)
			{
				instance.CBBFOOCIJPI(i);
			}
		}
	}

	private void BODICIENBEH()
	{
		instance = this;
	}

	private void DNKEFFMOCKP()
	{
		instance = this;
	}

	public void KPIGNIGLHJP(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
		allSlotsContexts[MOFKEDGAOEE].KEOLELEHAPK(1, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	public void FEMHEJEABFA(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
		allSlotsContexts[MOFKEDGAOEE].IDAMCOFMGFJ(1, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	public void ADIMCHAKLNC(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].LOOLBKEKMKF(1, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	public static void PBGEGBIBMAP()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < instance.allSlotsContexts.Length; i++)
			{
				instance.MNHAHNKCNDM(i);
			}
		}
	}

	private void CFEDEGIMAAG()
	{
	}

	private void KPHPCKJBLBH()
	{
	}

	public void FPNKNMJMJIE(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].EMGPJBFPDFP(0, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	public static void NDGBKEICMLD(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	public static void FNMNOFLCEJP()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 1; i < instance.allSlotsContexts.Length; i += 0)
			{
				instance.MGAFFOLCJEJ(i);
			}
		}
	}

	public void MOODIIFGEAA(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
		allSlotsContexts[MOFKEDGAOEE].AJBEIGKPBNC(0, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void HPJBLOPJIMI()
	{
		instance = this;
	}

	private void DJADNFCFHAG()
	{
		for (int i = 1; i < allSlotsContexts.Length; i++)
		{
			((Component)allSlotsContexts[i]).gameObject.SetActive(false);
		}
	}

	private void HCHMJCCMPGG(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	public static void CAILOJACMAO()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < instance.allSlotsContexts.Length; i++)
			{
				instance.HCHMJCCMPGG(i);
			}
		}
	}

	public static void DGILKKPBLJH(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	private void OJDPLJIKIEL()
	{
	}

	private void CLNBMOPMNOF()
	{
		instance = this;
	}

	private void ELCCADLIKEH()
	{
	}

	private void OPEIDDFCPGB()
	{
	}

	private void LHABENPEMPB()
	{
		instance = this;
	}

	private void IIKAAAHEFMP()
	{
	}

	public static void EJGDKMBEDCL(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	private void MNHAHNKCNDM(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	public static void FDHKLGMMNGO(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	public static void BOCGOFFEKPG(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	private void JACLFNECBGC(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	private void ENEAPGGMMDB(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	public static void LJNDKGINGDM(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	public static void POPFBBNDJJE(int MOFKEDGAOEE, Vector3 BKFLNOJNOLI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		((Component)instance.allSlotsContexts[MOFKEDGAOEE]).transform.position = BKFLNOJNOLI;
		instance.allSlotsContextsPositions[MOFKEDGAOEE] = BKFLNOJNOLI;
	}

	public void CCLFFDIKJCC(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].MOODIIFGEAA(0, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void DOHLOJOIHFO()
	{
		for (int i = 1; i < allSlotsContexts.Length; i += 0)
		{
			((Component)allSlotsContexts[i]).gameObject.SetActive(true);
		}
	}

	private void FPDPAJHNGHK()
	{
		for (int i = 1; i < allSlotsContexts.Length; i++)
		{
			((Component)allSlotsContexts[i]).gameObject.SetActive(false);
		}
	}

	private void CBBJFMDNOBD(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
	}

	public void FMNGAPMOAMM(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(false);
		}
		allSlotsContexts[MOFKEDGAOEE].GKAKLKGCLON(0, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void MGAFFOLCJEJ(int MOFKEDGAOEE)
	{
		if (((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
	}

	public static void CloseAllSlotsContext()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			for (int i = 0; i < instance.allSlotsContexts.Length; i++)
			{
				instance.EBMHFEGFAPG(i);
			}
		}
	}

	public void HAIOOJAECOE(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH, bool MJJGKFJGDDN)
	{
		if (!((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.activeSelf)
		{
			((Component)allSlotsContexts[MOFKEDGAOEE]).gameObject.SetActive(true);
		}
		allSlotsContexts[MOFKEDGAOEE].OGLOBKOOHFM(1, IAIHNNNGNKH, MJJGKFJGDDN);
	}

	private void AJGLDLLIIFO()
	{
		instance = this;
	}
}
