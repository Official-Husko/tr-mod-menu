using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HouseKeeperWaiting : HouseKeeperBaseState
{
	public float currentTimeNegotiating;

	public bool negotiating;

	public bool inTable;

	public bool anyRequest;

	private Customer customer;

	private List<RentedRoom> roomsAvailable;

	private RentedRoom rentedRoom;

	private void MHOILDMHNFG()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.GetHouseKeeperPositionTransform().position;
		FNKIODOAHPN();
	}

	private void CHFEBLHALFO()
	{
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
		}
		else
		{
			LACDAMFANIM();
		}
	}

	private void IPPJDOPPGEP()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.HFMICHAOJFK().position;
		BBHODALHMAD();
	}

	private bool NBODMEMNPFI()
	{
		if (!negotiating && inTable && !RentRoomUI.PPJMPMKLCME(0).IsOpen() && !RentRoomUI.FBKOKJCKICN(3).HDEPMJIDJEM())
		{
			return !RoomReceptionDesk.instance.MPFPHMDGIHB();
		}
		return true;
	}

	private void CADMIMFGPDE()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
		}
		else
		{
			BKNBKDKIDNJ();
		}
	}

	private void LIDNKOPEPBK()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.GetHouseKeeperPositionTransform().position;
		LMNGLLCDPIC();
	}

	private bool DFMDCHKHDAE()
	{
		if (!negotiating && inTable && !RentRoomUI.FBKOKJCKICN(1).IsOpen() && !RentRoomUI.LPJPJMPOHPG(4).IsOpen())
		{
			return !RoomReceptionDesk.instance.HLPDKNGONBI();
		}
		return false;
	}

	private bool HOLMCCIMKGA()
	{
		if (!negotiating && inTable && !RentRoomUI.JDODHPEDACJ(1).HDEPMJIDJEM() && !RentRoomUI.OFEFGPCGJDF(5).IsOpen())
		{
			return !RoomReceptionDesk.instance.DEJPMDCBJAN();
		}
		return true;
	}

	private void FCAHKEIABLD()
	{
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
		}
		else
		{
			EDDFAALFNGB();
		}
	}

	private bool OIJDGGKIPLM()
	{
		if (!negotiating && inTable && !RentRoomUI.FBKOKJCKICN(1).IsOpen() && !RentRoomUI.Get(8).IsOpen())
		{
			return RoomReceptionDesk.instance.MPFPHMDGIHB();
		}
		return true;
	}

	private void EDDFAALFNGB()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.EJEECOMAMBP().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Left;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(0);
		inTable = true;
	}

	private void LMNGLLCDPIC()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Diagonal);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private void BFGEFKOODNA()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM((Direction)7);
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void LKDCNMHNMCP()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.AJCPFEMEHNF().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)5;
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void IKOIKCHBBNG()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void JLLNNKLEKCP()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			houseKeeper.Leave();
		}
		else
		{
			LMNGLLCDPIC();
		}
	}

	private void FNJODLOADKA()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM((Direction)5);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Up;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private void OIKPCOJDHKA()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
		}
		else
		{
			IKABHLBGNBE();
		}
	}

	private bool AMFDIMGCJAN()
	{
		if (!negotiating && inTable && !RentRoomUI.JDODHPEDACJ(0).IsOpen() && !RentRoomUI.NHOFBAMNELD(7).BGLJFMHCFJF())
		{
			return RoomReceptionDesk.instance.HLPDKNGONBI();
		}
		return false;
	}

	private bool BKAIJIDFMAG()
	{
		if (!negotiating && inTable && !RentRoomUI.LPJPJMPOHPG(0).HDEPMJIDJEM() && !RentRoomUI.OFEFGPCGJDF(3).HDEPMJIDJEM())
		{
			return RoomReceptionDesk.instance.DEJPMDCBJAN();
		}
		return true;
	}

	private void KPMCGMJJBEA()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Right;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Up;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void KMCLMHNIKMC()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.GetHouseKeeperPositionTransform().position;
		LEDKBJOFJCM();
	}

	private void PADPIEKGNMH()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.EJEECOMAMBP().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM((Direction)8);
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = true;
	}

	private void JOPPNEFKCCO()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.JMEPJMJMAGL().position;
		NKAMNKDKLHI();
	}

	private void EGIHDANFNHG()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.EJEECOMAMBP().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private void NIGAFKHBOFI()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.NMCMGEAMLGH().position;
		IJKIFECCGEP();
	}

	private void GFLNGGGPGCF()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KAIKMCMMHLL().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Left);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void LACDAMFANIM()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.AJCPFEMEHNF().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM((Direction)5);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Up;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void NHCAPCCBNAL()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Right);
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Up);
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(1);
		inTable = true;
	}

	private void FFAHHKEJGJN()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Left);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = true;
	}

	private void JAGPGKCKBFA()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
		}
		else
		{
			IKOIKCHBBNG();
		}
	}

	private bool PDDIJDJNKEB()
	{
		if (!negotiating && inTable && !RentRoomUI.OMLGNAJPLDE(1).BGLJFMHCFJF() && !RentRoomUI.Get(8).IsOpen())
		{
			return !RoomReceptionDesk.instance.HLPDKNGONBI();
		}
		return false;
	}

	private void JFLOAIFDKAD()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.JMEPJMJMAGL().position;
		FNJODLOADKA();
	}

	private void FCBHBANPOKA()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
		}
		else
		{
			BCDDGNEGDNL();
		}
	}

	private void JPKHFKOKCJG()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
		}
		else
		{
			DCLMGAKHJDP();
		}
	}

	private bool IDLLLGDHGBP()
	{
		if (!negotiating && inTable && !RentRoomUI.HJHCKIAKCKD(0).BGLJFMHCFJF() && !RentRoomUI.NHOFBAMNELD(6).IsOpen())
		{
			return RoomReceptionDesk.instance.MPFPHMDGIHB();
		}
		return false;
	}

	private void IKABHLBGNBE()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.FEDJFNCCPDD().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void KBEKKHDBFII()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
		}
		else
		{
			EIAMODMOLIL();
		}
	}

	private void PDDJJOLOJIJ()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			houseKeeper.Leave();
		}
		else
		{
			EIAMODMOLIL();
		}
	}

	private void BBALEEMJKMP()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
		}
		else
		{
			OMPINFKNJAF();
		}
	}

	private void MMOGLAMDMLO()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.NMCMGEAMLGH().position;
		DCLMGAKHJDP();
	}

	private void FBGCCKIAPDF()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
		}
		else
		{
			JEPBPABEDGE();
		}
	}

	private void CNIEDLKPGBK()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)5;
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void BNJCGFFDIFD()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			houseKeeper.Leave();
		}
		else
		{
			KPMCGMJJBEA();
		}
	}

	private void BEEDFJOOPAH()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)8;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private void ODFOOGPCNGE()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.JMEPJMJMAGL().position;
		FFAHHKEJGJN();
	}

	private bool LDGECMAOBKF()
	{
		if (!negotiating && inTable && !RentRoomUI.OMLGNAJPLDE(0).BGLJFMHCFJF() && !RentRoomUI.Get(4).HDEPMJIDJEM())
		{
			return !RoomReceptionDesk.instance.HLPDKNGONBI();
		}
		return false;
	}

	private void LCCKPFDCPJO()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.NMCMGEAMLGH().position;
		CNIEDLKPGBK();
	}

	private bool ECILBPENMOK()
	{
		if (!negotiating && inTable && !RentRoomUI.PPJMPMKLCME(1).BGLJFMHCFJF() && !RentRoomUI.FBKOKJCKICN(0).HDEPMJIDJEM())
		{
			return !RoomReceptionDesk.instance.MNCNOGPLHLO();
		}
		return false;
	}

	private void KDONAPICDKI()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
		}
		else
		{
			FNJODLOADKA();
		}
	}

	private void PKFEKIBAAIG()
	{
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
		}
		else
		{
			BFGEFKOODNA();
		}
	}

	private void KGLFHLHBFBH()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)6;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = true;
	}

	private bool NBDBELJPIEN()
	{
		if (!negotiating && inTable && !RentRoomUI.NHOFBAMNELD(1).BGLJFMHCFJF() && !RentRoomUI.NHOFBAMNELD(0).HDEPMJIDJEM())
		{
			return !RoomReceptionDesk.instance.MNCNOGPLHLO();
		}
		return false;
	}

	[CompilerGenerated]
	private void GKHLGFDCNJP()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.GetHouseKeeperPositionTransform().position;
		PDOBHPLPKHG();
	}

	private void NKAMNKDKLHI()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Left;
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Up);
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private void KIJENJNBNEC()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.NMCMGEAMLGH().position;
		LODNIOGLMDC();
	}

	private void BKNBKDKIDNJ()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Right);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(1);
		inTable = true;
	}

	private void FENDGDNHEAG()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.JMEPJMJMAGL().position;
		KGLFHLHBFBH();
	}

	private void JEPBPABEDGE()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.FEDJFNCCPDD().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Up);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private bool JEIBKEJLPEB()
	{
		if (!negotiating && inTable && !RentRoomUI.FBKOKJCKICN(0).HDEPMJIDJEM() && !RentRoomUI.OFEFGPCGJDF(8).IsOpen())
		{
			return RoomReceptionDesk.instance.HLPDKNGONBI();
		}
		return false;
	}

	private void IDBCMIMFHJC()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)6;
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Up);
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private void KABGAOBCONI()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.HFMICHAOJFK().position;
		IKOIKCHBBNG();
	}

	private void NKAPOHJBJIM()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.NMCMGEAMLGH().position;
		OMPINFKNJAF();
	}

	private void DAONLAKGIEP()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
		}
		else
		{
			CAEDALACKDD();
		}
	}

	private void FNKIODOAHPN()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.AJCPFEMEHNF().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM((Direction)7);
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private void DCLMGAKHJDP()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.EJEECOMAMBP().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)6;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private void IJKIFECCGEP()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.AJCPFEMEHNF().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)6;
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(1);
		inTable = true;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		negotiating = false;
		inTable = false;
		houseKeeper.avoidingWorkEmote.SetBool(StaffBaseState.p_Avoid, false);
		houseKeeper.houseKeeperState = HouseKeeperState.Waiting;
		if (RoomReceptionDesk.IsValid())
		{
			houseKeeper.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(RoomReceptionDesk.GetHouseKeeperPositionTransform().position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
			walkTo.OnFailStart = (Action)Delegate.Combine(walkTo.OnFailStart, (Action)delegate
			{
				//IL_0023: Unknown result type (might be due to invalid IL or missing references)
				if (!RoomReceptionDesk.IsValid())
				{
					houseKeeper.Leave();
				}
				else
				{
					((Component)houseKeeper).transform.position = RoomReceptionDesk.GetHouseKeeperPositionTransform().position;
					PDOBHPLPKHG();
				}
			});
			NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
			walkTo2.OnActionComplete = (Action)Delegate.Combine(walkTo2.OnActionComplete, (Action)delegate
			{
				if (!RoomReceptionDesk.IsValid())
				{
					houseKeeper.Leave();
				}
				else
				{
					PDOBHPLPKHG();
				}
			});
			houseKeeper.OEONGPFALKH.PEHELKCIECB();
		}
		else
		{
			houseKeeper.Leave();
		}
	}

	private void IEFKNIBKCDJ()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.HFMICHAOJFK().position;
		CNIEDLKPGBK();
	}

	private bool MMJLHDDDDAO()
	{
		if (!negotiating && inTable && !RentRoomUI.OFEFGPCGJDF(0).BGLJFMHCFJF() && !RentRoomUI.Get(1).IsOpen())
		{
			return !RoomReceptionDesk.instance.MNCNOGPLHLO();
		}
		return true;
	}

	private bool NDLECJMNOPA()
	{
		if (!negotiating && inTable && !RentRoomUI.OFEFGPCGJDF(0).HDEPMJIDJEM() && !RentRoomUI.PPJMPMKLCME(6).IsOpen())
		{
			return !RoomReceptionDesk.instance.MNCNOGPLHLO();
		}
		return false;
	}

	private bool EMALAJIFCCI()
	{
		if (!negotiating && inTable && !RentRoomUI.Get(0).BGLJFMHCFJF() && !RentRoomUI.HJHCKIAKCKD(1).BGLJFMHCFJF())
		{
			return RoomReceptionDesk.instance.MPFPHMDGIHB();
		}
		return true;
	}

	private void MAFGCNJBPGN()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.JMEPJMJMAGL().position;
		CAEDALACKDD();
	}

	private bool GPDOGHIFNLI()
	{
		if (!negotiating && inTable && !RentRoomUI.LPJPJMPOHPG(0).IsOpen() && !RentRoomUI.NHOFBAMNELD(4).IsOpen())
		{
			return RoomReceptionDesk.instance.DEJPMDCBJAN();
		}
		return false;
	}

	private void JMPBBOJMBHG()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.NMCMGEAMLGH().position;
		IKOIKCHBBNG();
	}

	private bool LFHKCGPMOAI()
	{
		if (!negotiating && inTable && !RentRoomUI.JDODHPEDACJ(1).IsOpen() && !RentRoomUI.OFEFGPCGJDF(2).HDEPMJIDJEM())
		{
			return RoomReceptionDesk.instance.ANAFBLDDDGD;
		}
		return true;
	}

	private void NCLHKDAJEIE()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.JMEPJMJMAGL().position;
		KGLFHLHBFBH();
	}

	private bool BMNGCCGICOE()
	{
		if (!negotiating && inTable && !RentRoomUI.Get(1).IsOpen() && !RentRoomUI.Get(2).IsOpen())
		{
			return !RoomReceptionDesk.instance.ANAFBLDDDGD;
		}
		return false;
	}

	private bool MFICFMMJNKC()
	{
		if (!negotiating && inTable && !RentRoomUI.PPJMPMKLCME(1).HDEPMJIDJEM() && !RentRoomUI.NHOFBAMNELD(4).BGLJFMHCFJF())
		{
			return RoomReceptionDesk.instance.HLPDKNGONBI();
		}
		return false;
	}

	private bool NBKBBJENFEP()
	{
		if (!negotiating && inTable && !RentRoomUI.Get(1).BGLJFMHCFJF() && !RentRoomUI.OMLGNAJPLDE(0).IsOpen())
		{
			return RoomReceptionDesk.instance.HLPDKNGONBI();
		}
		return true;
	}

	private void PAGENCOEFGP()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
		}
		else
		{
			EDDFAALFNGB();
		}
	}

	private bool JCGNDCBAKFP()
	{
		if (!negotiating && inTable && !RentRoomUI.OMLGNAJPLDE(0).IsOpen() && !RentRoomUI.FBKOKJCKICN(1).IsOpen())
		{
			return RoomReceptionDesk.instance.HLPDKNGONBI();
		}
		return true;
	}

	private bool HDCFDNMCLDK()
	{
		if (!negotiating && inTable && !RentRoomUI.FBKOKJCKICN(1).IsOpen() && !RentRoomUI.OMLGNAJPLDE(5).BGLJFMHCFJF())
		{
			return !RoomReceptionDesk.instance.ANAFBLDDDGD;
		}
		return true;
	}

	private bool CIEEALPENGP()
	{
		if (!negotiating && inTable && !RentRoomUI.PPJMPMKLCME(1).IsOpen() && !RentRoomUI.HJHCKIAKCKD(7).HDEPMJIDJEM())
		{
			return !RoomReceptionDesk.instance.ANAFBLDDDGD;
		}
		return true;
	}

	private void LODNIOGLMDC()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Right);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Up;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(1);
		inTable = true;
	}

	private void LEDKBJOFJCM()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Up);
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Up);
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(1);
		inTable = true;
	}

	private bool EGIOELKGOJB()
	{
		if (!negotiating && inTable && !RentRoomUI.FBKOKJCKICN(1).IsOpen() && !RentRoomUI.OMLGNAJPLDE(1).HDEPMJIDJEM())
		{
			return RoomReceptionDesk.instance.HLPDKNGONBI();
		}
		return false;
	}

	private void DJNOFCBINHM()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.FEDJFNCCPDD().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Left);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private void JAGNDICPMMG()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.FEDJFNCCPDD().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void BCDDGNEGDNL()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)5;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(1);
		inTable = true;
	}

	private void DLFBDNPEKAE()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM((Direction)7);
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void KBEGILHFAIM()
	{
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
		}
		else
		{
			DLFBDNPEKAE();
		}
	}

	private void OKKLAFPMIMP()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
		}
		else
		{
			JEPBPABEDGE();
		}
	}

	private void IDJJFLMCMPN()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.JMEPJMJMAGL().position;
		KGLFHLHBFBH();
	}

	private void AAKEBAMGCHM()
	{
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
		}
		else
		{
			IDBCMIMFHJC();
		}
	}

	private void AKHABINFHOG()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			houseKeeper.Leave();
		}
		else
		{
			EGIHDANFNHG();
		}
	}

	private void ALDAHNKKOGE()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.EJEECOMAMBP().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Right;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Up;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = true;
	}

	private void OMPINFKNJAF()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.FEDJFNCCPDD().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Left);
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Up);
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(1);
		inTable = true;
	}

	private bool DEGEEMGDJJK()
	{
		if (!negotiating && inTable && !RentRoomUI.OFEFGPCGJDF(0).IsOpen() && !RentRoomUI.OFEFGPCGJDF(4).BGLJFMHCFJF())
		{
			return RoomReceptionDesk.instance.MNCNOGPLHLO();
		}
		return false;
	}

	private void PHADOOBDKKO()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
		}
		else
		{
			LPMIHGICGNK();
		}
	}

	private bool JMKEAEIHDFD()
	{
		if (!negotiating && inTable && !RentRoomUI.JDODHPEDACJ(0).IsOpen() && !RentRoomUI.HJHCKIAKCKD(1).HDEPMJIDJEM())
		{
			return !RoomReceptionDesk.instance.ANAFBLDDDGD;
		}
		return true;
	}

	private void LPMIHGICGNK()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.AJCPFEMEHNF().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Up);
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void OJBFAMKFAKB()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.NMCMGEAMLGH().position;
		KGLFHLHBFBH();
	}

	private void EIAMODMOLIL()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.EJEECOMAMBP().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)8;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void PDOBHPLPKHG()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Left;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(1);
		inTable = true;
	}

	private void DHFOEHFPLNB()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KAIKMCMMHLL().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)8;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(1);
		inTable = true;
	}

	private bool EMOIBDJIALA()
	{
		if (!negotiating && inTable && !RentRoomUI.LPJPJMPOHPG(0).BGLJFMHCFJF() && !RentRoomUI.OMLGNAJPLDE(7).HDEPMJIDJEM())
		{
			return !RoomReceptionDesk.instance.HLPDKNGONBI();
		}
		return true;
	}

	private bool KMIHKCGNHAC()
	{
		if (!negotiating && inTable && !RentRoomUI.NHOFBAMNELD(0).BGLJFMHCFJF() && !RentRoomUI.FBKOKJCKICN(4).BGLJFMHCFJF())
		{
			return RoomReceptionDesk.instance.ANAFBLDDDGD;
		}
		return false;
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		negotiating = false;
		inTable = false;
	}

	private bool EFJPCOKPJBH()
	{
		if (!negotiating && inTable && !RentRoomUI.LPJPJMPOHPG(0).IsOpen() && !RentRoomUI.HJHCKIAKCKD(4).IsOpen())
		{
			return !RoomReceptionDesk.instance.ANAFBLDDDGD;
		}
		return true;
	}

	private bool EKHAIDDBNMJ()
	{
		if (!negotiating && inTable && !RentRoomUI.OFEFGPCGJDF(0).HDEPMJIDJEM() && !RentRoomUI.OFEFGPCGJDF(5).HDEPMJIDJEM())
		{
			return RoomReceptionDesk.instance.MPFPHMDGIHB();
		}
		return true;
	}

	private void HANHKLHCHEI()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			houseKeeper.Leave();
		}
		else
		{
			LEDKBJOFJCM();
		}
	}

	private void GEAKPMEBBAI()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.AJCPFEMEHNF().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Down);
		}
		else
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM(Direction.Up);
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private bool PBAKCLBCBKP()
	{
		if (!negotiating && inTable && !RentRoomUI.PPJMPMKLCME(1).IsOpen() && !RentRoomUI.Get(7).IsOpen())
		{
			return !RoomReceptionDesk.instance.MPFPHMDGIHB();
		}
		return false;
	}

	private void DNIEAEGIOOA()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.JMEPJMJMAGL().position;
		BBHODALHMAD();
	}

	private void CAEDALACKDD()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM((Direction)8);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Up;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private void PCFNCMPNBDI()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.FEDJFNCCPDD().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)7;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(1);
		inTable = true;
	}

	private void GJMNAFHCPNE()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.JMEPJMJMAGL().position;
		JEPBPABEDGE();
	}

	private bool PDFPHJHHMLG()
	{
		if (!negotiating && inTable && !RentRoomUI.NHOFBAMNELD(0).BGLJFMHCFJF() && !RentRoomUI.OFEFGPCGJDF(8).IsOpen())
		{
			return !RoomReceptionDesk.instance.DEJPMDCBJAN();
		}
		return false;
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		houseKeeper.OEONGPFALKH.IIMEFNIECLI();
	}

	private bool EGHCNNNOBBL()
	{
		if (!negotiating && inTable && !RentRoomUI.NHOFBAMNELD(1).HDEPMJIDJEM() && !RentRoomUI.LPJPJMPOHPG(1).HDEPMJIDJEM())
		{
			return !RoomReceptionDesk.instance.HLPDKNGONBI();
		}
		return false;
	}

	private bool FGAMNIGKOAK()
	{
		if (!negotiating && inTable && !RentRoomUI.OMLGNAJPLDE(0).IsOpen() && !RentRoomUI.OMLGNAJPLDE(7).IsOpen())
		{
			return !RoomReceptionDesk.instance.DEJPMDCBJAN();
		}
		return false;
	}

	private bool BCHLOFHGMDI()
	{
		if (!negotiating && inTable && !RentRoomUI.JDODHPEDACJ(0).IsOpen() && !RentRoomUI.JDODHPEDACJ(5).IsOpen())
		{
			return !RoomReceptionDesk.instance.DEJPMDCBJAN();
		}
		return false;
	}

	private void HHENNGDABJI()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.JMEPJMJMAGL().position;
		NKAMNKDKLHI();
	}

	[CompilerGenerated]
	private void JABEJIPHMGI()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
		}
		else
		{
			PDOBHPLPKHG();
		}
	}

	private bool KGMMMMAGLGG()
	{
		if (!negotiating && inTable && !RentRoomUI.LPJPJMPOHPG(1).IsOpen() && !RentRoomUI.JDODHPEDACJ(2).HDEPMJIDJEM())
		{
			return !RoomReceptionDesk.instance.ANAFBLDDDGD;
		}
		return true;
	}

	private void PNPFANMIPEJ()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.NMCMGEAMLGH().position;
		FNJODLOADKA();
	}

	private bool MFIHGFBPNOD()
	{
		if (!negotiating && inTable && !RentRoomUI.NHOFBAMNELD(0).IsOpen() && !RentRoomUI.JDODHPEDACJ(7).IsOpen())
		{
			return RoomReceptionDesk.instance.DEJPMDCBJAN();
		}
		return false;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (!RoomReceptionDesk.IsValid())
		{
			houseKeeper.Leave();
			return;
		}
		anyRequest = RoomReceptionDesk.IsThereAnyRequest() && houseKeeper.JFCLIAFAOEK != null && houseKeeper.JFCLIAFAOEK.tasks[0];
		if (anyRequest && BMNGCCGICOE())
		{
			currentTimeNegotiating = Time.time + houseKeeper.timerNegotiating;
			negotiating = true;
			RoomReceptionDesk.instance.SetNegotiateRoom(AODONKKHPBP: true);
		}
		if (!anyRequest && houseKeeper.StartTask())
		{
			return;
		}
		if (negotiating && !RoomReceptionDesk.IsThereAnyRequest())
		{
			negotiating = false;
			RoomReceptionDesk.instance.SetNegotiateRoom(AODONKKHPBP: false);
		}
		else
		{
			if (houseKeeper.JFCLIAFAOEK == null || !houseKeeper.JFCLIAFAOEK.tasks[0] || !negotiating || !inTable || !(Time.time > currentTimeNegotiating))
			{
				return;
			}
			customer = RoomReceptionDesk.GetCurrentCustomer();
			roomsAvailable = RentedRoomsManager.GetAllRentableRooms();
			if ((Object)(object)customer != (Object)null)
			{
				if (roomsAvailable.Count > 0)
				{
					rentedRoom = null;
					for (int i = 0; i < roomsAvailable.Count; i++)
					{
						if (customer.roomRequest != null && customer.roomRequest.NAELCFCDHOD(roomsAvailable[i]))
						{
							rentedRoom = roomsAvailable[i];
							break;
						}
					}
					if ((Object)(object)rentedRoom == (Object)null)
					{
						rentedRoom = roomsAvailable[Random.Range(0, roomsAvailable.Count)];
					}
					customer.GiveRoom(rentedRoom, default(Price), houseKeeper);
				}
				else
				{
					customer.DeclineRoom();
				}
				RoomReceptionDesk.DereserveSpot();
			}
			negotiating = false;
		}
	}

	private void BBHODALHMAD()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = (Direction)8;
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.GGFJGHHHEJC.OnHouseKeeperGoingToWork(0);
		inTable = false;
	}

	private void GOEBHJHDOBI()
	{
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.FEDJFNCCPDD().direction))
		{
			houseKeeper.npc.animationBase.NCAJNNHBHJM((Direction)8);
		}
		else
		{
			houseKeeper.npc.animationBase.FCGBJEIIMBC = Direction.Down;
		}
		CommonReferences.MNFMOEKMJKN().OnHouseKeeperGoingToWork(1);
		inTable = false;
	}

	private void BDEMJGEJDPN()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.NMCMGEAMLGH().position;
		DLFBDNPEKAE();
	}

	private void MLGJELCOOEE()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			houseKeeper.Leave();
			return;
		}
		((Component)houseKeeper).transform.position = RoomReceptionDesk.HFMICHAOJFK().position;
		CAEDALACKDD();
	}

	private void CLGGMODLIAJ()
	{
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			houseKeeper.Leave();
		}
		else
		{
			CNIEDLKPGBK();
		}
	}
}
