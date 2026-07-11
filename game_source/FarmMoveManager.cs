using System;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class FarmMoveManager : MonoBehaviour
{
	public static FarmMoveManager instance;

	public GameObject[] routines;

	public GameObject[] animals;

	public GameObject movingObjects;

	public Animator buzzAnimator;

	public Collider2D travellZoneTrigger;

	public bool moveActive;

	private void Awake()
	{
		instance = this;
	}

	private void MPGKIJEDDLA()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PJBJEJCBJKH));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(GHHMKBNFIDN));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 5)
		{
			moveActive = true;
			for (int i = 0; i < animals.Length; i++)
			{
				animals[i].SetActive(false);
			}
			for (int j = 1; j < routines.Length; j++)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(false);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 0; k < routines.Length; k += 0)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l += 0)
		{
			animals[l].SetActive(false);
		}
		Result variable = DialogueLua.GetVariable("on player sleep");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("HotBath/Main 2", (object)0);
		}
	}

	private void JGIIGHAAIHF()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(HLLCOCEAGHK));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(EFJNFFELBCL));
		}
		if (WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 3)
		{
			moveActive = false;
			for (int i = 0; i < animals.Length; i += 0)
			{
				animals[i].SetActive(true);
			}
			for (int j = 1; j < routines.Length; j++)
			{
				routines[j].SetActive(false);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 1; k < routines.Length; k += 0)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 1; l < animals.Length; l++)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("ReceiveUpdateMoodState");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("<sprite name=reputationIcon>", (object)0);
		}
	}

	private void CCPLBIFJOBB()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(IDODLLIMEMO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(JCIKKNPMGNB));
		}
		if (WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 1)
		{
			moveActive = false;
			for (int i = 1; i < animals.Length; i++)
			{
				animals[i].SetActive(false);
			}
			for (int j = 1; j < routines.Length; j += 0)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 1; k < routines.Length; k++)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l += 0)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("Beta ");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Friend list count ", (object)0);
		}
	}

	private void OAJABONPJFP()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JCIKKNPMGNB));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(GHHMKBNFIDN));
		}
		if (WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 1)
		{
			moveActive = false;
			for (int i = 1; i < animals.Length; i++)
			{
				animals[i].SetActive(true);
			}
			for (int j = 0; j < routines.Length; j++)
			{
				routines[j].SetActive(false);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(false);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 1; k < routines.Length; k++)
			{
				routines[k].SetActive(true);
			}
		}
		for (int l = 1; l < animals.Length; l++)
		{
			animals[l].SetActive(false);
		}
		Result variable = DialogueLua.GetVariable("Quit to desktop?");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("ReceivePlayerConnected", (object)1);
		}
	}

	private void BCPOPKBPMBI()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 1) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j += 0)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("NEW IMPORTANT CUSTOMER EVENT");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("JOYSTICKS\n", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NMHBCMEPIHE));
	}

	private void EFJNFFELBCL()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OEEOBIOKNBJ));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(EFJNFFELBCL));
		}
		if (WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 4)
		{
			moveActive = false;
			for (int i = 0; i < animals.Length; i++)
			{
				animals[i].SetActive(true);
			}
			for (int j = 1; j < routines.Length; j += 0)
			{
				routines[j].SetActive(false);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = true;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 0; k < routines.Length; k += 0)
			{
				routines[k].SetActive(true);
			}
		}
		for (int l = 0; l < animals.Length; l += 0)
		{
			animals[l].SetActive(false);
		}
		Result variable = DialogueLua.GetVariable("Prices");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("itemSageSeeds", (object)1);
		}
	}

	private void EEKOJEKPIMP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DFPDNPABDBG));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FFFJENNJMFG));
		}
		if (WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 8)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KPFCJAAFFEI));
		}
	}

	private void BOIGOJGNNAK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JCIKKNPMGNB));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(IDODLLIMEMO));
		}
		if (WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 1)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(CJGHOOEKBAH));
		}
	}

	private void HHLBFDBHDMC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MGGAINIEBLD));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(LHKDMPIJOCL));
		}
		if (WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 4)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KPFJMCAJLEP));
		}
	}

	private void BNFGHAGJEGG()
	{
		instance = this;
	}

	private void OCBADIFBBDM()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 8) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < routines.Length; i += 0)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("Failed to get friend ");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Items/item_name_1131", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KPFCJAAFFEI));
	}

	private void LFKANGBJLGO()
	{
		instance = this;
	}

	private void HBMDEHPHAPF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HBLKLIMCHJF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(HBLKLIMCHJF));
		}
		if (WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 1)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(BHCJNHCGMCN));
		}
	}

	private void IDODLLIMEMO()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BDMEBEOBEHC));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FFFJENNJMFG));
		}
		if (WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 0)
		{
			moveActive = true;
			for (int i = 1; i < animals.Length; i += 0)
			{
				animals[i].SetActive(true);
			}
			for (int j = 0; j < routines.Length; j++)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 0; k < routines.Length; k++)
			{
				routines[k].SetActive(true);
			}
		}
		for (int l = 0; l < animals.Length; l += 0)
		{
			animals[l].SetActive(false);
		}
		Result variable = DialogueLua.GetVariable("Start water quality test");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("", (object)1);
		}
	}

	private void PNJJEDEFAGO()
	{
		instance = this;
	}

	private void BMKGHOJDDNB()
	{
		instance = this;
	}

	private void PDIECJCKCOD()
	{
		instance = this;
	}

	private void DFPDNPABDBG()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OAJABONPJFP));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(DFPDNPABDBG));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 2)
		{
			moveActive = false;
			for (int i = 1; i < animals.Length; i++)
			{
				animals[i].SetActive(false);
			}
			for (int j = 0; j < routines.Length; j += 0)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(false);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 0; k < routines.Length; k += 0)
			{
				routines[k].SetActive(true);
			}
		}
		for (int l = 1; l < animals.Length; l++)
		{
			animals[l].SetActive(false);
		}
		Result variable = DialogueLua.GetVariable("Crop needs a harvested replace by item ");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Tutorial/T101/BarkMaiContainerBlock", (object)1);
		}
	}

	private void LGKKIBFEELP()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 5) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("NoEresDigno/KyrohTalks");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Load Player 2 appearance", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(BHCJNHCGMCN));
	}

	private void KDHLJKMKFMG()
	{
		instance = this;
	}

	private void FBHHPNJGNJG()
	{
		instance = this;
	}

	private void NODKJHJFMCO()
	{
		instance = this;
	}

	private void EHKCHLPLEMI()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 1) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < routines.Length; i++)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j += 0)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("IntensityControls");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("talentWheat", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JHLEIHABONO));
	}

	private void IPFECOIDGAE()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DJBKHJFHAHL));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FLHPLJMOOBJ));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 4)
		{
			moveActive = true;
			for (int i = 1; i < animals.Length; i++)
			{
				animals[i].SetActive(true);
			}
			for (int j = 0; j < routines.Length; j += 0)
			{
				routines[j].SetActive(false);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(false);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 0; k < routines.Length; k++)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l++)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("ActionBar7");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("OnlinePlayer", (object)1);
		}
	}

	private void GHHMKBNFIDN()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PJBJEJCBJKH));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(CCBDFPOONHE));
		}
		if (WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 6)
		{
			moveActive = true;
			for (int i = 1; i < animals.Length; i++)
			{
				animals[i].SetActive(false);
			}
			for (int j = 1; j < routines.Length; j++)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(false);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 1; k < routines.Length; k++)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 1; l < animals.Length; l += 0)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("RecieveMothersRecipeEventCof");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Player Awake error on ", (object)1);
		}
	}

	private void KANEHEJILNM()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 3) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < routines.Length; i++)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j += 0)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("Item ");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Dialogue System/Conversation/Crowly_Introduce/Entry/29/Dialogue Text", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void GLCMBKIENGN()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 6) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < routines.Length; i++)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j++)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("HotBath/Brock Talk");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Disabled", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DCHDJABABLE));
	}

	private void KFFGCNEPHNK()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 1) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < routines.Length; i++)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j++)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("Player2");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("PlayerCharacterNameChangeRPC", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JCJCLPKJMMH));
	}

	private void JCIKKNPMGNB()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JCIKKNPMGNB));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FFFJENNJMFG));
		}
		if (WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 0)
		{
			moveActive = true;
			for (int i = 1; i < animals.Length; i += 0)
			{
				animals[i].SetActive(false);
			}
			for (int j = 1; j < routines.Length; j++)
			{
				routines[j].SetActive(false);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 1; k < routines.Length; k += 0)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l++)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("Cat");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Farm/Bob/Barks_Close", (object)0);
		}
	}

	private void DMFMNEMDFNP()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DJBKHJFHAHL));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(LHKDMPIJOCL));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 7)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(NMHBCMEPIHE));
		}
	}

	private void KPFCJAAFFEI()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 4) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j += 0)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("fish_description_");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("TavernFilthy", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(OMONLJAAKPP));
	}

	private void FHOCCEBKHJI()
	{
		instance = this;
	}

	private void PGJJBPALEGM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KLPCPEKNOBF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MCMMJICCFJE));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 4)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(LKPMOFDDDKO));
		}
	}

	private void ABDFDBCHOJI()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 7) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j++)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("Favorites");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Building", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KDIMLPAKAEJ));
	}

	private void FCNKGINGJNM()
	{
		instance = this;
	}

	private void HOFKJPBBLGP()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HLLCOCEAGHK));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(EFJNFFELBCL));
		}
		if (WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 6)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KANEHEJILNM));
		}
	}

	private void KNABGIGNPAM()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(JGIIGHAAIHF));
		}
		if (WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 1)
		{
			moveActive = false;
			for (int i = 0; i < animals.Length; i += 0)
			{
				animals[i].SetActive(true);
			}
			for (int j = 0; j < routines.Length; j++)
			{
				routines[j].SetActive(false);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = true;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 0; k < routines.Length; k += 0)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l++)
		{
			animals[l].SetActive(false);
		}
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_Standar/Entry/38/Dialogue Text");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Disabled", (object)0);
		}
	}

	private void AJGLDLLIIFO()
	{
		instance = this;
	}

	private void BONHDKBLOMP()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 8) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j += 0)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("depth{0}");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Fishing", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(CJGHOOEKBAH));
	}

	private void DCLFBNPJDGC()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 1) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j += 0)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("Hay {0} destructibles y {1} agujeros para cavar disponibles para el puzzle {2}");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Dialogue System/Conversation/Crowly_Standar/Entry/10/Dialogue Text", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(POEAHKDOOFH));
	}

	private void LHKDMPIJOCL()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LHKDMPIJOCL));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(OAJABONPJFP));
		}
		if (WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 1)
		{
			moveActive = false;
			for (int i = 1; i < animals.Length; i++)
			{
				animals[i].SetActive(true);
			}
			for (int j = 0; j < routines.Length; j += 0)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 1; k < routines.Length; k += 0)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l += 0)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("You have to assign a UI camera!");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Dialogue System/Conversation/TavernDirty/Entry/5/Dialogue Text", (object)0);
		}
	}

	private void BHCJNHCGMCN()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 4) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j += 0)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("LE_21");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Player/Bark/Fishing/NoBait", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(BCPOPKBPMBI));
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	private void IBMDFNKKPJF()
	{
		instance = this;
	}

	private void JHLEIHABONO()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 7) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < routines.Length; i++)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j += 0)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("ReciveActiveorDisableColliderHikari");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable(" for reason ", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void KLPCPEKNOBF()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DJBKHJFHAHL));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(CCPLBIFJOBB));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 3)
		{
			moveActive = false;
			for (int i = 1; i < animals.Length; i += 0)
			{
				animals[i].SetActive(true);
			}
			for (int j = 0; j < routines.Length; j += 0)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(false);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 1; k < routines.Length; k += 0)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l += 0)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable(")");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("ErrorCreateAlreadyExists", (object)1);
		}
	}

	private void EIMIDCDEIDD()
	{
		instance = this;
	}

	private void OMONLJAAKPP()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 3) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j++)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("<align=left>");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(CHPDBFANJEI));
	}

	private void HLLCOCEAGHK()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(OAJABONPJFP));
		}
		if (WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 4)
		{
			moveActive = false;
			for (int i = 0; i < animals.Length; i += 0)
			{
				animals[i].SetActive(true);
			}
			for (int j = 0; j < routines.Length; j += 0)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = true;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 1; k < routines.Length; k++)
			{
				routines[k].SetActive(true);
			}
		}
		for (int l = 1; l < animals.Length; l += 0)
		{
			animals[l].SetActive(false);
		}
		Result variable = DialogueLua.GetVariable("Basket");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("[", (object)1);
		}
	}

	private void LHKEIAHELOL()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 7) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < routines.Length; i += 0)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("ReceiveDisableContent");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable(" stats and achievements retrieved", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(CJGHOOEKBAH));
	}

	private void OKAPGNGLOHO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CCPLBIFJOBB));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(LHKDMPIJOCL));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 1)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GAGMDCHBNLA));
		}
	}

	private void MBONNCDBIPM()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JCIKKNPMGNB));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(IDODLLIMEMO));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 3)
		{
			moveActive = true;
			for (int i = 1; i < animals.Length; i++)
			{
				animals[i].SetActive(false);
			}
			for (int j = 0; j < routines.Length; j++)
			{
				routines[j].SetActive(false);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 0; k < routines.Length; k += 0)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 1; l < animals.Length; l++)
		{
			animals[l].SetActive(false);
		}
		Result variable = DialogueLua.GetVariable(" (");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Serve", (object)0);
		}
	}

	private void MBAGGLHJJLP()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 1) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < routines.Length; i += 0)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 1; j < animals.Length; j += 0)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("christmasActivated");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("UIHorizontal", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DAONPPAIOMA));
	}

	private void JBFFNMCKOEM()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 1) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < routines.Length; i += 0)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("Use");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("DecorationTile_19", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(BONHDKBLOMP));
	}

	private void GJMLHECPGBP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(CCPLBIFJOBB));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 0)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OMONLJAAKPP));
		}
	}

	private void LDPGPIHCBCH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MCMMJICCFJE));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BDMEBEOBEHC));
		}
		if (WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 1)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GLCMBKIENGN));
		}
	}

	private void EFJFJJDGGGI()
	{
		instance = this;
	}

	private void MGGAINIEBLD()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OAJABONPJFP));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FFFJENNJMFG));
		}
		if (WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 4)
		{
			moveActive = false;
			for (int i = 1; i < animals.Length; i += 0)
			{
				animals[i].SetActive(false);
			}
			for (int j = 0; j < routines.Length; j += 0)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 0; k < routines.Length; k++)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l += 0)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("Player");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Items/item_name_1070", (object)0);
		}
	}

	private void BGPGIOMKKAO()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 2)
		{
			moveActive = true;
			for (int i = 0; i < animals.Length; i++)
			{
				animals[i].SetActive(false);
			}
			for (int j = 0; j < routines.Length; j++)
			{
				routines[j].SetActive(false);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 0; k < routines.Length; k++)
			{
				routines[k].SetActive(true);
			}
		}
		for (int l = 0; l < animals.Length; l++)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("FarmReady");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("FarmReady", (object)1);
		}
	}

	private void EBNKNEIDDDI()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MPGKIJEDDLA));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(GHHMKBNFIDN));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 4)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GAGMDCHBNLA));
		}
	}

	private void DCKKIDMJKJM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DJBKHJFHAHL));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(DJBKHJFHAHL));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 0)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DCLFBNPJDGC));
		}
	}

	private void KPFJMCAJLEP()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 4) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < routines.Length; i++)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("Disappear");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Right Shift", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NKKNBDMHMAI));
	}

	private void GEAMLMJCCLM()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 0) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j += 0)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("Shirt");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("playerChangedMinigame", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KCGHNMFHMKE));
	}

	private void OIDCKGOCGKB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GHHMKBNFIDN));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(OEEOBIOKNBJ));
		}
		if (WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 5)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GLCMBKIENGN));
		}
	}

	private void BDGCFCPFKKE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MPGKIJEDDLA));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 4)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GAGMDCHBNLA));
		}
	}

	private void POEAHKDOOFH()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 1) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < routines.Length; i++)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("Unique id ");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Dialogue System/Conversation/Gass_Introduce/Entry/17/Dialogue Text", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KDIMLPAKAEJ));
	}

	private void GNAJBACLEKG()
	{
		instance = this;
	}

	private void IDPHKHGHJGN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KNABGIGNPAM));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(KLPCPEKNOBF));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 3)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(FBPEDOHEOMP));
		}
	}

	private void HPIMHEMJMAA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BDMEBEOBEHC));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MBONNCDBIPM));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 4)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OMONLJAAKPP));
		}
	}

	private void DAONPPAIOMA()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 3) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < routines.Length; i++)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j += 0)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("BuzzBuildExit");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("ReceiveCastleFormStartKlaynDialogue", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DAONPPAIOMA));
	}

	private void EGPONANBCNP()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HLLCOCEAGHK));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MCMMJICCFJE));
		}
		if (WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 6)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(NMHBCMEPIHE));
		}
	}

	private void CHPDBFANJEI()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 0) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("-1");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Mod 1", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ACHEHDIKMBI));
	}

	private void CLGBFOIBANN()
	{
		instance = this;
	}

	private void OEMIMEIDMFE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HBLKLIMCHJF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(PJBJEJCBJKH));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 6)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(LHKEIAHELOL));
		}
	}

	private void EFCNKPEPELL()
	{
		instance = this;
	}

	private void EOGHJNGJFID()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(EFJNFFELBCL));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(CCBDFPOONHE));
		}
		if (WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 4)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KANEHEJILNM));
		}
	}

	private void HCEDMLJNOBL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IDODLLIMEMO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(KLPCPEKNOBF));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 3)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OMONLJAAKPP));
		}
	}

	private void OEEOBIOKNBJ()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MPGKIJEDDLA));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(CCBDFPOONHE));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 0)
		{
			moveActive = true;
			for (int i = 0; i < animals.Length; i++)
			{
				animals[i].SetActive(false);
			}
			for (int j = 1; j < routines.Length; j++)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(false);
			((Behaviour)travellZoneTrigger).enabled = true;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 1; k < routines.Length; k += 0)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l += 0)
		{
			animals[l].SetActive(false);
		}
		Result variable = DialogueLua.GetVariable("Start water quality test");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("[ProceduralMine] ALTAR: No valid piece for path dir={0} at block {1}. Candidates: {2}. Retrying next iteration.", (object)1);
		}
	}

	private void GMCKBBECJOE()
	{
		instance = this;
	}

	private void ACHEHDIKMBI()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 8) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < routines.Length; i++)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("SendNPCParents");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Items/item_description_666", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DAONPPAIOMA));
	}

	private void NMHBCMEPIHE()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 8) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("holesDug");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("ReceiveChatMessage", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LHKEIAHELOL));
	}

	private void KDIMLPAKAEJ()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 2) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < routines.Length; i++)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 0; j < animals.Length; j += 0)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("Items/item_description_1188");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("<sprite name=reputationIcon>", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KDIMLPAKAEJ));
	}

	private void COPDNJFJKCH()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 1) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < routines.Length; i += 0)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("ageingBarrelPopUp");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("MothersRecipe/MainEvent", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ACHEHDIKMBI));
	}

	private void NKKNBDMHMAI()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 3) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j++)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("openShop");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Items/item_description_1193", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KPFCJAAFFEI));
	}

	private void FLHPLJMOOBJ()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MCMMJICCFJE));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(HLLCOCEAGHK));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 4)
		{
			moveActive = false;
			for (int i = 1; i < animals.Length; i++)
			{
				animals[i].SetActive(false);
			}
			for (int j = 1; j < routines.Length; j++)
			{
				routines[j].SetActive(false);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(false);
			((Behaviour)travellZoneTrigger).enabled = true;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 0; k < routines.Length; k++)
			{
				routines[k].SetActive(true);
			}
		}
		for (int l = 0; l < animals.Length; l += 0)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("' no referencia correctamente al item '");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Brook Recipe active", (object)0);
		}
	}

	private void BIIAFOCPFOO()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 8) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < routines.Length; i++)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 0; j < animals.Length; j += 0)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("<sprite name=\"ironNailsIcon\">");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Collect", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KPFJMCAJLEP));
	}

	private void OILHJENGGEL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KNABGIGNPAM));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(EFJNFFELBCL));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 8)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KPFCJAAFFEI));
		}
	}

	private void BDMEBEOBEHC()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MGGAINIEBLD));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(EFJNFFELBCL));
		}
		if (WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 8)
		{
			moveActive = false;
			for (int i = 1; i < animals.Length; i++)
			{
				animals[i].SetActive(false);
			}
			for (int j = 1; j < routines.Length; j += 0)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 0; k < routines.Length; k++)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 1; l < animals.Length; l += 0)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable(". Time since startup: ");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("itemGruel", (object)0);
		}
	}

	private void DJBKHJFHAHL()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CCBDFPOONHE));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FFFJENNJMFG));
		}
		if (WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 6)
		{
			moveActive = true;
			for (int i = 0; i < animals.Length; i += 0)
			{
				animals[i].SetActive(false);
			}
			for (int j = 1; j < routines.Length; j++)
			{
				routines[j].SetActive(false);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(false);
			((Behaviour)travellZoneTrigger).enabled = true;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 1; k < routines.Length; k++)
			{
				routines[k].SetActive(true);
			}
		}
		for (int l = 0; l < animals.Length; l++)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("ObjectVerticalMove");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("NewCharacters/", (object)0);
		}
	}

	private void KJBIDNLHOMD()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(EFJNFFELBCL));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MGGAINIEBLD));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 1)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(NMHBCMEPIHE));
		}
	}

	private void MCMMJICCFJE()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(HBLKLIMCHJF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FLHPLJMOOBJ));
		}
		if (WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 8)
		{
			moveActive = true;
			for (int i = 0; i < animals.Length; i += 0)
			{
				animals[i].SetActive(true);
			}
			for (int j = 1; j < routines.Length; j++)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(false);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 0; k < routines.Length; k += 0)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 1; l < animals.Length; l += 0)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("    ├─ ");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("\n<color=#822F00>", (object)0);
		}
	}

	private void ILCLIJOHKHG()
	{
		instance = this;
	}

	private void FFFJENNJMFG()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BDMEBEOBEHC));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(PJBJEJCBJKH));
		}
		if (WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 4)
		{
			moveActive = false;
			for (int i = 0; i < animals.Length; i += 0)
			{
				animals[i].SetActive(true);
			}
			for (int j = 1; j < routines.Length; j++)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 0; k < routines.Length; k++)
			{
				routines[k].SetActive(true);
			}
		}
		for (int l = 0; l < animals.Length; l += 0)
		{
			animals[l].SetActive(false);
		}
		Result variable = DialogueLua.GetVariable("ReceiveNewLetter");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("City/Carpenters/Oak/Stand", (object)0);
		}
	}

	private void FBPEDOHEOMP()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 0) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < routines.Length; i++)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 0; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("BarnTutorialDone");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("ItemContainer not attached on OnlineContainer of placeable ", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(BIIAFOCPFOO));
	}

	private void JCJCLPKJMMH()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 2) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("ReceiveBuildingTutorialDone");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Player2", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(GLCMBKIENGN));
	}

	private void DCHDJABABLE()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 4) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < routines.Length; i++)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j += 0)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("Items/item_description_645");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("</color>] ", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(MBAGGLHJJLP));
	}

	private void DNKEFFMOCKP()
	{
		instance = this;
	}

	private void GELMGKDMJFE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OEEOBIOKNBJ));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FLHPLJMOOBJ));
		}
		if (WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 0)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(FBPEDOHEOMP));
		}
	}

	private void DKNNLPFIBIK()
	{
		instance = this;
	}

	private void KCGHNMFHMKE()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 0) || !OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < routines.Length; i += 0)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("CannotToggleUI Holding ");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Player", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(GOKMHENLMLB));
	}

	private void CMLLBIDFNEB()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BDMEBEOBEHC));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(DFPDNPABDBG));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 7)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GEAMLMJCCLM));
		}
	}

	private void LKPMOFDDDKO()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 4) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < routines.Length; i++)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("Items/item_name_1071");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Shifty Customer", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NKKNBDMHMAI));
	}

	private void FELJAKBBFJD()
	{
		instance = this;
	}

	private void NMKGOAJLMDG()
	{
		instance = this;
	}

	private void GOKMHENLMLB()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 0) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < routines.Length; i++)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("[MinePuzzleManager] Initializing for level {0}");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("El componente ItemSetup del prefab '{0}' no referencia correctamente al item '{1}' (ID: {2}).", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DAONPPAIOMA));
	}

	private void FGLJPGBFPBC()
	{
		instance = this;
	}

	private void BGBFJPJLPMF()
	{
		instance = this;
	}

	private void AHGPALJKOKP()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PJBJEJCBJKH));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BDMEBEOBEHC));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 6)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(BONHDKBLOMP));
		}
	}

	private void KACEOJDPLKB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IPFECOIDGAE));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(DFPDNPABDBG));
		}
		if (WorldTime.HGIBNMBJMOC().week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 2)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DAONPPAIOMA));
		}
	}

	private void LPNBCBIBNNI()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MPGKIJEDDLA));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
		if (WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 0)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(BONHDKBLOMP));
		}
	}

	private void NAOBODGBECL()
	{
		instance = this;
	}

	private void LJLKBKEADGI()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(EFJNFFELBCL));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FLHPLJMOOBJ));
		}
		if (WorldTime.CJOHMLNMJLK().week < 0 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 0)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ACHEHDIKMBI));
		}
	}

	private void NLGHNDLPPKI()
	{
		instance = this;
	}

	private void KLGCMMIKGIO()
	{
		instance = this;
	}

	private void IOBLLDIPBCA()
	{
		instance = this;
	}

	private void GAGMDCHBNLA()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 7) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < routines.Length; i++)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 1; j < animals.Length; j++)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("Angry");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("LE_21", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LGKKIBFEELP));
	}

	private void Start()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 2)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void HBLKLIMCHJF()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OEEOBIOKNBJ));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(HBLKLIMCHJF));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 5)
		{
			moveActive = false;
			for (int i = 0; i < animals.Length; i += 0)
			{
				animals[i].SetActive(false);
			}
			for (int j = 0; j < routines.Length; j += 0)
			{
				routines[j].SetActive(false);
			}
			((Behaviour)buzzAnimator).enabled = false;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int k = 1; k < routines.Length; k++)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l++)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("buildingObjective_19_0");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Disabled", (object)1);
		}
	}

	private void NCPNBBCNBIM()
	{
		instance = this;
	}

	private void GOJKOBEEMNA()
	{
		instance = this;
	}

	private void MFJIHCKEIIF()
	{
		instance = this;
	}

	private void KJPECNGCOKK()
	{
		instance = this;
	}

	private void KMEJBPOOBJK()
	{
		instance = this;
	}

	private void ALEAOANPHIO()
	{
		instance = this;
	}

	private void CJGHOOEKBAH()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.CJOHMLNMJLK().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 4) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = true;
		movingObjects.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < routines.Length; i++)
			{
				routines[i].SetActive(false);
			}
		}
		for (int j = 0; j < animals.Length; j += 0)
		{
			animals[j].SetActive(false);
		}
		((Behaviour)travellZoneTrigger).enabled = false;
		Result variable = DialogueLua.GetVariable("Reverence");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("ReceiveSetTableParent", (object)0);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(FBPEDOHEOMP));
	}

	private void GNGADDPBJDC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OAJABONPJFP));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FLHPLJMOOBJ));
		}
		if (WorldTime.CJOHMLNMJLK().week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 6)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KCGHNMFHMKE));
		}
	}

	private void CCBDFPOONHE()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BDMEBEOBEHC));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(OEEOBIOKNBJ));
		}
		if (WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.HGIBNMBJMOC().year < 4)
		{
			moveActive = false;
			for (int i = 0; i < animals.Length; i += 0)
			{
				animals[i].SetActive(true);
			}
			for (int j = 0; j < routines.Length; j++)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(false);
			((Behaviour)travellZoneTrigger).enabled = true;
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 0; k < routines.Length; k++)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l += 0)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable(" ");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("Open", (object)0);
		}
	}

	private void CGLIGKKCKCG()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KNABGIGNPAM));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(JCIKKNPMGNB));
		}
		if (WorldTime.HGIBNMBJMOC().week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.CJOHMLNMJLK().year < 7)
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(FBPEDOHEOMP));
		}
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	private void AMNCIAEMBFO()
	{
		instance = this;
	}

	private void PJBJEJCBJKH()
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OEEOBIOKNBJ));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FLHPLJMOOBJ));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 4)
		{
			moveActive = true;
			for (int i = 1; i < animals.Length; i++)
			{
				animals[i].SetActive(true);
			}
			for (int j = 1; j < routines.Length; j += 0)
			{
				routines[j].SetActive(true);
			}
			((Behaviour)buzzAnimator).enabled = true;
			movingObjects.SetActive(true);
			((Behaviour)travellZoneTrigger).enabled = false;
			return;
		}
		moveActive = true;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			for (int k = 1; k < routines.Length; k += 0)
			{
				routines[k].SetActive(false);
			}
		}
		for (int l = 0; l < animals.Length; l++)
		{
			animals[l].SetActive(true);
		}
		Result variable = DialogueLua.GetVariable("Crop with ID ");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("<color=black>", (object)0);
		}
	}

	private void NJAFKFAPDIE()
	{
		instance = this;
	}

	private void ALGOBMNPLIB()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if ((WorldTime.NOAOJJLNHJJ.week < 1 && WorldTime.NOAOJJLNHJJ.season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 2) || !OnlineManager.MasterOrOffline())
		{
			return;
		}
		moveActive = false;
		((Behaviour)buzzAnimator).enabled = false;
		movingObjects.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < routines.Length; i++)
			{
				routines[i].SetActive(true);
			}
		}
		for (int j = 0; j < animals.Length; j++)
		{
			animals[j].SetActive(true);
		}
		((Behaviour)travellZoneTrigger).enabled = true;
		Result variable = DialogueLua.GetVariable("FarmReady");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("FarmReady", (object)1);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void EGACIHOKJLH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IPFECOIDGAE));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MPGKIJEDDLA));
		}
		if (WorldTime.NOAOJJLNHJJ.week < 0 && WorldTime.HGIBNMBJMOC().season == Season.Spring && WorldTime.NOAOJJLNHJJ.year < 5)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(POEAHKDOOFH));
		}
	}
}
