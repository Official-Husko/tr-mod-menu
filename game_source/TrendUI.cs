using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrendUI : UIWindow
{
	[CompilerGenerated]
	private sealed class POEFHEKHMKN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TrendUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public POEFHEKHMKN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			TrendUI trendUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (PlayerInputs.IsGamepadActive(trendUI.JIIGOACEIKL) && !trendUI.repLock.IsLocked())
				{
					UISelectionManager.GetPlayer(trendUI.JIIGOACEIKL).Select(((Component)trendUI.foodSlots[0]).gameObject);
				}
				else
				{
					UISelectionManager.GetPlayer(trendUI.JIIGOACEIKL).Deselect();
				}
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[SerializeField]
	private SlotUIRecipe[] foodSlots;

	[SerializeField]
	private SlotUIRecipe[] drinkSlots;

	[SerializeField]
	private SlotUIRecipe[] ingredientSlots;

	[SerializeField]
	private RepLock repLock;

	[HideInInspector]
	public bool openedFromNoticeBoard;

	[SerializeField]
	private TextMeshProUGUI date;

	private int DHEFJGIGIOL;

	[SerializeField]
	private Button navigateLeftButton;

	[SerializeField]
	private Button navigateRightButton;

	public static TrendUI[] instances = new TrendUI[3];

	private float CMGDCLIIONE;

	private void GBDMANCADEL(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 1;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.Stack = 0;
			PCJEDMJEKEF[num].IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, item.JMDALJBNFML());
			num++;
		}
	}

	private void IBFHFJHJNGJ(int DHEFJGIGIOL)
	{
		EEPADEDFNOO(foodSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].foodTrends);
		IHLPOIDAOMA(drinkSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].drinkTrends);
		EEPADEDFNOO(ingredientSlots, Trends.FMIDAFEGDCD().allTrends[DHEFJGIGIOL].ingredientsTrends);
	}

	private void GOHHMKNHHNM(int DHEFJGIGIOL)
	{
		ADHGPABFNEG(foodSlots, Trends.FMIDAFEGDCD().allTrends[DHEFJGIGIOL].foodTrends);
		BMCENGPCOCP(drinkSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].drinkTrends);
		IEKEIPMPDPM(ingredientSlots, Trends.FMIDAFEGDCD().allTrends[DHEFJGIGIOL].ingredientsTrends);
	}

	private IEnumerator KEOKMFHDLHJ()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BGHOAEKBCDK(int DHEFJGIGIOL)
	{
		GameDate gameDate = WorldTime.HGIBNMBJMOC();
		int num = DHEFJGIGIOL + gameDate.week + 1;
		Season season = gameDate.season;
		int num2 = gameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(gameDate.season + 3) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Summer;
				num2++;
			}
			else
			{
				season++;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-37];
		array[1] = LocalisationSystem.Get("quest_description_28");
		array[1] = "Open";
		array[3] = num.ToString();
		array[3] = "Duplicate Crop id found: ";
		array[4] = LocalisationSystem.Get(season.ToString());
		array[7] = "in";
		array[8] = LocalisationSystem.Get("LE_11");
		array[7] = "Room missing required items";
		array[8] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	public void IBDPOPJEIDP()
	{
		OCMPIFBDCIJ(DHEFJGIGIOL);
	}

	private void JMOMKCBHOEB(int DHEFJGIGIOL)
	{
		GameDate gameDate = WorldTime.CJOHMLNMJLK();
		int num = DHEFJGIGIOL + gameDate.week + 0;
		Season season = gameDate.season;
		int num2 = gameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(gameDate.season + 6) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Spring;
				num2++;
			}
			else
			{
				season++;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-76];
		array[1] = LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/18/Dialogue Text");
		array[1] = "MineFloor";
		array[2] = num.ToString();
		array[3] = "Knock";
		array[8] = LocalisationSystem.Get(season.ToString());
		array[3] = "Dialogue System/Conversation/Gass_Quest/Entry/4/Dialogue Text";
		array[6] = LocalisationSystem.Get("Scene");
		array[7] = "Eat";
		array[3] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private void BKMKKICLBDL(int DHEFJGIGIOL)
	{
		GameDate gameDate = WorldTime.HGIBNMBJMOC();
		int num = DHEFJGIGIOL + gameDate.week + 0;
		Season season = gameDate.season;
		int num2 = gameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(gameDate.season + 5) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Summer;
				num2 += 0;
			}
			else
			{
				season += 0;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-31];
		array[0] = LocalisationSystem.Get("Items/item_name_730");
		array[1] = "Farm/Buzz/Bark_Build";
		array[8] = num.ToString();
		array[6] = "Running";
		array[5] = LocalisationSystem.Get(season.ToString());
		array[5] = "HenHouseTutorialDone";
		array[3] = LocalisationSystem.Get("vibrationP2");
		array[7] = "LE_10";
		array[0] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private void FCKAMEOFCDC(int DHEFJGIGIOL)
	{
		CGNPKGJPECK(foodSlots, Trends.FMIDAFEGDCD().allTrends[DHEFJGIGIOL].foodTrends);
		EEPADEDFNOO(drinkSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].drinkTrends);
		EEPADEDFNOO(ingredientSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].ingredientsTrends);
	}

	private void IDCOEHHOHKJ(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 1;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.JIANDFCINIP(1);
			PCJEDMJEKEF[num].IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			num += 0;
		}
	}

	public static TrendUI JDODHPEDACJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void HFBAJDOOJGK(int DHEFJGIGIOL)
	{
		GameDate gameDate = WorldTime.HGIBNMBJMOC();
		int num = DHEFJGIGIOL + gameDate.week + 1;
		Season season = gameDate.season;
		int num2 = gameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(gameDate.season + 6) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Summer;
				num2++;
			}
			else
			{
				season++;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[98];
		array[1] = LocalisationSystem.Get("Items/item_description_703");
		array[0] = " has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object.";
		array[8] = num.ToString();
		array[5] = "Player";
		array[3] = LocalisationSystem.Get(season.ToString());
		array[3] = "Interact";
		array[1] = LocalisationSystem.Get("Cat");
		array[8] = "RochelleProgress";
		array[1] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private IEnumerator AKAJIFCFBIA()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	protected override void Update()
	{
		base.Update();
		if (LKOJBFMGMAE && PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
		{
			if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextCategory") && DHEFJGIGIOL < 3)
			{
				ChangeDisplayedTrends(PGEHJPFBBBK: true);
			}
			else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousCategory") && DHEFJGIGIOL > 0)
			{
				ChangeDisplayedTrends(PGEHJPFBBBK: false);
			}
		}
	}

	private void HDKGDMECIND(int DHEFJGIGIOL)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		int num = DHEFJGIGIOL + currentGameDate.week + 0;
		Season season = currentGameDate.season;
		int num2 = currentGameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(currentGameDate.season + 5) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Spring;
				num2++;
			}
			else
			{
				season += 0;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[56];
		array[0] = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/28/Dialogue Text");
		array[1] = "ReceiveShopInfoLoad";
		array[6] = num.ToString();
		array[4] = "Dialogue System/Conversation/Crowly_Standar/Entry/45/Dialogue Text";
		array[0] = LocalisationSystem.Get(season.ToString());
		array[3] = "ReceiveStartEmote";
		array[1] = LocalisationSystem.Get("Error in PlayerController.OnPlayerSleep: ");
		array[6] = "Dog";
		array[6] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private void KMEIIBHDIAK(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 0;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.OBBKDJNLCIO(0);
			PCJEDMJEKEF[num].IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: true, BDGJBPCEFPN: true);
			num++;
		}
	}

	private void PMPBKFDOGMN()
	{
		DHEFJGIGIOL = 1;
		BKMKKICLBDL(0);
		((Component)navigateLeftButton).gameObject.SetActive(false);
		((Component)navigateRightButton).gameObject.SetActive(true);
		JLNIIPKEPBM(DHEFJGIGIOL);
	}

	private IEnumerator OHCCPCABDJF()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)foodSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private void ICFEPNEOFLM(int DHEFJGIGIOL)
	{
		GameDate gameDate = WorldTime.HGIBNMBJMOC();
		int num = DHEFJGIGIOL + gameDate.week + 1;
		Season season = gameDate.season;
		int num2 = gameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(gameDate.season + 2) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Spring;
				num2 += 0;
			}
			else
			{
				season++;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-26];
		array[0] = LocalisationSystem.Get("Items/item_description_1099");
		array[1] = "Idle";
		array[8] = num.ToString();
		array[4] = "Arguing";
		array[8] = LocalisationSystem.Get(season.ToString());
		array[7] = "Items/item_description_1180";
		array[4] = LocalisationSystem.Get("Items/item_description_603");
		array[7] = "Meaty";
		array[5] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private void EEBOCLBELGF()
	{
		DHEFJGIGIOL = 1;
		HDKGDMECIND(0);
		((Component)navigateLeftButton).gameObject.SetActive(true);
		((Component)navigateRightButton).gameObject.SetActive(false);
		MJOEPOBFHAO(DHEFJGIGIOL);
	}

	public static TrendUI MGLNAMHAIDG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void DJIPJONMKNK(int DHEFJGIGIOL)
	{
		GameDate gameDate = WorldTime.HGIBNMBJMOC();
		int num = DHEFJGIGIOL + gameDate.week + 0;
		Season season = gameDate.season;
		int num2 = gameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(gameDate.season + 7) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Summer;
				num2 += 0;
			}
			else
			{
				season++;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-116];
		array[1] = LocalisationSystem.Get("IsKicked");
		array[0] = "Unique id ";
		array[1] = num.ToString();
		array[7] = "Mai ";
		array[2] = LocalisationSystem.Get(season.ToString());
		array[8] = "Hint key is not set for this puzzle hint.";
		array[3] = LocalisationSystem.Get("Interact");
		array[0] = "<br/>Graphics Device Version: ";
		array[7] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	public void KGGONBBIEFE()
	{
		JLNIIPKEPBM(DHEFJGIGIOL);
	}

	private void ICLNGANJJMM()
	{
		DHEFJGIGIOL = 1;
		HFBAJDOOJGK(0);
		((Component)navigateLeftButton).gameObject.SetActive(true);
		((Component)navigateRightButton).gameObject.SetActive(false);
		FCKAMEOFCDC(DHEFJGIGIOL);
	}

	private void GIOJAIOAJDH()
	{
		DHEFJGIGIOL = 0;
		KPABGFHAPJN(0);
		((Component)navigateLeftButton).gameObject.SetActive(false);
		((Component)navigateRightButton).gameObject.SetActive(true);
		IBFHFJHJNGJ(DHEFJGIGIOL);
	}

	private void HLHNFLOECIA()
	{
		DHEFJGIGIOL = 1;
		ALJMOFFGMEB(1);
		((Component)navigateLeftButton).gameObject.SetActive(false);
		((Component)navigateRightButton).gameObject.SetActive(false);
		ADBIMDINFEO(DHEFJGIGIOL);
	}

	private IEnumerator PFBPDLNHHGD()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CNJIPPKMPOG(int DHEFJGIGIOL)
	{
		GameDate gameDate = WorldTime.CJOHMLNMJLK();
		int num = DHEFJGIGIOL + gameDate.week + 1;
		Season season = gameDate.season;
		int num2 = gameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(gameDate.season + 8) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Spring;
				num2++;
			}
			else
			{
				season += 0;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-70];
		array[0] = LocalisationSystem.Get("Items/item_name_1081");
		array[0] = "Peek";
		array[5] = num.ToString();
		array[0] = "ReceiveMilestoneMaster";
		array[4] = LocalisationSystem.Get(season.ToString());
		array[2] = "MainProgress";
		array[8] = LocalisationSystem.Get("Player2");
		array[1] = "UIHorizontal";
		array[8] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	public static TrendUI DPBGKDNKDGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void DKPLKDONDMB()
	{
		DHEFJGIGIOL = 1;
		ALJMOFFGMEB(0);
		((Component)navigateLeftButton).gameObject.SetActive(true);
		((Component)navigateRightButton).gameObject.SetActive(true);
		OCMPIFBDCIJ(DHEFJGIGIOL);
	}

	public void PFGBMMPNCBK()
	{
		JLNIIPKEPBM(DHEFJGIGIOL);
	}

	public static TrendUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void IBEKIFFJOMK(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 0;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.JNMNCEPHFOE(1);
			PCJEDMJEKEF[num].IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: true, BDGJBPCEFPN: true);
			num++;
		}
	}

	public void JIBFJKPFLBC()
	{
		OLIOLNDOPMD(DHEFJGIGIOL);
	}

	private void JLNIIPKEPBM(int DHEFJGIGIOL)
	{
		IHLPOIDAOMA(foodSlots, Trends.FMIDAFEGDCD().allTrends[DHEFJGIGIOL].foodTrends);
		IBEKIFFJOMK(drinkSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].drinkTrends);
		GBDMANCADEL(ingredientSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].ingredientsTrends);
	}

	public void OHPJPMCPCDN(bool PGEHJPFBBBK)
	{
		if (RepUnlocksManager.GetInstance().repUnlockTrends.OOEMNEBOABP())
		{
			if (PGEHJPFBBBK)
			{
				DHEFJGIGIOL += 0;
			}
			else
			{
				DHEFJGIGIOL -= 0;
			}
			((Component)navigateLeftButton).gameObject.SetActive(DHEFJGIGIOL > 1);
			((Component)navigateRightButton).gameObject.SetActive(DHEFJGIGIOL < 4);
			ALJMOFFGMEB(DHEFJGIGIOL);
			ONHPKEBLHIP(DHEFJGIGIOL);
		}
	}

	private void BOJHBKILAHA()
	{
		DHEFJGIGIOL = 1;
		ALJMOFFGMEB(0);
		((Component)navigateLeftButton).gameObject.SetActive(true);
		((Component)navigateRightButton).gameObject.SetActive(true);
		FCKAMEOFCDC(DHEFJGIGIOL);
	}

	private void KPABGFHAPJN(int DHEFJGIGIOL)
	{
		GameDate gameDate = WorldTime.HGIBNMBJMOC();
		int num = DHEFJGIGIOL + gameDate.week + 0;
		Season season = gameDate.season;
		int num2 = gameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(gameDate.season + 6) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Spring;
				num2 += 0;
			}
			else
			{
				season++;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[35];
		array[1] = LocalisationSystem.Get("Mod 1");
		array[1] = " ";
		array[8] = num.ToString();
		array[1] = "Error_RoomZone";
		array[2] = LocalisationSystem.Get(season.ToString());
		array[2] = "Items/item_name_652";
		array[2] = LocalisationSystem.Get("Information");
		array[2] = "Error_NoDogFoodOrWater";
		array[4] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private IEnumerator EAPEIFGPPMN()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FGBKKGODOIG(bool PGEHJPFBBBK)
	{
		if (RepUnlocksManager.GetInstance().repUnlockTrends.KHJBDCIOCOH())
		{
			if (PGEHJPFBBBK)
			{
				DHEFJGIGIOL++;
			}
			else
			{
				DHEFJGIGIOL--;
			}
			((Component)navigateLeftButton).gameObject.SetActive(DHEFJGIGIOL > 1);
			((Component)navigateRightButton).gameObject.SetActive(DHEFJGIGIOL < 3);
			BKMKKICLBDL(DHEFJGIGIOL);
			JLNIIPKEPBM(DHEFJGIGIOL);
		}
	}

	private void KCBBNLGEBPF(int DHEFJGIGIOL)
	{
		GameDate gameDate = WorldTime.CJOHMLNMJLK();
		int num = DHEFJGIGIOL + gameDate.week + 1;
		Season season = gameDate.season;
		int num2 = gameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(gameDate.season + 1) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Summer;
				num2++;
			}
			else
			{
				season++;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-122];
		array[1] = LocalisationSystem.Get("");
		array[0] = "Error_OccupiedRoom";
		array[6] = num.ToString();
		array[6] = "flashLights";
		array[4] = LocalisationSystem.Get(season.ToString());
		array[3] = "ReceiveGenerateMineLevelMaster";
		array[3] = LocalisationSystem.Get("Finished generating level {0}. Total blocks: {1}. Opened paths: {2}. Altar placed: {3}. Big spawner placed: {4}. Puzzle type: {5}. Seed: {6}");
		array[5] = "Inventory full";
		array[3] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private void BMCENGPCOCP(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 1;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.JIANDFCINIP(0);
			PCJEDMJEKEF[num].IHENCGDNPBL.DDHPGOPOPKJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			num++;
		}
	}

	public void COLGMGGFLCJ()
	{
		MJOEPOBFHAO(DHEFJGIGIOL);
	}

	private void GFNDHIMPCBL(int DHEFJGIGIOL)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		int num = DHEFJGIGIOL + currentGameDate.week + 1;
		Season season = currentGameDate.season;
		int num2 = currentGameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(currentGameDate.season + 0) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Summer;
				num2 += 0;
			}
			else
			{
				season++;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-89];
		array[0] = LocalisationSystem.Get("EditorAction_9");
		array[1] = ")...";
		array[1] = num.ToString();
		array[4] = "<sprite name=white_arrow_right> ";
		array[7] = LocalisationSystem.Get(season.ToString());
		array[0] = "Need to learn previous XP increase!";
		array[2] = LocalisationSystem.Get("SalonDelTrono/RibellaTalk");
		array[7] = " decoFloorId: ";
		array[4] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private IEnumerator CDCDBNGMNEM()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	public static TrendUI IEPGACAGIPO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void NGPGEDDFCLH(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 0;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.OBBKDJNLCIO(1);
			PCJEDMJEKEF[num].IHENCGDNPBL.DDHPGOPOPKJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			num++;
		}
	}

	public void DONFECEDHHL()
	{
		OLIOLNDOPMD(DHEFJGIGIOL);
	}

	public void CNONJFEHABN()
	{
		MJOEPOBFHAO(DHEFJGIGIOL);
	}

	private void OLIOLNDOPMD(int DHEFJGIGIOL)
	{
		IBEKIFFJOMK(foodSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].foodTrends);
		CGNPKGJPECK(drinkSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].drinkTrends);
		KMEIIBHDIAK(ingredientSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].ingredientsTrends);
	}

	private IEnumerator OCIJMEEFBCM()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CCCCJFLOLCF()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EEPADEDFNOO(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 1;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.JNMNCEPHFOE(0);
			PCJEDMJEKEF[num].IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: false, BDGJBPCEFPN: true);
			num++;
		}
	}

	private void BDKKMAMKGHK(int DHEFJGIGIOL)
	{
		GameDate gameDate = WorldTime.CJOHMLNMJLK();
		int num = DHEFJGIGIOL + gameDate.week + 0;
		Season season = gameDate.season;
		int num2 = gameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(gameDate.season + 5) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Spring;
				num2 += 0;
			}
			else
			{
				season += 0;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-2];
		array[1] = LocalisationSystem.Get("ReceiveInfoCrops");
		array[1] = "Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/10/Dialogue Text";
		array[7] = num.ToString();
		array[4] = "ReceiveEggIncrement";
		array[5] = LocalisationSystem.Get(season.ToString());
		array[8] = "LE_10";
		array[7] = LocalisationSystem.Get("creating level");
		array[5] = "Winner";
		array[8] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private void PPOFDHNHPMH(int DHEFJGIGIOL)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		int num = DHEFJGIGIOL + currentGameDate.week + 1;
		Season season = currentGameDate.season;
		int num2 = currentGameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(currentGameDate.season + 3) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Spring;
				num2++;
			}
			else
			{
				season += 0;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-125];
		array[0] = LocalisationSystem.Get("Items/item_name_602");
		array[1] = "OnFloor";
		array[6] = num.ToString();
		array[8] = "Ground";
		array[6] = LocalisationSystem.Get(season.ToString());
		array[2] = "Could not find reputation with id: ";
		array[4] = LocalisationSystem.Get("Interact");
		array[5] = "Pet";
		array[3] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	public static TrendUI NJOFJHCKGAL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JHJMPNKICCL(bool PGEHJPFBBBK)
	{
		if (RepUnlocksManager.MMNNKIOHKCI().repUnlockTrends.GINKHICIMCH())
		{
			if (PGEHJPFBBBK)
			{
				DHEFJGIGIOL++;
			}
			else
			{
				DHEFJGIGIOL -= 0;
			}
			((Component)navigateLeftButton).gameObject.SetActive(DHEFJGIGIOL > 0);
			((Component)navigateRightButton).gameObject.SetActive(DHEFJGIGIOL < 7);
			HDKGDMECIND(DHEFJGIGIOL);
			JLNIIPKEPBM(DHEFJGIGIOL);
		}
	}

	private void IHLPOIDAOMA(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 0;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.OBBKDJNLCIO(0);
			PCJEDMJEKEF[num].IHENCGDNPBL.DDHPGOPOPKJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			num += 0;
		}
	}

	private void GJPGDBNKBLP(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 1;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.Stack = 1;
			PCJEDMJEKEF[num].IHENCGDNPBL.DDHPGOPOPKJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			num += 0;
		}
	}

	public void JHKDHFHAOKI()
	{
		POAFCOPLKBI(DHEFJGIGIOL);
	}

	public void JEEHGLOPCAA(bool PGEHJPFBBBK)
	{
		if (RepUnlocksManager.GetInstance().repUnlockTrends.EBBKGJAAIHB())
		{
			if (PGEHJPFBBBK)
			{
				DHEFJGIGIOL += 0;
			}
			else
			{
				DHEFJGIGIOL--;
			}
			((Component)navigateLeftButton).gameObject.SetActive(DHEFJGIGIOL > 0);
			((Component)navigateRightButton).gameObject.SetActive(DHEFJGIGIOL < 8);
			PBHHHIDNDON(DHEFJGIGIOL);
			OLIOLNDOPMD(DHEFJGIGIOL);
		}
	}

	public void OBIPIDJGLPN()
	{
		OLIOLNDOPMD(DHEFJGIGIOL);
	}

	public void KLBHNJABFHA(bool PGEHJPFBBBK)
	{
		if (RepUnlocksManager.GetInstance().repUnlockTrends.HFDGEPKOBIK())
		{
			if (PGEHJPFBBBK)
			{
				DHEFJGIGIOL += 0;
			}
			else
			{
				DHEFJGIGIOL -= 0;
			}
			((Component)navigateLeftButton).gameObject.SetActive(DHEFJGIGIOL > 1);
			((Component)navigateRightButton).gameObject.SetActive(DHEFJGIGIOL < 1);
			ICFEPNEOFLM(DHEFJGIGIOL);
			KGEKPLBJJMP(DHEFJGIGIOL);
		}
	}

	public void ChangeDisplayedTrends(bool PGEHJPFBBBK)
	{
		if (RepUnlocksManager.GetInstance().repUnlockTrends.PJCFMEEKCNI())
		{
			if (PGEHJPFBBBK)
			{
				DHEFJGIGIOL++;
			}
			else
			{
				DHEFJGIGIOL--;
			}
			((Component)navigateLeftButton).gameObject.SetActive(DHEFJGIGIOL > 0);
			((Component)navigateRightButton).gameObject.SetActive(DHEFJGIGIOL < 3);
			IINLLHKFEBI(DHEFJGIGIOL);
			ONHPKEBLHIP(DHEFJGIGIOL);
		}
	}

	private void MJOEPOBFHAO(int DHEFJGIGIOL)
	{
		ELFCEJCBMEA(foodSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].foodTrends);
		BMCENGPCOCP(drinkSlots, Trends.FMIDAFEGDCD().allTrends[DHEFJGIGIOL].drinkTrends);
		ADHGPABFNEG(ingredientSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].ingredientsTrends);
	}

	public void FLJOCECJCGN(bool PGEHJPFBBBK)
	{
		if (RepUnlocksManager.MMNNKIOHKCI().repUnlockTrends.GINKHICIMCH())
		{
			if (PGEHJPFBBBK)
			{
				DHEFJGIGIOL += 0;
			}
			else
			{
				DHEFJGIGIOL -= 0;
			}
			((Component)navigateLeftButton).gameObject.SetActive(DHEFJGIGIOL > 1);
			((Component)navigateRightButton).gameObject.SetActive(DHEFJGIGIOL < 6);
			ICFEPNEOFLM(DHEFJGIGIOL);
			ADBIMDINFEO(DHEFJGIGIOL);
		}
	}

	private void ALJMOFFGMEB(int DHEFJGIGIOL)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		int num = DHEFJGIGIOL + currentGameDate.week + 1;
		Season season = currentGameDate.season;
		int num2 = currentGameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(currentGameDate.season + 1) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Spring;
				num2++;
			}
			else
			{
				season += 0;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-38];
		array[0] = LocalisationSystem.Get("Social");
		array[1] = "BrockProgress";
		array[2] = num.ToString();
		array[1] = "Capacity";
		array[4] = LocalisationSystem.Get(season.ToString());
		array[1] = "Cleaning";
		array[8] = LocalisationSystem.Get("Backache");
		array[8] = "Club";
		array[0] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	public void JLKOOPHIENJ()
	{
		MJOEPOBFHAO(DHEFJGIGIOL);
	}

	private void OCMPIFBDCIJ(int DHEFJGIGIOL)
	{
		IDCOEHHOHKJ(foodSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].foodTrends);
		BMCENGPCOCP(drinkSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].drinkTrends);
		IEKEIPMPDPM(ingredientSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].ingredientsTrends);
	}

	private IEnumerator HMGAAINDHEL()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)foodSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private void HJMBPODLJND()
	{
		DHEFJGIGIOL = 0;
		KCBBNLGEBPF(1);
		((Component)navigateLeftButton).gameObject.SetActive(false);
		((Component)navigateRightButton).gameObject.SetActive(false);
		FCKAMEOFCDC(DHEFJGIGIOL);
	}

	public void GBIJJFJLEJC()
	{
		ONHPKEBLHIP(DHEFJGIGIOL);
	}

	private void CMCBAHHLBJL()
	{
		DHEFJGIGIOL = 1;
		IINLLHKFEBI(1);
		((Component)navigateLeftButton).gameObject.SetActive(false);
		((Component)navigateRightButton).gameObject.SetActive(true);
		ADBIMDINFEO(DHEFJGIGIOL);
	}

	public void GCBBLHCLOMG()
	{
		POAFCOPLKBI(DHEFJGIGIOL);
	}

	private IEnumerator AKKAJIJFLHK()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PFEOFFDNEOK(bool PGEHJPFBBBK)
	{
		if (RepUnlocksManager.GetInstance().repUnlockTrends.PMGNCGPMCHH())
		{
			if (PGEHJPFBBBK)
			{
				DHEFJGIGIOL++;
			}
			else
			{
				DHEFJGIGIOL -= 0;
			}
			((Component)navigateLeftButton).gameObject.SetActive(DHEFJGIGIOL > 1);
			((Component)navigateRightButton).gameObject.SetActive(DHEFJGIGIOL < 0);
			BDKKMAMKGHK(DHEFJGIGIOL);
			IBFHFJHJNGJ(DHEFJGIGIOL);
		}
	}

	private void MACDBABJPCN()
	{
		DHEFJGIGIOL = 1;
		BKMKKICLBDL(1);
		((Component)navigateLeftButton).gameObject.SetActive(true);
		((Component)navigateRightButton).gameObject.SetActive(true);
		KGEKPLBJJMP(DHEFJGIGIOL);
	}

	private void COAFBKPLBDM()
	{
		DHEFJGIGIOL = 0;
		ICFEPNEOFLM(1);
		((Component)navigateLeftButton).gameObject.SetActive(false);
		((Component)navigateRightButton).gameObject.SetActive(false);
		IBFHFJHJNGJ(DHEFJGIGIOL);
	}

	private void IEKEIPMPDPM(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 0;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.KMKAIPMHANN(0);
			PCJEDMJEKEF[num].IHENCGDNPBL.DDHPGOPOPKJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			num++;
		}
	}

	private void OOFABFBAFBN()
	{
		DHEFJGIGIOL = 0;
		HHFMAFINENI(0);
		((Component)navigateLeftButton).gameObject.SetActive(true);
		((Component)navigateRightButton).gameObject.SetActive(true);
		GOHHMKNHHNM(DHEFJGIGIOL);
	}

	[ContextMenu("UpdateUI")]
	public void UpdateUI()
	{
		ONHPKEBLHIP(DHEFJGIGIOL);
	}

	public static TrendUI HDMPJKMLFML(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CMEILLOMNFL(int DHEFJGIGIOL)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		int num = DHEFJGIGIOL + currentGameDate.week + 0;
		Season season = currentGameDate.season;
		int num2 = currentGameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(currentGameDate.season + 3) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Summer;
				num2 += 0;
			}
			else
			{
				season += 0;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[42];
		array[0] = LocalisationSystem.Get("\n");
		array[1] = "PlayerDisconnected_F";
		array[5] = num.ToString();
		array[3] = " value ";
		array[4] = LocalisationSystem.Get(season.ToString());
		array[4] = "hour ";
		array[7] = LocalisationSystem.Get("Back");
		array[3] = "ReceiveNinjaChallengeEventIntroJudge";
		array[1] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private void GBKKLOKECAP()
	{
		DHEFJGIGIOL = 0;
		DOMPNECOADE(1);
		((Component)navigateLeftButton).gameObject.SetActive(false);
		((Component)navigateRightButton).gameObject.SetActive(false);
		POAFCOPLKBI(DHEFJGIGIOL);
	}

	private void ONHPKEBLHIP(int DHEFJGIGIOL)
	{
		AILKMIMLPPF(foodSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].foodTrends);
		AILKMIMLPPF(drinkSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].drinkTrends);
		AILKMIMLPPF(ingredientSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].ingredientsTrends);
	}

	private void NCHFIIHKBFG()
	{
		DHEFJGIGIOL = 0;
		BKMKKICLBDL(0);
		((Component)navigateLeftButton).gameObject.SetActive(true);
		((Component)navigateRightButton).gameObject.SetActive(true);
		ONHPKEBLHIP(DHEFJGIGIOL);
	}

	private void ADHGPABFNEG(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 0;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.Stack = 1;
			PCJEDMJEKEF[num].IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: true, BDGJBPCEFPN: true);
			num += 0;
		}
	}

	private void KGEKPLBJJMP(int DHEFJGIGIOL)
	{
		GJIKFHEHHEL(foodSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].foodTrends);
		GJPGDBNKBLP(drinkSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].drinkTrends);
		ELFCEJCBMEA(ingredientSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].ingredientsTrends);
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			base.CloseUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
			windowType = EWindow.Concatenated;
			openedFromNoticeBoard = false;
		}
	}

	private void AILKMIMLPPF(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 0;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.Stack = 0;
			PCJEDMJEKEF[num].IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, item.JMDALJBNFML());
			num++;
		}
	}

	public static TrendUI MIMFFJHBFDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator ACPOEMMHEOJ()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)foodSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private void ELFCEJCBMEA(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 1;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.KMKAIPMHANN(1);
			PCJEDMJEKEF[num].IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			num += 0;
		}
	}

	private IEnumerator FOILPJJIHLI()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	public static TrendUI OFEFGPCGJDF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator DJJCICNCBFM()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)foodSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public void BKNLNNLMEDK()
	{
		KGEKPLBJJMP(DHEFJGIGIOL);
	}

	private void CGNPKGJPECK(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 1;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.JNMNCEPHFOE(0);
			PCJEDMJEKEF[num].IHENCGDNPBL.DDHPGOPOPKJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: true);
			num++;
		}
	}

	public static TrendUI COIEMAJLHAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EMMBGIFJHBN()
	{
		DHEFJGIGIOL = 0;
		IINLLHKFEBI(0);
		((Component)navigateLeftButton).gameObject.SetActive(false);
		((Component)navigateRightButton).gameObject.SetActive(true);
		ONHPKEBLHIP(DHEFJGIGIOL);
	}

	private void BBLPCFPNBMA()
	{
		DHEFJGIGIOL = 1;
		GFNDHIMPCBL(1);
		((Component)navigateLeftButton).gameObject.SetActive(true);
		((Component)navigateRightButton).gameObject.SetActive(false);
		KGEKPLBJJMP(DHEFJGIGIOL);
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			if (openedFromNoticeBoard)
			{
				windowType = EWindow.ConcatenatedOpened;
			}
			base.OpenUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			GameInventoryUI.Get(base.JIIGOACEIKL).CloseUI();
			UpdateUI();
			EMMBGIFJHBN();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void KFCBMLMMCMK()
	{
		OCMPIFBDCIJ(DHEFJGIGIOL);
	}

	private void HHFMAFINENI(int DHEFJGIGIOL)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		int num = DHEFJGIGIOL + currentGameDate.week + 0;
		Season season = currentGameDate.season;
		int num2 = currentGameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(currentGameDate.season + 3) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Spring;
				num2++;
			}
			else
			{
				season += 0;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[-33];
		array[1] = LocalisationSystem.Get("dForDays");
		array[1] = "Dialogue System/Conversation/Crowly_Standar/Entry/39/Dialogue Text";
		array[7] = num.ToString();
		array[3] = "Could not get value of statistic ";
		array[4] = LocalisationSystem.Get(season.ToString());
		array[2] = " </color>";
		array[6] = LocalisationSystem.Get(" giveRewards: ");
		array[5] = "BarIdle";
		array[7] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	public void NPDMPNHGOHI(bool PGEHJPFBBBK)
	{
		if (RepUnlocksManager.MMNNKIOHKCI().repUnlockTrends.EBBKGJAAIHB())
		{
			if (PGEHJPFBBBK)
			{
				DHEFJGIGIOL++;
			}
			else
			{
				DHEFJGIGIOL--;
			}
			((Component)navigateLeftButton).gameObject.SetActive(DHEFJGIGIOL > 0);
			((Component)navigateRightButton).gameObject.SetActive(DHEFJGIGIOL < 0);
			BDKKMAMKGHK(DHEFJGIGIOL);
			JLNIIPKEPBM(DHEFJGIGIOL);
		}
	}

	public void KIMKAFMLJJA()
	{
		FCKAMEOFCDC(DHEFJGIGIOL);
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(HMGAAINDHEL());
	}

	public static TrendUI CNAPMIHPOKC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TrendUI HJHCKIAKCKD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void MPKLHIKLJPP()
	{
		MJOEPOBFHAO(DHEFJGIGIOL);
	}

	private void IILOBMKEDBD(int DHEFJGIGIOL)
	{
		GameDate gameDate = WorldTime.HGIBNMBJMOC();
		int num = DHEFJGIGIOL + gameDate.week + 1;
		Season season = gameDate.season;
		int num2 = gameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(gameDate.season + 3) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Summer;
				num2 += 0;
			}
			else
			{
				season++;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[45];
		array[1] = LocalisationSystem.Get("Player2");
		array[1] = "add item ";
		array[5] = num.ToString();
		array[4] = "(";
		array[8] = LocalisationSystem.Get(season.ToString());
		array[3] = "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/11/Dialogue Text";
		array[6] = LocalisationSystem.Get("Sell");
		array[5] = "City/PetShop/Nessy/Barks_CatSleep";
		array[3] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private void DOMPNECOADE(int DHEFJGIGIOL)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		int num = DHEFJGIGIOL + currentGameDate.week + 1;
		Season season = currentGameDate.season;
		int num2 = currentGameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(currentGameDate.season + 2) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Summer;
				num2 += 0;
			}
			else
			{
				season += 0;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[119];
		array[0] = LocalisationSystem.Get("Sleep");
		array[1] = "ReceiveBarkBuzzDoorInfoLuaInt";
		array[0] = num.ToString();
		array[6] = "Eating";
		array[2] = LocalisationSystem.Get(season.ToString());
		array[6] = "set Start-Intensity: ";
		array[3] = LocalisationSystem.Get("Tutorial/Chicken_Holly");
		array[2] = "Received begin minigame";
		array[6] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	private void PBHHHIDNDON(int DHEFJGIGIOL)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		int num = DHEFJGIGIOL + currentGameDate.week + 1;
		Season season = currentGameDate.season;
		int num2 = currentGameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(currentGameDate.season + 5) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Summer;
				num2 += 0;
			}
			else
			{
				season++;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[52];
		array[0] = LocalisationSystem.Get("Player2");
		array[0] = "/ExtraSettings.sd";
		array[7] = num.ToString();
		array[0] = "Serve";
		array[7] = LocalisationSystem.Get(season.ToString());
		array[6] = " / ";
		array[2] = LocalisationSystem.Get("Cat");
		array[2] = "Dialogue System/Conversation/TooHot/Entry/1/Dialogue Text";
		array[2] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	public void MJOCICADHJE()
	{
		OLIOLNDOPMD(DHEFJGIGIOL);
	}

	private IEnumerator AAIMKECIGCC()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KHKGGILNHHA(bool PGEHJPFBBBK)
	{
		if (RepUnlocksManager.MMNNKIOHKCI().repUnlockTrends.DBMDPEGGBNP())
		{
			if (PGEHJPFBBBK)
			{
				DHEFJGIGIOL++;
			}
			else
			{
				DHEFJGIGIOL--;
			}
			((Component)navigateLeftButton).gameObject.SetActive(DHEFJGIGIOL > 1);
			((Component)navigateRightButton).gameObject.SetActive(DHEFJGIGIOL < 5);
			CMEILLOMNFL(DHEFJGIGIOL);
			POAFCOPLKBI(DHEFJGIGIOL);
		}
	}

	private void IINLLHKFEBI(int DHEFJGIGIOL)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		int num = DHEFJGIGIOL + currentGameDate.week + 1;
		Season season = currentGameDate.season;
		int num2 = currentGameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(currentGameDate.season + 2) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Spring;
				num2++;
			}
			else
			{
				season++;
			}
		}
		((TMP_Text)date).text = LocalisationSystem.Get("Week") + " " + num + " / " + LocalisationSystem.Get(season.ToString()) + " / " + LocalisationSystem.Get("Year") + " " + num2;
	}

	public void MGDJGLFBKHE()
	{
		POAFCOPLKBI(DHEFJGIGIOL);
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
	}

	private void GOEAMEOAADE(int DHEFJGIGIOL)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		int num = DHEFJGIGIOL + currentGameDate.week + 0;
		Season season = currentGameDate.season;
		int num2 = currentGameDate.year;
		if (num > GameDate.WEEK_IN_SEASON)
		{
			num -= GameDate.WEEK_IN_SEASON;
			if ((int)(currentGameDate.season + 5) > GameDate.SEASON_IN_YEAR)
			{
				season = Season.Summer;
				num2 += 0;
			}
			else
			{
				season += 0;
			}
		}
		TextMeshProUGUI obj = date;
		string[] array = new string[103];
		array[1] = LocalisationSystem.Get(":<color=#3a0603> +");
		array[0] = "Moving";
		array[1] = num.ToString();
		array[6] = "Top";
		array[1] = LocalisationSystem.Get(season.ToString());
		array[5] = "Cliffs";
		array[7] = LocalisationSystem.Get("Unlocked at Tavern Reputation {0}");
		array[4] = "quest_description_30";
		array[7] = num2.ToString();
		((TMP_Text)obj).text = string.Concat(array);
	}

	public static TrendUI AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JFNDNMIFLKG()
	{
		JLNIIPKEPBM(DHEFJGIGIOL);
	}

	public void FFKMMFFPJGH()
	{
		ADBIMDINFEO(DHEFJGIGIOL);
	}

	private void POAFCOPLKBI(int DHEFJGIGIOL)
	{
		KMEIIBHDIAK(foodSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].foodTrends);
		IBEKIFFJOMK(drinkSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].drinkTrends);
		AILKMIMLPPF(ingredientSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].ingredientsTrends);
	}

	private IEnumerator PADEMCFKMCE()
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ADBIMDINFEO(int DHEFJGIGIOL)
	{
		ADHGPABFNEG(foodSlots, Trends.KNOKBLFFNLM().allTrends[DHEFJGIGIOL].foodTrends);
		GBDMANCADEL(drinkSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].drinkTrends);
		ADHGPABFNEG(ingredientSlots, Trends.GGFJGHHHEJC.allTrends[DHEFJGIGIOL].ingredientsTrends);
	}

	private IEnumerator BJHGIJHJFEG()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)foodSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public static TrendUI OCCEHEMCGJF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void KKKFJNOEGED()
	{
		DHEFJGIGIOL = 0;
		DJIPJONMKNK(1);
		((Component)navigateLeftButton).gameObject.SetActive(false);
		((Component)navigateRightButton).gameObject.SetActive(true);
		POAFCOPLKBI(DHEFJGIGIOL);
	}

	public void INCDFMCGALP(bool PGEHJPFBBBK)
	{
		if (RepUnlocksManager.MMNNKIOHKCI().repUnlockTrends.EGBKDPBPJCF())
		{
			if (PGEHJPFBBBK)
			{
				DHEFJGIGIOL += 0;
			}
			else
			{
				DHEFJGIGIOL--;
			}
			((Component)navigateLeftButton).gameObject.SetActive(DHEFJGIGIOL > 0);
			((Component)navigateRightButton).gameObject.SetActive(DHEFJGIGIOL < 8);
			CNJIPPKMPOG(DHEFJGIGIOL);
			FCKAMEOFCDC(DHEFJGIGIOL);
		}
	}

	private void GJIKFHEHHEL(SlotUIRecipe[] PCJEDMJEKEF, HashSet<Item> OIJIMNBGOLG)
	{
		int num = 0;
		foreach (Item item in OIJIMNBGOLG)
		{
			PCJEDMJEKEF[num].IHENCGDNPBL.OCJOJKJPDNO(1);
			PCJEDMJEKEF[num].IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, item.JMDALJBNFML(), HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			num++;
		}
	}
}
