using System;
using AlmenaraGames;
using UnityEngine;

public class Pickupable : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public struct PickedUp
	{
		public Vector3 position;

		public Item item;

		public bool flipX;

		public PickedUp(Vector3 IMOBLFMHKOD, Item MEMGMDOCBOJ, bool CBANJPOGGKA)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			position = IMOBLFMHKOD;
			item = MEMGMDOCBOJ;
			flipX = CBANJPOGGKA;
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void KPMGOKPDFHC(int JIIGOACEIKL)
	{
	}

	public bool LBNJPLCFLEE(int JIIGOACEIKL)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (JPDMPGABGAD(JIIGOACEIKL))
		{
			ItemInstance bGLFLHDNOKJ = ((Component)this).GetComponent<ItemSetup>().item.JMDALJBNFML();
			if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(bGLFLHDNOKJ, HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false))
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
				CommonReferences.MNFMOEKMJKN().pickedUps.Add(new PickedUp(((Component)this).transform.position, ((Component)this).GetComponent<ItemSetup>().item, ((Component)this).GetComponent<SpriteRenderer>().flipX));
				return false;
			}
		}
		return false;
	}

	public bool POLADKOEIOM(int JIIGOACEIKL)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ItemInstance bGLFLHDNOKJ = ((Component)this).GetComponent<ItemSetup>().item.JMDALJBNFML();
			if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).OJDGOADOCMG(bGLFLHDNOKJ))
			{
				MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
				CommonReferences.GGFJGHHHEJC.pickedUps.Add(new PickedUp(((Component)this).transform.position, ((Component)this).GetComponent<ItemSetup>().item, ((Component)this).GetComponent<SpriteRenderer>().flipX));
				return true;
			}
		}
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void KMBCKODACPJ(int JIIGOACEIKL)
	{
	}

	public bool JPDMPGABGAD(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Pick up"));
			return true;
		}
		return false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ItemInstance bGLFLHDNOKJ = ((Component)this).GetComponent<ItemSetup>().item.JMDALJBNFML();
			if (PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(bGLFLHDNOKJ))
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
				CommonReferences.GGFJGHHHEJC.pickedUps.Add(new PickedUp(((Component)this).transform.position, ((Component)this).GetComponent<ItemSetup>().item, ((Component)this).GetComponent<SpriteRenderer>().flipX));
				return true;
			}
		}
		return false;
	}

	public bool GHJJBAINGGM(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool IDMKOACGEHF(int JIIGOACEIKL)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (POCJGFBIJDL(JIIGOACEIKL))
		{
			ItemInstance bGLFLHDNOKJ = ((Component)this).GetComponent<ItemSetup>().item.JMDALJBNFML();
			if (PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).OJDGOADOCMG(bGLFLHDNOKJ, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false))
			{
				MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
				CommonReferences.MNFMOEKMJKN().pickedUps.Add(new PickedUp(((Component)this).transform.position, ((Component)this).GetComponent<ItemSetup>().item, ((Component)this).GetComponent<SpriteRenderer>().flipX));
				return true;
			}
		}
		return false;
	}

	public void LGFDLJLHEOJ(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool HFAILPNNNBB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool NOJJKKFGJEJ(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool OLAELPBFNEB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool AFAKDGJEKFG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool JLKEECCECMF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool DFHNFGMFGLH(int JIIGOACEIKL)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (NOJJKKFGJEJ(JIIGOACEIKL))
		{
			ItemInstance bGLFLHDNOKJ = ((Component)this).GetComponent<ItemSetup>().item.JMDALJBNFML();
			if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(bGLFLHDNOKJ, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false))
			{
				MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
				CommonReferences.GGFJGHHHEJC.pickedUps.Add(new PickedUp(((Component)this).transform.position, ((Component)this).GetComponent<ItemSetup>().item, ((Component)this).GetComponent<SpriteRenderer>().flipX));
				return false;
			}
		}
		return true;
	}

	public void BJCDFHFKEGG(int JIIGOACEIKL)
	{
	}

	public void JBAMJKJNMHG(int JIIGOACEIKL)
	{
	}

	public bool POCJGFBIJDL(int JIIGOACEIKL)
	{
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public void FMOLFKKGDDM(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool EEKCDBMDNOG(int JIIGOACEIKL)
	{
		return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DFNMDDHOIJI();
	}
}
