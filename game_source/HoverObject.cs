using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HoverObject : MonoBehaviour
{
	private static HoverObject IADEMLIIDPC;

	private static HoverObject BBINLIGKIPE;

	private int JIIGOACEIKL;

	private IHoverable MDMJJBAPINF;

	private MonoBehaviour[] CENALNOKJCE;

	private IHoverable HMMPDEJDPDP;

	private OnlineObject NKJHFIDLEMN;

	public static HoverObject GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<HoverObject>();
			}
			return IADEMLIIDPC;
		}
	}

	public static HoverObject CNKLEOKFFLB
	{
		get
		{
			if ((Object)(object)BBINLIGKIPE == (Object)null)
			{
				BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
			}
			return BBINLIGKIPE;
		}
	}

	public IHoverable APABFFIMLFF
	{
		get
		{
			return MDMJJBAPINF;
		}
		set
		{
			if (MDMJJBAPINF != null && MDMJJBAPINF != value)
			{
				MDMJJBAPINF.OffHover(JIIGOACEIKL);
			}
			MDMJJBAPINF = value;
		}
	}

	private IHoverable OPFFKBCOOEG()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IHoverable>(JIIGOACEIKL);
		if (CENALNOKJCE != null && CENALNOKJCE.Length != 0)
		{
			for (int i = 0; i < CENALNOKJCE.Length; i += 0)
			{
				if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)InteractObject.PBFCHGLAAAJ(JIIGOACEIKL).interactingObject))
				{
					continue;
				}
				if (OnlineManager.PlayingOnline())
				{
					NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
					if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
					{
						continue;
					}
				}
				if (((IHoverable)CENALNOKJCE[i]).OnHover(JIIGOACEIKL))
				{
					return (IHoverable)CENALNOKJCE[i];
				}
			}
		}
		return null;
	}

	[SpecialName]
	public static HoverObject GJFMMOPOKGJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<HoverObject>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static HoverObject NJNFHEPLEHL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<HoverObject>();
		}
		return IADEMLIIDPC;
	}

	private void FBHBEAJFBAH()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GetPlayer(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Remove(player.OnClick, new Action<List<IInteractable>>(GBGFOEPDDPP));
		}
	}

	private void JMJDHLOMKAP()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GetPlayer(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Remove(player.OnClick, new Action<List<IInteractable>>(HDCFBNNANEB));
		}
	}

	private IHoverable FDECPKNOAHM()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IHoverable>(JIIGOACEIKL);
		if (CENALNOKJCE != null && CENALNOKJCE.Length != 0)
		{
			for (int i = 1; i < CENALNOKJCE.Length; i++)
			{
				if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)InteractObject.GetOtherPlayer(JIIGOACEIKL).interactingObject))
				{
					continue;
				}
				if (OnlineManager.PlayingOnline())
				{
					NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
					if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
					{
						continue;
					}
				}
				if (((IHoverable)CENALNOKJCE[i]).OnHover(JIIGOACEIKL))
				{
					return (IHoverable)CENALNOKJCE[i];
				}
			}
		}
		return null;
	}

	private IHoverable DGPHNGBCOGJ()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IHoverable>(JIIGOACEIKL);
		if (CENALNOKJCE != null && CENALNOKJCE.Length != 0)
		{
			for (int i = 0; i < CENALNOKJCE.Length; i += 0)
			{
				if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)InteractObject.PBFCHGLAAAJ(JIIGOACEIKL).interactingObject))
				{
					continue;
				}
				if (OnlineManager.PlayingOnline())
				{
					NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
					if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
					{
						continue;
					}
				}
				if (((IHoverable)CENALNOKJCE[i]).OnHover(JIIGOACEIKL))
				{
					return (IHoverable)CENALNOKJCE[i];
				}
			}
		}
		return null;
	}

	private void IIJNMAGGMND(List<IInteractable> JGDIEMODGLI)
	{
		MDMJJBAPINF?.OffHover(JIIGOACEIKL);
		MDMJJBAPINF = null;
	}

	private void ODBKBMCMFNB()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GetPlayer(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Remove(interactObject.OnClick, new Action<List<IInteractable>>(MFIBNAICBPA));
		}
	}

	private IHoverable KKCNOHFNPCA()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IHoverable>(JIIGOACEIKL);
		if (CENALNOKJCE != null && CENALNOKJCE.Length != 0)
		{
			for (int i = 0; i < CENALNOKJCE.Length; i++)
			{
				if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)InteractObject.PBFCHGLAAAJ(JIIGOACEIKL).interactingObject))
				{
					continue;
				}
				if (OnlineManager.PlayingOnline())
				{
					NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
					if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
					{
						continue;
					}
				}
				if (((IHoverable)CENALNOKJCE[i]).OnHover(JIIGOACEIKL))
				{
					return (IHoverable)CENALNOKJCE[i];
				}
			}
		}
		return null;
	}

	public static HoverObject HELHJMDEDNL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void IDMNLNDEBMC()
	{
		if (DecorationMode.NPANPNIDKDG(JIIGOACEIKL).IDPGEBNGDJD())
		{
			LGBLFPOOMEJ(KNDPHJAICKD());
		}
	}

	private void NOOICDFHJPM(List<IInteractable> JGDIEMODGLI)
	{
		MDMJJBAPINF?.OffHover(JIIGOACEIKL);
		MDMJJBAPINF = null;
	}

	private void OAKGHDAABPM()
	{
		if (DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DFNMDDHOIJI())
		{
			Hover(FDECPKNOAHM());
		}
	}

	[SpecialName]
	public void MNLEEKJDPNB(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	private void MEAMEBFFMJH()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GNCPLNHMFHN(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.BBJCJFJEFKK(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Combine(interactObject.OnClick, new Action<List<IInteractable>>(BHHJKCGLGPK));
		}
	}

	private void DDIBFALLCNO()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GNCPLNHMFHN(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Remove(player.OnClick, new Action<List<IInteractable>>(EHMHJIJPAHL));
		}
	}

	[SpecialName]
	public static HoverObject LFPEPJBNCBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<HoverObject>();
		}
		return IADEMLIIDPC;
	}

	public void KHFCKIEOEPG(IHoverable EDEMBNBDJDH)
	{
		HMMPDEJDPDP = EDEMBNBDJDH;
		if (MDMJJBAPINF != null && HMMPDEJDPDP != MDMJJBAPINF)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = HMMPDEJDPDP;
	}

	private void OLFPIBOIIIO()
	{
		if (DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DBAEGBDEPFK())
		{
			KHFCKIEOEPG(CCCIEHLJCNC());
		}
	}

	private void MHLHJGHHONF()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GNCPLNHMFHN(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.BBJCJFJEFKK(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Combine(interactObject.OnClick, new Action<List<IInteractable>>(CGHOMDMHBCJ));
		}
	}

	[SpecialName]
	public static HoverObject FCCBIHJKLCI()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public static HoverObject PLCKKCLCIEG()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}

	private IHoverable CCCIEHLJCNC()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IHoverable>(JIIGOACEIKL);
		if (CENALNOKJCE != null && CENALNOKJCE.Length != 0)
		{
			for (int i = 0; i < CENALNOKJCE.Length; i += 0)
			{
				if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)InteractObject.PBFCHGLAAAJ(JIIGOACEIKL).interactingObject))
				{
					continue;
				}
				if (OnlineManager.PlayingOnline())
				{
					NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
					if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
					{
						continue;
					}
				}
				if (((IHoverable)CENALNOKJCE[i]).OnHover(JIIGOACEIKL))
				{
					return (IHoverable)CENALNOKJCE[i];
				}
			}
		}
		return null;
	}

	private void AOJCCOIHPMH()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GetPlayer(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Combine(player.OnClick, new Action<List<IInteractable>>(GBGFOEPDDPP));
		}
	}

	[SpecialName]
	public void LALFOOBJOGM(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	private void ABJIPFAEENG()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.BBJCJFJEFKK(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Combine(interactObject.OnClick, new Action<List<IInteractable>>(IIJNMAGGMND));
		}
	}

	[SpecialName]
	public IHoverable GBLJOFMCBAJ()
	{
		return MDMJJBAPINF;
	}

	private void KLGCMMIKGIO()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		if (JIIGOACEIKL == 0)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	[SpecialName]
	public IHoverable DDCGJJPICOA()
	{
		return MDMJJBAPINF;
	}

	public static HoverObject CMIBBCIKMCF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public IHoverable BEOICHLAHFK()
	{
		return MDMJJBAPINF;
	}

	[SpecialName]
	public void CAMHHLGMJMO(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	[SpecialName]
	public IHoverable IHDCNGFHLFL()
	{
		return MDMJJBAPINF;
	}

	public void OLAABCGOLOJ(IHoverable EDEMBNBDJDH)
	{
		HMMPDEJDPDP = EDEMBNBDJDH;
		if (MDMJJBAPINF != null && HMMPDEJDPDP != MDMJJBAPINF)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = HMMPDEJDPDP;
	}

	private void ADJHOLOIGJE()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.BBJCJFJEFKK(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Remove(interactObject.OnClick, new Action<List<IInteractable>>(GBGFOEPDDPP));
		}
	}

	private void OnDisable()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GetPlayer(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Remove(player.OnClick, new Action<List<IInteractable>>(HDCFBNNANEB));
		}
	}

	[SpecialName]
	public void GKEBCFBPOAN(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	[SpecialName]
	public void GIONDGFGJCB(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	private void NOKBAKEAJAD()
	{
		if (DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DFNMDDHOIJI())
		{
			NDGNDCFCBDN(FDECPKNOAHM());
		}
	}

	private void OHOHFGMJGAJ()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.BBJCJFJEFKK(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Combine(player.OnClick, new Action<List<IInteractable>>(NOOICDFHJPM));
		}
	}

	[SpecialName]
	public static HoverObject MGMECAEHBED()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public void KGHPHBMMMKH(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	private void DLNOLBHCIGC()
	{
		if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).DFNMDDHOIJI())
		{
			LGBLFPOOMEJ(DGPHNGBCOGJ());
		}
	}

	public static HoverObject PLGOJOBJALC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void BHHJKCGLGPK(List<IInteractable> JGDIEMODGLI)
	{
		MDMJJBAPINF?.OffHover(JIIGOACEIKL);
		MDMJJBAPINF = null;
	}

	[SpecialName]
	public IHoverable DCFLCOGLINN()
	{
		return MDMJJBAPINF;
	}

	public void JBFCJPNCNCH(IHoverable EDEMBNBDJDH)
	{
		HMMPDEJDPDP = EDEMBNBDJDH;
		if (MDMJJBAPINF != null && HMMPDEJDPDP != MDMJJBAPINF)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = HMMPDEJDPDP;
	}

	[SpecialName]
	public static HoverObject AMINECMFPAH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<HoverObject>();
		}
		return IADEMLIIDPC;
	}

	public void PPALIKLFDEE(IHoverable EDEMBNBDJDH)
	{
		HMMPDEJDPDP = EDEMBNBDJDH;
		if (MDMJJBAPINF != null && HMMPDEJDPDP != MDMJJBAPINF)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = HMMPDEJDPDP;
	}

	private void KCOFAJBKHAO()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.BBJCJFJEFKK(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Combine(interactObject.OnClick, new Action<List<IInteractable>>(BHHJKCGLGPK));
		}
	}

	public void LGBLFPOOMEJ(IHoverable EDEMBNBDJDH)
	{
		HMMPDEJDPDP = EDEMBNBDJDH;
		if (MDMJJBAPINF != null && HMMPDEJDPDP != MDMJJBAPINF)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = HMMPDEJDPDP;
	}

	[SpecialName]
	public IHoverable JAOHKCPPAJJ()
	{
		return MDMJJBAPINF;
	}

	private void LMFICKFGEFI()
	{
		if (DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM())
		{
			NDGNDCFCBDN(KKCNOHFNPCA());
		}
	}

	private void Update()
	{
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			Hover(IPNLKFBKKFC());
		}
	}

	[SpecialName]
	public static HoverObject KIALFDOKABP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<HoverObject>();
		}
		return IADEMLIIDPC;
	}

	private void ONJAODIAAIM()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GNCPLNHMFHN(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.BBJCJFJEFKK(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Combine(interactObject.OnClick, new Action<List<IInteractable>>(EHMHJIJPAHL));
		}
	}

	[SpecialName]
	public IHoverable GLODANPILJB()
	{
		return MDMJJBAPINF;
	}

	private void POFDOILPANH()
	{
		if (DecorationMode.HBDCJFLINDA(JIIGOACEIKL).GABNNLJOMHI())
		{
			NDGNDCFCBDN(AACLNFFPJPO());
		}
	}

	private void OGEJKOIOKAN()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	[SpecialName]
	public static HoverObject IAAPCAGJLML()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public static HoverObject NFEDEEKJOGB()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public static HoverObject LKOABOAADCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<HoverObject>();
		}
		return IADEMLIIDPC;
	}

	private IHoverable KNDPHJAICKD()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IHoverable>(JIIGOACEIKL);
		if (CENALNOKJCE != null && CENALNOKJCE.Length != 0)
		{
			for (int i = 1; i < CENALNOKJCE.Length; i++)
			{
				if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)InteractObject.GetOtherPlayer(JIIGOACEIKL).interactingObject))
				{
					continue;
				}
				if (OnlineManager.PlayingOnline())
				{
					NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
					if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
					{
						continue;
					}
				}
				if (((IHoverable)CENALNOKJCE[i]).OnHover(JIIGOACEIKL, IIEDALMMNLI: false))
				{
					return (IHoverable)CENALNOKJCE[i];
				}
			}
		}
		return null;
	}

	[SpecialName]
	public void IMAJDKEPAGO(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	private void GBGFOEPDDPP(List<IInteractable> JGDIEMODGLI)
	{
		MDMJJBAPINF?.OffHover(JIIGOACEIKL);
		MDMJJBAPINF = null;
	}

	private void FEPFNOEGFEM()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.BBJCJFJEFKK(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Combine(player.OnClick, new Action<List<IInteractable>>(GBGFOEPDDPP));
		}
	}

	private void Awake()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private void IHICKHAABJH()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	[SpecialName]
	public static HoverObject LIKHPCJHGAN()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}

	public static HoverObject IKAEFEPNADI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private IHoverable HCCNEGGAANP()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IHoverable>(JIIGOACEIKL);
		if (CENALNOKJCE != null && CENALNOKJCE.Length != 0)
		{
			for (int i = 1; i < CENALNOKJCE.Length; i++)
			{
				if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)InteractObject.GetOtherPlayer(JIIGOACEIKL).interactingObject))
				{
					continue;
				}
				if (OnlineManager.PlayingOnline())
				{
					NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
					if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
					{
						continue;
					}
				}
				if (((IHoverable)CENALNOKJCE[i]).OnHover(JIIGOACEIKL))
				{
					return (IHoverable)CENALNOKJCE[i];
				}
			}
		}
		return null;
	}

	public void LEOPFMDNBGH(IHoverable EDEMBNBDJDH)
	{
		HMMPDEJDPDP = EDEMBNBDJDH;
		if (MDMJJBAPINF != null && HMMPDEJDPDP != MDMJJBAPINF)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = HMMPDEJDPDP;
	}

	private void CGHOMDMHBCJ(List<IInteractable> JGDIEMODGLI)
	{
		MDMJJBAPINF?.OffHover(JIIGOACEIKL);
		MDMJJBAPINF = null;
	}

	public static HoverObject NHAMJJGEHJO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void LEPDLPEPEFD()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GNCPLNHMFHN(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Combine(player.OnClick, new Action<List<IInteractable>>(CGHOMDMHBCJ));
		}
	}

	private void HDCFBNNANEB(List<IInteractable> JGDIEMODGLI)
	{
		MDMJJBAPINF?.OffHover(JIIGOACEIKL);
		MDMJJBAPINF = null;
	}

	private void NLMLOOGHLCH()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GetPlayer(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Combine(interactObject.OnClick, new Action<List<IInteractable>>(NOOICDFHJPM));
		}
	}

	private void MFIBNAICBPA(List<IInteractable> JGDIEMODGLI)
	{
		MDMJJBAPINF?.OffHover(JIIGOACEIKL);
		MDMJJBAPINF = null;
	}

	[SpecialName]
	public void EJJFBLDDEHP(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	[SpecialName]
	public void OAFNCBINNBF(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	private void EFCNKPEPELL()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		if (JIIGOACEIKL == 0)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private void MHENLAGHFOD()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GNCPLNHMFHN(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Remove(player.OnClick, new Action<List<IInteractable>>(CGHOMDMHBCJ));
		}
	}

	[SpecialName]
	public static HoverObject PHPEPGNMLBE()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}

	private void OnEnable()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GetPlayer(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Combine(player.OnClick, new Action<List<IInteractable>>(HDCFBNNANEB));
		}
	}

	public static HoverObject LANFPNBBFMO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void HCKMHIHALBL()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.BBJCJFJEFKK(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Combine(interactObject.OnClick, new Action<List<IInteractable>>(HDCFBNNANEB));
		}
	}

	private void NCEDBIDHNIC()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.BBJCJFJEFKK(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Remove(interactObject.OnClick, new Action<List<IInteractable>>(EHMHJIJPAHL));
		}
	}

	private void OJPLLAOFDCC()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GNCPLNHMFHN(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Remove(player.OnClick, new Action<List<IInteractable>>(EHMHJIJPAHL));
		}
	}

	public void Hover(IHoverable EDEMBNBDJDH)
	{
		HMMPDEJDPDP = EDEMBNBDJDH;
		if (MDMJJBAPINF != null && HMMPDEJDPDP != MDMJJBAPINF)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = HMMPDEJDPDP;
	}

	[SpecialName]
	public static HoverObject BCDNCEONJAE()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}

	private void JMAHDPMEEHM()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GetPlayer(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Remove(player.OnClick, new Action<List<IInteractable>>(GBGFOEPDDPP));
		}
	}

	private void PKEPBKHEDOD()
	{
		if (DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DBAEGBDEPFK())
		{
			JBFCJPNCNCH(KNDPHJAICKD());
		}
	}

	public static HoverObject EOLBINONPKJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public void PJNNLDMBHMC(IHoverable EDEMBNBDJDH)
	{
		HMMPDEJDPDP = EDEMBNBDJDH;
		if (MDMJJBAPINF != null && HMMPDEJDPDP != MDMJJBAPINF)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = HMMPDEJDPDP;
	}

	private void BHKNJOEBCKA()
	{
		if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).DMBFKFLDDLH)
		{
			JBFCJPNCNCH(MLBHIJCPDFC());
		}
	}

	[SpecialName]
	public static HoverObject PNHHCHJCDNM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<HoverObject>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static HoverObject BJBIONLDLFD()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}

	public void NDGNDCFCBDN(IHoverable EDEMBNBDJDH)
	{
		HMMPDEJDPDP = EDEMBNBDJDH;
		if (MDMJJBAPINF != null && HMMPDEJDPDP != MDMJJBAPINF)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = HMMPDEJDPDP;
	}

	private IHoverable IPNLKFBKKFC()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IHoverable>(JIIGOACEIKL);
		if (CENALNOKJCE != null && CENALNOKJCE.Length != 0)
		{
			for (int i = 0; i < CENALNOKJCE.Length; i++)
			{
				if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)InteractObject.GetOtherPlayer(JIIGOACEIKL).interactingObject))
				{
					continue;
				}
				if (OnlineManager.PlayingOnline())
				{
					NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
					if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
					{
						continue;
					}
				}
				if (((IHoverable)CENALNOKJCE[i]).OnHover(JIIGOACEIKL))
				{
					return (IHoverable)CENALNOKJCE[i];
				}
			}
		}
		return null;
	}

	[SpecialName]
	public IHoverable IPDNICKJIMI()
	{
		return MDMJJBAPINF;
	}

	[SpecialName]
	public static HoverObject MJFGPOAIPMC()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public void JCKLCEMHLIA(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	private void INKOKIGFJBG()
	{
		if (DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DFNMDDHOIJI())
		{
			PJNNLDMBHMC(HCCNEGGAANP());
		}
	}

	private void CGHHPELBKBK()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GetPlayer(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Combine(interactObject.OnClick, new Action<List<IInteractable>>(IIJNMAGGMND));
		}
	}

	[SpecialName]
	public IHoverable ALALAGJDNFG()
	{
		return MDMJJBAPINF;
	}

	private void EHMHJIJPAHL(List<IInteractable> JGDIEMODGLI)
	{
		MDMJJBAPINF?.OffHover(JIIGOACEIKL);
		MDMJJBAPINF = null;
	}

	private void EIHMDMMOPCM()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private void LNPDALMANFB()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private IHoverable MLBHIJCPDFC()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IHoverable>(JIIGOACEIKL);
		if (CENALNOKJCE != null && CENALNOKJCE.Length != 0)
		{
			for (int i = 1; i < CENALNOKJCE.Length; i += 0)
			{
				if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)InteractObject.PBFCHGLAAAJ(JIIGOACEIKL).interactingObject))
				{
					continue;
				}
				if (OnlineManager.PlayingOnline())
				{
					NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
					if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
					{
						continue;
					}
				}
				if (((IHoverable)CENALNOKJCE[i]).OnHover(JIIGOACEIKL, IIEDALMMNLI: false))
				{
					return (IHoverable)CENALNOKJCE[i];
				}
			}
		}
		return null;
	}

	[SpecialName]
	public IHoverable FDLHMDCKAMM()
	{
		return MDMJJBAPINF;
	}

	private void FPOIFOGELHC()
	{
		if (DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DFNMDDHOIJI())
		{
			NDGNDCFCBDN(DGPHNGBCOGJ());
		}
	}

	private void ICOJDKMKIPL()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GNCPLNHMFHN(JIIGOACEIKL)))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClick = (Action<List<IInteractable>>)Delegate.Combine(player.OnClick, new Action<List<IInteractable>>(GBGFOEPDDPP));
		}
	}

	[SpecialName]
	public IHoverable GJLMCPHKIOK()
	{
		return MDMJJBAPINF;
	}

	[SpecialName]
	public static HoverObject KELIHELCBKI()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}

	private void NMKGOAJLMDG()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public static HoverObject CAAJNJBGPPM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public IHoverable GLFHIDIEABD()
	{
		return MDMJJBAPINF;
	}

	private IHoverable AACLNFFPJPO()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IHoverable>(JIIGOACEIKL);
		if (CENALNOKJCE != null && CENALNOKJCE.Length != 0)
		{
			for (int i = 1; i < CENALNOKJCE.Length; i++)
			{
				if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)InteractObject.PBFCHGLAAAJ(JIIGOACEIKL).interactingObject))
				{
					continue;
				}
				if (OnlineManager.PlayingOnline())
				{
					NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
					if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
					{
						continue;
					}
				}
				if (((IHoverable)CENALNOKJCE[i]).OnHover(JIIGOACEIKL))
				{
					return (IHoverable)CENALNOKJCE[i];
				}
			}
		}
		return null;
	}

	private IHoverable PHALDOKKCAM()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IHoverable>(JIIGOACEIKL);
		if (CENALNOKJCE != null && CENALNOKJCE.Length != 0)
		{
			for (int i = 0; i < CENALNOKJCE.Length; i++)
			{
				if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)InteractObject.PBFCHGLAAAJ(JIIGOACEIKL).interactingObject))
				{
					continue;
				}
				if (OnlineManager.PlayingOnline())
				{
					NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
					if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
					{
						continue;
					}
				}
				if (((IHoverable)CENALNOKJCE[i]).OnHover(JIIGOACEIKL))
				{
					return (IHoverable)CENALNOKJCE[i];
				}
			}
		}
		return null;
	}

	[SpecialName]
	public void JGODDNHDEOP(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	public static HoverObject GetPlayer(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void DJDLCPCCBHA()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.BBJCJFJEFKK(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Combine(interactObject.OnClick, new Action<List<IInteractable>>(NOOICDFHJPM));
		}
	}

	private void HCEHKDGMECG()
	{
		if (Object.op_Implicit((Object)(object)InteractObject.GNCPLNHMFHN(JIIGOACEIKL)))
		{
			InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
			interactObject.OnClick = (Action<List<IInteractable>>)Delegate.Remove(interactObject.OnClick, new Action<List<IInteractable>>(BHHJKCGLGPK));
		}
	}

	private void CNJMEALOCJJ()
	{
		if (DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DMBFKFLDDLH)
		{
			LGBLFPOOMEJ(OPFFKBCOOEG());
		}
	}

	[SpecialName]
	public static HoverObject OLHBLKIAFOM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<HoverObject>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public void CKDLLPBPLHB(IHoverable AODONKKHPBP)
	{
		if (MDMJJBAPINF != null && MDMJJBAPINF != AODONKKHPBP)
		{
			MDMJJBAPINF.OffHover(JIIGOACEIKL);
		}
		MDMJJBAPINF = AODONKKHPBP;
	}

	public static HoverObject IPBEEBLCHHA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public static HoverObject EPGMLMBEGMP()
	{
		if ((Object)(object)BBINLIGKIPE == (Object)null)
		{
			BBINLIGKIPE = Object.FindObjectOfType<HoverObject>();
		}
		return BBINLIGKIPE;
	}
}
