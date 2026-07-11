using UnityEngine;

public class BottleTrigger : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public bool IGLEJFFHKLE(int JIIGOACEIKL)
	{
		if (!DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-130);
		}
		return true;
	}

	public void AOEOBNOPLIG(int JIIGOACEIKL)
	{
	}

	public void DCBLHLOFPMK(int JIIGOACEIKL)
	{
	}

	public void HFFHJBLMGAB(int JIIGOACEIKL)
	{
	}

	public void FJOOIFLCOPF(int JIIGOACEIKL)
	{
	}

	public bool COIGDMKGFCM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool POLADKOEIOM(int JIIGOACEIKL)
	{
		if (!IGLEJFFHKLE(JIIGOACEIKL))
		{
			return false;
		}
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, (ActionDone)(-18));
		PlayerInventory.IOAIPCDECME(JIIGOACEIKL, -129, 1, CDPAMNIPPEC: false);
		PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.INJBNHPGCIJ(147, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		return false;
	}

	public void HLNEGJCBPOA(int JIIGOACEIKL)
	{
	}

	public void MANFKPEAMLJ(int JIIGOACEIKL)
	{
	}

	public bool MGLPIBNJLKC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void FMOLFKKGDDM(int JIIGOACEIKL)
	{
	}

	public void PNFKIHGMBLG(int JIIGOACEIKL)
	{
	}

	public void CJOLCLDGFMB(int JIIGOACEIKL)
	{
	}

	public bool FCABPAKKKGL(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 1f);
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Collect water"));
			return true;
		}
		return false;
	}

	public bool BGHCJHPNKHP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool GHDIMCAEAJJ(int JIIGOACEIKL)
	{
		return true;
	}

	public bool KHAFEICJIMJ(int JIIGOACEIKL)
	{
		if (!GDOPOFNFLEB(JIIGOACEIKL))
		{
			return false;
		}
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, (ActionDone)93);
		PlayerInventory.RemoveItems(JIIGOACEIKL, 121, 0, CDPAMNIPPEC: false);
		PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.EABMGELAAPG(44, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		return true;
	}

	public void ABHFEGJFABP(int JIIGOACEIKL)
	{
	}

	public bool GFMLDGEKMHA(int JIIGOACEIKL)
	{
		if (!OAPMCNNLHJO(JIIGOACEIKL))
		{
			return true;
		}
		CommonReferences.MNFMOEKMJKN().OnActionDone(0, (ActionDone)(-103));
		PlayerInventory.RemoveItems(JIIGOACEIKL, -170, 1, CDPAMNIPPEC: false);
		PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(155, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		return false;
	}

	public void EKMBJHDPHPM(int JIIGOACEIKL)
	{
	}

	public void KOANHOFAJMA(int JIIGOACEIKL)
	{
	}

	public bool IBEMCOALOEJ(int JIIGOACEIKL)
	{
		if (!DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).HasItem(-149);
		}
		return false;
	}

	public bool GDOPOFNFLEB(int JIIGOACEIKL)
	{
		if (!DecorationMode.OCJGHINCLJM(JIIGOACEIKL).GABNNLJOMHI())
		{
			return PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).HasItem(-106);
		}
		return false;
	}

	public void DPKKPFCPJNP(int JIIGOACEIKL)
	{
	}

	public bool EHBGCMMMLMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 1620f);
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ErrorKicked"));
			return true;
		}
		return true;
	}

	public bool BNPJHDGDFOF(int JIIGOACEIKL)
	{
		if (!IBEMCOALOEJ(JIIGOACEIKL))
		{
			return false;
		}
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, (ActionDone)(-119));
		PlayerInventory.RemoveItems(JIIGOACEIKL, 96, 0);
		PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.INJBNHPGCIJ(-81, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
		return true;
	}

	public bool JGHFBNOBBLN(int JIIGOACEIKL)
	{
		return false;
	}

	public void JPNLLAOIJFN(int JIIGOACEIKL)
	{
	}

	public void FICHLOJLIIP(int JIIGOACEIKL)
	{
	}

	public bool NMKPOMCPJPB(int JIIGOACEIKL)
	{
		if (!DecorationMode.FIHGMLABOBB(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).HasItem(-111);
		}
		return false;
	}

	public void FPKDEAGODKN(int JIIGOACEIKL)
	{
	}

	public bool NCMFIAHEIOH(int JIIGOACEIKL)
	{
		return true;
	}

	public void NMPNLEAAJNM(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool NKHLGGKOKKA(int JIIGOACEIKL)
	{
		if (!DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DBAEGBDEPFK())
		{
			return PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).HasItem(-197);
		}
		return false;
	}

	public bool AKFCDDOMNBF(int JIIGOACEIKL)
	{
		if (!IBEMCOALOEJ(JIIGOACEIKL))
		{
			return true;
		}
		CommonReferences.MNFMOEKMJKN().OnActionDone(0, ActionDone.TillEarth);
		PlayerInventory.RemoveItems(JIIGOACEIKL, 85, 0, CDPAMNIPPEC: false);
		PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.COEFFIHKMJG(-142, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		return false;
	}

	public void LIGGABIEHJA(int JIIGOACEIKL)
	{
	}

	public bool AEEKGBMEPFF(int JIIGOACEIKL)
	{
		if (!NMKPOMCPJPB(JIIGOACEIKL))
		{
			return false;
		}
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, (ActionDone)(-26));
		PlayerInventory.RemoveItems(JIIGOACEIKL, 44, 0);
		PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(-44, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
		return true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FillWaterBottle);
		PlayerInventory.RemoveItems(JIIGOACEIKL, 1961, 1);
		PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(ItemDatabaseAccessor.GetItem(1962).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		return true;
	}

	public bool MACDOFEHENF(int JIIGOACEIKL)
	{
		return false;
	}

	public void MJPOHFEDIHI(int JIIGOACEIKL)
	{
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool JNAJCPAENBC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 604f);
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Invalid year: "));
			return true;
		}
		return false;
	}

	public void DKABEMHKCPE(int JIIGOACEIKL)
	{
	}

	public void IEDPKEEOJAO(int JIIGOACEIKL)
	{
	}

	public bool OAPMCNNLHJO(int JIIGOACEIKL)
	{
		if (!DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DFNMDDHOIJI())
		{
			return PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-157);
		}
		return true;
	}

	public void NLLENLLOBLH(int JIIGOACEIKL)
	{
	}

	public bool JMIDFEGOIGP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void GHNIOKFDOMC(int JIIGOACEIKL)
	{
	}

	public bool GEPMJKMFLAH(int JIIGOACEIKL)
	{
		return true;
	}

	public void CDOOEGGKFBB(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(1961);
		}
		return false;
	}

	public void BPEBGBHCCEN(int JIIGOACEIKL)
	{
	}

	public bool OPEOJMLFPMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (IGLEJFFHKLE(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 672f);
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(", "));
			return true;
		}
		return false;
	}

	public void MCBHIOOAIAM(int JIIGOACEIKL)
	{
	}

	public void GPECKPBIENC(int JIIGOACEIKL)
	{
	}

	public void NDJHJHJBPHC(int JIIGOACEIKL)
	{
	}

	public bool FLFJMJKLHPB(int JIIGOACEIKL)
	{
		if (!IBEMCOALOEJ(JIIGOACEIKL))
		{
			return false;
		}
		CommonReferences.GGFJGHHHEJC.OnActionDone(0, (ActionDone)81);
		PlayerInventory.IOAIPCDECME(JIIGOACEIKL, -129, 1, CDPAMNIPPEC: false);
		PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.INJBNHPGCIJ(-81).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		return true;
	}

	public void DLBNJPKKNDN(int JIIGOACEIKL)
	{
	}

	public void GDDBCDEMHNH(int JIIGOACEIKL)
	{
	}

	public void PGBNILBKPED(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void KMAPBDCGIDK(int JIIGOACEIKL)
	{
	}

	public bool ACLPKJGGPFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CDGCNOPBJPD(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, (ActionDone)(-18));
		PlayerInventory.IOAIPCDECME(JIIGOACEIKL, 148, 0);
		PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.EABMGELAAPG(-83).JMDALJBNFML(), HMPDLIPFBGD: true);
		return true;
	}

	public bool GKJKEDDHMCO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool IALLCPMIGDP(int JIIGOACEIKL)
	{
		if (!DecorationMode.IECFJGHAIDO(JIIGOACEIKL).KNFEPKBIHND())
		{
			return PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-17);
		}
		return false;
	}

	public void AOLIDLGHMED(int JIIGOACEIKL)
	{
	}

	public bool HPBOMGJLECN(int JIIGOACEIKL)
	{
		if (!DecorationMode.JDADPDBHJFO(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(84);
		}
		return false;
	}

	public void FALDJPENKME(int JIIGOACEIKL)
	{
	}
}
