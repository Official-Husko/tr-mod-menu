using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecipeSlot : MonoBehaviour
{
	public enum CheckInventory
	{
		crafterInventory,
		playerInventory
	}

	[CompilerGenerated]
	private sealed class OAOOLKFPMJE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecipeSlot _003C_003E4__this;

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
		public OAOOLKFPMJE(int _003C_003E1__state)
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
			RecipeSlot recipeSlot = _003C_003E4__this;
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
				recipeSlot.AINLICCOBPC();
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

	[CompilerGenerated]
	private sealed class BOBLGMDBLLG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecipeSlot _003C_003E4__this;

		public bool useRecipeOutputDescription;

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
		public BOBLGMDBLLG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			RecipeSlot recipeSlot = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.waitRealtime01;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (recipeSlot.JKIAKMICLKF && recipeSlot.FMINLAJEHIG())
				{
					ItemTooltip.Get(recipeSlot.playerNum).SetPositionAndEnable(new Vector2(((Transform)recipeSlot.rectTransform).position.x + 4f * ((Transform)recipeSlot.rectTransform).lossyScale.x, ((Transform)recipeSlot.rectTransform).position.y + 4f * ((Transform)recipeSlot.rectTransform).lossyScale.y), new Vector2(50f, (recipeSlot.rectTransform.sizeDelta.y + 15f) * ((Transform)recipeSlot.rectTransform).lossyScale.x), recipeSlot.recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance);
					TooltipInfo tooltipInfo = new TooltipInfo();
					if (ItemInstance.showIdsNum)
					{
						tooltipInfo.toolTipTitle = recipeSlot.recipe.output.item.JDJGFAACPFC() + " ";
					}
					else
					{
						tooltipInfo.toolTipTitle = "";
					}
					tooltipInfo.toolTipTitle += recipeSlot.recipe.IABAKHPEOAF();
					tooltipInfo.toolTipTitle += Utils.NFEOACEFIHI(recipeSlot.playerNum, recipeSlot.recipe.output.item, AKNBKINJGCF: false, null, AHCENOLCIBM: true);
					if (useRecipeOutputDescription && Object.op_Implicit((Object)(object)recipeSlot.recipe) && Object.op_Implicit((Object)(object)recipeSlot.recipe.output.item))
					{
						if (!string.IsNullOrEmpty(recipeSlot.recipe.output.item.IGDKFHCHEAJ(recipeSlot.playerNum)))
						{
							tooltipInfo.mainBody = tooltipInfo.mainBody + "<color=black>" + recipeSlot.recipe.output.item.IGDKFHCHEAJ(recipeSlot.playerNum) + "</color>";
						}
						ItemTooltip.Get(recipeSlot.playerNum).FillTooltipInfo(tooltipInfo);
						return false;
					}
					KOCAANJLPEP = recipeSlot.recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE();
					tooltipInfo.mainBody = "";
					if (!string.IsNullOrEmpty(KOCAANJLPEP.IGDKFHCHEAJ(recipeSlot.playerNum)))
					{
						tooltipInfo.mainBody = tooltipInfo.mainBody + "<color=black>" + KOCAANJLPEP.IGDKFHCHEAJ(recipeSlot.playerNum) + "</color>";
						tooltipInfo.mainBody += "\n";
					}
					bool flag = GameCraftingUI.Get(recipeSlot.playerNum).IsOpen();
					Placeable fLAAGFECLME = ((!flag) ? null : GameCraftingUI.Get(recipeSlot.playerNum).GetCrafter());
					for (int i = 0; i < recipeSlot.recipe.ingredientsNeeded.Length; i++)
					{
						if (i == 0)
						{
							tooltipInfo.mainBody += "\n";
						}
						int num2 = Utils.CCLEBHFHFCF(recipeSlot.playerNum, recipeSlot.recipe, recipeSlot.recipe.ingredientsNeeded[i], flag, fLAAGFECLME);
						int num3 = recipeSlot.recipe.ingredientsNeeded[i].amount;
						if (GameCraftingUI.Get(recipeSlot.playerNum).IsOpen())
						{
							num3 -= (int)GameCraftingUI.Get(recipeSlot.playerNum).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.RecipeCost, recipeSlot.recipe);
						}
						if (num2 < Math.Max(1, num3))
						{
							tooltipInfo.mainBody += "<color=#BF0000>";
						}
						if (ItemInstance.showIdsNum)
						{
							tooltipInfo.mainBody += recipeSlot.recipe.ingredientsNeeded[i].item.JDJGFAACPFC();
						}
						tooltipInfo.mainBody += recipeSlot.recipe.ingredientsNeeded[i].item.IABAKHPEOAF(OAFPBCPDOKH: true);
						if (recipeSlot.recipe.ingredientsNeeded[i].item.NGDPNIFFHKL() && Item.MLBOMGHINCA(recipeSlot.recipe.ingredientsNeeded[i].mod, null))
						{
							tooltipInfo.mainBody = tooltipInfo.mainBody + " (" + recipeSlot.recipe.ingredientsNeeded[i].mod.IABAKHPEOAF(OAFPBCPDOKH: true) + ")";
						}
						if (num3 > 1)
						{
							tooltipInfo.mainBody = tooltipInfo.mainBody + " (" + num3 + ")";
						}
						if (num2 < Math.Max(1, num3))
						{
							tooltipInfo.mainBody += "</color>";
						}
						tooltipInfo.mainBody += "\n";
					}
					if (Object.op_Implicit((Object)(object)KOCAANJLPEP.PHGCBMPGGLI()))
					{
						recipeSlot.CDJDHPCKKDD = KOCAANJLPEP.PHGCBMPGGLI().GetComponent<AreaBonification>();
						if (Object.op_Implicit((Object)(object)recipeSlot.CDJDHPCKKDD))
						{
							tooltipInfo.mainBody = tooltipInfo.mainBody + "\n<color=#A95A00>" + recipeSlot.CDJDHPCKKDD.GetDescription() + "</color>";
						}
					}
					if (KOCAANJLPEP.comfort != 0)
					{
						TooltipInfo tooltipInfo2 = tooltipInfo;
						tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#3662B5>" + LocalisationSystem.Get("Comfort") + ": " + KOCAANJLPEP.comfort + "</color>";
					}
					if (KOCAANJLPEP is Food food && (food.canBeSold || KOCAANJLPEP.price.OOIPLIEJILO() > 0))
					{
						if (KOCAANJLPEP.ticket && Utils.EPDMFPBLIHH())
						{
							TooltipInfo tooltipInfo2 = tooltipInfo;
							tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#822F00>" + LocalisationSystem.Get("Sell") + ":</color> <sprite name=\"ChristmasTicket\">" + KOCAANJLPEP.ticketPrice;
						}
						else
						{
							Price price = Money.CalculateSellPrice(recipeSlot.recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance, HOECMANECIM: true);
							Price price2 = Money.CalculateSellPrice(recipeSlot.recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance, HOECMANECIM: true, JNOEGJNPCFE: false, CalculatePriceMode.ExpensivePrice);
							if (food.canBeSold)
							{
								if (price.OOIPLIEJILO() != price2.OOIPLIEJILO())
								{
									TooltipInfo tooltipInfo2 = tooltipInfo;
									TooltipInfo tooltipInfo3 = tooltipInfo2;
									string[] obj = new string[5]
									{
										tooltipInfo2.mainBody,
										"\n<color=#822F00>",
										LocalisationSystem.Get("MinPrice"),
										":</color> ",
										null
									};
									Price price3 = price;
									obj[4] = price3.ToString();
									tooltipInfo3.mainBody = string.Concat(obj);
									tooltipInfo2 = tooltipInfo;
									TooltipInfo tooltipInfo4 = tooltipInfo2;
									string[] obj2 = new string[5]
									{
										tooltipInfo2.mainBody,
										"\n<color=#822F00>",
										LocalisationSystem.Get("MaxPrice"),
										":</color> ",
										null
									};
									price3 = price2;
									obj2[4] = price3.ToString();
									tooltipInfo4.mainBody = string.Concat(obj2);
								}
								else
								{
									TooltipInfo tooltipInfo2 = tooltipInfo;
									TooltipInfo tooltipInfo5 = tooltipInfo2;
									string[] obj3 = new string[5]
									{
										tooltipInfo2.mainBody,
										"\n<color=#822F00>",
										LocalisationSystem.Get("Price"),
										":</color> ",
										null
									};
									Price price3 = price;
									obj3[4] = price3.ToString();
									tooltipInfo5.mainBody = string.Concat(obj3);
								}
							}
							else if (price.OOIPLIEJILO() != price2.OOIPLIEJILO())
							{
								TooltipInfo tooltipInfo2 = tooltipInfo;
								TooltipInfo tooltipInfo6 = tooltipInfo2;
								string[] obj4 = new string[5]
								{
									tooltipInfo2.mainBody,
									"\n<color=#822F00>",
									LocalisationSystem.Get("MinProductValue"),
									":</color> ",
									null
								};
								Price price3 = price;
								obj4[4] = price3.ToString();
								tooltipInfo6.mainBody = string.Concat(obj4);
								tooltipInfo2 = tooltipInfo;
								TooltipInfo tooltipInfo7 = tooltipInfo2;
								string[] obj5 = new string[5]
								{
									tooltipInfo2.mainBody,
									"\n<color=#822F00>",
									LocalisationSystem.Get("MaxProductValue"),
									":</color> ",
									null
								};
								price3 = price2;
								obj5[4] = price3.ToString();
								tooltipInfo7.mainBody = string.Concat(obj5);
							}
							else
							{
								TooltipInfo tooltipInfo2 = tooltipInfo;
								TooltipInfo tooltipInfo8 = tooltipInfo2;
								string[] obj6 = new string[5]
								{
									tooltipInfo2.mainBody,
									"\n<color=#822F00>",
									LocalisationSystem.Get("ProductValue"),
									":</color> ",
									null
								};
								Price price3 = price;
								obj6[4] = price3.ToString();
								tooltipInfo8.mainBody = string.Concat(obj6);
							}
						}
					}
					tooltipInfo.mainBody += recipeSlot.recipe.output.item.MOBLAPBAMIH();
					if (OnlineManager.ClientOnline() && (Object)(object)recipeSlot.recipe != (Object)null)
					{
						if ((Object)(object)recipeSlot.recipe.reputationRequired != (Object)null && !recipeSlot.recipe.reputationRequired.PJCFMEEKCNI())
						{
							tooltipInfo.mainBody = tooltipInfo.mainBody + "\n<color=#BF0000>" + LocalisationSystem.Get("MasterMilestoneLower") + "</color>";
						}
						else if (!recipeSlot.recipe.FENMFGFLDBO(MJHDMIGEJAK: false) && recipeSlot.recipe.CFIFCPPAOGF())
						{
							tooltipInfo.mainBody = tooltipInfo.mainBody + "\n<color=#d99100>" + LocalisationSystem.Get("RecipeFromHost") + "</color>";
						}
					}
					ItemTooltip.Get(recipeSlot.playerNum).FillTooltipInfo(tooltipInfo);
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

	public Image image;

	public Image slotImage;

	public GameObject redBox;

	public TextMeshProUGUI topRightTM;

	public Image questIcon;

	public Image favoritesIcon;

	public int playerNum;

	public UIButtonExtended buttonExtended;

	[SerializeField]
	private RectTransform rectTransform;

	private bool PIIFEFOLEOF;

	private bool JKIAKMICLKF;

	public Recipe recipe;

	public RecipeElementUI recipeElementInfo;

	private Coroutine ANKPDEANCEI;

	private bool OEEPLPMIEOG = true;

	private int BGIHHIKDCEI;

	private bool CDPKJGCLAHE;

	private AreaBonification CDJDHPCKKDD;

	public CheckInventory checkInventory;

	private static Item KOCAANJLPEP;

	private void JMJDHLOMKAP()
	{
		if (JKIAKMICLKF)
		{
			OnDeselect();
		}
	}

	private void CIGEOFPLBCK()
	{
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < QuestManager.GGFJGHHHEJC.MADOFDHLKKN.Count; i++)
		{
			if (!(QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i].quest is RequiredItemQuest requiredItemQuest))
			{
				continue;
			}
			for (int j = 0; j < requiredItemQuest.possibleItems.Length; j++)
			{
				if (((object)requiredItemQuest.possibleItems[j]).Equals((object?)recipe.output.item))
				{
					flag = true;
					flag2 = requiredItemQuest.id != 0;
				}
			}
		}
		if ((Object)(object)questIcon != (Object)null)
		{
			if (flag)
			{
				((Behaviour)questIcon).enabled = true;
				questIcon.sprite = (flag2 ? RecipesBookUI.Get(playerNum).mainQuestSprite : RecipesBookUI.Get(playerNum).orderSprite);
				((Graphic)questIcon).SetNativeSize();
			}
			else if (RecipesManager.IsFavoriteRecipe(recipe))
			{
				((Behaviour)questIcon).enabled = true;
				questIcon.sprite = RecipesBookUI.Get(playerNum).favoriteSprite;
				((Graphic)questIcon).SetNativeSize();
			}
			else
			{
				((Behaviour)questIcon).enabled = false;
			}
		}
	}

	public void OnSelect()
	{
		NEBOMGGJOPD();
		PNKABKHGHNB();
	}

	public void HNCHEFNBKPN()
	{
		if (PlayerInputs.POLDHCKJINN(playerNum))
		{
			LIACBEEAPGN();
		}
	}

	public void DCNMKPDGHBJ()
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			GAKKBAPHGAC();
		}
	}

	private void PBJEJKHCHMI()
	{
		recipeElementInfo.clickable = PIIFEFOLEOF;
		recipeElementInfo.BDBBCBKLFOL(recipe);
	}

	private void AEHJOHKPHPA()
	{
		if (Object.op_Implicit((Object)(object)recipeElementInfo))
		{
			recipeElementInfo.GBJDNNCOIAC = null;
		}
	}

	public void OGAKPPPMNAO(int JIIGOACEIKL, Recipe GDBMELMKBMA, RecipeElementUI NGCCDEJGGHG, bool CIPCLBFOIOO)
	{
		playerNum = JIIGOACEIKL;
		recipeElementInfo = NGCCDEJGGHG;
		recipe = GDBMELMKBMA;
		PIIFEFOLEOF = CIPCLBFOIOO;
		image.sprite = recipe.output.item.icon;
		slotImage.sprite = CommonReferences.MNFMOEKMJKN().recipeSlotsSprites[(int)recipe.output.item.eventTags];
		BAIABLHPPKL();
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(BINGCFKECJH());
		}
		else
		{
			LLCMFHMCAJH();
		}
	}

	public void IALEIEMCFDG()
	{
		if (PlayerInputs.ODGALPDEIFG(playerNum))
		{
			BDNHHMHBBDI();
		}
	}

	public void LOAEOFHDNLM()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			HFLBMOIACGJ();
			MCKIJGKLECH();
			if (GameCraftingUI.Get(playerNum).BGLJFMHCFJF())
			{
				GameCraftingUI.Get(playerNum).GHFEDBPGDHG(CDPKJGCLAHE: false);
			}
		}
	}

	public void GAKKBAPHGAC()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			LJBEKIIOLJE();
			JCMNDJLCJBJ();
			if (GameCraftingUI.Get(playerNum).IsOpen())
			{
				GameCraftingUI.Get(playerNum).GHFEDBPGDHG(CDPKJGCLAHE: false);
			}
		}
	}

	public void PNGLEMGHBPD()
	{
		FLOFFGNIPGJ(KPGOCFFJMAD: true);
	}

	private IEnumerator EMBJFAAFDCB(bool KPGOCFFJMAD = false)
	{
		return new BOBLGMDBLLG(1)
		{
			_003C_003E4__this = this,
			useRecipeOutputDescription = KPGOCFFJMAD
		};
	}

	private void ECHMKEAGFFO()
	{
		if (JKIAKMICLKF)
		{
			LOAEOFHDNLM();
		}
	}

	private void NEBOMGGJOPD()
	{
		recipeElementInfo.clickable = PIIFEFOLEOF;
		recipeElementInfo.GBJDNNCOIAC = recipe;
	}

	private void FLLDIJEOIJP()
	{
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		JKIAKMICLKF = false;
		ItemTooltip.NMCJELBLKBB(playerNum).SetVisible(MDIKPGGBNLI: true);
	}

	public void OnDeselect()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			HFLBMOIACGJ();
			OOGKBGOCAFG();
			if (GameCraftingUI.Get(playerNum).IsOpen())
			{
				GameCraftingUI.Get(playerNum).UpdateFuelBackground(CDPKJGCLAHE: true);
			}
		}
	}

	public void JAPFFLIILOO()
	{
		KOOOHCMAFBL();
		recipeElementInfo.ElementClicked();
		if (!recipeElementInfo.clickable)
		{
			DPEJMDKLHJJ();
		}
		if (RecipesBookUI.LAIEKOOCNPC(playerNum).BGLJFMHCFJF() && RecipesBookUI.MAOAEHDKHDP(playerNum).favoriteListOpen)
		{
			OOGKBGOCAFG();
			if (((Component)this).gameObject.activeSelf)
			{
				EODIANIFJLM();
			}
		}
	}

	public void EBCKPHDBLEG()
	{
		LEBGKDLINAJ();
		recipeElementInfo.ElementClicked();
		if (!recipeElementInfo.clickable)
		{
			NEMLPHKHOMJ();
		}
		if (RecipesBookUI.ODLPIANFFFJ(playerNum).IsOpen() && RecipesBookUI.LAIEKOOCNPC(playerNum).favoriteListOpen)
		{
			MCKIJGKLECH();
			if (((Component)this).gameObject.activeSelf)
			{
				PNKABKHGHNB(KPGOCFFJMAD: true);
			}
		}
	}

	private void JFPDAHJLJJG()
	{
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		JKIAKMICLKF = true;
		ItemTooltip.IEKODILKIHJ(playerNum).SetVisible(MDIKPGGBNLI: false);
	}

	public void APKAJOCFNDO()
	{
		if (PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			OnDeselect();
		}
	}

	private void KNACMDGDELO()
	{
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		JKIAKMICLKF = false;
		ItemTooltip.AIMEAJAHLAA(playerNum).SetVisible(MDIKPGGBNLI: true);
	}

	public void PPFCPLPJEMD(int JIIGOACEIKL, Recipe GDBMELMKBMA, RecipeElementUI NGCCDEJGGHG, bool CIPCLBFOIOO)
	{
		playerNum = JIIGOACEIKL;
		recipeElementInfo = NGCCDEJGGHG;
		recipe = GDBMELMKBMA;
		PIIFEFOLEOF = CIPCLBFOIOO;
		image.sprite = recipe.output.item.icon;
		slotImage.sprite = CommonReferences.MNFMOEKMJKN().recipeSlotsSprites[(int)recipe.output.item.eventTags];
		NEMLPHKHOMJ();
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(BINGCFKECJH());
		}
		else
		{
			AINLICCOBPC();
		}
	}

	private void OJPLLAOFDCC()
	{
		if (JKIAKMICLKF)
		{
			BMAKHCCGMGP();
		}
	}

	private void PNKABKHGHNB(bool KPGOCFFJMAD = false)
	{
		JKIAKMICLKF = true;
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		ANKPDEANCEI = ((MonoBehaviour)this).StartCoroutine(BKJKGMFLDCC(KPGOCFFJMAD));
	}

	private void MAGJPMOKDPB()
	{
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		JKIAKMICLKF = false;
		ItemTooltip.EOPIEMLAPFN(playerNum).SetVisible(MDIKPGGBNLI: true);
	}

	public void GKKEGLGOEFL()
	{
		KOOOHCMAFBL();
		PNKABKHGHNB(KPGOCFFJMAD: true);
	}

	private void JCMNDJLCJBJ()
	{
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		JKIAKMICLKF = true;
		ItemTooltip.LAIEKOOCNPC(playerNum).FCACMDNLAIG(MDIKPGGBNLI: false);
	}

	public void LLAMBHIANFJ()
	{
		if (PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			IEAIDKCIAHK();
		}
	}

	public void LJHNLOHJOCL()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			MAGJPMOKDPB();
		}
	}

	private void OnDisable()
	{
		if (JKIAKMICLKF)
		{
			OnDeselect();
		}
	}

	public void LIACBEEAPGN()
	{
		EODIANIFJLM(KPGOCFFJMAD: true);
	}

	public void EEEPGEPCGPH()
	{
		FLOFFGNIPGJ();
	}

	private void ACKAEONKKJA(bool KPGOCFFJMAD = false)
	{
		JKIAKMICLKF = false;
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		ANKPDEANCEI = ((MonoBehaviour)this).StartCoroutine(JECFILOHEAG(KPGOCFFJMAD));
	}

	private bool BPJKDMKILHO()
	{
		if ((Object)(object)recipeElementInfo != (Object)null && Object.op_Implicit((Object)(object)recipeElementInfo.outputSlot))
		{
			return recipeElementInfo.outputSlot.IHENCGDNPBL.KPINNBKMOMO();
		}
		return false;
	}

	public void IEBBDGEEIEO()
	{
		EODIANIFJLM();
	}

	public void IEAIDKCIAHK()
	{
		JLCEMHMPPPG();
		FLOFFGNIPGJ();
	}

	public void BMAKHCCGMGP()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			AEHJOHKPHPA();
			JFPDAHJLJJG();
			if (GameCraftingUI.Get(playerNum).HDEPMJIDJEM())
			{
				GameCraftingUI.Get(playerNum).GHFEDBPGDHG(CDPKJGCLAHE: false);
			}
		}
	}

	public void FEPMAIGCFOD()
	{
		if (PlayerInputs.POLDHCKJINN(playerNum))
		{
			GHHKCHNBIOI();
		}
	}

	private void HPOMPFNHGHN()
	{
		if (JKIAKMICLKF)
		{
			EICBGCOKKMG();
		}
	}

	private void LLCMFHMCAJH()
	{
		OEEPLPMIEOG = false;
		bool flag = GameCraftingUI.Get(playerNum).IsOpen();
		Placeable fLAAGFECLME = ((!flag) ? null : GameCraftingUI.Get(playerNum).FBBFDHLJAIJ());
		if (OnlineManager.HHDBMDMFEMP() && (Object)(object)recipe.reputationRequired != (Object)null && !recipe.reputationRequired.DBMDPEGGBNP())
		{
			OEEPLPMIEOG = false;
		}
		for (int i = 0; i < recipe.ingredientsNeeded.Length; i += 0)
		{
			int num = ((checkInventory != CheckInventory.playerInventory) ? Utils.CCLEBHFHFCF(playerNum, recipe, recipe.ingredientsNeeded[i], flag, fLAAGFECLME) : PlayerInventory.EIFPKCAFDIB(playerNum).CPJBEMJOJJK(recipe.ingredientsNeeded[i].item.ODENMDOJPLC(DAINLFIMLIH: false)));
			int num2 = recipe.ingredientsNeeded[i].amount;
			if (flag)
			{
				num2 -= (int)GameCraftingUI.Get(playerNum).BNIFOFAPJDL().KEKPCMBDFHM(AreaBonificationType.FuelDiscount, recipe);
			}
			if (num2 > num)
			{
				OEEPLPMIEOG = true;
				break;
			}
		}
		int num3 = ((!GameCraftingUI.Get(playerNum).BGLJFMHCFJF() || recipe.fuel <= 0) ? recipe.fuel : ((int)Mathf.Max(264f, (float)recipe.fuel - GameCraftingUI.Get(playerNum).LDLINOBIKPL.KEKPCMBDFHM(AreaBonificationType.RecipeProduction, recipe))));
		if ((Object)(object)GameCraftingUI.Get(playerNum).LDLINOBIKPL != (Object)null && GameCraftingUI.Get(playerNum).LDLINOBIKPL.LCCABPFHCOL < num3)
		{
			CDPKJGCLAHE = false;
		}
		else
		{
			CDPKJGCLAHE = true;
		}
		if (!CDPKJGCLAHE || !OEEPLPMIEOG)
		{
			redBox.SetActive(false);
		}
		else
		{
			redBox.SetActive(false);
		}
	}

	private void OOGKBGOCAFG()
	{
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		JKIAKMICLKF = false;
		ItemTooltip.Get(playerNum).SetVisible(MDIKPGGBNLI: false);
	}

	public void PIEHNOMHOOB()
	{
		if (PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			LIACBEEAPGN();
		}
	}

	public void JIHIKDGAJDG()
	{
		JLCEMHMPPPG();
		EODIANIFJLM();
	}

	private void FLOFFGNIPGJ(bool KPGOCFFJMAD = false)
	{
		JKIAKMICLKF = true;
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		ANKPDEANCEI = ((MonoBehaviour)this).StartCoroutine(BKJKGMFLDCC(KPGOCFFJMAD));
	}

	private bool MJCBNBFHDAJ()
	{
		if ((Object)(object)recipeElementInfo != (Object)null && Object.op_Implicit((Object)(object)recipeElementInfo.outputSlot))
		{
			return recipeElementInfo.outputSlot.IHENCGDNPBL.KPINNBKMOMO();
		}
		return false;
	}

	public void NHIKGCKCPJH()
	{
		PNKABKHGHNB(KPGOCFFJMAD: true);
	}

	private void LINJKBHEMEB()
	{
		if (Object.op_Implicit((Object)(object)recipeElementInfo))
		{
			recipeElementInfo.GBJDNNCOIAC = null;
		}
	}

	public void UpdateSlot(int JIIGOACEIKL, Recipe GDBMELMKBMA, RecipeElementUI NGCCDEJGGHG, bool CIPCLBFOIOO)
	{
		playerNum = JIIGOACEIKL;
		recipeElementInfo = NGCCDEJGGHG;
		recipe = GDBMELMKBMA;
		PIIFEFOLEOF = CIPCLBFOIOO;
		image.sprite = recipe.output.item.icon;
		slotImage.sprite = CommonReferences.GGFJGHHHEJC.recipeSlotsSprites[(int)recipe.output.item.eventTags];
		CIGEOFPLBCK();
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(ABBEGCAFGEA());
		}
		else
		{
			AINLICCOBPC();
		}
	}

	private IEnumerator BKJKGMFLDCC(bool KPGOCFFJMAD = false)
	{
		yield return CommonReferences.waitRealtime01;
		if (!JKIAKMICLKF || !FMINLAJEHIG())
		{
			yield break;
		}
		ItemTooltip.Get(playerNum).SetPositionAndEnable(new Vector2(((Transform)rectTransform).position.x + 4f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 4f * ((Transform)rectTransform).lossyScale.y), new Vector2(50f, (rectTransform.sizeDelta.y + 15f) * ((Transform)rectTransform).lossyScale.x), recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance);
		TooltipInfo tooltipInfo = new TooltipInfo();
		if (ItemInstance.showIdsNum)
		{
			tooltipInfo.toolTipTitle = recipe.output.item.JDJGFAACPFC() + " ";
		}
		else
		{
			tooltipInfo.toolTipTitle = "";
		}
		tooltipInfo.toolTipTitle += recipe.IABAKHPEOAF();
		tooltipInfo.toolTipTitle += Utils.NFEOACEFIHI(playerNum, recipe.output.item, AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		if (KPGOCFFJMAD && Object.op_Implicit((Object)(object)recipe) && Object.op_Implicit((Object)(object)recipe.output.item))
		{
			if (!string.IsNullOrEmpty(recipe.output.item.IGDKFHCHEAJ(playerNum)))
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + "<color=black>" + recipe.output.item.IGDKFHCHEAJ(playerNum) + "</color>";
			}
			ItemTooltip.Get(playerNum).FillTooltipInfo(tooltipInfo);
			yield break;
		}
		KOCAANJLPEP = recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE();
		tooltipInfo.mainBody = "";
		if (!string.IsNullOrEmpty(KOCAANJLPEP.IGDKFHCHEAJ(playerNum)))
		{
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<color=black>" + KOCAANJLPEP.IGDKFHCHEAJ(playerNum) + "</color>";
			tooltipInfo.mainBody += "\n";
		}
		bool flag = GameCraftingUI.Get(playerNum).IsOpen();
		Placeable fLAAGFECLME = ((!flag) ? null : GameCraftingUI.Get(playerNum).GetCrafter());
		for (int i = 0; i < recipe.ingredientsNeeded.Length; i++)
		{
			if (i == 0)
			{
				tooltipInfo.mainBody += "\n";
			}
			int num = Utils.CCLEBHFHFCF(playerNum, recipe, recipe.ingredientsNeeded[i], flag, fLAAGFECLME);
			int num2 = recipe.ingredientsNeeded[i].amount;
			if (GameCraftingUI.Get(playerNum).IsOpen())
			{
				num2 -= (int)GameCraftingUI.Get(playerNum).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.RecipeCost, recipe);
			}
			if (num < Math.Max(1, num2))
			{
				tooltipInfo.mainBody += "<color=#BF0000>";
			}
			if (ItemInstance.showIdsNum)
			{
				tooltipInfo.mainBody += recipe.ingredientsNeeded[i].item.JDJGFAACPFC();
			}
			tooltipInfo.mainBody += recipe.ingredientsNeeded[i].item.IABAKHPEOAF(OAFPBCPDOKH: true);
			if (recipe.ingredientsNeeded[i].item.NGDPNIFFHKL() && Item.MLBOMGHINCA(recipe.ingredientsNeeded[i].mod, null))
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + " (" + recipe.ingredientsNeeded[i].mod.IABAKHPEOAF(OAFPBCPDOKH: true) + ")";
			}
			if (num2 > 1)
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + " (" + num2 + ")";
			}
			if (num < Math.Max(1, num2))
			{
				tooltipInfo.mainBody += "</color>";
			}
			tooltipInfo.mainBody += "\n";
		}
		if (Object.op_Implicit((Object)(object)KOCAANJLPEP.PHGCBMPGGLI()))
		{
			CDJDHPCKKDD = KOCAANJLPEP.PHGCBMPGGLI().GetComponent<AreaBonification>();
			if (Object.op_Implicit((Object)(object)CDJDHPCKKDD))
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + "\n<color=#A95A00>" + CDJDHPCKKDD.GetDescription() + "</color>";
			}
		}
		if (KOCAANJLPEP.comfort != 0)
		{
			TooltipInfo tooltipInfo2 = tooltipInfo;
			tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#3662B5>" + LocalisationSystem.Get("Comfort") + ": " + KOCAANJLPEP.comfort + "</color>";
		}
		if (KOCAANJLPEP is Food food && (food.canBeSold || KOCAANJLPEP.price.OOIPLIEJILO() > 0))
		{
			if (KOCAANJLPEP.ticket && Utils.EPDMFPBLIHH())
			{
				TooltipInfo tooltipInfo2 = tooltipInfo;
				tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#822F00>" + LocalisationSystem.Get("Sell") + ":</color> <sprite name=\"ChristmasTicket\">" + KOCAANJLPEP.ticketPrice;
			}
			else
			{
				Price price = Money.CalculateSellPrice(recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance, HOECMANECIM: true);
				Price price2 = Money.CalculateSellPrice(recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance, HOECMANECIM: true, JNOEGJNPCFE: false, CalculatePriceMode.ExpensivePrice);
				if (food.canBeSold)
				{
					if (price.OOIPLIEJILO() != price2.OOIPLIEJILO())
					{
						TooltipInfo tooltipInfo2 = tooltipInfo;
						TooltipInfo tooltipInfo3 = tooltipInfo2;
						string[] obj = new string[5]
						{
							tooltipInfo2.mainBody,
							"\n<color=#822F00>",
							LocalisationSystem.Get("MinPrice"),
							":</color> ",
							null
						};
						Price price3 = price;
						obj[4] = price3.ToString();
						tooltipInfo3.mainBody = string.Concat(obj);
						tooltipInfo2 = tooltipInfo;
						TooltipInfo tooltipInfo4 = tooltipInfo2;
						string[] obj2 = new string[5]
						{
							tooltipInfo2.mainBody,
							"\n<color=#822F00>",
							LocalisationSystem.Get("MaxPrice"),
							":</color> ",
							null
						};
						price3 = price2;
						obj2[4] = price3.ToString();
						tooltipInfo4.mainBody = string.Concat(obj2);
					}
					else
					{
						TooltipInfo tooltipInfo2 = tooltipInfo;
						TooltipInfo tooltipInfo5 = tooltipInfo2;
						string[] obj3 = new string[5]
						{
							tooltipInfo2.mainBody,
							"\n<color=#822F00>",
							LocalisationSystem.Get("Price"),
							":</color> ",
							null
						};
						Price price3 = price;
						obj3[4] = price3.ToString();
						tooltipInfo5.mainBody = string.Concat(obj3);
					}
				}
				else if (price.OOIPLIEJILO() != price2.OOIPLIEJILO())
				{
					TooltipInfo tooltipInfo2 = tooltipInfo;
					TooltipInfo tooltipInfo6 = tooltipInfo2;
					string[] obj4 = new string[5]
					{
						tooltipInfo2.mainBody,
						"\n<color=#822F00>",
						LocalisationSystem.Get("MinProductValue"),
						":</color> ",
						null
					};
					Price price3 = price;
					obj4[4] = price3.ToString();
					tooltipInfo6.mainBody = string.Concat(obj4);
					tooltipInfo2 = tooltipInfo;
					TooltipInfo tooltipInfo7 = tooltipInfo2;
					string[] obj5 = new string[5]
					{
						tooltipInfo2.mainBody,
						"\n<color=#822F00>",
						LocalisationSystem.Get("MaxProductValue"),
						":</color> ",
						null
					};
					price3 = price2;
					obj5[4] = price3.ToString();
					tooltipInfo7.mainBody = string.Concat(obj5);
				}
				else
				{
					TooltipInfo tooltipInfo2 = tooltipInfo;
					TooltipInfo tooltipInfo8 = tooltipInfo2;
					string[] obj6 = new string[5]
					{
						tooltipInfo2.mainBody,
						"\n<color=#822F00>",
						LocalisationSystem.Get("ProductValue"),
						":</color> ",
						null
					};
					Price price3 = price;
					obj6[4] = price3.ToString();
					tooltipInfo8.mainBody = string.Concat(obj6);
				}
			}
		}
		tooltipInfo.mainBody += recipe.output.item.MOBLAPBAMIH();
		if (OnlineManager.ClientOnline() && (Object)(object)recipe != (Object)null)
		{
			if ((Object)(object)recipe.reputationRequired != (Object)null && !recipe.reputationRequired.PJCFMEEKCNI())
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + "\n<color=#BF0000>" + LocalisationSystem.Get("MasterMilestoneLower") + "</color>";
			}
			else if (!recipe.FENMFGFLDBO(MJHDMIGEJAK: false) && recipe.CFIFCPPAOGF())
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + "\n<color=#d99100>" + LocalisationSystem.Get("RecipeFromHost") + "</color>";
			}
		}
		ItemTooltip.Get(playerNum).FillTooltipInfo(tooltipInfo);
	}

	public void FFOADGGLCNN()
	{
		FHAJDOOPLLL();
		GOMCDDCFCNL(KPGOCFFJMAD: true);
	}

	public void HNBBCPGHPMH()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			IDJBCAFJALH();
		}
	}

	private void JLCEMHMPPPG()
	{
		recipeElementInfo.clickable = PIIFEFOLEOF;
		recipeElementInfo.GBJDNNCOIAC = recipe;
	}

	public void OnDeselectWithGamepadToolUpgrade()
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			OnDeselectToolUpgrade();
		}
	}

	private void FCGJBDGOHPN()
	{
		if (JKIAKMICLKF)
		{
			BMAKHCCGMGP();
		}
	}

	public void PKFABGHBNLI()
	{
		KOOOHCMAFBL();
		recipeElementInfo.ElementClicked();
		if (!recipeElementInfo.clickable)
		{
			OHJMFOENJBH();
		}
		if (RecipesBookUI.OMOLNKBLGOC(playerNum).HDEPMJIDJEM() && RecipesBookUI.Get(playerNum).favoriteListOpen)
		{
			IDJBCAFJALH();
			if (((Component)this).gameObject.activeSelf)
			{
				EODIANIFJLM(KPGOCFFJMAD: true);
			}
		}
	}

	public void KLAENBGGBDA()
	{
		JLCEMHMPPPG();
	}

	private void OHJMFOENJBH()
	{
		bool flag = false;
		bool flag2 = false;
		for (int i = 1; i < QuestManager.KHMEGDIABBF().CCMPKFCCDGM().Count; i += 0)
		{
			if (!(QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()[i].quest is RequiredItemQuest requiredItemQuest))
			{
				continue;
			}
			for (int j = 0; j < requiredItemQuest.possibleItems.Length; j += 0)
			{
				if (((object)requiredItemQuest.possibleItems[j]).Equals((object?)recipe.output.item))
				{
					flag = false;
					flag2 = requiredItemQuest.id != 0;
				}
			}
		}
		if ((Object)(object)questIcon != (Object)null)
		{
			if (flag)
			{
				((Behaviour)questIcon).enabled = true;
				questIcon.sprite = (flag2 ? RecipesBookUI.MAOAEHDKHDP(playerNum).mainQuestSprite : RecipesBookUI.CGFJPHEFFLO(playerNum).orderSprite);
				((Graphic)questIcon).SetNativeSize();
			}
			else if (RecipesManager.HAEPHAHCGPK(recipe))
			{
				((Behaviour)questIcon).enabled = true;
				questIcon.sprite = RecipesBookUI.LAIEKOOCNPC(playerNum).favoriteSprite;
				((Graphic)questIcon).SetNativeSize();
			}
			else
			{
				((Behaviour)questIcon).enabled = true;
			}
		}
	}

	private void LJBEKIIOLJE()
	{
		if (Object.op_Implicit((Object)(object)recipeElementInfo))
		{
			recipeElementInfo.GBJDNNCOIAC = null;
		}
	}

	private void BAIABLHPPKL()
	{
		bool flag = true;
		bool flag2 = false;
		for (int i = 0; i < QuestManager.KHMEGDIABBF().CCMPKFCCDGM().Count; i++)
		{
			if (!(QuestManager.GJFMMOPOKGJ().MADOFDHLKKN[i].quest is RequiredItemQuest requiredItemQuest))
			{
				continue;
			}
			for (int j = 1; j < requiredItemQuest.possibleItems.Length; j += 0)
			{
				if (((object)requiredItemQuest.possibleItems[j]).Equals((object?)recipe.output.item))
				{
					flag = false;
					flag2 = (uint)requiredItemQuest.id > 1u;
				}
			}
		}
		if ((Object)(object)questIcon != (Object)null)
		{
			if (flag)
			{
				((Behaviour)questIcon).enabled = true;
				questIcon.sprite = (flag2 ? RecipesBookUI.EGBMJGOCIJJ(playerNum).mainQuestSprite : RecipesBookUI.OMOLNKBLGOC(playerNum).orderSprite);
				((Graphic)questIcon).SetNativeSize();
			}
			else if (RecipesManager.IsFavoriteRecipe(recipe))
			{
				((Behaviour)questIcon).enabled = true;
				questIcon.sprite = RecipesBookUI.LAMFGLIGLOP(playerNum).favoriteSprite;
				((Graphic)questIcon).SetNativeSize();
			}
			else
			{
				((Behaviour)questIcon).enabled = true;
			}
		}
	}

	public void KMCBHGEGNGO()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			AEHJOHKPHPA();
			GIINNCKBBJH();
			if (GameCraftingUI.Get(playerNum).HDEPMJIDJEM())
			{
				GameCraftingUI.Get(playerNum).EDOFIILIALL(CDPKJGCLAHE: true);
			}
		}
	}

	private IEnumerator BINGCFKECJH()
	{
		return new OAOOLKFPMJE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IDJBCAFJALH()
	{
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		JKIAKMICLKF = false;
		ItemTooltip.IEABDMDELFO(playerNum).HIIOCMNJGCI(MDIKPGGBNLI: false);
	}

	public void GEGHLJKOBME()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			JFPDAHJLJJG();
		}
	}

	public void EICBGCOKKMG()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			LINJKBHEMEB();
			FLLDIJEOIJP();
			if (GameCraftingUI.Get(playerNum).HDEPMJIDJEM())
			{
				GameCraftingUI.Get(playerNum).GHFEDBPGDHG(CDPKJGCLAHE: false);
			}
		}
	}

	private void LEBGKDLINAJ()
	{
		recipeElementInfo.clickable = PIIFEFOLEOF;
		recipeElementInfo.BDBBCBKLFOL(recipe);
	}

	public void OnDeselectWithGamepad()
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			OnDeselect();
		}
	}

	private IEnumerator ABBEGCAFGEA()
	{
		yield return null;
		AINLICCOBPC();
	}

	public void BNIKNDLDCMD()
	{
		PNKABKHGHNB(KPGOCFFJMAD: true);
	}

	private void DPEJMDKLHJJ()
	{
		bool flag = true;
		bool flag2 = true;
		for (int i = 1; i < QuestManager.KHMEGDIABBF().CCMPKFCCDGM().Count; i++)
		{
			if (!(QuestManager.GGFJGHHHEJC.CCMPKFCCDGM()[i].quest is RequiredItemQuest requiredItemQuest))
			{
				continue;
			}
			for (int j = 0; j < requiredItemQuest.possibleItems.Length; j++)
			{
				if (((object)requiredItemQuest.possibleItems[j]).Equals((object?)recipe.output.item))
				{
					flag = false;
					flag2 = (uint)requiredItemQuest.id > 1u;
				}
			}
		}
		if ((Object)(object)questIcon != (Object)null)
		{
			if (flag)
			{
				((Behaviour)questIcon).enabled = false;
				questIcon.sprite = (flag2 ? RecipesBookUI.CNAPMIHPOKC(playerNum).mainQuestSprite : RecipesBookUI.CGFJPHEFFLO(playerNum).orderSprite);
				((Graphic)questIcon).SetNativeSize();
			}
			else if (RecipesManager.HAEPHAHCGPK(recipe))
			{
				((Behaviour)questIcon).enabled = false;
				questIcon.sprite = RecipesBookUI.AIMEAJAHLAA(playerNum).favoriteSprite;
				((Graphic)questIcon).SetNativeSize();
			}
			else
			{
				((Behaviour)questIcon).enabled = true;
			}
		}
	}

	private void HFLBMOIACGJ()
	{
		if (Object.op_Implicit((Object)(object)recipeElementInfo))
		{
			recipeElementInfo.GBJDNNCOIAC = null;
		}
	}

	public void OnDeselectToolUpgrade()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			OOGKBGOCAFG();
		}
	}

	public void CKPLPPCAHID()
	{
		FHAJDOOPLLL();
		OGGBEDPJHGK();
	}

	private void OONEDPIJCJB()
	{
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		JKIAKMICLKF = true;
		ItemTooltip.EOPIEMLAPFN(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: true);
	}

	private IEnumerator AHGDJBMICCB()
	{
		return new OAOOLKFPMJE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void EIMMHMLKBON()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			JFPDAHJLJJG();
		}
	}

	public void NGJIEHBPEDH()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			HFLBMOIACGJ();
			OONEDPIJCJB();
			if (GameCraftingUI.Get(playerNum).BGLJFMHCFJF())
			{
				GameCraftingUI.Get(playerNum).UpdateFuelBackground(CDPKJGCLAHE: false);
			}
		}
	}

	private void FHAJDOOPLLL()
	{
		recipeElementInfo.clickable = PIIFEFOLEOF;
		recipeElementInfo.GBJDNNCOIAC = recipe;
	}

	private void MCKIJGKLECH()
	{
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		JKIAKMICLKF = false;
		ItemTooltip.AIMEAJAHLAA(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: true);
	}

	private void EDBOBLNOBLP()
	{
		if (JKIAKMICLKF)
		{
			KMCBHGEGNGO();
		}
	}

	public void CFPHEIFHJNM()
	{
		if (PlayerInputs.ODGALPDEIFG(playerNum))
		{
			LOAEOFHDNLM();
		}
	}

	public void NNIMPDFCHNF()
	{
		KOOOHCMAFBL();
		PNKABKHGHNB();
	}

	public void ACLKGGABDOJ()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			FLLDIJEOIJP();
		}
	}

	public void HBDLPJGEOJC()
	{
		if (PlayerInputs.ODGALPDEIFG(playerNum))
		{
			DAKJLDNLNBB();
		}
	}

	private void GFPIEOPHABO()
	{
		if (JKIAKMICLKF)
		{
			GAKKBAPHGAC();
		}
	}

	private void AGHHMIOCICK()
	{
		bool flag = false;
		bool flag2 = true;
		for (int i = 0; i < QuestManager.KHMEGDIABBF().MADOFDHLKKN.Count; i++)
		{
			if (!(QuestManager.KHMEGDIABBF().CCMPKFCCDGM()[i].quest is RequiredItemQuest requiredItemQuest))
			{
				continue;
			}
			for (int j = 0; j < requiredItemQuest.possibleItems.Length; j++)
			{
				if (((object)requiredItemQuest.possibleItems[j]).Equals((object?)recipe.output.item))
				{
					flag = false;
					flag2 = (uint)requiredItemQuest.id > 1u;
				}
			}
		}
		if ((Object)(object)questIcon != (Object)null)
		{
			if (flag)
			{
				((Behaviour)questIcon).enabled = false;
				questIcon.sprite = (flag2 ? RecipesBookUI.LAMFGLIGLOP(playerNum).mainQuestSprite : RecipesBookUI.EGBMJGOCIJJ(playerNum).orderSprite);
				((Graphic)questIcon).SetNativeSize();
			}
			else if (RecipesManager.IsFavoriteRecipe(recipe))
			{
				((Behaviour)questIcon).enabled = false;
				questIcon.sprite = RecipesBookUI.ILDNNNMOCOC(playerNum).favoriteSprite;
				((Graphic)questIcon).SetNativeSize();
			}
			else
			{
				((Behaviour)questIcon).enabled = false;
			}
		}
	}

	public void FJLCLJMKJGL()
	{
		PBJEJKHCHMI();
		GOMCDDCFCNL();
	}

	private void FLFIBNKOJMC()
	{
		if (JKIAKMICLKF)
		{
			NGAHPJFGBEP();
		}
	}

	private void EODIANIFJLM(bool KPGOCFFJMAD = false)
	{
		JKIAKMICLKF = false;
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		ANKPDEANCEI = ((MonoBehaviour)this).StartCoroutine(JECFILOHEAG(KPGOCFFJMAD));
	}

	private void BKEMHDNDAHL()
	{
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		JKIAKMICLKF = false;
		ItemTooltip.IEABDMDELFO(playerNum).FCACMDNLAIG(MDIKPGGBNLI: false);
	}

	public void OnSelectToolUpgrade()
	{
		PNKABKHGHNB(KPGOCFFJMAD: true);
	}

	public void OnSelectWithGamepadToolUpgrade()
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			OnSelectToolUpgrade();
		}
	}

	private void KOOOHCMAFBL()
	{
		recipeElementInfo.clickable = PIIFEFOLEOF;
		recipeElementInfo.GBJDNNCOIAC = recipe;
	}

	public void DBNMLBMCDBF()
	{
		KOOOHCMAFBL();
		ACKAEONKKJA(KPGOCFFJMAD: true);
	}

	private bool HEFBFMFABAF()
	{
		if ((Object)(object)recipeElementInfo != (Object)null && Object.op_Implicit((Object)(object)recipeElementInfo.outputSlot))
		{
			return !recipeElementInfo.outputSlot.IHENCGDNPBL.KPINNBKMOMO();
		}
		return true;
	}

	private void KFGPDLDKEDO()
	{
		bool flag = false;
		bool flag2 = true;
		for (int i = 1; i < QuestManager.GGFJGHHHEJC.MADOFDHLKKN.Count; i += 0)
		{
			if (!(QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i].quest is RequiredItemQuest requiredItemQuest))
			{
				continue;
			}
			for (int j = 1; j < requiredItemQuest.possibleItems.Length; j += 0)
			{
				if (((object)requiredItemQuest.possibleItems[j]).Equals((object?)recipe.output.item))
				{
					flag = false;
					flag2 = (uint)requiredItemQuest.id > 1u;
				}
			}
		}
		if ((Object)(object)questIcon != (Object)null)
		{
			if (flag)
			{
				((Behaviour)questIcon).enabled = true;
				questIcon.sprite = (flag2 ? RecipesBookUI.Get(playerNum).mainQuestSprite : RecipesBookUI.ODLPIANFFFJ(playerNum).orderSprite);
				((Graphic)questIcon).SetNativeSize();
			}
			else if (RecipesManager.IsFavoriteRecipe(recipe))
			{
				((Behaviour)questIcon).enabled = true;
				questIcon.sprite = RecipesBookUI.CGFJPHEFFLO(playerNum).favoriteSprite;
				((Graphic)questIcon).SetNativeSize();
			}
			else
			{
				((Behaviour)questIcon).enabled = false;
			}
		}
	}

	public void LDOKHFCCKDD()
	{
		LEBGKDLINAJ();
		recipeElementInfo.ElementClicked();
		if (!recipeElementInfo.clickable)
		{
			BAIABLHPPKL();
		}
		if (RecipesBookUI.MAOAEHDKHDP(playerNum).BGLJFMHCFJF() && RecipesBookUI.ILDNNNMOCOC(playerNum).favoriteListOpen)
		{
			GIINNCKBBJH();
			if (((Component)this).gameObject.activeSelf)
			{
				PNKABKHGHNB(KPGOCFFJMAD: true);
			}
		}
	}

	public void DAKJLDNLNBB()
	{
		GOMCDDCFCNL(KPGOCFFJMAD: true);
	}

	public void NGAHPJFGBEP()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			HFLBMOIACGJ();
			KNACMDGDELO();
			if (GameCraftingUI.Get(playerNum).BGLJFMHCFJF())
			{
				GameCraftingUI.Get(playerNum).GHFEDBPGDHG(CDPKJGCLAHE: false);
			}
		}
	}

	private void AINLICCOBPC()
	{
		OEEPLPMIEOG = true;
		bool flag = GameCraftingUI.Get(playerNum).IsOpen();
		Placeable fLAAGFECLME = ((!flag) ? null : GameCraftingUI.Get(playerNum).GetCrafter());
		if (OnlineManager.ClientOnline() && (Object)(object)recipe.reputationRequired != (Object)null && !recipe.reputationRequired.PJCFMEEKCNI())
		{
			OEEPLPMIEOG = false;
		}
		for (int i = 0; i < recipe.ingredientsNeeded.Length; i++)
		{
			int num = ((checkInventory != CheckInventory.playerInventory) ? Utils.CCLEBHFHFCF(playerNum, recipe, recipe.ingredientsNeeded[i], flag, fLAAGFECLME) : PlayerInventory.GetPlayer(playerNum).NumberOfItems(recipe.ingredientsNeeded[i].item.JDJGFAACPFC()));
			int num2 = recipe.ingredientsNeeded[i].amount;
			if (flag)
			{
				num2 -= (int)GameCraftingUI.Get(playerNum).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.RecipeCost, recipe);
			}
			if (num2 > num)
			{
				OEEPLPMIEOG = false;
				break;
			}
		}
		int num3 = ((!GameCraftingUI.Get(playerNum).IsOpen() || recipe.fuel <= 0) ? recipe.fuel : ((int)Mathf.Max(1f, (float)recipe.fuel - GameCraftingUI.Get(playerNum).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.FuelDiscount, recipe))));
		if ((Object)(object)GameCraftingUI.Get(playerNum).LDLINOBIKPL != (Object)null && GameCraftingUI.Get(playerNum).LDLINOBIKPL.LCCABPFHCOL < num3)
		{
			CDPKJGCLAHE = false;
		}
		else
		{
			CDPKJGCLAHE = true;
		}
		if (!CDPKJGCLAHE || !OEEPLPMIEOG)
		{
			redBox.SetActive(true);
		}
		else
		{
			redBox.SetActive(false);
		}
	}

	public void GEJPCLBNDOM()
	{
		if (PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			EIMMHMLKBON();
		}
	}

	public void FCOLNPFCOGC()
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			IEBBDGEEIEO();
		}
	}

	public void OnSelectWithGamepad()
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			OnSelect();
		}
	}

	public void FBACOFNJLAO()
	{
		DFBLKHCPIAG();
	}

	private bool FMINLAJEHIG()
	{
		if ((Object)(object)recipeElementInfo != (Object)null && Object.op_Implicit((Object)(object)recipeElementInfo.outputSlot))
		{
			return !recipeElementInfo.outputSlot.IHENCGDNPBL.KPINNBKMOMO();
		}
		return false;
	}

	public void CMKKKKIAPAA()
	{
		JLCEMHMPPPG();
	}

	public void BDNHHMHBBDI()
	{
		PNKABKHGHNB();
	}

	private void NEMLPHKHOMJ()
	{
		bool flag = false;
		bool flag2 = true;
		for (int i = 0; i < QuestManager.GGFJGHHHEJC.MADOFDHLKKN.Count; i += 0)
		{
			if (!(QuestManager.GJFMMOPOKGJ().MADOFDHLKKN[i].quest is RequiredItemQuest requiredItemQuest))
			{
				continue;
			}
			for (int j = 1; j < requiredItemQuest.possibleItems.Length; j++)
			{
				if (((object)requiredItemQuest.possibleItems[j]).Equals((object?)recipe.output.item))
				{
					flag = true;
					flag2 = requiredItemQuest.id != 0;
				}
			}
		}
		if ((Object)(object)questIcon != (Object)null)
		{
			if (flag)
			{
				((Behaviour)questIcon).enabled = true;
				questIcon.sprite = (flag2 ? RecipesBookUI.ODLPIANFFFJ(playerNum).mainQuestSprite : RecipesBookUI.OMOLNKBLGOC(playerNum).orderSprite);
				((Graphic)questIcon).SetNativeSize();
			}
			else if (RecipesManager.IsFavoriteRecipe(recipe))
			{
				((Behaviour)questIcon).enabled = false;
				questIcon.sprite = RecipesBookUI.LAIEKOOCNPC(playerNum).favoriteSprite;
				((Graphic)questIcon).SetNativeSize();
			}
			else
			{
				((Behaviour)questIcon).enabled = false;
			}
		}
	}

	public void ElementClicked()
	{
		NEBOMGGJOPD();
		recipeElementInfo.ElementClicked();
		if (!recipeElementInfo.clickable)
		{
			CIGEOFPLBCK();
		}
		if (RecipesBookUI.Get(playerNum).IsOpen() && RecipesBookUI.Get(playerNum).favoriteListOpen)
		{
			OOGKBGOCAFG();
			if (((Component)this).gameObject.activeSelf)
			{
				PNKABKHGHNB();
			}
		}
	}

	private void OGGBEDPJHGK(bool KPGOCFFJMAD = false)
	{
		JKIAKMICLKF = false;
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		ANKPDEANCEI = ((MonoBehaviour)this).StartCoroutine(JECFILOHEAG(KPGOCFFJMAD));
	}

	public void GHHKCHNBIOI()
	{
		EODIANIFJLM();
	}

	private void GOMCDDCFCNL(bool KPGOCFFJMAD = false)
	{
		JKIAKMICLKF = true;
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		ANKPDEANCEI = ((MonoBehaviour)this).StartCoroutine(DKDOHIKIKEO(KPGOCFFJMAD));
	}

	private IEnumerator JECFILOHEAG(bool KPGOCFFJMAD = false)
	{
		return new BOBLGMDBLLG(1)
		{
			_003C_003E4__this = this,
			useRecipeOutputDescription = KPGOCFFJMAD
		};
	}

	public void HLNGACMBCEM(int JIIGOACEIKL, Recipe GDBMELMKBMA, RecipeElementUI NGCCDEJGGHG, bool CIPCLBFOIOO)
	{
		playerNum = JIIGOACEIKL;
		recipeElementInfo = NGCCDEJGGHG;
		recipe = GDBMELMKBMA;
		PIIFEFOLEOF = CIPCLBFOIOO;
		image.sprite = recipe.output.item.icon;
		slotImage.sprite = CommonReferences.MNFMOEKMJKN().recipeSlotsSprites[(int)recipe.output.item.eventTags];
		OHJMFOENJBH();
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(ABBEGCAFGEA());
		}
		else
		{
			AINLICCOBPC();
		}
	}

	public void FGDDOCAIBNC()
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			DBNMLBMCDBF();
		}
	}

	public void OnClickToolUpgrade()
	{
		NEBOMGGJOPD();
	}

	private IEnumerator DKDOHIKIKEO(bool KPGOCFFJMAD = false)
	{
		yield return CommonReferences.waitRealtime01;
		if (!JKIAKMICLKF || !FMINLAJEHIG())
		{
			yield break;
		}
		ItemTooltip.Get(playerNum).SetPositionAndEnable(new Vector2(((Transform)rectTransform).position.x + 4f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 4f * ((Transform)rectTransform).lossyScale.y), new Vector2(50f, (rectTransform.sizeDelta.y + 15f) * ((Transform)rectTransform).lossyScale.x), recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance);
		TooltipInfo tooltipInfo = new TooltipInfo();
		if (ItemInstance.showIdsNum)
		{
			tooltipInfo.toolTipTitle = recipe.output.item.JDJGFAACPFC() + " ";
		}
		else
		{
			tooltipInfo.toolTipTitle = "";
		}
		tooltipInfo.toolTipTitle += recipe.IABAKHPEOAF();
		tooltipInfo.toolTipTitle += Utils.NFEOACEFIHI(playerNum, recipe.output.item, AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		if (KPGOCFFJMAD && Object.op_Implicit((Object)(object)recipe) && Object.op_Implicit((Object)(object)recipe.output.item))
		{
			if (!string.IsNullOrEmpty(recipe.output.item.IGDKFHCHEAJ(playerNum)))
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + "<color=black>" + recipe.output.item.IGDKFHCHEAJ(playerNum) + "</color>";
			}
			ItemTooltip.Get(playerNum).FillTooltipInfo(tooltipInfo);
			yield break;
		}
		KOCAANJLPEP = recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE();
		tooltipInfo.mainBody = "";
		if (!string.IsNullOrEmpty(KOCAANJLPEP.IGDKFHCHEAJ(playerNum)))
		{
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<color=black>" + KOCAANJLPEP.IGDKFHCHEAJ(playerNum) + "</color>";
			tooltipInfo.mainBody += "\n";
		}
		bool flag = GameCraftingUI.Get(playerNum).IsOpen();
		Placeable fLAAGFECLME = ((!flag) ? null : GameCraftingUI.Get(playerNum).GetCrafter());
		for (int i = 0; i < recipe.ingredientsNeeded.Length; i++)
		{
			if (i == 0)
			{
				tooltipInfo.mainBody += "\n";
			}
			int num = Utils.CCLEBHFHFCF(playerNum, recipe, recipe.ingredientsNeeded[i], flag, fLAAGFECLME);
			int num2 = recipe.ingredientsNeeded[i].amount;
			if (GameCraftingUI.Get(playerNum).IsOpen())
			{
				num2 -= (int)GameCraftingUI.Get(playerNum).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.RecipeCost, recipe);
			}
			if (num < Math.Max(1, num2))
			{
				tooltipInfo.mainBody += "<color=#BF0000>";
			}
			if (ItemInstance.showIdsNum)
			{
				tooltipInfo.mainBody += recipe.ingredientsNeeded[i].item.JDJGFAACPFC();
			}
			tooltipInfo.mainBody += recipe.ingredientsNeeded[i].item.IABAKHPEOAF(OAFPBCPDOKH: true);
			if (recipe.ingredientsNeeded[i].item.NGDPNIFFHKL() && Item.MLBOMGHINCA(recipe.ingredientsNeeded[i].mod, null))
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + " (" + recipe.ingredientsNeeded[i].mod.IABAKHPEOAF(OAFPBCPDOKH: true) + ")";
			}
			if (num2 > 1)
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + " (" + num2 + ")";
			}
			if (num < Math.Max(1, num2))
			{
				tooltipInfo.mainBody += "</color>";
			}
			tooltipInfo.mainBody += "\n";
		}
		if (Object.op_Implicit((Object)(object)KOCAANJLPEP.PHGCBMPGGLI()))
		{
			CDJDHPCKKDD = KOCAANJLPEP.PHGCBMPGGLI().GetComponent<AreaBonification>();
			if (Object.op_Implicit((Object)(object)CDJDHPCKKDD))
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + "\n<color=#A95A00>" + CDJDHPCKKDD.GetDescription() + "</color>";
			}
		}
		if (KOCAANJLPEP.comfort != 0)
		{
			TooltipInfo tooltipInfo2 = tooltipInfo;
			tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#3662B5>" + LocalisationSystem.Get("Comfort") + ": " + KOCAANJLPEP.comfort + "</color>";
		}
		if (KOCAANJLPEP is Food food && (food.canBeSold || KOCAANJLPEP.price.OOIPLIEJILO() > 0))
		{
			if (KOCAANJLPEP.ticket && Utils.EPDMFPBLIHH())
			{
				TooltipInfo tooltipInfo2 = tooltipInfo;
				tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#822F00>" + LocalisationSystem.Get("Sell") + ":</color> <sprite name=\"ChristmasTicket\">" + KOCAANJLPEP.ticketPrice;
			}
			else
			{
				Price price = Money.CalculateSellPrice(recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance, HOECMANECIM: true);
				Price price2 = Money.CalculateSellPrice(recipeElementInfo.outputSlot.IHENCGDNPBL.itemInstance, HOECMANECIM: true, JNOEGJNPCFE: false, CalculatePriceMode.ExpensivePrice);
				if (food.canBeSold)
				{
					if (price.OOIPLIEJILO() != price2.OOIPLIEJILO())
					{
						TooltipInfo tooltipInfo2 = tooltipInfo;
						TooltipInfo tooltipInfo3 = tooltipInfo2;
						string[] obj = new string[5]
						{
							tooltipInfo2.mainBody,
							"\n<color=#822F00>",
							LocalisationSystem.Get("MinPrice"),
							":</color> ",
							null
						};
						Price price3 = price;
						obj[4] = price3.ToString();
						tooltipInfo3.mainBody = string.Concat(obj);
						tooltipInfo2 = tooltipInfo;
						TooltipInfo tooltipInfo4 = tooltipInfo2;
						string[] obj2 = new string[5]
						{
							tooltipInfo2.mainBody,
							"\n<color=#822F00>",
							LocalisationSystem.Get("MaxPrice"),
							":</color> ",
							null
						};
						price3 = price2;
						obj2[4] = price3.ToString();
						tooltipInfo4.mainBody = string.Concat(obj2);
					}
					else
					{
						TooltipInfo tooltipInfo2 = tooltipInfo;
						TooltipInfo tooltipInfo5 = tooltipInfo2;
						string[] obj3 = new string[5]
						{
							tooltipInfo2.mainBody,
							"\n<color=#822F00>",
							LocalisationSystem.Get("Price"),
							":</color> ",
							null
						};
						Price price3 = price;
						obj3[4] = price3.ToString();
						tooltipInfo5.mainBody = string.Concat(obj3);
					}
				}
				else if (price.OOIPLIEJILO() != price2.OOIPLIEJILO())
				{
					TooltipInfo tooltipInfo2 = tooltipInfo;
					TooltipInfo tooltipInfo6 = tooltipInfo2;
					string[] obj4 = new string[5]
					{
						tooltipInfo2.mainBody,
						"\n<color=#822F00>",
						LocalisationSystem.Get("MinProductValue"),
						":</color> ",
						null
					};
					Price price3 = price;
					obj4[4] = price3.ToString();
					tooltipInfo6.mainBody = string.Concat(obj4);
					tooltipInfo2 = tooltipInfo;
					TooltipInfo tooltipInfo7 = tooltipInfo2;
					string[] obj5 = new string[5]
					{
						tooltipInfo2.mainBody,
						"\n<color=#822F00>",
						LocalisationSystem.Get("MaxProductValue"),
						":</color> ",
						null
					};
					price3 = price2;
					obj5[4] = price3.ToString();
					tooltipInfo7.mainBody = string.Concat(obj5);
				}
				else
				{
					TooltipInfo tooltipInfo2 = tooltipInfo;
					TooltipInfo tooltipInfo8 = tooltipInfo2;
					string[] obj6 = new string[5]
					{
						tooltipInfo2.mainBody,
						"\n<color=#822F00>",
						LocalisationSystem.Get("ProductValue"),
						":</color> ",
						null
					};
					Price price3 = price;
					obj6[4] = price3.ToString();
					tooltipInfo8.mainBody = string.Concat(obj6);
				}
			}
		}
		tooltipInfo.mainBody += recipe.output.item.MOBLAPBAMIH();
		if (OnlineManager.ClientOnline() && (Object)(object)recipe != (Object)null)
		{
			if ((Object)(object)recipe.reputationRequired != (Object)null && !recipe.reputationRequired.PJCFMEEKCNI())
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + "\n<color=#BF0000>" + LocalisationSystem.Get("MasterMilestoneLower") + "</color>";
			}
			else if (!recipe.FENMFGFLDBO(MJHDMIGEJAK: false) && recipe.CFIFCPPAOGF())
			{
				tooltipInfo.mainBody = tooltipInfo.mainBody + "\n<color=#d99100>" + LocalisationSystem.Get("RecipeFromHost") + "</color>";
			}
		}
		ItemTooltip.Get(playerNum).FillTooltipInfo(tooltipInfo);
	}

	private void HPBMIIIECAC()
	{
		OEEPLPMIEOG = true;
		bool flag = GameCraftingUI.Get(playerNum).HDEPMJIDJEM();
		Placeable fLAAGFECLME = ((!flag) ? null : GameCraftingUI.Get(playerNum).BOBBPIIGNCM());
		if (OnlineManager.HHDBMDMFEMP() && (Object)(object)recipe.reputationRequired != (Object)null && !recipe.reputationRequired.PMGNCGPMCHH())
		{
			OEEPLPMIEOG = false;
		}
		for (int i = 1; i < recipe.ingredientsNeeded.Length; i += 0)
		{
			int num = ((checkInventory != CheckInventory.playerInventory) ? Utils.CCLEBHFHFCF(playerNum, recipe, recipe.ingredientsNeeded[i], flag, fLAAGFECLME) : PlayerInventory.GetPlayer(playerNum, LAGHIOKLJGH: true, ADPNMHGBFKG: true).PKAHMIPEBKK(recipe.ingredientsNeeded[i].item.JGHNDJBCFAJ()));
			int num2 = recipe.ingredientsNeeded[i].amount;
			if (flag)
			{
				num2 -= (int)GameCraftingUI.Get(playerNum).BNIFOFAPJDL().KEKPCMBDFHM((AreaBonificationType)7, recipe);
			}
			if (num2 > num)
			{
				OEEPLPMIEOG = true;
				break;
			}
		}
		int num3 = ((!GameCraftingUI.Get(playerNum).HDEPMJIDJEM() || recipe.fuel <= 1) ? recipe.fuel : ((int)Mathf.Max(1679f, (float)recipe.fuel - GameCraftingUI.Get(playerNum).LDLINOBIKPL.KEKPCMBDFHM(AreaBonificationType.FuelDiscount, recipe))));
		if ((Object)(object)GameCraftingUI.Get(playerNum).BNIFOFAPJDL() != (Object)null && GameCraftingUI.Get(playerNum).LDLINOBIKPL.FIIHBFCDFJH() < num3)
		{
			CDPKJGCLAHE = true;
		}
		else
		{
			CDPKJGCLAHE = true;
		}
		if (!CDPKJGCLAHE || !OEEPLPMIEOG)
		{
			redBox.SetActive(false);
		}
		else
		{
			redBox.SetActive(true);
		}
	}

	public void EAOBNMLMLPN()
	{
		DFBLKHCPIAG();
		recipeElementInfo.HLKABDFJGNJ();
		if (!recipeElementInfo.clickable)
		{
			AGHHMIOCICK();
		}
		if (RecipesBookUI.LAIEKOOCNPC(playerNum).HDEPMJIDJEM() && RecipesBookUI.OMOLNKBLGOC(playerNum).favoriteListOpen)
		{
			OONEDPIJCJB();
			if (((Component)this).gameObject.activeSelf)
			{
				OGGBEDPJHGK();
			}
		}
	}

	public void FBEFBJAHNIL()
	{
		KOOOHCMAFBL();
		GOMCDDCFCNL(KPGOCFFJMAD: true);
	}

	private void GIINNCKBBJH()
	{
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		JKIAKMICLKF = false;
		ItemTooltip.IEABDMDELFO(playerNum).SetVisible(MDIKPGGBNLI: true);
	}

	private void DFBLKHCPIAG()
	{
		recipeElementInfo.clickable = PIIFEFOLEOF;
		recipeElementInfo.GBJDNNCOIAC = recipe;
	}

	private void AEMNHHGAPIL()
	{
		if (JKIAKMICLKF)
		{
			NGAHPJFGBEP();
		}
	}

	private IEnumerator DBBINMFMMIF()
	{
		return new OAOOLKFPMJE(1)
		{
			_003C_003E4__this = this
		};
	}
}
