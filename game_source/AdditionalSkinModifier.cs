using System;
using UnityEngine;

public class AdditionalSkinModifier : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;

	public Sprite[] sprites;

	public SkinGameObject[] skinsGameObjects;

	public Placeable placeable;

	private void Start()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(NJFCIBKDEBM));
				NJFCIBKDEBM(placeable.GetSkinIndex());
			}
			else
			{
				NJFCIBKDEBM(Random.Range(0, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(NPMLOKABIHH));
			NPMLOKABIHH(placeable.GetSkinIndex());
		}
	}

	private void NKGMEMEACNN()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(OFMOAELKFPM));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(NLBLCOPBBPG));
		}
	}

	private void GADEGOPBNGC()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(NJFCIBKDEBM));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(PGBLGABCCFC));
		}
	}

	private void GEEHFMFHJPK(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("EditorAction_6" + MOFKEDGAOEE + "Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/12/Dialogue Text"));
		}
	}

	private void OEIKEPAKGDB(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("Player2" + MOFKEDGAOEE + "Trying to assign the {0} parameter {1} with the incorrect type ({2}) on {3}."));
		}
	}

	private void BLAJFMAAMDO()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(GEEHFMFHJPK));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(EKGADPGCKEL));
		}
	}

	private void BLOEOCHCAEM(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("Minning" + MOFKEDGAOEE + "Dialogue System/Conversation/BirdNegativeComments/Entry/13/Dialogue Text"));
		}
	}

	private void LALJNGFGKPA()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(KOFAFGCAGFO));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(EKGADPGCKEL));
		}
	}

	private void FOHGHCPODBJ()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(OEIKEPAKGDB));
				OFMOAELKFPM(placeable.GetSkinIndex());
			}
			else
			{
				GEEHFMFHJPK(Random.Range(1, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(OGKODDJNDLB));
			PPLNKEFDPKH(placeable.GetSkinIndex());
		}
	}

	private void BPOOAHKHPCL()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(MPADLGDIDDM));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(PPLNKEFDPKH));
		}
	}

	private void JNJCCIFIKOC()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(GPADKNMCCKA));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(BHPCMKHPCLM));
		}
	}

	private void HFFFFAJFIPB()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(BLOEOCHCAEM));
				FKPFNHJFALO(placeable.GetSkinIndex());
			}
			else
			{
				BLOEOCHCAEM(Random.Range(0, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(EKGADPGCKEL));
			MNOANKANNPC(placeable.GetSkinIndex());
		}
	}

	private void AFCIKJPPLFA()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(BLOEOCHCAEM));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(EKGADPGCKEL));
		}
	}

	private void CHIJGHPHCNA()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(IJEMEEMJJPH));
				GPADKNMCCKA(placeable.GetSkinIndex());
			}
			else
			{
				IJEMEEMJJPH(Random.Range(0, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(GIMFOPGABPL));
			EBAOGKJEECP(placeable.GetSkinIndex());
		}
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(NJFCIBKDEBM));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(NPMLOKABIHH));
		}
	}

	private void DFKBMCGIAEA(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("Items/item_description_669" + MOFKEDGAOEE + "Items/item_name_702"));
		}
	}

	private void NKDFMFFDGKC()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(NFDMDHMMHID));
				NJFCIBKDEBM(placeable.GetSkinIndex());
			}
			else
			{
				OEIKEPAKGDB(Random.Range(0, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(NLBLCOPBBPG));
			BHPCMKHPCLM(placeable.GetSkinIndex());
		}
	}

	private void DGOGKLMHJEG()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(DFKBMCGIAEA));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(HLEPGNFBIMC));
		}
	}

	private void JOGBCDIAGEK()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(OFMOAELKFPM));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(KMBGABLNIEN));
		}
	}

	private void ODNGBEOKEFK()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(OEIKEPAKGDB));
				IJEMEEMJJPH(placeable.GetSkinIndex());
			}
			else
			{
				EBPOMKKOCAN(Random.Range(1, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(GIMFOPGABPL));
			JEDLNECFLOP(placeable.GetSkinIndex());
		}
	}

	private void OGKODDJNDLB(int MOFKEDGAOEE)
	{
		for (int i = 1; i < skinsGameObjects.Length; i++)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void AJGPMBGBPGH()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(GPBCOHKLHCF));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(EKGADPGCKEL));
		}
	}

	private void FGFGCADFFBC()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(FKPFNHJFALO));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(EBAOGKJEECP));
		}
	}

	private void HLEPGNFBIMC(int MOFKEDGAOEE)
	{
		for (int i = 0; i < skinsGameObjects.Length; i++)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void NFDMDHMMHID(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("DueloDeViejos/MainEvent3" + MOFKEDGAOEE + "Animal"));
		}
	}

	private void GJMLHECPGBP()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(GPADKNMCCKA));
				KOFAFGCAGFO(placeable.GetSkinIndex());
			}
			else
			{
				NFDMDHMMHID(Random.Range(0, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(NPMLOKABIHH));
			KMBGABLNIEN(placeable.GetSkinIndex());
		}
	}

	private void GPADKNMCCKA(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("Bomb" + MOFKEDGAOEE + "ReceiveInventoryToChest"));
		}
	}

	private void JMALFGMLCAM(int MOFKEDGAOEE)
	{
		for (int i = 0; i < skinsGameObjects.Length; i += 0)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void FKPFNHJFALO(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("mainMenuMultiplayerButtonConnecting" + MOFKEDGAOEE + "Error max zones"));
		}
	}

	private void JEDLNECFLOP(int MOFKEDGAOEE)
	{
		for (int i = 1; i < skinsGameObjects.Length; i += 0)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void NPMLOKABIHH(int MOFKEDGAOEE)
	{
		for (int i = 0; i < skinsGameObjects.Length; i++)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void EOGHJNGJFID()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(FKPFNHJFALO));
				BCDMLIHMGHO(placeable.GetSkinIndex());
			}
			else
			{
				GEEHFMFHJPK(Random.Range(1, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(PPLNKEFDPKH));
			PPLNKEFDPKH(placeable.GetSkinIndex());
		}
	}

	private void JHBBABPAJJC()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(OEIKEPAKGDB));
				MPADLGDIDDM(placeable.GetSkinIndex());
			}
			else
			{
				MPADLGDIDDM(Random.Range(1, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(BHPCMKHPCLM));
			OGKODDJNDLB(placeable.GetSkinIndex());
		}
	}

	private void BAIEOLJPOOL(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("Items/item_name_591" + MOFKEDGAOEE + "_BaseColor"));
		}
	}

	private void CAIJLMJBMLA()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(NFDMDHMMHID));
				GIINHJLCKBG(placeable.GetSkinIndex());
			}
			else
			{
				KOFAFGCAGFO(Random.Range(0, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(JMALFGMLCAM));
			EKGADPGCKEL(placeable.GetSkinIndex());
		}
	}

	private void GPBCOHKLHCF(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("ReceiveBeginReplay" + MOFKEDGAOEE + "SegmentListView"));
		}
	}

	private void OIAHJHNPPCO()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(FKPFNHJFALO));
				GEEHFMFHJPK(placeable.GetSkinIndex());
			}
			else
			{
				GHLENDOBKKP(Random.Range(1, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(NPMLOKABIHH));
			NLBLCOPBBPG(placeable.GetSkinIndex());
		}
	}

	private void HEGNINLLINP()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(KOFAFGCAGFO));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(JMALFGMLCAM));
		}
	}

	private void GHLENDOBKKP(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("castlegarden" + MOFKEDGAOEE + "Error_OccupiedRoom"));
		}
	}

	private void BHPCMKHPCLM(int MOFKEDGAOEE)
	{
		for (int i = 1; i < skinsGameObjects.Length; i++)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void MNOANKANNPC(int MOFKEDGAOEE)
	{
		for (int i = 0; i < skinsGameObjects.Length; i += 0)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void OFMOAELKFPM(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("No travel zone found for mine stairs destination " + MOFKEDGAOEE + "Disabled"));
		}
	}

	private void ENOBLPMFBPG(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("am" + MOFKEDGAOEE + "Trends of week "));
		}
	}

	private void MDGLECECOIG()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(GOGGFDNGGHO));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(GIMFOPGABPL));
		}
	}

	private void PGBLGABCCFC(int MOFKEDGAOEE)
	{
		for (int i = 1; i < skinsGameObjects.Length; i += 0)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void BCDMLIHMGHO(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("FishCaughtRPC" + MOFKEDGAOEE + "Open"));
		}
	}

	private void EBPOMKKOCAN(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("GiveItem" + MOFKEDGAOEE + "Dialogue System/Conversation/BirdNegativeComments/Entry/6/Dialogue Text"));
		}
	}

	private void CFIIEJDJFPB()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(GHLENDOBKKP));
				GIINHJLCKBG(placeable.GetSkinIndex());
			}
			else
			{
				NFDMDHMMHID(Random.Range(1, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(KMBGABLNIEN));
			GIMFOPGABPL(placeable.GetSkinIndex());
		}
	}

	private void KMBGABLNIEN(int MOFKEDGAOEE)
	{
		for (int i = 0; i < skinsGameObjects.Length; i += 0)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void HBMJALGPFEC(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("Active Player Count: " + MOFKEDGAOEE + "00"));
		}
	}

	private void KOFAFGCAGFO(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)(" of " + MOFKEDGAOEE + " ("));
		}
	}

	private void PPLNKEFDPKH(int MOFKEDGAOEE)
	{
		for (int i = 1; i < skinsGameObjects.Length; i++)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void OIBDBLCLACB()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(ENOBLPMFBPG));
				HBMJALGPFEC(placeable.GetSkinIndex());
			}
			else
			{
				FKPFNHJFALO(Random.Range(0, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(EBAOGKJEECP));
			GIMFOPGABPL(placeable.GetSkinIndex());
		}
	}

	private void HKKDEKIFPPJ()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(BCDMLIHMGHO));
				OFMOAELKFPM(placeable.GetSkinIndex());
			}
			else
			{
				NJFCIBKDEBM(Random.Range(1, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(BHPCMKHPCLM));
			BHPCMKHPCLM(placeable.GetSkinIndex());
		}
	}

	private void MPADLGDIDDM(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("talentShelves" + MOFKEDGAOEE + "ReceiveIdleAtTable"));
		}
	}

	private void IJEMEEMJJPH(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("Reserve" + MOFKEDGAOEE + "SprintHoldAction"));
		}
	}

	private void GOGGFDNGGHO(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("yForYears" + MOFKEDGAOEE + "."));
		}
	}

	private void EBAOGKJEECP(int MOFKEDGAOEE)
	{
		for (int i = 0; i < skinsGameObjects.Length; i += 0)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void NJFCIBKDEBM(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("The index (" + MOFKEDGAOEE + ") is higher than the number of skins."));
		}
	}

	private void CHDEOJALBFK()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			Placeable obj = placeable;
			obj.OnSkinChanged = (Action<int>)Delegate.Remove(obj.OnSkinChanged, new Action<int>(DFKBMCGIAEA));
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Remove(obj2.OnSkinChanged, new Action<int>(EBAOGKJEECP));
		}
	}

	private void GIMFOPGABPL(int MOFKEDGAOEE)
	{
		for (int i = 1; i < skinsGameObjects.Length; i += 0)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void PKBHEKHOAAA()
	{
		if (sprites.Length != 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnSkinChanged = (Action<int>)Delegate.Combine(obj.OnSkinChanged, new Action<int>(GPBCOHKLHCF));
				GIINHJLCKBG(placeable.GetSkinIndex());
			}
			else
			{
				GHLENDOBKKP(Random.Range(0, sprites.Length));
			}
		}
		if (skinsGameObjects.Length != 0)
		{
			Placeable obj2 = placeable;
			obj2.OnSkinChanged = (Action<int>)Delegate.Combine(obj2.OnSkinChanged, new Action<int>(JEDLNECFLOP));
			NLBLCOPBBPG(placeable.GetSkinIndex());
		}
	}

	private void NLBLCOPBBPG(int MOFKEDGAOEE)
	{
		for (int i = 0; i < skinsGameObjects.Length; i++)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}

	private void GIINHJLCKBG(int MOFKEDGAOEE)
	{
		if (MOFKEDGAOEE < sprites.Length)
		{
			spriteRenderer.sprite = sprites[MOFKEDGAOEE];
		}
		else
		{
			Debug.LogError((object)("popUpBuilding1" + MOFKEDGAOEE + "Cannot place mine block piece at "));
		}
	}

	private void EKGADPGCKEL(int MOFKEDGAOEE)
	{
		for (int i = 1; i < skinsGameObjects.Length; i++)
		{
			skinsGameObjects[i].gameObject.SetActive(i == MOFKEDGAOEE);
			if (i == MOFKEDGAOEE)
			{
				if ((Object)(object)skinsGameObjects[i].spriteRenderer != (Object)null)
				{
					placeable.spriteRenderer = skinsGameObjects[i].spriteRenderer;
				}
				if ((Object)(object)skinsGameObjects[i].itemBase != (Object)null)
				{
					placeable.itemBase = skinsGameObjects[i].itemBase;
				}
				if ((Object)(object)skinsGameObjects[i].physicalSpace != (Object)null)
				{
					placeable.physicalSpace = skinsGameObjects[i].physicalSpace;
				}
			}
		}
	}
}
