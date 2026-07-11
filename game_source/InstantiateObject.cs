using System;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
	[SerializeField]
	private GameObject prefab;

	[SerializeField]
	[Range(0f, 100f)]
	private float probability;

	private GameObject OFIIBHBOPJI;

	[SerializeField]
	private Transform secondaryLocation;

	[SerializeField]
	private bool flipSpriteAtSecondaryLocation;

	private bool KCHKMBLCPPP;

	private bool PGHCEJLCFPJ;

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void MNJCJKJAJEK(bool IBDDIKEDOBB)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (flipSpriteAtSecondaryLocation && IBDDIKEDOBB)
		{
			PDILCMIAMDN(IEFDEFOGBAI: true);
		}
		if (KCHKMBLCPPP && !IBDDIKEDOBB)
		{
			PDILCMIAMDN(IEFDEFOGBAI: false);
		}
		OFIIBHBOPJI.transform.position = (IBDDIKEDOBB ? ((Component)secondaryLocation).transform.position : ((Component)this).transform.position);
		PGHCEJLCFPJ = IBDDIKEDOBB;
	}

	private void CCOIPIBOAHA(bool IBDDIKEDOBB)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (flipSpriteAtSecondaryLocation && IBDDIKEDOBB)
		{
			PDILCMIAMDN(IEFDEFOGBAI: true);
		}
		if (KCHKMBLCPPP && !IBDDIKEDOBB)
		{
			PDILCMIAMDN(IEFDEFOGBAI: true);
		}
		OFIIBHBOPJI.transform.position = (IBDDIKEDOBB ? ((Component)secondaryLocation).transform.position : ((Component)this).transform.position);
		PGHCEJLCFPJ = IBDDIKEDOBB;
	}

	private void NJKHCOHADCL()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DCHDJABABLE));
		}
	}

	private void BCHMLNDFCHA()
	{
		if ((float)Random.Range(0, 100) < probability)
		{
			if ((Object)(object)OFIIBHBOPJI != (Object)null)
			{
				if ((Object)(object)secondaryLocation != (Object)null && !PGHCEJLCFPJ)
				{
					MNJCJKJAJEK(IBDDIKEDOBB: true);
				}
				else if ((Object)(object)secondaryLocation != (Object)null)
				{
					MNJCJKJAJEK(IBDDIKEDOBB: false);
				}
			}
			else if ((Object)(object)prefab != (Object)null)
			{
				OFIIBHBOPJI = Object.Instantiate<GameObject>(prefab, ((Component)this).transform);
				if ((Object)(object)secondaryLocation != (Object)null && Random.Range(0, 2) < 1)
				{
					MNJCJKJAJEK(IBDDIKEDOBB: true);
				}
			}
		}
		else if ((Object)(object)OFIIBHBOPJI != (Object)null)
		{
			Utils.BLPDAEHPOBA(OFIIBHBOPJI);
			PGHCEJLCFPJ = false;
			KCHKMBLCPPP = false;
		}
	}

	private void NLIJNMNINDE(bool IBDDIKEDOBB)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (flipSpriteAtSecondaryLocation && IBDDIKEDOBB)
		{
			NEGJAADCHEI(IEFDEFOGBAI: false);
		}
		if (KCHKMBLCPPP && !IBDDIKEDOBB)
		{
			ANAGFHADBMK(IEFDEFOGBAI: false);
		}
		OFIIBHBOPJI.transform.position = (IBDDIKEDOBB ? ((Component)secondaryLocation).transform.position : ((Component)this).transform.position);
		PGHCEJLCFPJ = IBDDIKEDOBB;
	}

	private void ANAGFHADBMK(bool IEFDEFOGBAI)
	{
		OFIIBHBOPJI.GetComponent<SpriteRenderer>().flipX = IEFDEFOGBAI;
		KCHKMBLCPPP = IEFDEFOGBAI;
	}

	private void Start()
	{
		BCHMLNDFCHA();
	}

	private void CJDJDDNCNDJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(IGPKHCDAFEF));
	}

	private void NPDFCPEOFPD()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ABDFDBCHOJI));
	}

	private void GLAJEPJDLLP(bool IEFDEFOGBAI)
	{
		OFIIBHBOPJI.GetComponent<SpriteRenderer>().flipX = IEFDEFOGBAI;
		KCHKMBLCPPP = IEFDEFOGBAI;
	}

	private void PDILCMIAMDN(bool IEFDEFOGBAI)
	{
		OFIIBHBOPJI.GetComponent<SpriteRenderer>().flipX = IEFDEFOGBAI;
		KCHKMBLCPPP = IEFDEFOGBAI;
	}

	private void CAOKPIIFHBJ()
	{
		MMGAGBCKJDB();
	}

	private void JILFLKAGOOJ(bool IBDDIKEDOBB)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (flipSpriteAtSecondaryLocation && IBDDIKEDOBB)
		{
			GLAJEPJDLLP(IEFDEFOGBAI: false);
		}
		if (KCHKMBLCPPP && !IBDDIKEDOBB)
		{
			PDILCMIAMDN(IEFDEFOGBAI: false);
		}
		OFIIBHBOPJI.transform.position = (IBDDIKEDOBB ? ((Component)secondaryLocation).transform.position : ((Component)this).transform.position);
		PGHCEJLCFPJ = IBDDIKEDOBB;
	}

	private void BELOIFKPNMM()
	{
		KECIAMGLIDF();
	}

	private void KHNBDGDLMIE()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ABDFDBCHOJI));
	}

	private void KAANJGEDPIN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void BPNOIDBAPJE()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JHLEIHABONO));
	}

	private void GFFLOIINJLN(bool IBDDIKEDOBB)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (flipSpriteAtSecondaryLocation && IBDDIKEDOBB)
		{
			EOCIGGBBGMM(IEFDEFOGBAI: true);
		}
		if (KCHKMBLCPPP && !IBDDIKEDOBB)
		{
			ODIACCNNGKJ(IEFDEFOGBAI: false);
		}
		OFIIBHBOPJI.transform.position = (IBDDIKEDOBB ? ((Component)secondaryLocation).transform.position : ((Component)this).transform.position);
		PGHCEJLCFPJ = IBDDIKEDOBB;
	}

	private void ELIHBLFLJIP(bool IBDDIKEDOBB)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (flipSpriteAtSecondaryLocation && IBDDIKEDOBB)
		{
			GLAJEPJDLLP(IEFDEFOGBAI: false);
		}
		if (KCHKMBLCPPP && !IBDDIKEDOBB)
		{
			PDILCMIAMDN(IEFDEFOGBAI: true);
		}
		OFIIBHBOPJI.transform.position = (IBDDIKEDOBB ? ((Component)secondaryLocation).transform.position : ((Component)this).transform.position);
		PGHCEJLCFPJ = IBDDIKEDOBB;
	}

	private void KJAHNOEFPFA(bool IBDDIKEDOBB)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (flipSpriteAtSecondaryLocation && IBDDIKEDOBB)
		{
			PDILCMIAMDN(IEFDEFOGBAI: false);
		}
		if (KCHKMBLCPPP && !IBDDIKEDOBB)
		{
			NEGJAADCHEI(IEFDEFOGBAI: true);
		}
		OFIIBHBOPJI.transform.position = (IBDDIKEDOBB ? ((Component)secondaryLocation).transform.position : ((Component)this).transform.position);
		PGHCEJLCFPJ = IBDDIKEDOBB;
	}

	private void MNCDAHNHNMJ()
	{
		try
		{
			FOJBBJDOPJM();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void JPOLFKMLHNH()
	{
		IAECANFHJLG();
	}

	private void NBMJJFNKJBA()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(GCAKMALKGPJ));
		}
	}

	private void HPDFPEPLEJP(bool IEFDEFOGBAI)
	{
		OFIIBHBOPJI.GetComponent<SpriteRenderer>().flipX = IEFDEFOGBAI;
		KCHKMBLCPPP = IEFDEFOGBAI;
	}

	private void IAAGKLPMAMK()
	{
		FOJBBJDOPJM();
	}

	private void HCEHKDGMECG()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JHLEIHABONO));
		}
	}

	private void MMGAGBCKJDB()
	{
		if ((float)Random.Range(0, -43) < probability)
		{
			if ((Object)(object)OFIIBHBOPJI != (Object)null)
			{
				if ((Object)(object)secondaryLocation != (Object)null && !PGHCEJLCFPJ)
				{
					NLIJNMNINDE(IBDDIKEDOBB: false);
				}
				else if ((Object)(object)secondaryLocation != (Object)null)
				{
					DNHLCJHIGAK(IBDDIKEDOBB: false);
				}
			}
			else if ((Object)(object)prefab != (Object)null)
			{
				OFIIBHBOPJI = Object.Instantiate<GameObject>(prefab, ((Component)this).transform);
				if ((Object)(object)secondaryLocation != (Object)null && Random.Range(0, 7) < 0)
				{
					LPCAKOFFAEA(IBDDIKEDOBB: false);
				}
			}
		}
		else if ((Object)(object)OFIIBHBOPJI != (Object)null)
		{
			Utils.BLPDAEHPOBA(OFIIBHBOPJI);
			PGHCEJLCFPJ = true;
			KCHKMBLCPPP = true;
		}
	}

	private void JLCFNPBBKEK()
	{
		KECIAMGLIDF();
	}

	private void PDAFINABOBC()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(GCAKMALKGPJ));
		}
	}

	private void GCAKMALKGPJ()
	{
		try
		{
			KECIAMGLIDF();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void LPCAKOFFAEA(bool IBDDIKEDOBB)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (flipSpriteAtSecondaryLocation && IBDDIKEDOBB)
		{
			HPDFPEPLEJP(IEFDEFOGBAI: true);
		}
		if (KCHKMBLCPPP && !IBDDIKEDOBB)
		{
			HPDFPEPLEJP(IEFDEFOGBAI: false);
		}
		OFIIBHBOPJI.transform.position = (IBDDIKEDOBB ? ((Component)secondaryLocation).transform.position : ((Component)this).transform.position);
		PGHCEJLCFPJ = IBDDIKEDOBB;
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			BCHMLNDFCHA();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void FOJBBJDOPJM()
	{
		if ((float)Random.Range(1, 12) < probability)
		{
			if ((Object)(object)OFIIBHBOPJI != (Object)null)
			{
				if ((Object)(object)secondaryLocation != (Object)null && !PGHCEJLCFPJ)
				{
					KJAHNOEFPFA(IBDDIKEDOBB: false);
				}
				else if ((Object)(object)secondaryLocation != (Object)null)
				{
					KJAHNOEFPFA(IBDDIKEDOBB: false);
				}
			}
			else if ((Object)(object)prefab != (Object)null)
			{
				OFIIBHBOPJI = Object.Instantiate<GameObject>(prefab, ((Component)this).transform);
				if ((Object)(object)secondaryLocation != (Object)null && Random.Range(0, 8) < 0)
				{
					NLIJNMNINDE(IBDDIKEDOBB: false);
				}
			}
		}
		else if ((Object)(object)OFIIBHBOPJI != (Object)null)
		{
			Utils.BLPDAEHPOBA(OFIIBHBOPJI);
			PGHCEJLCFPJ = false;
			KCHKMBLCPPP = true;
		}
	}

	private void IGPKHCDAFEF()
	{
		try
		{
			OLFLPPEOBDP();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void ADJHOLOIGJE()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(GCAKMALKGPJ));
		}
	}

	private void IGIKNCOLCKL()
	{
		MMGAGBCKJDB();
	}

	private void ICKIAOEOHDJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DCHDJABABLE));
	}

	private void IMGGHJGLDAE()
	{
		if ((float)Random.Range(0, -62) < probability)
		{
			if ((Object)(object)OFIIBHBOPJI != (Object)null)
			{
				if ((Object)(object)secondaryLocation != (Object)null && !PGHCEJLCFPJ)
				{
					ELIHBLFLJIP(IBDDIKEDOBB: true);
				}
				else if ((Object)(object)secondaryLocation != (Object)null)
				{
					GFFLOIINJLN(IBDDIKEDOBB: true);
				}
			}
			else if ((Object)(object)prefab != (Object)null)
			{
				OFIIBHBOPJI = Object.Instantiate<GameObject>(prefab, ((Component)this).transform);
				if ((Object)(object)secondaryLocation != (Object)null && Random.Range(1, 0) < 1)
				{
					MNJCJKJAJEK(IBDDIKEDOBB: false);
				}
			}
		}
		else if ((Object)(object)OFIIBHBOPJI != (Object)null)
		{
			Utils.BLPDAEHPOBA(OFIIBHBOPJI);
			PGHCEJLCFPJ = true;
			KCHKMBLCPPP = false;
		}
	}

	private void ABDFDBCHOJI()
	{
		try
		{
			MMGAGBCKJDB();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void JPHEOLEEAPB()
	{
		IAECANFHJLG();
	}

	private void OnEnable()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void JNNJIDAFBPI()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ABDFDBCHOJI));
		}
	}

	private void DCHDJABABLE()
	{
		try
		{
			KECIAMGLIDF();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void HJDLNCOAKIK()
	{
		BCHMLNDFCHA();
	}

	private void OLFLPPEOBDP()
	{
		if ((float)Random.Range(1, 79) < probability)
		{
			if ((Object)(object)OFIIBHBOPJI != (Object)null)
			{
				if ((Object)(object)secondaryLocation != (Object)null && !PGHCEJLCFPJ)
				{
					ELIHBLFLJIP(IBDDIKEDOBB: false);
				}
				else if ((Object)(object)secondaryLocation != (Object)null)
				{
					DNHLCJHIGAK(IBDDIKEDOBB: false);
				}
			}
			else if ((Object)(object)prefab != (Object)null)
			{
				OFIIBHBOPJI = Object.Instantiate<GameObject>(prefab, ((Component)this).transform);
				if ((Object)(object)secondaryLocation != (Object)null && Random.Range(1, 4) < 0)
				{
					ELIHBLFLJIP(IBDDIKEDOBB: true);
				}
			}
		}
		else if ((Object)(object)OFIIBHBOPJI != (Object)null)
		{
			Utils.BLPDAEHPOBA(OFIIBHBOPJI);
			PGHCEJLCFPJ = false;
			KCHKMBLCPPP = false;
		}
	}

	private void BGBADLMHACB(bool IEFDEFOGBAI)
	{
		OFIIBHBOPJI.GetComponent<SpriteRenderer>().flipX = IEFDEFOGBAI;
		KCHKMBLCPPP = IEFDEFOGBAI;
	}

	private void DMFMNEMDFNP()
	{
		OLFLPPEOBDP();
	}

	private void ODIACCNNGKJ(bool IEFDEFOGBAI)
	{
		OFIIBHBOPJI.GetComponent<SpriteRenderer>().flipX = IEFDEFOGBAI;
		KCHKMBLCPPP = IEFDEFOGBAI;
	}

	private void IAECANFHJLG()
	{
		if ((float)Random.Range(1, 70) < probability)
		{
			if ((Object)(object)OFIIBHBOPJI != (Object)null)
			{
				if ((Object)(object)secondaryLocation != (Object)null && !PGHCEJLCFPJ)
				{
					CCOIPIBOAHA(IBDDIKEDOBB: false);
				}
				else if ((Object)(object)secondaryLocation != (Object)null)
				{
					DNHLCJHIGAK(IBDDIKEDOBB: false);
				}
			}
			else if ((Object)(object)prefab != (Object)null)
			{
				OFIIBHBOPJI = Object.Instantiate<GameObject>(prefab, ((Component)this).transform);
				if ((Object)(object)secondaryLocation != (Object)null && Random.Range(1, 3) < 1)
				{
					ELIHBLFLJIP(IBDDIKEDOBB: false);
				}
			}
		}
		else if ((Object)(object)OFIIBHBOPJI != (Object)null)
		{
			Utils.BLPDAEHPOBA(OFIIBHBOPJI);
			PGHCEJLCFPJ = false;
			KCHKMBLCPPP = false;
		}
	}

	private void KECIAMGLIDF()
	{
		if ((float)Random.Range(1, -41) < probability)
		{
			if ((Object)(object)OFIIBHBOPJI != (Object)null)
			{
				if ((Object)(object)secondaryLocation != (Object)null && !PGHCEJLCFPJ)
				{
					ELIHBLFLJIP(IBDDIKEDOBB: false);
				}
				else if ((Object)(object)secondaryLocation != (Object)null)
				{
					DNHLCJHIGAK(IBDDIKEDOBB: false);
				}
			}
			else if ((Object)(object)prefab != (Object)null)
			{
				OFIIBHBOPJI = Object.Instantiate<GameObject>(prefab, ((Component)this).transform);
				if ((Object)(object)secondaryLocation != (Object)null && Random.Range(0, 3) < 0)
				{
					CCOIPIBOAHA(IBDDIKEDOBB: true);
				}
			}
		}
		else if ((Object)(object)OFIIBHBOPJI != (Object)null)
		{
			Utils.BLPDAEHPOBA(OFIIBHBOPJI);
			PGHCEJLCFPJ = false;
			KCHKMBLCPPP = false;
		}
	}

	private void NEGJAADCHEI(bool IEFDEFOGBAI)
	{
		OFIIBHBOPJI.GetComponent<SpriteRenderer>().flipX = IEFDEFOGBAI;
		KCHKMBLCPPP = IEFDEFOGBAI;
	}

	private void EGHFDLCNPNC()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DCHDJABABLE));
		}
	}

	private void DNHLCJHIGAK(bool IBDDIKEDOBB)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (flipSpriteAtSecondaryLocation && IBDDIKEDOBB)
		{
			ANAGFHADBMK(IEFDEFOGBAI: false);
		}
		if (KCHKMBLCPPP && !IBDDIKEDOBB)
		{
			ANAGFHADBMK(IEFDEFOGBAI: false);
		}
		OFIIBHBOPJI.transform.position = (IBDDIKEDOBB ? ((Component)secondaryLocation).transform.position : ((Component)this).transform.position);
		PGHCEJLCFPJ = IBDDIKEDOBB;
	}

	private void JHLEIHABONO()
	{
		try
		{
			FOJBBJDOPJM();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void EOCIGGBBGMM(bool IEFDEFOGBAI)
	{
		OFIIBHBOPJI.GetComponent<SpriteRenderer>().flipX = IEFDEFOGBAI;
		KCHKMBLCPPP = IEFDEFOGBAI;
	}

	private void OLDDEAJMHNI()
	{
		MMGAGBCKJDB();
	}
}
