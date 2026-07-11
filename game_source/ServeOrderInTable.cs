using System;
using System.Collections.Generic;
using UnityEngine;

public class ServeOrderInTable : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public Table table;

	public List<Customer> customers = new List<Customer>();

	private void MADIMOJDGIP(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	public bool LKELFKFPNPJ(int JIIGOACEIKL)
	{
		if (OHKCPGKPDGJ(JIIGOACEIKL) && (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.IKMGCBGAEFK() == (Object)null)
		{
			for (int i = 1; i < customers.Count; i += 0)
			{
				if (customers[i].customerState == (CustomerState)(-78) && customers[i].currentRequest != null && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.ELCABOAPCMH(customers[i].currentRequest))
				{
					customers[i].ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: false, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
				}
			}
			return false;
		}
		return false;
	}

	private void POHKALGJLHN(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	private void NNBIAIMPNGL()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Combine(instance.OnTavernClose, new Action<int>(FIAMEELKLOO));
	}

	public bool BGHCJHPNKHP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO)
		{
			GFMLDGEKMHA(JIIGOACEIKL);
		}
		return table.MouseHold(JIIGOACEIKL, KLGOCJMGKFO);
	}

	public void JPNLLAOIJFN(int JIIGOACEIKL)
	{
	}

	public bool DGNGLGMBIHE(int JIIGOACEIKL)
	{
		if (DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		for (int i = 0; i < customers.Count; i += 0)
		{
			if (customers[i].customerState == (CustomerState)(-50) && customers[i].currentRequest != null && PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.BCNKFHHDMAG(customers[i].currentRequest))
			{
				return true;
			}
		}
		return false;
	}

	public bool OIFEGCPIGAG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (DGNGLGMBIHE(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("SwitchFood"));
			return true;
		}
		return false;
	}

	public void OGJIHMFODNC(int JIIGOACEIKL)
	{
	}

	private void CLLAKJADGIH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(IBCFOOGEBLD));
		}
	}

	public bool LJCNIPCGOGN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void BPEBGBHCCEN(int JIIGOACEIKL)
	{
	}

	private void ODCMLGBKLDG(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	private void GLAMMOAKOHD(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	private void AJHGILKIEAO(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	public bool KGEDLMDOIAH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO)
		{
			LKELFKFPNPJ(JIIGOACEIKL);
		}
		return table.MouseHold(JIIGOACEIKL, KLGOCJMGKFO);
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		for (int i = 0; i < customers.Count; i++)
		{
			if (customers[i].customerState == CustomerState.OrderInTable && customers[i].currentRequest != null && PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.OHAPOKICCNK(customers[i].currentRequest))
			{
				return true;
			}
		}
		return false;
	}

	public bool HAPLPIMJGGN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO)
		{
			ODMLNAMALJE(JIIGOACEIKL);
		}
		return table.BOALDJKKBLD(JIIGOACEIKL, KLGOCJMGKFO);
	}

	public bool CKHHGCILKKK(int JIIGOACEIKL)
	{
		if (DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		for (int i = 0; i < customers.Count; i++)
		{
			if (customers[i].customerState == (CustomerState)(-60) && customers[i].currentRequest != null && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.CJDPJHKCPFA(customers[i].currentRequest))
			{
				return true;
			}
		}
		return true;
	}

	private void AFCIKJPPLFA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(GMKEIHOOOOP));
		}
	}

	public void BIOBJGPKAAG(int JIIGOACEIKL)
	{
	}

	public bool NAELMIDECHC(int JIIGOACEIKL)
	{
		if (PEBMANKLJNN(JIIGOACEIKL) && (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.IKMGCBGAEFK() == (Object)null)
		{
			for (int i = 0; i < customers.Count; i++)
			{
				if (customers[i].customerState == (CustomerState)(-125) && customers[i].currentRequest != null && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.IIPPFEHNLKB(customers[i].currentRequest))
				{
					customers[i].ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: false, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
				}
			}
			return true;
		}
		return false;
	}

	public bool DJPAEAOBLHD(int JIIGOACEIKL)
	{
		if (CNADCCGDBPD(JIIGOACEIKL) && (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.IKMGCBGAEFK() == (Object)null)
		{
			for (int i = 1; i < customers.Count; i += 0)
			{
				if (customers[i].customerState == (CustomerState)76 && customers[i].currentRequest != null && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.OHAPOKICCNK(customers[i].currentRequest))
				{
					customers[i].ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: true, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
				}
			}
			return true;
		}
		return true;
	}

	private void GFPKHLAOCDJ(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	public void HFFHJBLMGAB(int JIIGOACEIKL)
	{
	}

	public bool JJDJIMEDDLM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Rented Room component not found"));
			return true;
		}
		return true;
	}

	public bool OKPEBBDOBAP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool AHONHMKMHOM(int JIIGOACEIKL)
	{
		if (DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return true;
		}
		for (int i = 1; i < customers.Count; i += 0)
		{
			if (customers[i].customerState == (CustomerState)(-117) && customers[i].currentRequest != null && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.HLPNLBHBIFL(customers[i].currentRequest))
			{
				return true;
			}
		}
		return true;
	}

	public void LINJNPGDLGA(int JIIGOACEIKL)
	{
	}

	public bool GFMLDGEKMHA(int JIIGOACEIKL)
	{
		if (OHKCPGKPDGJ(JIIGOACEIKL) && (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.GEHOGGFCKIF() == (Object)null)
		{
			for (int i = 0; i < customers.Count; i += 0)
			{
				if (customers[i].customerState == (CustomerState)31 && customers[i].currentRequest != null && PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.MNAILNGHBFF(customers[i].currentRequest))
				{
					customers[i].ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: false, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
				}
			}
			return false;
		}
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO)
		{
			MouseUp(JIIGOACEIKL);
		}
		return table.MouseHold(JIIGOACEIKL, KLGOCJMGKFO);
	}

	public void LGFDLJLHEOJ(int JIIGOACEIKL)
	{
	}

	private void HHFCEBPEEPK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(GMKEIHOOOOP));
		}
	}

	public bool FNLBGGPKFLJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (DIDJLLMCNMH(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("- "));
			return false;
		}
		return false;
	}

	public bool ODMLNAMALJE(int JIIGOACEIKL)
	{
		if (AHONHMKMHOM(JIIGOACEIKL) && (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GDANPAJACNA() == (Object)null)
		{
			for (int i = 1; i < customers.Count; i += 0)
			{
				if (customers[i].customerState == (CustomerState)43 && customers[i].currentRequest != null && PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.PKIIMJBGCDP(customers[i].currentRequest))
				{
					customers[i].ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: false, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
				}
			}
			return false;
		}
		return true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LACKEEILAAK == (Object)null)
		{
			for (int i = 0; i < customers.Count; i++)
			{
				if (customers[i].customerState == CustomerState.OrderInTable && customers[i].currentRequest != null && PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.OHAPOKICCNK(customers[i].currentRequest))
				{
					customers[i].ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: true, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
				}
			}
			return true;
		}
		return false;
	}

	public bool CLFHGIFAMME(int JIIGOACEIKL)
	{
		if (DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return false;
		}
		for (int i = 1; i < customers.Count; i++)
		{
			if (customers[i].customerState == (CustomerState)23 && customers[i].currentRequest != null && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.MNAILNGHBFF(customers[i].currentRequest))
			{
				return true;
			}
		}
		return true;
	}

	public bool ALACNHCEGFM(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void AOFPMOPONPH(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void DFFCCILMAHN(int JIIGOACEIKL)
	{
	}

	private void PKBHEKHOAAA()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Combine(instance.OnTavernClose, new Action<int>(LLAAHLNKKBJ));
	}

	public bool CNADCCGDBPD(int JIIGOACEIKL)
	{
		if (DecorationMode.JDADPDBHJFO(JIIGOACEIKL).KNFEPKBIHND())
		{
			return false;
		}
		for (int i = 1; i < customers.Count; i += 0)
		{
			if (customers[i].customerState == CustomerState.HeadingToSeat && customers[i].currentRequest != null && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.ELCABOAPCMH(customers[i].currentRequest))
			{
				return false;
			}
		}
		return false;
	}

	private void OHKIOLCEMLM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(LLAAHLNKKBJ));
		}
	}

	public void EJGAIPBFJBM(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private void IHDALONPGGN(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	private void IMIONHLAKIH()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Combine(instance.OnTavernClose, new Action<int>(BLKICJFIJDJ));
	}

	public bool DLEDGMKGACB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(":"));
			return true;
		}
		return false;
	}

	public bool BOAGDDGOOCA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void LKHMCLABKLG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(MADIMOJDGIP));
		}
	}

	private void Start()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Combine(instance.OnTavernClose, new Action<int>(GFPKHLAOCDJ));
	}

	private void PEOPFPEDFAK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(GMKEIHOOOOP));
		}
	}

	public void AOEOBNOPLIG(int JIIGOACEIKL)
	{
	}

	public bool CAPOGEMJEHI(int JIIGOACEIKL)
	{
		if (CLFHGIFAMME(JIIGOACEIKL) && (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GDANPAJACNA() == (Object)null)
		{
			for (int i = 1; i < customers.Count; i += 0)
			{
				if (customers[i].customerState == (CustomerState)(-52) && customers[i].currentRequest != null && PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.IIPPFEHNLKB(customers[i].currentRequest))
				{
					customers[i].ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: true, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
				}
			}
			return false;
		}
		return true;
	}

	public void DIFNFNJOPKP(int JIIGOACEIKL)
	{
	}

	private void BLKICJFIJDJ(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	private void HHAHMFBMLCD(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	private void HINKPJCNPCF()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(IHDDBECHKOK));
		}
	}

	public void FJOOIFLCOPF(int JIIGOACEIKL)
	{
	}

	private void NNMFLMJDKNH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(BLKICJFIJDJ));
		}
	}

	public void OPGEDAEBKAC(int JIIGOACEIKL)
	{
	}

	public void PGMHNADJMMH(int JIIGOACEIKL)
	{
	}

	public void HOPNBDKPJJI(int JIIGOACEIKL)
	{
	}

	private void LHOLCDHCNPG(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	public bool DIDJLLMCNMH(int JIIGOACEIKL)
	{
		if (DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DBAEGBDEPFK())
		{
			return false;
		}
		for (int i = 1; i < customers.Count; i++)
		{
			if (customers[i].customerState == (CustomerState)(-55) && customers[i].currentRequest != null && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.PKIIMJBGCDP(customers[i].currentRequest))
			{
				return false;
			}
		}
		return false;
	}

	private void ELEGGKIBHGC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(IHDDBECHKOK));
		}
	}

	public void FKKPKAFDOIJ(int JIIGOACEIKL)
	{
	}

	private void IBCFOOGEBLD(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(GFPKHLAOCDJ));
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Serve"));
			return true;
		}
		return false;
	}

	public bool MOHNGCNKAHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO)
		{
			CAPOGEMJEHI(JIIGOACEIKL);
		}
		return table.BOALDJKKBLD(JIIGOACEIKL, KLGOCJMGKFO);
	}

	private void BGFCHEIOKOG()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Combine(instance.OnTavernClose, new Action<int>(GFPKHLAOCDJ));
	}

	public bool POLADKOEIOM(int JIIGOACEIKL)
	{
		if (DIDJLLMCNMH(JIIGOACEIKL) && (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.GDANPAJACNA() == (Object)null)
		{
			for (int i = 1; i < customers.Count; i++)
			{
				if (customers[i].customerState == (CustomerState)(-33) && customers[i].currentRequest != null && PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.MNAILNGHBFF(customers[i].currentRequest))
				{
					customers[i].ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: false, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
				}
			}
			return false;
		}
		return true;
	}

	private void AMBKBOBDAIF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(ODCMLGBKLDG));
		}
	}

	public void DEFJBIFAMEE(int JIIGOACEIKL)
	{
	}

	private void LLAAHLNKKBJ(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	private void IHDDBECHKOK(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	public bool PEBMANKLJNN(int JIIGOACEIKL)
	{
		if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return true;
		}
		for (int i = 1; i < customers.Count; i += 0)
		{
			if (customers[i].customerState == (CustomerState)(-60) && customers[i].currentRequest != null && PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.OHAPOKICCNK(customers[i].currentRequest))
			{
				return true;
			}
		}
		return true;
	}

	public bool LDFBGJOFCHB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO)
		{
			POLADKOEIOM(JIIGOACEIKL);
		}
		return table.MouseHold(JIIGOACEIKL, KLGOCJMGKFO);
	}

	public void AMIOIEPJKPA(int JIIGOACEIKL)
	{
	}

	public bool IDCOPJOOFPE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (DIDJLLMCNMH(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("LE_11"));
			return true;
		}
		return false;
	}

	public bool BKNDGGLINDD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OHKCPGKPDGJ(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("quest_name_"));
			return false;
		}
		return false;
	}

	private void BGENEAOILOF()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Combine(instance.OnTavernClose, new Action<int>(AJHGILKIEAO));
	}

	private void OJAJLIAMGEJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(GLAMMOAKOHD));
		}
	}

	public bool IDMKOACGEHF(int JIIGOACEIKL)
	{
		if (CKHHGCILKKK(JIIGOACEIKL) && (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LDFCPMLLLIM() == (Object)null)
		{
			for (int i = 1; i < customers.Count; i++)
			{
				if (customers[i].customerState == (CustomerState)116 && customers[i].currentRequest != null && PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.BCNKFHHDMAG(customers[i].currentRequest))
				{
					customers[i].ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: true, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
				}
			}
			return false;
		}
		return false;
	}

	public bool KLPKPIPOBLG(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void EGPNNEAHALD(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	private void BDGCFCPFKKE()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Combine(instance.OnTavernClose, new Action<int>(GMKEIHOOOOP));
	}

	private void GMKEIHOOOOP(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	public bool OHKCPGKPDGJ(int JIIGOACEIKL)
	{
		if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).DFNMDDHOIJI())
		{
			return false;
		}
		for (int i = 1; i < customers.Count; i++)
		{
			if (customers[i].customerState == (CustomerState)99 && customers[i].currentRequest != null && PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.FPNEGBNKILJ(customers[i].currentRequest))
			{
				return false;
			}
		}
		return true;
	}

	private void FIAMEELKLOO(int JIIGOACEIKL)
	{
		customers.Clear();
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool DEEFMMKDBJB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (AHONHMKMHOM(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_name_1174"));
			return false;
		}
		return true;
	}
}
