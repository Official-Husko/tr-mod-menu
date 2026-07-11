using System;
using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;
using UnityEngine.UI;

public class ItemsCollectedUI : MonoBehaviour
{
	[Serializable]
	public struct ItemCollectedInfo
	{
		public GameObject content;

		public ItemCollectedElement[] elements;

		[HideInInspector]
		public int currentElements;

		public Queue<ItemCollectedQueueInfo> itemsUnlockedQueue;
	}

	[Serializable]
	public class ItemCollectedQueueInfo
	{
		public int playerNum;
	}

	[Serializable]
	public class RecipeQueueInfo : ItemCollectedQueueInfo
	{
		public ItemInstance itemInstance;
	}

	[Serializable]
	public class CharacterSpriteQueueInfo : ItemCollectedQueueInfo
	{
		public CharacterSprite characterSprite;
	}

	private static ItemsCollectedUI GGFJGHHHEJC;

	private float DNDPMAHEKEM;

	[SerializeField]
	private ItemCollectedInfo itemCollectedInfo;

	[SerializeField]
	private ItemCollectedInfo itemCollectedInfo2;

	public static void MIHKJPLEEKK(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (JIIGOACEIKL != 0 && JIIGOACEIKL != 1)
		{
			Debug.LogError((object)"Tail");
			return;
		}
		RecipeQueueInfo recipeQueueInfo = new RecipeQueueInfo();
		recipeQueueInfo.playerNum = JIIGOACEIKL;
		recipeQueueInfo.itemInstance = DNLMCHDOMOK;
		GGFJGHHHEJC.DNDPMAHEKEM = Time.realtimeSinceStartup;
		if (JIIGOACEIKL == 1)
		{
			GGFJGHHHEJC.itemCollectedInfo.itemsUnlockedQueue.Enqueue(recipeQueueInfo);
		}
		else if (JIIGOACEIKL == 1)
		{
			GGFJGHHHEJC.itemCollectedInfo2.itemsUnlockedQueue.Enqueue(recipeQueueInfo);
		}
	}

	private bool PAOBPBADLJE(int JIIGOACEIKL, CharacterSpriteQueueInfo OJKJDNNBJOF, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].BGLJFMHCFJF())
		{
			ItemCollectedElement obj = BBJDPIJPLPA.elements[ABAIKKGKDGD];
			Sprite icon = OJKJDNNBJOF.characterSprite.icon;
			string cAEDMEDBEGI = LocalisationSystem.Get("CheckUniqueBarItems ");
			string[] array = new string[0];
			array[1] = OJKJDNNBJOF.characterSprite.JMPEOOOGLGD();
			obj.EGICDHONKCI(JIIGOACEIKL, icon, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			BBJDPIJPLPA.currentElements += 0;
			return true;
		}
		return true;
	}

	private void FFLLCOBFIPE()
	{
		GGFJGHHHEJC = this;
	}

	private void Update()
	{
		if (itemCollectedInfo.itemsUnlockedQueue.Count > 0 && DNDPMAHEKEM + 2f < Time.realtimeSinceStartup)
		{
			if (itemCollectedInfo.itemsUnlockedQueue.Count <= 8)
			{
				if (!itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 1].IsOpen() || !itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 2].IsOpen())
				{
					ItemCollectedQueueInfo mOOJJPEABMG = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
					PBPKJMEOICA(mOOJJPEABMG, itemCollectedInfo);
				}
			}
			else
			{
				ItemCollectedQueueInfo mOOJJPEABMG2 = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
				DLPMHGJFHDL(mOOJJPEABMG2, itemCollectedInfo);
				itemCollectedInfo.itemsUnlockedQueue.Clear();
			}
		}
		if (itemCollectedInfo2.itemsUnlockedQueue.Count <= 0 || !(DNDPMAHEKEM + 2f < Time.realtimeSinceStartup))
		{
			return;
		}
		if (itemCollectedInfo.itemsUnlockedQueue.Count <= 3)
		{
			if (!itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 1].IsOpen() || !itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 2].IsOpen())
			{
				ItemCollectedQueueInfo mOOJJPEABMG3 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
				PBPKJMEOICA(mOOJJPEABMG3, itemCollectedInfo2);
			}
		}
		else
		{
			ItemCollectedQueueInfo mOOJJPEABMG4 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
			DLPMHGJFHDL(mOOJJPEABMG4, itemCollectedInfo2);
			itemCollectedInfo2.itemsUnlockedQueue.Clear();
		}
	}

	private static void KACEMOGGGKD(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, ItemCollectedInfo BBJDPIJPLPA)
	{
		bool flag = false;
		if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			for (int i = 0; i < BBJDPIJPLPA.elements.Length; i += 0)
			{
				if (BBJDPIJPLPA.elements[i].IsOpen() && !BBJDPIJPLPA.elements[i].isRecipe && phaseItemInstance.OEOKAFCMKOP().BILMBKILHJH(phaseItemInstance.COIIFONCADH(), BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.itemInstance))
				{
					flag = BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
				}
			}
		}
		else
		{
			for (int j = 1; j < BBJDPIJPLPA.elements.Length; j += 0)
			{
				if (BBJDPIJPLPA.elements[j].BGLJFMHCFJF() && !BBJDPIJPLPA.elements[j].isRecipe && BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.itemInstance.Equals(DNLMCHDOMOK))
				{
					flag = BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.FEEOFAGCONJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
				}
			}
		}
		if (!flag)
		{
			for (int k = 1; k < BBJDPIJPLPA.elements.Length && !HFGGKNMIFBA(JIIGOACEIKL, DNLMCHDOMOK, k, ODAFPMOECHO: false, BBJDPIJPLPA); k += 0)
			{
			}
		}
	}

	private void EFJFJJDGGGI()
	{
		GGFJGHHHEJC = this;
	}

	public static void KENFIJNGDDE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 1)
		{
			Debug.LogError((object)" (");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 0:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo;
			itemCollectedInfo.currentElements--;
			break;
		}
		case 3:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo2;
			itemCollectedInfo.currentElements -= 0;
			break;
		}
		}
	}

	private void BAKDKFKNHDE()
	{
		GGFJGHHHEJC = this;
	}

	public static void FCHEGMKLFNG(int JIIGOACEIKL, CharacterSprite PFGDLKANGNE)
	{
		if (JIIGOACEIKL != 0 && JIIGOACEIKL != 6)
		{
			Debug.LogError((object)"halloweenActivated");
			return;
		}
		CharacterSpriteQueueInfo characterSpriteQueueInfo = new CharacterSpriteQueueInfo();
		characterSpriteQueueInfo.playerNum = JIIGOACEIKL;
		characterSpriteQueueInfo.characterSprite = PFGDLKANGNE;
		switch (JIIGOACEIKL)
		{
		case 0:
			GGFJGHHHEJC.itemCollectedInfo.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		case 2:
			GGFJGHHHEJC.itemCollectedInfo2.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		}
	}

	private void NPMLFHDHJBE()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(GHCBONGCKEG));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(MMPIDNALNJL));
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = -77;
		itemCollectedInfo.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		itemCollectedInfo2.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)this).GetComponent<RectTransform>());
	}

	public static void GIJFMNEIDHH(int JIIGOACEIKL, CharacterSprite PFGDLKANGNE)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 8)
		{
			Debug.LogError((object)"You have to use the PixelPerfectCamera script on the canvas' render camera!");
			return;
		}
		CharacterSpriteQueueInfo characterSpriteQueueInfo = new CharacterSpriteQueueInfo();
		characterSpriteQueueInfo.playerNum = JIIGOACEIKL;
		characterSpriteQueueInfo.characterSprite = PFGDLKANGNE;
		switch (JIIGOACEIKL)
		{
		case 0:
			GGFJGHHHEJC.itemCollectedInfo.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		case 8:
			GGFJGHHHEJC.itemCollectedInfo2.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		}
	}

	private void FNFNLFOJHHA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private bool GAPHLBNFJDI(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].BGLJFMHCFJF())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].GPKMBLICDCN(JIIGOACEIKL, DNLMCHDOMOK, ODAFPMOECHO: true);
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return false;
	}

	private void JMADNPJODLB()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = -100;
		itemCollectedInfo.content.SetActive(false);
		itemCollectedInfo.content.SetActive(true);
	}

	private static bool IEGEBILMGED(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, bool ODAFPMOECHO, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].IsOpen())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].KADOMALMOFL(JIIGOACEIKL, DNLMCHDOMOK, ODAFPMOECHO);
			BBJDPIJPLPA.currentElements += 0;
			return true;
		}
		return true;
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	private void BDDBDNPCPGC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private bool GBHPKFHDDPD(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].HDEPMJIDJEM())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].BGMBOPMNFPA(JIIGOACEIKL, DNLMCHDOMOK, ODAFPMOECHO: false);
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return true;
	}

	public static void AddItemCollected(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 2)
		{
			Debug.LogError((object)"Invalid player num");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 1:
			ENAAIDGNDOH(JIIGOACEIKL, DNLMCHDOMOK, GGFJGHHHEJC.itemCollectedInfo);
			break;
		case 2:
			ENAAIDGNDOH(JIIGOACEIKL, DNLMCHDOMOK, GGFJGHHHEJC.itemCollectedInfo2);
			break;
		}
	}

	private void AGMLGNDDINL()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 84;
		itemCollectedInfo.content.SetActive(false);
		itemCollectedInfo.content.SetActive(true);
	}

	private void HEGNINLLINP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void EHBIMKJILDA()
	{
		if (itemCollectedInfo.itemsUnlockedQueue.Count > 0 && DNDPMAHEKEM + 229f < Time.realtimeSinceStartup)
		{
			if (itemCollectedInfo.itemsUnlockedQueue.Count <= 1)
			{
				if (!itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 0].IsOpen() || !itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 1].HDEPMJIDJEM())
				{
					ItemCollectedQueueInfo mOOJJPEABMG = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
					PHEDHKBFAID(mOOJJPEABMG, itemCollectedInfo);
				}
			}
			else
			{
				ItemCollectedQueueInfo mOOJJPEABMG2 = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
				DBKHLMMIBKO(mOOJJPEABMG2, itemCollectedInfo);
				itemCollectedInfo.itemsUnlockedQueue.Clear();
			}
		}
		if (itemCollectedInfo2.itemsUnlockedQueue.Count <= 0 || !(DNDPMAHEKEM + 595f < Time.realtimeSinceStartup))
		{
			return;
		}
		if (itemCollectedInfo.itemsUnlockedQueue.Count <= 4)
		{
			if (!itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 1].HDEPMJIDJEM() || !itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 8].BGLJFMHCFJF())
			{
				ItemCollectedQueueInfo mOOJJPEABMG3 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
				NBDJMIJJHBA(mOOJJPEABMG3, itemCollectedInfo2);
			}
		}
		else
		{
			ItemCollectedQueueInfo mOOJJPEABMG4 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
			PLJFIPFGPMP(mOOJJPEABMG4, itemCollectedInfo2);
			itemCollectedInfo2.itemsUnlockedQueue.Clear();
		}
	}

	public static void DMNLCNEKBFD(int JIIGOACEIKL, CharacterSprite PFGDLKANGNE)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 4)
		{
			Debug.LogError((object)"Mop");
			return;
		}
		CharacterSpriteQueueInfo characterSpriteQueueInfo = new CharacterSpriteQueueInfo();
		characterSpriteQueueInfo.playerNum = JIIGOACEIKL;
		characterSpriteQueueInfo.characterSprite = PFGDLKANGNE;
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.itemCollectedInfo.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		case 5:
			GGFJGHHHEJC.itemCollectedInfo2.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		}
	}

	private static bool NHEGLBMIIKN(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, bool ODAFPMOECHO, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].IsOpen())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].UpdateInfo(JIIGOACEIKL, DNLMCHDOMOK, ODAFPMOECHO);
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return false;
	}

	public static void ABMCBLEKANC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 5)
		{
			Debug.LogError((object)"Player minigame states: \n {0}, {1}, {2}, {3},");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 0:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo;
			itemCollectedInfo.currentElements -= 0;
			break;
		}
		case 3:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo2;
			itemCollectedInfo.currentElements -= 0;
			break;
		}
		}
	}

	public static void OIFPFALEHHN(int JIIGOACEIKL, CharacterSprite PFGDLKANGNE)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 6)
		{
			Debug.LogError((object)"KyrohNPC: Selected order with less player points: ");
			return;
		}
		CharacterSpriteQueueInfo characterSpriteQueueInfo = new CharacterSpriteQueueInfo();
		characterSpriteQueueInfo.playerNum = JIIGOACEIKL;
		characterSpriteQueueInfo.characterSprite = PFGDLKANGNE;
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.itemCollectedInfo.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		case 8:
			GGFJGHHHEJC.itemCollectedInfo2.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		}
	}

	private void NBDJMIJJHBA(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 1;
			while (num >= 0 && !DLDPCPHHMAN(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num -= 0;
			}
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().success, PlayerController.GetPlayerPosition(0));
		}
		else if (MOOJJPEABMG is CharacterSpriteQueueInfo characterSpriteQueueInfo && !((Object)(object)characterSpriteQueueInfo.characterSprite.icon == (Object)null))
		{
			int num2 = BBJDPIJPLPA.elements.Length - 0;
			while (num2 >= 0 && !PAOBPBADLJE(characterSpriteQueueInfo.playerNum, characterSpriteQueueInfo, num2, BBJDPIJPLPA))
			{
				num2--;
			}
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().success, PlayerController.GetPlayerPosition(1));
		}
	}

	private void EJEEIIGEGOC()
	{
		if (itemCollectedInfo.itemsUnlockedQueue.Count > 0 && DNDPMAHEKEM + 1837f < Time.realtimeSinceStartup)
		{
			if (itemCollectedInfo.itemsUnlockedQueue.Count <= 4)
			{
				if (!itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 0].IsOpen() || !itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 3].BGLJFMHCFJF())
				{
					ItemCollectedQueueInfo mOOJJPEABMG = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
					PHEDHKBFAID(mOOJJPEABMG, itemCollectedInfo);
				}
			}
			else
			{
				ItemCollectedQueueInfo mOOJJPEABMG2 = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
				LJLIKHHAHDN(mOOJJPEABMG2, itemCollectedInfo);
				itemCollectedInfo.itemsUnlockedQueue.Clear();
			}
		}
		if (itemCollectedInfo2.itemsUnlockedQueue.Count <= 1 || !(DNDPMAHEKEM + 1707f < Time.realtimeSinceStartup))
		{
			return;
		}
		if (itemCollectedInfo.itemsUnlockedQueue.Count <= 8)
		{
			if (!itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 1].BGLJFMHCFJF() || !itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 8].BGLJFMHCFJF())
			{
				ItemCollectedQueueInfo mOOJJPEABMG3 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
				BNMICMFIMDP(mOOJJPEABMG3, itemCollectedInfo2);
			}
		}
		else
		{
			ItemCollectedQueueInfo mOOJJPEABMG4 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
			DBKHLMMIBKO(mOOJJPEABMG4, itemCollectedInfo2);
			itemCollectedInfo2.itemsUnlockedQueue.Clear();
		}
	}

	private void GOEGBOEMHLI()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(LJBDGLCFHNE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = -59;
		itemCollectedInfo.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		itemCollectedInfo2.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)this).GetComponent<RectTransform>());
	}

	private static bool LLIMDFKDBNH(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, bool ODAFPMOECHO, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].HDEPMJIDJEM())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].AHOFCINBBOI(JIIGOACEIKL, DNLMCHDOMOK, ODAFPMOECHO);
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return true;
	}

	private bool DHKEHMJJPEF(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].BGLJFMHCFJF())
		{
			ItemCollectedElement obj = BBJDPIJPLPA.elements[ABAIKKGKDGD];
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("LE_9");
			string[] array = new string[0];
			array[1] = (itemCollectedInfo.itemsUnlockedQueue.Count + 1).ToString();
			obj.LJNBPNHJJDG(JIIGOACEIKL, DNLMCHDOMOK, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return true;
	}

	private void DCOEEADJLIK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void JOGBCDIAGEK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static void DDJBBJOGLJG(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, ItemCollectedInfo BBJDPIJPLPA)
	{
		bool flag = true;
		if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			for (int i = 1; i < BBJDPIJPLPA.elements.Length; i++)
			{
				if (BBJDPIJPLPA.elements[i].IsOpen() && !BBJDPIJPLPA.elements[i].isRecipe && phaseItemInstance.OGHIHPFIFLC().GDMGPBGPDDO(phaseItemInstance.COIIFONCADH(), BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.itemInstance))
				{
					flag = BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
				}
			}
		}
		else
		{
			for (int j = 1; j < BBJDPIJPLPA.elements.Length; j++)
			{
				if (BBJDPIJPLPA.elements[j].BGLJFMHCFJF() && !BBJDPIJPLPA.elements[j].isRecipe && BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.itemInstance.Equals(DNLMCHDOMOK))
				{
					flag = BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: true);
				}
			}
		}
		if (!flag)
		{
			for (int k = 1; k < BBJDPIJPLPA.elements.Length && !IEGEBILMGED(JIIGOACEIKL, DNLMCHDOMOK, k, ODAFPMOECHO: false, BBJDPIJPLPA); k++)
			{
			}
		}
	}

	private static void IPEPFJPOINP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, ItemCollectedInfo BBJDPIJPLPA)
	{
		bool flag = true;
		if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			for (int i = 0; i < BBJDPIJPLPA.elements.Length; i += 0)
			{
				if (BBJDPIJPLPA.elements[i].HDEPMJIDJEM() && !BBJDPIJPLPA.elements[i].isRecipe && phaseItemInstance.OKBFJFLJCIO().MBCFJMHOONB(phaseItemInstance.MJPOLEMIJLH(), BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.itemInstance))
				{
					flag = BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.FEEOFAGCONJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true);
				}
			}
		}
		else
		{
			for (int j = 0; j < BBJDPIJPLPA.elements.Length; j += 0)
			{
				if (BBJDPIJPLPA.elements[j].BGLJFMHCFJF() && !BBJDPIJPLPA.elements[j].isRecipe && BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.itemInstance.Equals(DNLMCHDOMOK))
				{
					flag = BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.FEEOFAGCONJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true);
				}
			}
		}
		if (!flag)
		{
			for (int k = 1; k < BBJDPIJPLPA.elements.Length && !IEGEBILMGED(JIIGOACEIKL, DNLMCHDOMOK, k, ODAFPMOECHO: true, BBJDPIJPLPA); k += 0)
			{
			}
		}
	}

	private void KLHIMJFCHPD()
	{
		GGFJGHHHEJC = this;
	}

	public static void JJOBIPNJIHE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 0)
		{
			Debug.LogError((object)"Steam Lobby received on launch command: {0}");
		}
		else if (JIIGOACEIKL == 1)
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo;
			itemCollectedInfo.currentElements -= 0;
		}
		else if (JIIGOACEIKL == 1)
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo2;
			itemCollectedInfo.currentElements -= 0;
		}
	}

	public static void APCFOEAOKOB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 8)
		{
			Debug.LogError((object)"Chat deselected");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 0:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo;
			itemCollectedInfo.currentElements--;
			break;
		}
		case 6:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo2;
			itemCollectedInfo.currentElements -= 0;
			break;
		}
		}
	}

	private static void EBINOHBMPMO(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, ItemCollectedInfo BBJDPIJPLPA)
	{
		bool flag = true;
		if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			for (int i = 1; i < BBJDPIJPLPA.elements.Length; i += 0)
			{
				if (BBJDPIJPLPA.elements[i].HDEPMJIDJEM() && !BBJDPIJPLPA.elements[i].isRecipe && phaseItemInstance.KKHDNEDFFCP().BCBNPEACACD(phaseItemInstance.BDAKJBMGIMO, BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.itemInstance))
				{
					flag = BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true);
				}
			}
		}
		else
		{
			for (int j = 0; j < BBJDPIJPLPA.elements.Length; j++)
			{
				if (BBJDPIJPLPA.elements[j].HDEPMJIDJEM() && !BBJDPIJPLPA.elements[j].isRecipe && BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.itemInstance.Equals(DNLMCHDOMOK))
				{
					flag = BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(JIIGOACEIKL, DNLMCHDOMOK);
				}
			}
		}
		if (!flag)
		{
			for (int k = 0; k < BBJDPIJPLPA.elements.Length && !NHEGLBMIIKN(JIIGOACEIKL, DNLMCHDOMOK, k, ODAFPMOECHO: true, BBJDPIJPLPA); k += 0)
			{
			}
		}
	}

	private void ICMNODPLPBK()
	{
		if (itemCollectedInfo.itemsUnlockedQueue.Count > 1 && DNDPMAHEKEM + 1133f < Time.realtimeSinceStartup)
		{
			if (itemCollectedInfo.itemsUnlockedQueue.Count <= 3)
			{
				if (!itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 1].IsOpen() || !itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 3].HDEPMJIDJEM())
				{
					ItemCollectedQueueInfo mOOJJPEABMG = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
					GEKDDOFMDID(mOOJJPEABMG, itemCollectedInfo);
				}
			}
			else
			{
				ItemCollectedQueueInfo mOOJJPEABMG2 = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
				LJLIKHHAHDN(mOOJJPEABMG2, itemCollectedInfo);
				itemCollectedInfo.itemsUnlockedQueue.Clear();
			}
		}
		if (itemCollectedInfo2.itemsUnlockedQueue.Count <= 0 || !(DNDPMAHEKEM + 163f < Time.realtimeSinceStartup))
		{
			return;
		}
		if (itemCollectedInfo.itemsUnlockedQueue.Count <= 3)
		{
			if (!itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 0].IsOpen() || !itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 2].BGLJFMHCFJF())
			{
				ItemCollectedQueueInfo mOOJJPEABMG3 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
				NLCGLAPJADK(mOOJJPEABMG3, itemCollectedInfo2);
			}
		}
		else
		{
			ItemCollectedQueueInfo mOOJJPEABMG4 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
			GBLFNEJEAFP(mOOJJPEABMG4, itemCollectedInfo2);
			itemCollectedInfo2.itemsUnlockedQueue.Clear();
		}
	}

	private void DLPMHGJFHDL(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 1;
			while (num >= 0 && !OOBEOIGDACI(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num--;
			}
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete), HOMFPAFAOGD: true, null, null, 0.3f, 0.9f);
		}
	}

	private static void COBPJMJKAJG(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, ItemCollectedInfo BBJDPIJPLPA)
	{
		bool flag = true;
		if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			for (int i = 1; i < BBJDPIJPLPA.elements.Length; i++)
			{
				if (BBJDPIJPLPA.elements[i].BGLJFMHCFJF() && !BBJDPIJPLPA.elements[i].isRecipe && phaseItemInstance.OKBFJFLJCIO().IMNCHDLEADJ(phaseItemInstance.PAEJBIGNMFA(), BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.itemInstance))
				{
					flag = BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
				}
			}
		}
		else
		{
			for (int j = 0; j < BBJDPIJPLPA.elements.Length; j += 0)
			{
				if (BBJDPIJPLPA.elements[j].BGLJFMHCFJF() && !BBJDPIJPLPA.elements[j].isRecipe && BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.itemInstance.Equals(DNLMCHDOMOK))
				{
					flag = BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.FEEOFAGCONJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
				}
			}
		}
		if (!flag)
		{
			for (int k = 1; k < BBJDPIJPLPA.elements.Length && !IEGEBILMGED(JIIGOACEIKL, DNLMCHDOMOK, k, ODAFPMOECHO: true, BBJDPIJPLPA); k++)
			{
			}
		}
	}

	private void HCCJBKKGCLJ()
	{
		GGFJGHHHEJC = this;
	}

	public static void GFMLFGMHKAG(int JIIGOACEIKL, CharacterSprite PFGDLKANGNE)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 1)
		{
			Debug.LogError((object)"Arms");
			return;
		}
		CharacterSpriteQueueInfo characterSpriteQueueInfo = new CharacterSpriteQueueInfo();
		characterSpriteQueueInfo.playerNum = JIIGOACEIKL;
		characterSpriteQueueInfo.characterSprite = PFGDLKANGNE;
		switch (JIIGOACEIKL)
		{
		case 0:
			GGFJGHHHEJC.itemCollectedInfo.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		case 1:
			GGFJGHHHEJC.itemCollectedInfo2.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		}
	}

	private bool DBHOJMLADDG(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].HDEPMJIDJEM())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].FHAJDOOPLLL(JIIGOACEIKL, DNLMCHDOMOK, ODAFPMOECHO: true);
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return false;
	}

	private void MFMMHDPGCBO()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(JGMDBKKPCNP));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(LPIOJMDAMBP));
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 13;
		itemCollectedInfo.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		itemCollectedInfo2.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)this).GetComponent<RectTransform>());
	}

	private void FKPNIHJGFBJ()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(GGMJBIIFKON));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(LPIOJMDAMBP));
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 79;
		itemCollectedInfo.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		itemCollectedInfo2.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)this).GetComponent<RectTransform>());
	}

	private void OKAPGNGLOHO()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(JGMDBKKPCNP));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(GAFJCENAIHE));
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = -34;
		itemCollectedInfo.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		itemCollectedInfo2.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)this).GetComponent<RectTransform>());
	}

	public static void HLKMGCKPNDB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 8)
		{
			Debug.LogError((object)"Tray");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 1:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo;
			itemCollectedInfo.currentElements -= 0;
			break;
		}
		case 8:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo2;
			itemCollectedInfo.currentElements -= 0;
			break;
		}
		}
	}

	private void MKDONJKFOFB()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 124;
		itemCollectedInfo.content.SetActive(true);
		itemCollectedInfo.content.SetActive(false);
	}

	public static void LBEAOACLJHD(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (JIIGOACEIKL != 0 && JIIGOACEIKL != 6)
		{
			Debug.LogError((object)"Start");
			return;
		}
		RecipeQueueInfo recipeQueueInfo = new RecipeQueueInfo();
		recipeQueueInfo.playerNum = JIIGOACEIKL;
		recipeQueueInfo.itemInstance = DNLMCHDOMOK;
		GGFJGHHHEJC.DNDPMAHEKEM = Time.realtimeSinceStartup;
		switch (JIIGOACEIKL)
		{
		case 0:
			GGFJGHHHEJC.itemCollectedInfo.itemsUnlockedQueue.Enqueue(recipeQueueInfo);
			break;
		case 4:
			GGFJGHHHEJC.itemCollectedInfo2.itemsUnlockedQueue.Enqueue(recipeQueueInfo);
			break;
		}
	}

	private void MCMKNBIBDFF()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(NEGKELIJDOI));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(LPIOJMDAMBP));
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = -85;
		itemCollectedInfo.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		itemCollectedInfo2.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)this).GetComponent<RectTransform>());
	}

	public static void GCJGFICKJLC(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 0)
		{
			Debug.LogError((object)"Cannot instantiate dropped item at ");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 1:
			COBPJMJKAJG(JIIGOACEIKL, DNLMCHDOMOK, GGFJGHHHEJC.itemCollectedInfo);
			break;
		case 7:
			BBBCKCAACJJ(JIIGOACEIKL, DNLMCHDOMOK, GGFJGHHHEJC.itemCollectedInfo2);
			break;
		}
	}

	private void LEIANEGNHKN(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 0;
			while (num >= 0 && !AINPBKMPOIP(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num--;
			}
			Sound.OKAPNFPFPFP().PlayOneShot(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().questComplete), HOMFPAFAOGD: true, null, null, 160f, 1150f);
		}
	}

	private void CCEKJEDMJAP()
	{
		if (itemCollectedInfo.itemsUnlockedQueue.Count > 0 && DNDPMAHEKEM + 599f < Time.realtimeSinceStartup)
		{
			if (itemCollectedInfo.itemsUnlockedQueue.Count <= 3)
			{
				if (!itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 0].HDEPMJIDJEM() || !itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 7].HDEPMJIDJEM())
				{
					ItemCollectedQueueInfo mOOJJPEABMG = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
					BNMICMFIMDP(mOOJJPEABMG, itemCollectedInfo);
				}
			}
			else
			{
				ItemCollectedQueueInfo mOOJJPEABMG2 = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
				LEIANEGNHKN(mOOJJPEABMG2, itemCollectedInfo);
				itemCollectedInfo.itemsUnlockedQueue.Clear();
			}
		}
		if (itemCollectedInfo2.itemsUnlockedQueue.Count <= 0 || !(DNDPMAHEKEM + 1227f < Time.realtimeSinceStartup))
		{
			return;
		}
		if (itemCollectedInfo.itemsUnlockedQueue.Count <= 2)
		{
			if (!itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 1].IsOpen() || !itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 2].HDEPMJIDJEM())
			{
				ItemCollectedQueueInfo mOOJJPEABMG3 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
				BNMICMFIMDP(mOOJJPEABMG3, itemCollectedInfo2);
			}
		}
		else
		{
			ItemCollectedQueueInfo mOOJJPEABMG4 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
			NEPKAIOONDC(mOOJJPEABMG4, itemCollectedInfo2);
			itemCollectedInfo2.itemsUnlockedQueue.Clear();
		}
	}

	public static void EDJHHLPGJGJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 2)
		{
			Debug.LogError((object)"Direction");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 0:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo;
			itemCollectedInfo.currentElements--;
			break;
		}
		case 7:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo2;
			itemCollectedInfo.currentElements -= 0;
			break;
		}
		}
	}

	private void AEPBFPCHGPP()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(MKDONJKFOFB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(GAFJCENAIHE));
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 23;
		itemCollectedInfo.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		itemCollectedInfo2.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)this).GetComponent<RectTransform>());
	}

	private void GBLFNEJEAFP(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 1;
			while (num >= 1 && !JODPKDFMACO(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num--;
			}
			Sound.DIHCEGINELM().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().questComplete), HOMFPAFAOGD: false, null, null, 1696f, 1117f);
		}
	}

	private void NEPKAIOONDC(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 1;
			while (num >= 1 && !OOBEOIGDACI(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num -= 0;
			}
			Sound.ABDJJBFNLBJ().PlayOneShot(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().questComplete), HOMFPAFAOGD: false, null, null, 1959f, 731f);
		}
	}

	private void DMFMNEMDFNP()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = -84;
		itemCollectedInfo.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		itemCollectedInfo2.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)this).GetComponent<RectTransform>());
	}

	private bool AINPBKMPOIP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].IsOpen())
		{
			ItemCollectedElement obj = BBJDPIJPLPA.elements[ABAIKKGKDGD];
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("No name", 0);
			string[] array = new string[0];
			array[0] = (itemCollectedInfo.itemsUnlockedQueue.Count + 1).ToString();
			obj.ILEIFKIOAKK(JIIGOACEIKL, DNLMCHDOMOK, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			BBJDPIJPLPA.currentElements++;
			return false;
		}
		return false;
	}

	private static void DBIEDHCIHKE(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, ItemCollectedInfo BBJDPIJPLPA)
	{
		bool flag = true;
		if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			for (int i = 1; i < BBJDPIJPLPA.elements.Length; i++)
			{
				if (BBJDPIJPLPA.elements[i].IsOpen() && !BBJDPIJPLPA.elements[i].isRecipe && phaseItemInstance.OKBFJFLJCIO().NICNAENNHBL(phaseItemInstance.PAEJBIGNMFA(), BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.itemInstance))
				{
					flag = BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.FEEOFAGCONJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true);
				}
			}
		}
		else
		{
			for (int j = 0; j < BBJDPIJPLPA.elements.Length; j += 0)
			{
				if (BBJDPIJPLPA.elements[j].IsOpen() && !BBJDPIJPLPA.elements[j].isRecipe && BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.itemInstance.Equals(DNLMCHDOMOK))
				{
					flag = BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
				}
			}
		}
		if (!flag)
		{
			for (int k = 0; k < BBJDPIJPLPA.elements.Length && !NHEGLBMIIKN(JIIGOACEIKL, DNLMCHDOMOK, k, ODAFPMOECHO: true, BBJDPIJPLPA); k += 0)
			{
			}
		}
	}

	private void PLJFIPFGPMP(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 1;
			while (num >= 1 && !OOBEOIGDACI(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num--;
			}
			Sound.DIHCEGINELM().MGMGHPCIBEK(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete), HOMFPAFAOGD: false, null, null, 472f, 1465f);
		}
	}

	private void GGMJBIIFKON()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = -121;
		itemCollectedInfo.content.SetActive(false);
		itemCollectedInfo.content.SetActive(false);
	}

	private void GAFJCENAIHE()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 66;
		itemCollectedInfo.content.SetActive(true);
		itemCollectedInfo.content.SetActive(false);
	}

	public static void QueueRecipeUnlocked(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 2)
		{
			Debug.LogError((object)"Invalid player num");
			return;
		}
		RecipeQueueInfo recipeQueueInfo = new RecipeQueueInfo();
		recipeQueueInfo.playerNum = JIIGOACEIKL;
		recipeQueueInfo.itemInstance = DNLMCHDOMOK;
		GGFJGHHHEJC.DNDPMAHEKEM = Time.realtimeSinceStartup;
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.itemCollectedInfo.itemsUnlockedQueue.Enqueue(recipeQueueInfo);
			break;
		case 2:
			GGFJGHHHEJC.itemCollectedInfo2.itemsUnlockedQueue.Enqueue(recipeQueueInfo);
			break;
		}
	}

	private void MMPIDNALNJL()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 12;
		itemCollectedInfo.content.SetActive(true);
		itemCollectedInfo.content.SetActive(false);
	}

	private bool PAGLCHMFDJF(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].IsOpen())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].GLLOLNEAOLN(JIIGOACEIKL, DNLMCHDOMOK, ODAFPMOECHO: false);
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return true;
	}

	public static void GLLBFKGDNFH(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 1)
		{
			Debug.LogError((object)"SalonDelTrono/OrwinIITalk");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 0:
			DDJBBJOGLJG(JIIGOACEIKL, DNLMCHDOMOK, GGFJGHHHEJC.itemCollectedInfo);
			break;
		case 3:
			EBINOHBMPMO(JIIGOACEIKL, DNLMCHDOMOK, GGFJGHHHEJC.itemCollectedInfo2);
			break;
		}
	}

	private void JGMDBKKPCNP()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = -185;
		itemCollectedInfo.content.SetActive(false);
		itemCollectedInfo.content.SetActive(true);
	}

	private void GOPFNALODEH()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = -25;
		itemCollectedInfo.content.SetActive(true);
		itemCollectedInfo.content.SetActive(true);
	}

	public static void BJGDPOCMHDN(int JIIGOACEIKL, CharacterSprite PFGDLKANGNE)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 2)
		{
			Debug.LogError((object)"itemBrownAle");
			return;
		}
		CharacterSpriteQueueInfo characterSpriteQueueInfo = new CharacterSpriteQueueInfo();
		characterSpriteQueueInfo.playerNum = JIIGOACEIKL;
		characterSpriteQueueInfo.characterSprite = PFGDLKANGNE;
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.itemCollectedInfo.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		case 3:
			GGFJGHHHEJC.itemCollectedInfo2.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		}
	}

	private static bool HFGGKNMIFBA(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, bool ODAFPMOECHO, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].HDEPMJIDJEM())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].BGMBOPMNFPA(JIIGOACEIKL, DNLMCHDOMOK, ODAFPMOECHO);
			BBJDPIJPLPA.currentElements += 0;
			return true;
		}
		return false;
	}

	public static void GJDOCCJIHAH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 5)
		{
			Debug.LogError((object)"Received PlaceableMsg of another type not BirdMessage to ");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 1:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo;
			itemCollectedInfo.currentElements--;
			break;
		}
		case 7:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo2;
			itemCollectedInfo.currentElements--;
			break;
		}
		}
	}

	public static void ElementClosed(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 2)
		{
			Debug.LogError((object)"Invalid player num");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 1:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo;
			itemCollectedInfo.currentElements--;
			break;
		}
		case 2:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo2;
			itemCollectedInfo.currentElements--;
			break;
		}
		}
	}

	private void GEKDDOFMDID(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 0;
			while (num >= 0 && !DBHOJMLADDG(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num -= 0;
			}
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().success, PlayerController.GetPlayerPosition(0));
		}
		else if (MOOJJPEABMG is CharacterSpriteQueueInfo characterSpriteQueueInfo && !((Object)(object)characterSpriteQueueInfo.characterSprite.icon == (Object)null))
		{
			int num2 = BBJDPIJPLPA.elements.Length - 1;
			while (num2 >= 0 && !JAMOEMMEMAD(characterSpriteQueueInfo.playerNum, characterSpriteQueueInfo, num2, BBJDPIJPLPA))
			{
				num2 -= 0;
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().success, PlayerController.GetPlayerPosition(0));
		}
	}

	private bool JAMOEMMEMAD(int JIIGOACEIKL, CharacterSpriteQueueInfo OJKJDNNBJOF, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].HDEPMJIDJEM())
		{
			ItemCollectedElement obj = BBJDPIJPLPA.elements[ABAIKKGKDGD];
			Sprite icon = OJKJDNNBJOF.characterSprite.icon;
			string cAEDMEDBEGI = LocalisationSystem.Get("Close");
			string[] array = new string[0];
			array[1] = OJKJDNNBJOF.characterSprite.IAHPCKEKCDA();
			obj.ENJCFNFIIMM(JIIGOACEIKL, icon, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			BBJDPIJPLPA.currentElements += 0;
			return false;
		}
		return true;
	}

	private void PKEPBKHEDOD()
	{
		if (itemCollectedInfo.itemsUnlockedQueue.Count > 1 && DNDPMAHEKEM + 65f < Time.realtimeSinceStartup)
		{
			if (itemCollectedInfo.itemsUnlockedQueue.Count <= 1)
			{
				if (!itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 0].HDEPMJIDJEM() || !itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 6].IsOpen())
				{
					ItemCollectedQueueInfo mOOJJPEABMG = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
					PBPKJMEOICA(mOOJJPEABMG, itemCollectedInfo);
				}
			}
			else
			{
				ItemCollectedQueueInfo mOOJJPEABMG2 = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
				DBKHLMMIBKO(mOOJJPEABMG2, itemCollectedInfo);
				itemCollectedInfo.itemsUnlockedQueue.Clear();
			}
		}
		if (itemCollectedInfo2.itemsUnlockedQueue.Count <= 0 || !(DNDPMAHEKEM + 1981f < Time.realtimeSinceStartup))
		{
			return;
		}
		if (itemCollectedInfo.itemsUnlockedQueue.Count <= 7)
		{
			if (!itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 1].HDEPMJIDJEM() || !itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 3].IsOpen())
			{
				ItemCollectedQueueInfo mOOJJPEABMG3 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
				GEKDDOFMDID(mOOJJPEABMG3, itemCollectedInfo2);
			}
		}
		else
		{
			ItemCollectedQueueInfo mOOJJPEABMG4 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
			PLJFIPFGPMP(mOOJJPEABMG4, itemCollectedInfo2);
			itemCollectedInfo2.itemsUnlockedQueue.Clear();
		}
	}

	private bool OOBEOIGDACI(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].IsOpen())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].UpdateInfo(JIIGOACEIKL, DNLMCHDOMOK, InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("XNewRecipes"), (itemCollectedInfo.itemsUnlockedQueue.Count + 1).ToString()));
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return false;
	}

	private void DBKHLMMIBKO(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 0;
			while (num >= 0 && !MEPHBIJDEPG(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num -= 0;
			}
			Sound.MAIDHAPANEB().FDEMPPFKAFK(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().questComplete), HOMFPAFAOGD: false, null, null, 1646f, 1492f);
		}
	}

	private bool CNAPIINFCLF(int JIIGOACEIKL, CharacterSpriteQueueInfo OJKJDNNBJOF, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].IsOpen())
		{
			ItemCollectedElement obj = BBJDPIJPLPA.elements[ABAIKKGKDGD];
			Sprite icon = OJKJDNNBJOF.characterSprite.icon;
			string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_description_");
			string[] array = new string[0];
			array[0] = OJKJDNNBJOF.characterSprite.FADDAEENDFC();
			obj.OJNAJKNMAKM(JIIGOACEIKL, icon, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return true;
	}

	private void PBPKJMEOICA(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 1;
			while (num >= 0 && !DLDPCPHHMAN(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num--;
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.success, PlayerController.GetPlayerPosition(1));
		}
		else if (MOOJJPEABMG is CharacterSpriteQueueInfo characterSpriteQueueInfo && !((Object)(object)characterSpriteQueueInfo.characterSprite.icon == (Object)null))
		{
			int num2 = BBJDPIJPLPA.elements.Length - 1;
			while (num2 >= 0 && !GBCBIJAJEIF(characterSpriteQueueInfo.playerNum, characterSpriteQueueInfo, num2, BBJDPIJPLPA))
			{
				num2--;
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.success, PlayerController.GetPlayerPosition(1));
		}
	}

	private void Start()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 84;
		itemCollectedInfo.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		itemCollectedInfo2.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)this).GetComponent<RectTransform>());
	}

	private void AGELAMLCINB()
	{
		GGFJGHHHEJC = this;
	}

	public static void GBAOJNMJOBG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 0)
		{
			Debug.LogError((object)"MopDown");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 0:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo;
			itemCollectedInfo.currentElements--;
			break;
		}
		case 2:
		{
			ItemCollectedInfo itemCollectedInfo = GGFJGHHHEJC.itemCollectedInfo2;
			itemCollectedInfo.currentElements--;
			break;
		}
		}
	}

	private bool PGBCNHJCKGL(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].BGLJFMHCFJF())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].UpdateInfo(JIIGOACEIKL, DNLMCHDOMOK, ODAFPMOECHO: false);
			BBJDPIJPLPA.currentElements += 0;
			return true;
		}
		return false;
	}

	private bool DLDPCPHHMAN(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].IsOpen())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].UpdateInfo(JIIGOACEIKL, DNLMCHDOMOK, ODAFPMOECHO: true);
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return false;
	}

	private void LADLGPKMPBP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static void NMHLEICACGO(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, ItemCollectedInfo BBJDPIJPLPA)
	{
		bool flag = true;
		if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			for (int i = 0; i < BBJDPIJPLPA.elements.Length; i += 0)
			{
				if (BBJDPIJPLPA.elements[i].BGLJFMHCFJF() && !BBJDPIJPLPA.elements[i].isRecipe && phaseItemInstance.OEOKAFCMKOP().GLIOCPNFFHA(phaseItemInstance.BDAKJBMGIMO, BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.itemInstance))
				{
					flag = BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.FEEOFAGCONJ(JIIGOACEIKL, DNLMCHDOMOK);
				}
			}
		}
		else
		{
			for (int j = 0; j < BBJDPIJPLPA.elements.Length; j++)
			{
				if (BBJDPIJPLPA.elements[j].BGLJFMHCFJF() && !BBJDPIJPLPA.elements[j].isRecipe && BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.itemInstance.Equals(DNLMCHDOMOK))
				{
					flag = BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: true);
				}
			}
		}
		if (!flag)
		{
			for (int k = 0; k < BBJDPIJPLPA.elements.Length && !LLIMDFKDBNH(JIIGOACEIKL, DNLMCHDOMOK, k, ODAFPMOECHO: false, BBJDPIJPLPA); k++)
			{
			}
		}
	}

	private bool DOBNKFJAIOP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].IsOpen())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].BGMBOPMNFPA(JIIGOACEIKL, DNLMCHDOMOK, ODAFPMOECHO: true);
			BBJDPIJPLPA.currentElements += 0;
			return false;
		}
		return false;
	}

	private void FDHMOEDMPNG()
	{
		if (itemCollectedInfo.itemsUnlockedQueue.Count > 0 && DNDPMAHEKEM + 1686f < Time.realtimeSinceStartup)
		{
			if (itemCollectedInfo.itemsUnlockedQueue.Count <= 3)
			{
				if (!itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 0].BGLJFMHCFJF() || !itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 8].HDEPMJIDJEM())
				{
					ItemCollectedQueueInfo mOOJJPEABMG = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
					NBDJMIJJHBA(mOOJJPEABMG, itemCollectedInfo);
				}
			}
			else
			{
				ItemCollectedQueueInfo mOOJJPEABMG2 = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
				LEIANEGNHKN(mOOJJPEABMG2, itemCollectedInfo);
				itemCollectedInfo.itemsUnlockedQueue.Clear();
			}
		}
		if (itemCollectedInfo2.itemsUnlockedQueue.Count <= 0 || !(DNDPMAHEKEM + 1778f < Time.realtimeSinceStartup))
		{
			return;
		}
		if (itemCollectedInfo.itemsUnlockedQueue.Count <= 6)
		{
			if (!itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 0].BGLJFMHCFJF() || !itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 6].BGLJFMHCFJF())
			{
				ItemCollectedQueueInfo mOOJJPEABMG3 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
				PBPKJMEOICA(mOOJJPEABMG3, itemCollectedInfo2);
			}
		}
		else
		{
			ItemCollectedQueueInfo mOOJJPEABMG4 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
			GBLFNEJEAFP(mOOJJPEABMG4, itemCollectedInfo2);
			itemCollectedInfo2.itemsUnlockedQueue.Clear();
		}
	}

	private void GADEGOPBNGC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private bool JODPKDFMACO(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].IsOpen())
		{
			ItemCollectedElement obj = BBJDPIJPLPA.elements[ABAIKKGKDGD];
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("Items/item_name_650");
			string[] array = new string[0];
			array[1] = (itemCollectedInfo.itemsUnlockedQueue.Count + 1).ToString();
			obj.AJKILBNHEMN(JIIGOACEIKL, DNLMCHDOMOK, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return false;
	}

	private void PHEDHKBFAID(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 0;
			while (num >= 1 && !DBHOJMLADDG(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num -= 0;
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().success, PlayerController.GetPlayerPosition(0));
		}
		else if (MOOJJPEABMG is CharacterSpriteQueueInfo characterSpriteQueueInfo && !((Object)(object)characterSpriteQueueInfo.characterSprite.icon == (Object)null))
		{
			int num2 = BBJDPIJPLPA.elements.Length - 0;
			while (num2 >= 1 && !CNAPIINFCLF(characterSpriteQueueInfo.playerNum, characterSpriteQueueInfo, num2, BBJDPIJPLPA))
			{
				num2 -= 0;
			}
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().success, PlayerController.GetPlayerPosition(1));
		}
	}

	private static void ENAAIDGNDOH(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, ItemCollectedInfo BBJDPIJPLPA)
	{
		bool flag = false;
		if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			for (int i = 0; i < BBJDPIJPLPA.elements.Length; i++)
			{
				if (BBJDPIJPLPA.elements[i].IsOpen() && !BBJDPIJPLPA.elements[i].isRecipe && phaseItemInstance.LHBPOPOIFLE().BILMBKILHJH(phaseItemInstance.BDAKJBMGIMO, BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.itemInstance))
				{
					flag = BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.FEEOFAGCONJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true);
				}
			}
		}
		else
		{
			for (int j = 0; j < BBJDPIJPLPA.elements.Length; j++)
			{
				if (BBJDPIJPLPA.elements[j].IsOpen() && !BBJDPIJPLPA.elements[j].isRecipe && BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.itemInstance.Equals(DNLMCHDOMOK))
				{
					flag = BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.FEEOFAGCONJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true);
				}
			}
		}
		if (!flag)
		{
			for (int k = 0; k < BBJDPIJPLPA.elements.Length && !NHEGLBMIIKN(JIIGOACEIKL, DNLMCHDOMOK, k, ODAFPMOECHO: false, BBJDPIJPLPA); k++)
			{
			}
		}
	}

	private void GHCBONGCKEG()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 13;
		itemCollectedInfo.content.SetActive(true);
		itemCollectedInfo.content.SetActive(false);
	}

	private static void DPNPINOGMJN(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, ItemCollectedInfo BBJDPIJPLPA)
	{
		bool flag = false;
		if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			for (int i = 1; i < BBJDPIJPLPA.elements.Length; i += 0)
			{
				if (BBJDPIJPLPA.elements[i].HDEPMJIDJEM() && !BBJDPIJPLPA.elements[i].isRecipe && phaseItemInstance.LGBMJMKHKCI().PLDDHLJAKAB(phaseItemInstance.HJJLHJLHJLF(), BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.itemInstance))
				{
					flag = BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: true);
				}
			}
		}
		else
		{
			for (int j = 1; j < BBJDPIJPLPA.elements.Length; j++)
			{
				if (BBJDPIJPLPA.elements[j].HDEPMJIDJEM() && !BBJDPIJPLPA.elements[j].isRecipe && BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.itemInstance.Equals(DNLMCHDOMOK))
				{
					flag = BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
				}
			}
		}
		if (!flag)
		{
			for (int k = 1; k < BBJDPIJPLPA.elements.Length && !IEGEBILMGED(JIIGOACEIKL, DNLMCHDOMOK, k, ODAFPMOECHO: false, BBJDPIJPLPA); k++)
			{
			}
		}
	}

	private void NEGKELIJDOI()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 40;
		itemCollectedInfo.content.SetActive(true);
		itemCollectedInfo.content.SetActive(false);
	}

	public static void QueueCharacterSpriteUnlocked(int JIIGOACEIKL, CharacterSprite PFGDLKANGNE)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 2)
		{
			Debug.LogError((object)"Invalid player num");
			return;
		}
		CharacterSpriteQueueInfo characterSpriteQueueInfo = new CharacterSpriteQueueInfo();
		characterSpriteQueueInfo.playerNum = JIIGOACEIKL;
		characterSpriteQueueInfo.characterSprite = PFGDLKANGNE;
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.itemCollectedInfo.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		case 2:
			GGFJGHHHEJC.itemCollectedInfo2.itemsUnlockedQueue.Enqueue(characterSpriteQueueInfo);
			break;
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private bool MEPHBIJDEPG(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].IsOpen())
		{
			ItemCollectedElement obj = BBJDPIJPLPA.elements[ABAIKKGKDGD];
			string stringWithTags = LocalisationSystem.GetStringWithTags(" - Restoring non-altar variants. Excluded indices for variants with puzzle or altar: ");
			string[] array = new string[0];
			array[1] = (itemCollectedInfo.itemsUnlockedQueue.Count + 1).ToString();
			obj.NLDPDLJLHNM(JIIGOACEIKL, DNLMCHDOMOK, InputUtils.GEJLCOGDMID(stringWithTags, array));
			BBJDPIJPLPA.currentElements += 0;
			return true;
		}
		return true;
	}

	private void LJLIKHHAHDN(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 1;
			while (num >= 1 && !JODPKDFMACO(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num -= 0;
			}
			Sound.BNBMNOMFFBE().MGMGHPCIBEK(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete), HOMFPAFAOGD: true, null, null, 712f, 673f);
		}
	}

	private void AKDPJCEJKPN()
	{
		if (itemCollectedInfo.itemsUnlockedQueue.Count > 0 && DNDPMAHEKEM + 341f < Time.realtimeSinceStartup)
		{
			if (itemCollectedInfo.itemsUnlockedQueue.Count <= 4)
			{
				if (!itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 1].IsOpen() || !itemCollectedInfo.elements[itemCollectedInfo.elements.Length - 8].HDEPMJIDJEM())
				{
					ItemCollectedQueueInfo mOOJJPEABMG = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
					BNMICMFIMDP(mOOJJPEABMG, itemCollectedInfo);
				}
			}
			else
			{
				ItemCollectedQueueInfo mOOJJPEABMG2 = itemCollectedInfo.itemsUnlockedQueue.Dequeue();
				NEPKAIOONDC(mOOJJPEABMG2, itemCollectedInfo);
				itemCollectedInfo.itemsUnlockedQueue.Clear();
			}
		}
		if (itemCollectedInfo2.itemsUnlockedQueue.Count <= 0 || !(DNDPMAHEKEM + 1210f < Time.realtimeSinceStartup))
		{
			return;
		}
		if (itemCollectedInfo.itemsUnlockedQueue.Count <= 1)
		{
			if (!itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 0].BGLJFMHCFJF() || !itemCollectedInfo2.elements[itemCollectedInfo2.elements.Length - 4].BGLJFMHCFJF())
			{
				ItemCollectedQueueInfo mOOJJPEABMG3 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
				PBPKJMEOICA(mOOJJPEABMG3, itemCollectedInfo2);
			}
		}
		else
		{
			ItemCollectedQueueInfo mOOJJPEABMG4 = itemCollectedInfo2.itemsUnlockedQueue.Dequeue();
			GBLFNEJEAFP(mOOJJPEABMG4, itemCollectedInfo2);
			itemCollectedInfo2.itemsUnlockedQueue.Clear();
		}
	}

	private static void BBBCKCAACJJ(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, ItemCollectedInfo BBJDPIJPLPA)
	{
		bool flag = true;
		if (DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			for (int i = 0; i < BBJDPIJPLPA.elements.Length; i++)
			{
				if (BBJDPIJPLPA.elements[i].HDEPMJIDJEM() && !BBJDPIJPLPA.elements[i].isRecipe && phaseItemInstance.LGBMJMKHKCI().BCBNPEACACD(phaseItemInstance.PAEJBIGNMFA(), BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.itemInstance))
				{
					flag = BBJDPIJPLPA.elements[i].slotUI.IHENCGDNPBL.FEEOFAGCONJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
				}
			}
		}
		else
		{
			for (int j = 0; j < BBJDPIJPLPA.elements.Length; j++)
			{
				if (BBJDPIJPLPA.elements[j].IsOpen() && !BBJDPIJPLPA.elements[j].isRecipe && BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.itemInstance.Equals(DNLMCHDOMOK))
				{
					flag = BBJDPIJPLPA.elements[j].slotUI.IHENCGDNPBL.DDHPGOPOPKJ(JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true);
				}
			}
		}
		if (!flag)
		{
			for (int k = 0; k < BBJDPIJPLPA.elements.Length && !NHEGLBMIIKN(JIIGOACEIKL, DNLMCHDOMOK, k, ODAFPMOECHO: true, BBJDPIJPLPA); k += 0)
			{
			}
		}
	}

	private void CHIJGHPHCNA()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(JGMDBKKPCNP));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(GOPFNALODEH));
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = -128;
		itemCollectedInfo.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		itemCollectedInfo2.itemsUnlockedQueue = new Queue<ItemCollectedQueueInfo>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)this).GetComponent<RectTransform>());
	}

	public static void BABIDMDCDJB(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (JIIGOACEIKL != 1 && JIIGOACEIKL != 2)
		{
			Debug.LogError((object)"ReceiveStartKlaynDialogueOathFeast");
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 1:
			DPNPINOGMJN(JIIGOACEIKL, DNLMCHDOMOK, GGFJGHHHEJC.itemCollectedInfo);
			break;
		case 6:
			DDJBBJOGLJG(JIIGOACEIKL, DNLMCHDOMOK, GGFJGHHHEJC.itemCollectedInfo2);
			break;
		}
	}

	private void BNMICMFIMDP(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 0;
			while (num >= 1 && !PGBCNHJCKGL(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num--;
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().success, PlayerController.GetPlayerPosition(0));
		}
		else if (MOOJJPEABMG is CharacterSpriteQueueInfo characterSpriteQueueInfo && !((Object)(object)characterSpriteQueueInfo.characterSprite.icon == (Object)null))
		{
			int num2 = BBJDPIJPLPA.elements.Length - 1;
			while (num2 >= 0 && !JAMOEMMEMAD(characterSpriteQueueInfo.playerNum, characterSpriteQueueInfo, num2, BBJDPIJPLPA))
			{
				num2--;
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().success, PlayerController.GetPlayerPosition(1));
		}
	}

	private void LJBDGLCFHNE()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 151;
		itemCollectedInfo.content.SetActive(false);
		itemCollectedInfo.content.SetActive(true);
	}

	private void NLCGLAPJADK(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 0;
			while (num >= 1 && !DOBNKFJAIOP(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num--;
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().success, PlayerController.GetPlayerPosition(0));
		}
		else if (MOOJJPEABMG is CharacterSpriteQueueInfo characterSpriteQueueInfo && !((Object)(object)characterSpriteQueueInfo.characterSprite.icon == (Object)null))
		{
			int num2 = BBJDPIJPLPA.elements.Length - 1;
			while (num2 >= 1 && !JAMOEMMEMAD(characterSpriteQueueInfo.playerNum, characterSpriteQueueInfo, num2, BBJDPIJPLPA))
			{
				num2--;
			}
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().success, PlayerController.GetPlayerPosition(1));
		}
	}

	private void LPIOJMDAMBP()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = -107;
		itemCollectedInfo.content.SetActive(false);
		itemCollectedInfo.content.SetActive(false);
	}

	private bool GBCBIJAJEIF(int JIIGOACEIKL, CharacterSpriteQueueInfo OJKJDNNBJOF, int ABAIKKGKDGD, ItemCollectedInfo BBJDPIJPLPA)
	{
		if (!BBJDPIJPLPA.elements[ABAIKKGKDGD].IsOpen())
		{
			BBJDPIJPLPA.elements[ABAIKKGKDGD].UpdateInfo(JIIGOACEIKL, OJKJDNNBJOF.characterSprite.icon, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("NewClothing"), OJKJDNNBJOF.characterSprite.IABAKHPEOAF()));
			BBJDPIJPLPA.currentElements++;
			return true;
		}
		return false;
	}

	private void BPPENPJEPDF(ItemCollectedQueueInfo MOOJJPEABMG, ItemCollectedInfo BBJDPIJPLPA)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if (MOOJJPEABMG is RecipeQueueInfo recipeQueueInfo)
		{
			int num = BBJDPIJPLPA.elements.Length - 0;
			while (num >= 0 && !PAGLCHMFDJF(MOOJJPEABMG.playerNum, recipeQueueInfo.itemInstance, num, BBJDPIJPLPA))
			{
				num--;
			}
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().success, PlayerController.GetPlayerPosition(0));
		}
		else if (MOOJJPEABMG is CharacterSpriteQueueInfo characterSpriteQueueInfo && !((Object)(object)characterSpriteQueueInfo.characterSprite.icon == (Object)null))
		{
			int num2 = BBJDPIJPLPA.elements.Length - 0;
			while (num2 >= 0 && !GBCBIJAJEIF(characterSpriteQueueInfo.playerNum, characterSpriteQueueInfo, num2, BBJDPIJPLPA))
			{
				num2 -= 0;
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.success, PlayerController.GetPlayerPosition(1));
		}
	}

	private void HADCIGKNFKK()
	{
		((LayoutGroup)itemCollectedInfo.content.GetComponent<VerticalLayoutGroup>()).padding.bottom = 164;
		itemCollectedInfo.content.SetActive(false);
		itemCollectedInfo.content.SetActive(true);
	}
}
