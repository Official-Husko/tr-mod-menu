using System.Collections.Generic;
using UnityEngine;

public class PhysicalSpaceWall : PhysicalSpace
{
	public List<int> exceptionIds;

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("Bob") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.JGHNDJBCFAJ()))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	private void MKCEGNPBGMP(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("{0} - The mine piece {1} has a variant object with puzzle altar but the piece ID doesn't match the altar piece ID. Piece ID: {2} - Altar Piece ID: {3}") && colliders.Contains(HANHCHBHHEH))
		{
			PKCAAIIIAGH(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	private void JDFDGHGMIEO(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("Error_CloseMenus") && colliders.Contains(HANHCHBHHEH))
		{
			HIEJKGKOPHI(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	public void HFKDDFOADLP()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
				}
			}
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("Throw") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.JGHNDJBCFAJ()))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	private void IEKAODBMKDL(Collider2D HANHCHBHHEH)
	{
		OMJOPFKJAJM = ((Component)HANHCHBHHEH).GetComponent<PhysicalSpace>();
		if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable))
		{
			OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: true);
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("itemRawChicken") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.IMCJPECAAPC()))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	private void CFEAEHLDCOI()
	{
		HLJICAAOJPM();
	}

	public void NEMPIEBJDDI()
	{
		for (int i = 1; i < colliders.Count; i += 0)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: false);
				}
			}
		}
	}

	private void BNOJNEJMCID(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("\n") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.ODENMDOJPLC()))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	private void HMFAFGOALOH(Collider2D HANHCHBHHEH)
	{
		OMJOPFKJAJM = ((Component)HANHCHBHHEH).GetComponent<PhysicalSpace>();
		if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable))
		{
			OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
		}
	}

	public void GLKEKAGEKJA()
	{
		for (int i = 0; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.HJFOHHPNKIO(KMEJCLIOMBA: true);
				}
			}
		}
	}

	public void OFHEAMDAHJN()
	{
		for (int i = 0; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.HJFOHHPNKIO(KMEJCLIOMBA: false);
				}
			}
		}
	}

	private void KCDODEOOBHG(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("UINextCategory") && colliders.Contains(HANHCHBHHEH))
		{
			LMGMAGOCDND(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	public void CJBECHMCKON()
	{
		for (int i = 1; i < colliders.Count; i += 0)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: true);
				}
			}
		}
	}

	public void OPMPCMAKOLD()
	{
		for (int i = 0; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.HJFOHHPNKIO(KMEJCLIOMBA: false);
				}
			}
		}
	}

	public void KDCKJHLNOIA()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: true);
				}
			}
		}
	}

	private void BIJGJOMFNOJ(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("daysLeft") && colliders.Contains(HANHCHBHHEH))
		{
			HMFAFGOALOH(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	private void FAJIHILFELE(Collider2D HANHCHBHHEH)
	{
		OMJOPFKJAJM = ((Component)HANHCHBHHEH).GetComponent<PhysicalSpace>();
		if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable))
		{
			OMJOPFKJAJM.placeable.HJFOHHPNKIO(KMEJCLIOMBA: false);
		}
	}

	private void GGIJFBAJLIF()
	{
		MFKPPFLMBMI();
	}

	private void OBLCKPMAADM()
	{
		DPLDOCEEGHE();
	}

	public void OMEFGMLGDJM()
	{
		for (int i = 0; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: true);
				}
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("PhysicalSpace") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.JDJGFAACPFC()))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	public void BNJLLOCELED()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
				}
			}
		}
	}

	public void CKKLJJNMMGP()
	{
		for (int i = 1; i < colliders.Count; i += 0)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
				}
			}
		}
	}

	private void DCFEMOFDLHH(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("cameraZoom2") && colliders.Contains(HANHCHBHHEH))
		{
			HMFAFGOALOH(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	public void EINCHLIKANO()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: false);
				}
			}
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false)))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("PhysicalSpace") && colliders.Contains(HANHCHBHHEH))
		{
			IJIGFBOFBFA(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	private void FBHBEAJFBAH()
	{
		ELGLOJFJPCE();
	}

	private void JEMIPCBNPDI(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("OnGameLobbyJoinRequested. \nLobby: {0} \nFriend: {1}") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.JPNFKDMFKMC()))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	private void BLOCHBJIICN(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains(")") && colliders.Contains(HANHCHBHHEH))
		{
			LMGMAGOCDND(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	public void OHKNCKFDIAM()
	{
		for (int i = 1; i < colliders.Count; i += 0)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
				}
			}
		}
	}

	public void DADOIKNEBKL()
	{
		for (int i = 0; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.HJFOHHPNKIO(KMEJCLIOMBA: false);
				}
			}
		}
	}

	private void DEKJGPJMAPC(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("ReceiveAddItemOnTray") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false)))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	private void BKAMJGAELGH(Collider2D HANHCHBHHEH)
	{
		OMJOPFKJAJM = ((Component)HANHCHBHHEH).GetComponent<PhysicalSpace>();
		if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable))
		{
			OMJOPFKJAJM.placeable.HJFOHHPNKIO(KMEJCLIOMBA: false);
		}
	}

	private void GPLHAHMGODA(Collider2D HANHCHBHHEH)
	{
		OMJOPFKJAJM = ((Component)HANHCHBHHEH).GetComponent<PhysicalSpace>();
		if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable))
		{
			OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
		}
	}

	public void MFKPPFLMBMI()
	{
		for (int i = 0; i < colliders.Count; i += 0)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
				}
			}
		}
	}

	private void LMGMAGOCDND(Collider2D HANHCHBHHEH)
	{
		OMJOPFKJAJM = ((Component)HANHCHBHHEH).GetComponent<PhysicalSpace>();
		if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable))
		{
			OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: false);
		}
	}

	public void IILFJDAHDIE()
	{
		for (int i = 1; i < colliders.Count; i += 0)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: false);
				}
			}
		}
	}

	private void KIJDNFODCKJ(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("OrderName") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false)))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	private void CGNGIBNPDNA(Collider2D HANHCHBHHEH)
	{
		OMJOPFKJAJM = ((Component)HANHCHBHHEH).GetComponent<PhysicalSpace>();
		if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable))
		{
			OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
		}
	}

	public void ECFJLPAKHJD()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: true);
				}
			}
		}
	}

	public void HLJICAAOJPM()
	{
		for (int i = 0; i < colliders.Count; i += 0)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.HJFOHHPNKIO(KMEJCLIOMBA: false);
				}
			}
		}
	}

	private void IJIGFBOFBFA(Collider2D HANHCHBHHEH)
	{
		OMJOPFKJAJM = ((Component)HANHCHBHHEH).GetComponent<PhysicalSpace>();
		if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable))
		{
			OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
		}
	}

	private void GHCOOCFODFH(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("") && colliders.Contains(HANHCHBHHEH))
		{
			BKAMJGAELGH(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	private void HHGJLOKEPJE(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("Brewing") && colliders.Contains(HANHCHBHHEH))
		{
			GPLHAHMGODA(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	private void OnDisable()
	{
		UnhighlightInvalids();
	}

	public void HNDFPHKPLMN()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: true);
				}
			}
		}
	}

	public void DCCCANLFFIB()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: false);
				}
			}
		}
	}

	private void KNKILPPBEDC()
	{
		UnhighlightInvalids();
	}

	public void DPLDOCEEGHE()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: false);
				}
			}
		}
	}

	private void HHBJICLBNPE(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("City/Lia/Bark/Bye") && colliders.Contains(HANHCHBHHEH))
		{
			FAJIHILFELE(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	private void PKCAAIIIAGH(Collider2D HANHCHBHHEH)
	{
		OMJOPFKJAJM = ((Component)HANHCHBHHEH).GetComponent<PhysicalSpace>();
		if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable))
		{
			OMJOPFKJAJM.placeable.HJFOHHPNKIO(KMEJCLIOMBA: false);
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("Clean") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.IMCJPECAAPC()))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	private void BPINJGFECPF()
	{
		BNJLLOCELED();
	}

	public override bool ValidPosition()
	{
		for (int i = 0; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					return false;
				}
			}
		}
		return true;
	}

	public void FDOBEBAGHPK()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: false);
				}
			}
		}
	}

	public void GOKBAFACJOM()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.HJFOHHPNKIO(KMEJCLIOMBA: true);
				}
			}
		}
	}

	public void UnhighlightInvalids()
	{
		for (int i = 0; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
				}
			}
		}
	}

	public void ELGLOJFJPCE()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: true);
				}
			}
		}
	}

	private void AECMHPBLPNP()
	{
		ECFJLPAKHJD();
	}

	private void CHDGJHNBNEJ()
	{
		OFHEAMDAHJN();
	}

	private void HJMGMIKGPOI(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("F2") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false)))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	public void HighlightInvalids()
	{
		for (int i = 0; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: false);
				}
			}
		}
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("add letter ") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.CIGFGKKCPCK()))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	private void ECHMKEAGFFO()
	{
		OFHEAMDAHJN();
	}

	private void DAGGKPKBCLD(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("startPolling") && colliders.Contains(HANHCHBHHEH))
		{
			BKAMJGAELGH(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	private void CENNMFKEOED(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("Creating new snow map") && colliders.Contains(HANHCHBHHEH))
		{
			LMGMAGOCDND(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	private void HIEJKGKOPHI(Collider2D HANHCHBHHEH)
	{
		OMJOPFKJAJM = ((Component)HANHCHBHHEH).GetComponent<PhysicalSpace>();
		if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable))
		{
			OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: false);
		}
	}

	public void JMOEDCIJEBE()
	{
		for (int i = 0; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: false);
				}
			}
		}
	}

	private void HCGGDMEEBHD(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("Unfreeze") && colliders.Contains(HANHCHBHHEH))
		{
			CGNGIBNPDNA(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	public void FCPHPLPFOJB()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
				}
			}
		}
	}

	private void CMLFBCFLPBJ(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("Items/item_description_1031") && !colliders.Contains(HANHCHBHHEH))
		{
			if (exceptionIds == null)
			{
				colliders.Add(HANHCHBHHEH);
			}
			else if (!exceptionIds.Contains(((Component)HANHCHBHHEH).gameObject.GetComponent<PhysicalSpaceWall>().placeable.itemSetup.item.CIGFGKKCPCK()))
			{
				colliders.Add(HANHCHBHHEH);
			}
		}
	}

	private void DNDNCBILKMB(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains(",") && colliders.Contains(HANHCHBHHEH))
		{
			BKAMJGAELGH(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}

	public void NODOHGEAJOE()
	{
		for (int i = 1; i < colliders.Count; i += 0)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: true);
				}
			}
		}
	}

	public void DODBBJKCLFB()
	{
		for (int i = 0; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.HJFOHHPNKIO(KMEJCLIOMBA: false);
				}
			}
		}
	}

	public void MJKGAAONIHN()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.MMLKIKPOJDJ(KMEJCLIOMBA: false);
				}
			}
		}
	}

	private void HKNNKJKNAGL()
	{
		JMOEDCIJEBE();
	}

	public void MJAGEOBGDIK()
	{
		for (int i = 1; i < colliders.Count; i++)
		{
			if (!((Object)(object)colliders[i] == (Object)null))
			{
				OMJOPFKJAJM = ((Component)colliders[i]).GetComponent<PhysicalSpace>();
				if (Object.op_Implicit((Object)(object)OMJOPFKJAJM) && Object.op_Implicit((Object)(object)OMJOPFKJAJM.placeable) && (Object)(object)OMJOPFKJAJM.placeable.currentSurface == (Object)(object)placeable.currentSurface)
				{
					OMJOPFKJAJM.placeable.SetValidColor(KMEJCLIOMBA: true);
				}
			}
		}
	}

	private void FGLCNIOLKKL()
	{
		CKKLJJNMMGP();
	}

	private void KEICGGPGIED(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name.Contains("Intro01") && colliders.Contains(HANHCHBHHEH))
		{
			IEKAODBMKDL(HANHCHBHHEH);
			colliders.Remove(HANHCHBHHEH);
		}
	}
}
