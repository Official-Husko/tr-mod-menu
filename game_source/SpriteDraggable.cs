using System;
using UnityEngine;

public class SpriteDraggable : MonoBehaviour, IDragable, IInteractable
{
	public bool followOnDrag = true;

	private bool AEFGLLDFDBB;

	private int JIIGOACEIKL;

	private void EBFJOAEJPGE()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.FJLAMCHKCOI(0))
			{
				JIIGOACEIKL = 4;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).CEHENKKHEID();
			if (PlayerInputs.DEGBDMMDIIL(0).ALPHFOIMNIA("SendHome"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	public void DGPAPPICMHP()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	private void LMFICKFGEFI()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.POLDHCKJINN(5))
			{
				JIIGOACEIKL = 8;
			}
			else
			{
				JIIGOACEIKL = 1;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition();
			if (PlayerInputs.DEGBDMMDIIL(0).GetButtonUp("NormalLeft"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	private void NIHJCJJKDBA()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.FJLAMCHKCOI(6))
			{
				JIIGOACEIKL = 0;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).IKMFEPDGBFI();
			if (PlayerInputs.DEGBDMMDIIL(1).ALPHFOIMNIA(""))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	public void KPGGMCDDMAG()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public void GNADEGLGAOJ()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public void POMEEAFNCCA()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	private void GGPDPOAICOM()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.POLDHCKJINN(6))
			{
				JIIGOACEIKL = 3;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).CEHENKKHEID();
			if (PlayerInputs.GetPlayer(0).GetButtonUp(" "))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	public bool DOGBEDLPOMJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool EAOHDAKIJCK(int JIIGOACEIKL)
	{
		return false;
	}

	public void EPKIJMKDGML()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool PHJEHEOFJFN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool JOFKADGLMPD(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PJBBLEGMBAK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void JKINNKHOFPA()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	private void DDLLFPICOJK()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(6))
			{
				JIIGOACEIKL = 5;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).CEHENKKHEID();
			if (PlayerInputs.DEGBDMMDIIL(1).LKOGGHNGBKD("BecomeNuisance"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	public bool HEHFGHDILPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool POLADKOEIOM(int JIIGOACEIKL)
	{
		return false;
	}

	public void PIGDFNEPGHO()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool DJPAEAOBLHD(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PDPOCEDOJMB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void APDIBAFGHMO()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void OPDPCCHJIKA()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool JENFOIFJOPF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool CANOIJPJMBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void EJPHBJNIIOK()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool FKNBGLEMLFM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool PKDBLDMIMAO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void LCEKCPFEKJL()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	private void EIGEIJJPFFP()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(6))
			{
				JIIGOACEIKL = 7;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IKMFEPDGBFI();
			if (PlayerInputs.GetPlayer(0).KFAFNEJNDDL("ReceiveUpdateDrinkColorTable"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	private void ELHCBGCEJDH()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(2))
			{
				JIIGOACEIKL = 7;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).CEHENKKHEID();
			if (PlayerInputs.DEGBDMMDIIL(0).KFAFNEJNDDL("\n"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	public bool BAJPKFFHDPJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool PIJNGCIFLPG(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PAGLJJJCFJN(int JIIGOACEIKL)
	{
		return false;
	}

	private void MCLAJGDIIBK()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.FJLAMCHKCOI(4))
			{
				JIIGOACEIKL = 7;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).CEHENKKHEID();
			if (PlayerInputs.DEGBDMMDIIL(1).ALPHFOIMNIA("Bouncer/"))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		return true;
	}

	public void IFGGIINHPBG()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	private void GGCCOKCOMEE()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.POLDHCKJINN(1))
			{
				JIIGOACEIKL = 1;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorScreenPosition();
			if (PlayerInputs.GetPlayer(0).LKOGGHNGBKD("No content to enable / disable in this NPC!"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	public bool IPPODLIPDPJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool NLJKBACPIFA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool JENDIAHPKNK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void LOJCGAKNPPB()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool MNDDOAAODLI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void OnDrag()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public void HFAFCENAEJE()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool OPDOELKOIMI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void KGJHEGJPIBM()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool MGJJNHMOJHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool OIICHHNIBMC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void HMCLGKHCLPG()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(4))
			{
				JIIGOACEIKL = 3;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).CEHENKKHEID();
			if (PlayerInputs.GetPlayer(0).LKOGGHNGBKD("Till"))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	public bool LMECIDNJHIL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool AGBPAGIILDG(int JIIGOACEIKL)
	{
		return false;
	}

	public void CBMOFCOGJHE()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool MJDJANLLJPP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void CMJPIAAGIFF()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(8))
			{
				JIIGOACEIKL = 0;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).CEHENKKHEID();
			if (PlayerInputs.GetPlayer(0).KFAFNEJNDDL("contentLockRepMessage"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	public bool PGDDFHMBGDK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void DEPHFGJHDBE()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	private void OFDEGDJGGGF()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.POLDHCKJINN(7))
			{
				JIIGOACEIKL = 7;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).IKMFEPDGBFI();
			if (PlayerInputs.GetPlayer(0).ALPHFOIMNIA("show popup"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	public bool NHHLLANEOEA(int JIIGOACEIKL)
	{
		return false;
	}

	public bool ABLNPEOHBNL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void DMCDEFFLHOL()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool KHAFEICJIMJ(int JIIGOACEIKL)
	{
		return false;
	}

	public void KHAPHLLCKFJ()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool BBHBNGPELEP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void GHGAAECFJAE()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	private void AKDPJCEJKPN()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(2))
			{
				JIIGOACEIKL = 4;
			}
			else
			{
				JIIGOACEIKL = 1;
			}
			((Component)this).transform.position = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).CEHENKKHEID();
			if (PlayerInputs.GetPlayer(1).ALPHFOIMNIA("Sleep"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	public bool PNLGPKCJJHG(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool JGKPIMAGPAK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool BGHCJHPNKHP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CFLDFKODIKL(int JIIGOACEIKL)
	{
		return true;
	}

	public bool GKKEAILLOBN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool KPBBDKDPEFL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool CAJMKLBCBEK(int JIIGOACEIKL)
	{
		return false;
	}

	public bool OICEBEEANAI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool FIBJOCDEDEJ(int JIIGOACEIKL)
	{
		return true;
	}

	public bool AJCGEBOAAIJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void KCDCKLMCMEE()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void FLKCLAPFAMM()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	private void CNBLOMJJECI()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.POLDHCKJINN(7))
			{
				JIIGOACEIKL = 0;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).CEHENKKHEID();
			if (PlayerInputs.GetPlayer(1).LKOGGHNGBKD("Controls"))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	public bool HINGCLJLHJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void MKBAHKDPLIB()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	private void LHFOFAMDKEO()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.IsGamepadActive(7))
			{
				JIIGOACEIKL = 4;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).IKMFEPDGBFI();
			if (PlayerInputs.GetPlayer(0).KFAFNEJNDDL("Error_CellarDoorIsBlocking"))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	public void KNCPDACOOHA()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	private void LEDIGKGAFHC()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(4))
			{
				JIIGOACEIKL = 8;
			}
			else
			{
				JIIGOACEIKL = 1;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition();
			if (PlayerInputs.GetPlayer(0).ALPHFOIMNIA("Wage"))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	public bool OAJLNOBMLDI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool HHNGABEOOPL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void FPMJAKBLAJN()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool HGBPIJGKALA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool PGJPIMIJHJA(int JIIGOACEIKL)
	{
		return false;
	}

	public void EKFFLOKNLID()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool OKBPDMDJICC(int JIIGOACEIKL)
	{
		return false;
	}

	private void MGMLDHPOLGK()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.POLDHCKJINN(4))
			{
				JIIGOACEIKL = 2;
			}
			else
			{
				JIIGOACEIKL = 1;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).CEHENKKHEID();
			if (PlayerInputs.GetPlayer(1).GetButtonUp("OpenRecipeBook"))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	public bool GHDIMCAEAJJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool IHDJCCLMDII(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EGGKNHMIOLE(int JIIGOACEIKL)
	{
		return false;
	}

	public void MCCFKDPAOHF()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public void CGLNFFADENK()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool GGLKCAFNFOB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool ONDLNJAJKEH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void Update()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.IsGamepadActive(2))
			{
				JIIGOACEIKL = 2;
			}
			else
			{
				JIIGOACEIKL = 1;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition();
			if (PlayerInputs.GetPlayer(1).GetButtonUp("Interact"))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	public void GHNDCIECCAC()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool KAPFKOCOOCO(int JIIGOACEIKL)
	{
		return false;
	}

	private void HAJJALABMOC()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.ODGALPDEIFG(5))
			{
				JIIGOACEIKL = 2;
			}
			else
			{
				JIIGOACEIKL = 1;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).IKMFEPDGBFI();
			if (PlayerInputs.GetPlayer(0).LKOGGHNGBKD("Dialogue System/Conversation/BirdCatInteraction/Entry/4/Dialogue Text"))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	public bool FHDFKMOIKBM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void CPMAIMEEMLF()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	private void DHBMBJOLGDE()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(6))
			{
				JIIGOACEIKL = 3;
			}
			else
			{
				JIIGOACEIKL = 1;
			}
			((Component)this).transform.position = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IKMFEPDGBFI();
			if (PlayerInputs.DEGBDMMDIIL(1).ALPHFOIMNIA("vSync"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	public void CEPFNJFAONC()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool KKCJMNJFELB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void IGKPEBGHPGD()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.POLDHCKJINN(1))
			{
				JIIGOACEIKL = 1;
			}
			else
			{
				JIIGOACEIKL = 1;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).IKMFEPDGBFI();
			if (PlayerInputs.GetPlayer(0).ALPHFOIMNIA("Starchy"))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	private void INKOKIGFJBG()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(4))
			{
				JIIGOACEIKL = 5;
			}
			else
			{
				JIIGOACEIKL = 1;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).IKMFEPDGBFI();
			if (PlayerInputs.GetPlayer(0).KFAFNEJNDDL("UI2"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	public bool CGBBGIFMMDB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void MHCOLHEDNGN()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.POLDHCKJINN(7))
			{
				JIIGOACEIKL = 1;
			}
			else
			{
				JIIGOACEIKL = 1;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition();
			if (PlayerInputs.GetPlayer(1).ALPHFOIMNIA("Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/4/Dialogue Text"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	private void NDLCBLKOBLF()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.ODGALPDEIFG(0))
			{
				JIIGOACEIKL = 7;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition();
			if (PlayerInputs.GetPlayer(0).KFAFNEJNDDL("Circle"))
			{
				AEFGLLDFDBB = true;
			}
		}
	}

	private void DGJKLAEINHJ()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(8))
			{
				JIIGOACEIKL = 2;
			}
			else
			{
				JIIGOACEIKL = 1;
			}
			((Component)this).transform.position = CursorManager.GetPlayer(JIIGOACEIKL).IKMFEPDGBFI();
			if (PlayerInputs.GetPlayer(1).GetButtonUp("Open"))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	private void OLFPIBOIIIO()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (AEFGLLDFDBB)
		{
			if (GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(1))
			{
				JIIGOACEIKL = 2;
			}
			else
			{
				JIIGOACEIKL = 0;
			}
			((Component)this).transform.position = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorScreenPosition();
			if (PlayerInputs.GetPlayer(0).GetButtonUp("A number is needed."))
			{
				AEFGLLDFDBB = false;
			}
		}
	}

	public bool BAGPKDFCDPN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void MDJHDKLAFBD()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public void HKGNFLAHGOF()
	{
		AEFGLLDFDBB = followOnDrag;
	}

	public bool JCCEPNCJDPB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}
}
