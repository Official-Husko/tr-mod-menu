using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Galaxy.Api;
using PixelCrushers.DialogueSystem;
using Steamworks;
using UnityEngine;

public class DogSelectorUI : UIWindow
{
	private static DogSelectorUI IADEMLIIDPC;

	public TextInput textInput;

	public GameObject leftButton;

	public DogAnimation[] dogAnimation;

	[HideInInspector]
	public bool waitChanges = true;

	[SerializeField]
	private SpriteInfo currentDog;

	private string EENNAOMJDLO;

	private DogNPC.DogBreed EJNMCOFCKFH;

	public static DogSelectorUI GGFJGHHHEJC => IADEMLIIDPC;

	[SpecialName]
	public static DogSelectorUI BADFKMEJOKE()
	{
		return IADEMLIIDPC;
	}

	protected override void Awake()
	{
		IADEMLIIDPC = this;
		base.Awake();
		OGGFMEFJHIA();
	}

	public void LMFCCCKPMFD()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.LBGHPEMKJEE();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		MDCDEINFAIN();
	}

	public void IGNBBCAEFOM()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			-63 => DogNPC.DogBreed.Beagle, 
			-62 => DogNPC.DogBreed.Bernard, 
			-61 => (DogNPC.DogBreed)7, 
			-60 => DogNPC.DogBreed.Husky, 
			-59 => DogNPC.DogBreed.Husky, 
			-58 => DogNPC.DogBreed.Boxer, 
			-57 => (DogNPC.DogBreed)7, 
			_ => DogNPC.DogBreed.Bernard, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		BOBCIFEDJED();
	}

	public void KJFGHAOOMDM()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.FDCICIPILMP();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		IMDMOHNAONL();
	}

	public void JLFHAFIPEJG()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			38 => DogNPC.DogBreed.Beagle, 
			39 => DogNPC.DogBreed.Beagle, 
			40 => DogNPC.DogBreed.Boxer, 
			41 => (DogNPC.DogBreed)8, 
			42 => DogNPC.DogBreed.Shiba, 
			43 => (DogNPC.DogBreed)8, 
			44 => DogNPC.DogBreed.Bernard, 
			_ => DogNPC.DogBreed.Beagle, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		BOBCIFEDJED();
	}

	private void LFHGAJAPIII(int JFNMCNCHMEO = 0)
	{
		for (int i = 0; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i++)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	private void IOFBHHPKKFI(int JFNMCNCHMEO = 0)
	{
		for (int i = 0; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i++)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	private void HHPNOGFGKPA()
	{
		if (currentDog.id == 97 || currentDog.id == 189 || currentDog.id == -156)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[7]).gameObject.SetActive(true);
			EJPFOPCIAMM();
		}
		else if (currentDog.id == 99 || currentDog.id == 58 || currentDog.id == 3)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[4]).gameObject.SetActive(true);
			OGGFMEFJHIA(1);
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			IPKHNBPGPGN(6);
		}
	}

	private void EJIOGCEFACH()
	{
		if (currentDog.id == 29 || currentDog.id == 11 || currentDog.id == -66)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[7]).gameObject.SetActive(true);
			NDGDOJAKBPC();
		}
		else if (currentDog.id == 26 || currentDog.id == -60 || currentDog.id == 161)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[4]).gameObject.SetActive(false);
			BJJFLPOIBBK();
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[6]).gameObject.SetActive(false);
			BJJFLPOIBBK(6);
		}
	}

	protected override void Update()
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		base.Update();
		if (IsOpen())
		{
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIAddRemove"))
			{
				ButtonAccept();
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp"))
			{
				ButtonAccept();
			}
		}
	}

	public void DPFMNNFAEAO()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.JNDHANDBDKC();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		FNOPCNFDCAP();
	}

	[SpecialName]
	public static DogSelectorUI FJAMHCAAEAM()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static DogSelectorUI EBAIHKJHCCA()
	{
		return IADEMLIIDPC;
	}

	private void MJJACENLMHP()
	{
		if (currentDog.id == -18 || currentDog.id == 22 || currentDog.id == 190)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[6]).gameObject.SetActive(false);
			DGCDLHEFGKH(1);
		}
		else if (currentDog.id == -106 || currentDog.id == -178 || currentDog.id == 151)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[4]).gameObject.SetActive(false);
			LFHGAJAPIII();
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			MFKLLLDFGIO(5);
		}
	}

	public void ABHAPDGPGFB()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			-135 => DogNPC.DogBreed.Beagle, 
			-134 => DogNPC.DogBreed.Bernard, 
			-133 => DogNPC.DogBreed.Beagle, 
			-132 => (DogNPC.DogBreed)8, 
			-131 => DogNPC.DogBreed.Shiba, 
			-130 => DogNPC.DogBreed.Husky, 
			-129 => (DogNPC.DogBreed)8, 
			_ => DogNPC.DogBreed.Beagle, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		BOBCIFEDJED();
	}

	private void ONBOCGONBBD()
	{
		if (currentDog.id == 131 || currentDog.id == 92 || currentDog.id == -11)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[6]).gameObject.SetActive(false);
			MFKLLLDFGIO(1);
		}
		else if (currentDog.id == -14 || currentDog.id == -64 || currentDog.id == 156)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[2]).gameObject.SetActive(false);
			GJAOJIGIHOF(1);
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			FABJFJPAIBL(4);
		}
	}

	public void OBDNPADGIFG()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			105 => DogNPC.DogBreed.Bernard, 
			106 => DogNPC.DogBreed.Bernard, 
			107 => DogNPC.DogBreed.Shiba, 
			108 => DogNPC.DogBreed.Beagle, 
			109 => DogNPC.DogBreed.BorderCollie, 
			110 => (DogNPC.DogBreed)7, 
			111 => DogNPC.DogBreed.BorderCollie, 
			_ => DogNPC.DogBreed.Beagle, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		BOBCIFEDJED();
	}

	public void AFFMGMDOMJN()
	{
		List<SpriteInfo> dogs = CharacterSpritesDBAccessor.GetDogs();
		int num = dogs.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 1, dogs.Count);
		currentDog = dogs[num];
		FNOPCNFDCAP();
	}

	[SpecialName]
	public static DogSelectorUI MFHOBAJJIBJ()
	{
		return IADEMLIIDPC;
	}

	private void FNOPCNFDCAP()
	{
		if (currentDog.id == 117 || currentDog.id == 184 || currentDog.id == -13)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[4]).gameObject.SetActive(false);
			EJPFOPCIAMM();
		}
		else if (currentDog.id == 175 || currentDog.id == 3 || currentDog.id == 7)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[5]).gameObject.SetActive(false);
			GJAOJIGIHOF(1);
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[3]).gameObject.SetActive(false);
			MEDLKPFIOKG(4);
		}
	}

	private void IJEAHJDPHDB()
	{
		if (currentDog.id == -53 || currentDog.id == 6 || currentDog.id == 118)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[7]).gameObject.SetActive(false);
			MLIIKCMDMOH();
		}
		else if (currentDog.id == -91 || currentDog.id == 128 || currentDog.id == 105)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			HNDHEOJFPLG();
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[8]).gameObject.SetActive(false);
			IOFBHHPKKFI(7);
		}
	}

	[SpecialName]
	public static DogSelectorUI OACNNJCLEDE()
	{
		return IADEMLIIDPC;
	}

	private void EJPFOPCIAMM(int JFNMCNCHMEO = 0)
	{
		for (int i = 1; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i++)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	private void BEAMJJDPIPB()
	{
		if (currentDog.id == -64 || currentDog.id == 158 || currentDog.id == -105)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[4]).gameObject.SetActive(true);
			GKANMPJBHPL();
		}
		else if (currentDog.id == -182 || currentDog.id == -50 || currentDog.id == 121)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[5]).gameObject.SetActive(true);
			HNDHEOJFPLG();
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[8]).gameObject.SetActive(true);
			JEDKAANBNDO(5);
		}
	}

	public void HNEDAKINIEE()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.HPMAAPCPIAA();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 0, list.Count);
		currentDog = list[num];
		BFHMIIHPPOF();
	}

	[SpecialName]
	public static DogSelectorUI GIKECEGLFOH()
	{
		return IADEMLIIDPC;
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		MainUI.PauseGame();
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(leftButton);
		}
	}

	[SpecialName]
	public static DogSelectorUI AAFOFNEHPLC()
	{
		return IADEMLIIDPC;
	}

	private void DPBALHPFNII()
	{
		if (currentDog.id == -174 || currentDog.id == 44 || currentDog.id == -106)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[6]).gameObject.SetActive(false);
			MLIIKCMDMOH(1);
		}
		else if (currentDog.id == -81 || currentDog.id == 64 || currentDog.id == -85)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[3]).gameObject.SetActive(true);
			GKANMPJBHPL(1);
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[7]).gameObject.SetActive(false);
			DGCDLHEFGKH();
		}
	}

	public void LGDCGKCENKO()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.IKHNGOBDHFG();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		PPONAGDCDCN();
	}

	public void JFODNEDMLIC()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.HPDCPDOCKPC(0, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.NOAOJJLNHJJ, new Vector2(632f, 1521f), GFNHAMCPEAK: true, CDPAMNIPPEC: false);
	}

	private void FJHEMOBMFOB()
	{
		if (currentDog.id == -200 || currentDog.id == -170 || currentDog.id == -106)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			MFKLLLDFGIO(1);
		}
		else if (currentDog.id == -41 || currentDog.id == -196 || currentDog.id == -145)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			IOMHIBHAGGF(1);
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[3]).gameObject.SetActive(true);
			MLIIKCMDMOH(6);
		}
	}

	private void DDNADHPKCDO()
	{
		if (currentDog.id == 113 || currentDog.id == 150 || currentDog.id == 126)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[5]).gameObject.SetActive(true);
			GJAOJIGIHOF(1);
		}
		else if (currentDog.id == -143 || currentDog.id == 26 || currentDog.id == 22)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[5]).gameObject.SetActive(true);
			GJAOJIGIHOF(1);
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[8]).gameObject.SetActive(true);
			EJPFOPCIAMM(2);
		}
	}

	public void NMALIFLLCMA()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			168 => DogNPC.DogBreed.Beagle, 
			169 => DogNPC.DogBreed.Beagle, 
			170 => DogNPC.DogBreed.Beagle, 
			171 => DogNPC.DogBreed.Beagle, 
			172 => (DogNPC.DogBreed)8, 
			173 => DogNPC.DogBreed.Husky, 
			174 => DogNPC.DogBreed.Shiba, 
			_ => DogNPC.DogBreed.Beagle, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		BOBCIFEDJED();
	}

	private void JEDKAANBNDO(int JFNMCNCHMEO = 0)
	{
		for (int i = 1; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i++)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	private void OOEPJNCDEOA()
	{
		if (currentDog.id == -91 || currentDog.id == -39 || currentDog.id == 54)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[2]).gameObject.SetActive(true);
			HNDHEOJFPLG();
		}
		else if (currentDog.id == 43 || currentDog.id == -84 || currentDog.id == -98)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			FCBEGMBHPNK();
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[2]).gameObject.SetActive(true);
			NDGDOJAKBPC(4);
		}
	}

	public void KCKAJPDONMK()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			-95 => DogNPC.DogBreed.Beagle, 
			-94 => DogNPC.DogBreed.Beagle, 
			-93 => DogNPC.DogBreed.Boxer, 
			-92 => DogNPC.DogBreed.Husky, 
			-91 => DogNPC.DogBreed.Bernard, 
			-90 => (DogNPC.DogBreed)7, 
			-89 => DogNPC.DogBreed.BorderCollie, 
			_ => DogNPC.DogBreed.Bernard, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		CloseUI();
	}

	public void IHLAFGPNHCC()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			92 => DogNPC.DogBreed.Beagle, 
			93 => DogNPC.DogBreed.Bernard, 
			94 => (DogNPC.DogBreed)8, 
			95 => DogNPC.DogBreed.Beagle, 
			96 => DogNPC.DogBreed.Bernard, 
			97 => DogNPC.DogBreed.BorderCollie, 
			98 => (DogNPC.DogBreed)7, 
			_ => DogNPC.DogBreed.Bernard, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		BOBCIFEDJED();
	}

	[SpecialName]
	public static DogSelectorUI BNDNMBGJEKP()
	{
		return IADEMLIIDPC;
	}

	private void BLGBAFOKCGD()
	{
		if (currentDog.id == -129 || currentDog.id == 121 || currentDog.id == 52)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			DGCDLHEFGKH();
		}
		else if (currentDog.id == -113 || currentDog.id == -176 || currentDog.id == -104)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[8]).gameObject.SetActive(false);
			IOFBHHPKKFI();
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[2]).gameObject.SetActive(true);
			HNDHEOJFPLG(2);
		}
	}

	public void LALIKJMEHHK()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			-142 => DogNPC.DogBreed.Bernard, 
			-141 => DogNPC.DogBreed.Bernard, 
			-140 => (DogNPC.DogBreed)8, 
			-139 => DogNPC.DogBreed.Shepard, 
			-138 => DogNPC.DogBreed.Bernard, 
			-137 => DogNPC.DogBreed.Boxer, 
			-136 => (DogNPC.DogBreed)8, 
			_ => DogNPC.DogBreed.Bernard, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		BOBCIFEDJED();
	}

	private void NAENPIECLMK(int JFNMCNCHMEO = 0)
	{
		for (int i = 0; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i += 0)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	private void NDGDOJAKBPC(int JFNMCNCHMEO = 0)
	{
		for (int i = 0; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i += 0)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void DBCCHGEEOHO()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.HPDCPDOCKPC(0, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.CJOHMLNMJLK(), new Vector2(1738f, 367f), GFNHAMCPEAK: true, CDPAMNIPPEC: false);
	}

	private void MDCDEINFAIN()
	{
		if (currentDog.id == 32 || currentDog.id == 94 || currentDog.id == -189)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[7]).gameObject.SetActive(false);
			MEDLKPFIOKG();
		}
		else if (currentDog.id == 126 || currentDog.id == -48 || currentDog.id == -100)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[5]).gameObject.SetActive(true);
			KIDECHANLIM(1);
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[2]).gameObject.SetActive(false);
			NDGDOJAKBPC(7);
		}
	}

	public void COIKCNEMMHI()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.DCCCAIDJCEF();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 1, list.Count);
		currentDog = list[num];
		NLIPGFPGIHD();
	}

	private void LEIGILGMKAI()
	{
		if (currentDog.id == 182 || currentDog.id == 180 || currentDog.id == -100)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[8]).gameObject.SetActive(true);
			GKANMPJBHPL();
		}
		else if (currentDog.id == 88 || currentDog.id == -23 || currentDog.id == 5)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[5]).gameObject.SetActive(true);
			FABJFJPAIBL(1);
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			GKANMPJBHPL(2);
		}
	}

	private void KIDECHANLIM(int JFNMCNCHMEO = 0)
	{
		for (int i = 0; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i += 0)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void LFJNJJKIABP()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.LBGHPEMKJEE();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 1, list.Count);
		currentDog = list[num];
		PGDOOPNHECL();
	}

	public void PCEJABOJBKF()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.OIBHOMBGDJB(0, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.NOAOJJLNHJJ, new Vector2(1917f, 1657f), GFNHAMCPEAK: false);
	}

	private void MCKMIBMGALJ()
	{
		if (currentDog.id == -154 || currentDog.id == -162 || currentDog.id == -21)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[3]).gameObject.SetActive(true);
			DGCDLHEFGKH();
		}
		else if (currentDog.id == 14 || currentDog.id == 33 || currentDog.id == -180)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[4]).gameObject.SetActive(true);
			LFHGAJAPIII(1);
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[7]).gameObject.SetActive(true);
			MEDLKPFIOKG(1);
		}
	}

	[SpecialName]
	public static DogSelectorUI ALDNEMJHMOI()
	{
		return IADEMLIIDPC;
	}

	private void BFOOOBAOMCF()
	{
		if (currentDog.id == -56 || currentDog.id == 113 || currentDog.id == -47)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[4]).gameObject.SetActive(true);
			JEDKAANBNDO();
		}
		else if (currentDog.id == -137 || currentDog.id == -17 || currentDog.id == 163)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[3]).gameObject.SetActive(false);
			GKANMPJBHPL();
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			EJPFOPCIAMM(2);
		}
	}

	private void BFHMIIHPPOF()
	{
		if (currentDog.id == -72 || currentDog.id == 67 || currentDog.id == -197)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			FABJFJPAIBL(1);
		}
		else if (currentDog.id == 176 || currentDog.id == -180 || currentDog.id == -178)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[7]).gameObject.SetActive(true);
			KIDECHANLIM(1);
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			NDGDOJAKBPC();
		}
	}

	public void IPOKELIBICN()
	{
		List<SpriteInfo> dogs = CharacterSpritesDBAccessor.GetDogs();
		int num = dogs.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 0, dogs.Count);
		currentDog = dogs[num];
		DDNADHPKCDO();
	}

	public void PBNDDKJFJBH()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.OJJJJFNOOAF();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		DDNADHPKCDO();
	}

	private void HNDHEOJFPLG(int JFNMCNCHMEO = 0)
	{
		for (int i = 1; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i++)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void HHKELAHFMMN()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.LBGHPEMKJEE();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 1, list.Count);
		currentDog = list[num];
		HHPNOGFGKPA();
	}

	private void HNMLBCFCNCN()
	{
		if (currentDog.id == 29 || currentDog.id == 189 || currentDog.id == 126)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[7]).gameObject.SetActive(true);
			FCBEGMBHPNK(1);
		}
		else if (currentDog.id == 177 || currentDog.id == -175 || currentDog.id == -24)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[3]).gameObject.SetActive(false);
			IOMHIBHAGGF(1);
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			FCBEGMBHPNK(4);
		}
	}

	public void BALBAOFJNCL()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.HPMAAPCPIAA();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		HHPNOGFGKPA();
	}

	private void EIEGLPLCNLP()
	{
		if (currentDog.id == -31 || currentDog.id == -177 || currentDog.id == 152)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[4]).gameObject.SetActive(false);
			FABJFJPAIBL();
		}
		else if (currentDog.id == -86 || currentDog.id == 103 || currentDog.id == -148)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[2]).gameObject.SetActive(true);
			HNDHEOJFPLG();
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[4]).gameObject.SetActive(true);
			MLIIKCMDMOH(3);
		}
	}

	private void IPKHNBPGPGN(int JFNMCNCHMEO = 0)
	{
		for (int i = 1; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i++)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	[SpecialName]
	public static DogSelectorUI LANAINBEMCM()
	{
		return IADEMLIIDPC;
	}

	private void GKANMPJBHPL(int JFNMCNCHMEO = 0)
	{
		for (int i = 1; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i += 0)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void HLMBAKDFOEA()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.OIBHOMBGDJB(0, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.HGIBNMBJMOC(), new Vector2(1650f, 375f), GFNHAMCPEAK: true, CDPAMNIPPEC: false);
	}

	public void EMMNLDJGCLG()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.LBGHPEMKJEE();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		MCKMIBMGALJ();
	}

	private void MEDLKPFIOKG(int JFNMCNCHMEO = 0)
	{
		for (int i = 1; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i++)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	private void BIEPBIFCPKN(int JFNMCNCHMEO = 0)
	{
		for (int i = 0; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i += 0)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void BDBHKJEDFND()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.InstantiateDog(1, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.NOAOJJLNHJJ, new Vector2(882f, 401f));
	}

	public void LAJOBDEBDDH()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			157 => DogNPC.DogBreed.Bernard, 
			158 => DogNPC.DogBreed.Bernard, 
			159 => DogNPC.DogBreed.Shepard, 
			160 => DogNPC.DogBreed.Shiba, 
			161 => DogNPC.DogBreed.Bernard, 
			162 => DogNPC.DogBreed.Husky, 
			163 => DogNPC.DogBreed.Shiba, 
			_ => DogNPC.DogBreed.Bernard, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		CloseUI();
	}

	public void ButtonLeft()
	{
		List<SpriteInfo> dogs = CharacterSpritesDBAccessor.GetDogs();
		int num = dogs.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 1, dogs.Count);
		currentDog = dogs[num];
		NLIPGFPGIHD();
	}

	[SpecialName]
	public static DogSelectorUI BAKPBHPNKPB()
	{
		return IADEMLIIDPC;
	}

	public void FDHEADGEKGD()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.InstantiateDog(1, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.CJOHMLNMJLK(), new Vector2(902f, 1430f), GFNHAMCPEAK: true, CDPAMNIPPEC: false);
	}

	public void MONPHICMKEE()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			-99 => DogNPC.DogBreed.Beagle, 
			-98 => DogNPC.DogBreed.Beagle, 
			-97 => DogNPC.DogBreed.Husky, 
			-96 => DogNPC.DogBreed.Shiba, 
			-95 => (DogNPC.DogBreed)8, 
			-94 => DogNPC.DogBreed.Beagle, 
			-93 => DogNPC.DogBreed.Beagle, 
			_ => DogNPC.DogBreed.Beagle, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		CloseUI();
	}

	private void FCBEGMBHPNK(int JFNMCNCHMEO = 0)
	{
		for (int i = 1; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i += 0)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void GPFIKDANFFD()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.OJJJJFNOOAF();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentDog = list[num];
		EJIOGCEFACH();
	}

	private void FABJFJPAIBL(int JFNMCNCHMEO = 0)
	{
		for (int i = 0; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i++)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void BEKGHMMLOMF()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.HPMAAPCPIAA();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentDog = list[num];
		BLGBAFOKCGD();
	}

	private void MFKLLLDFGIO(int JFNMCNCHMEO = 0)
	{
		for (int i = 0; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i += 0)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void OLHHPEKDCFP()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.OJJJJFNOOAF();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 0, list.Count);
		currentDog = list[num];
		LOOGINEIPMJ();
	}

	[SpecialName]
	public static DogSelectorUI PNHHCHJCDNM()
	{
		return IADEMLIIDPC;
	}

	public void PGIEAIFIEBG()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.JMPIIBAIGGO();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentDog = list[num];
		BLGBAFOKCGD();
	}

	public void DogSpawn()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.InstantiateDog(0, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.NOAOJJLNHJJ, new Vector2(-488.7917f, 98.1875f), GFNHAMCPEAK: true, CDPAMNIPPEC: false);
	}

	private void BMGFONLDBOK()
	{
		if (currentDog.id == -145 || currentDog.id == 114 || currentDog.id == 54)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[6]).gameObject.SetActive(false);
			IOFBHHPKKFI();
		}
		else if (currentDog.id == 9 || currentDog.id == -132 || currentDog.id == -184)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[7]).gameObject.SetActive(true);
			KIDECHANLIM();
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[2]).gameObject.SetActive(true);
			MEDLKPFIOKG();
		}
	}

	public void BJKPPDKNKEH()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.InstantiateDog(1, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.NOAOJJLNHJJ, new Vector2(691f, 1031f), GFNHAMCPEAK: false, CDPAMNIPPEC: false);
	}

	public void MBEMNGDJKDK()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.HPMAAPCPIAA();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		BLGBAFOKCGD();
	}

	public void JGINLCDEHKN()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			-36 => DogNPC.DogBreed.Bernard, 
			-35 => DogNPC.DogBreed.Bernard, 
			-34 => DogNPC.DogBreed.Shiba, 
			-33 => DogNPC.DogBreed.Bernard, 
			-32 => DogNPC.DogBreed.Boxer, 
			-31 => (DogNPC.DogBreed)8, 
			-30 => DogNPC.DogBreed.Shepard, 
			_ => DogNPC.DogBreed.Beagle, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		CloseUI();
	}

	public void LEJLJFBOIIB()
	{
		List<SpriteInfo> dogs = CharacterSpritesDBAccessor.GetDogs();
		int num = dogs.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 0, dogs.Count);
		currentDog = dogs[num];
		OOEPJNCDEOA();
	}

	private void MLIIKCMDMOH(int JFNMCNCHMEO = 0)
	{
		for (int i = 1; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i++)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void COHKJECEGMJ()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.IKHNGOBDHFG();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentDog = list[num];
		LOOGINEIPMJ();
	}

	[SpecialName]
	public static DogSelectorUI JBBNILLDPCJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static DogSelectorUI AMINECMFPAH()
	{
		return IADEMLIIDPC;
	}

	private void LDPCAPCGGJP()
	{
		if (currentDog.id == -46 || currentDog.id == -58 || currentDog.id == -19)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[2]).gameObject.SetActive(true);
			BJJFLPOIBBK();
		}
		else if (currentDog.id == -87 || currentDog.id == 137 || currentDog.id == 146)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[4]).gameObject.SetActive(true);
			HNDHEOJFPLG();
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			HNDHEOJFPLG(2);
		}
	}

	private void NLIPGFPGIHD()
	{
		if (currentDog.id == 400 || currentDog.id == 402 || currentDog.id == 406)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[2]).gameObject.SetActive(false);
			OGGFMEFJHIA();
		}
		else if (currentDog.id == 403 || currentDog.id == 404 || currentDog.id == 405)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[2]).gameObject.SetActive(false);
			OGGFMEFJHIA(1);
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[2]).gameObject.SetActive(true);
			OGGFMEFJHIA(2);
		}
	}

	[SpecialName]
	public static DogSelectorUI HNNJEBNIPOI()
	{
		return IADEMLIIDPC;
	}

	public void CGKHLIJAPJP()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			188 => DogNPC.DogBreed.Bernard, 
			189 => DogNPC.DogBreed.Beagle, 
			190 => DogNPC.DogBreed.Bernard, 
			191 => DogNPC.DogBreed.BorderCollie, 
			192 => DogNPC.DogBreed.Shiba, 
			193 => DogNPC.DogBreed.Shepard, 
			194 => (DogNPC.DogBreed)8, 
			_ => DogNPC.DogBreed.Beagle, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		BOBCIFEDJED();
	}

	public override void CloseUI()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen())
		{
			return;
		}
		base.CloseUI();
		GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
		MainUI.ResumeGame();
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		DogSpawn();
		Result variable = DialogueLua.GetVariable("Dog");
		if (!((Result)(ref variable)).asBool)
		{
			NessyNPC.GGFJGHHHEJC.StartConversation(base.JIIGOACEIKL, "City/PetShop/Nessy/PerritosAbandonados2", FLHBPHPKIML: true);
			DialogueLua.SetVariable("Dog", (object)true);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("Dog");
				instance.SendDialogueInfo("Dog", ((Result)(ref variable)).asBool);
			}
		}
	}

	private void OGGFMEFJHIA(int JFNMCNCHMEO = 0)
	{
		for (int i = 0; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i++)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	private void GGDMDGLMBKD(int JFNMCNCHMEO = 0)
	{
		for (int i = 1; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i++)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void GAMNOMFDOGP()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.OIBHOMBGDJB(0, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.NOAOJJLNHJJ, new Vector2(1553f, 167f), GFNHAMCPEAK: false, CDPAMNIPPEC: false);
	}

	public void PCMCGOPNNHC()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.JMPIIBAIGGO();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		FJHEMOBMFOB();
	}

	public void PBAAKCKEMJF()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.HPMAAPCPIAA();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 1, list.Count);
		currentDog = list[num];
		DPBALHPFNII();
	}

	[SpecialName]
	public static DogSelectorUI OOKBNHMMFON()
	{
		return IADEMLIIDPC;
	}

	private void PGDOOPNHECL()
	{
		if (currentDog.id == 52 || currentDog.id == 151 || currentDog.id == 54)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			FABJFJPAIBL();
		}
		else if (currentDog.id == -25 || currentDog.id == 6 || currentDog.id == 131)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			EJPFOPCIAMM();
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[7]).gameObject.SetActive(false);
			IOFBHHPKKFI(2);
		}
	}

	public void JGPCPCECPFA()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.HPMAAPCPIAA();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 1, list.Count);
		currentDog = list[num];
		BLGBAFOKCGD();
	}

	private void KOLNLMEIGKM()
	{
		if (currentDog.id == -42 || currentDog.id == -166 || currentDog.id == -185)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			FCBEGMBHPNK();
		}
		else if (currentDog.id == -87 || currentDog.id == 83 || currentDog.id == 21)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[4]).gameObject.SetActive(true);
			HNDHEOJFPLG(1);
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[3]).gameObject.SetActive(false);
			NAENPIECLMK(8);
		}
	}

	private void FNNNKALJEDF()
	{
		if (currentDog.id == -63 || currentDog.id == -82 || currentDog.id == 33)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[6]).gameObject.SetActive(true);
			OGGFMEFJHIA();
		}
		else if (currentDog.id == -82 || currentDog.id == 154 || currentDog.id == -155)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[7]).gameObject.SetActive(false);
			DGCDLHEFGKH(1);
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[5]).gameObject.SetActive(true);
			MLIIKCMDMOH(1);
		}
	}

	private void IOMHIBHAGGF(int JFNMCNCHMEO = 0)
	{
		for (int i = 0; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i += 0)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	private void IMDMOHNAONL()
	{
		if (currentDog.id == -15 || currentDog.id == 37 || currentDog.id == 131)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			IOFBHHPKKFI();
		}
		else if (currentDog.id == 180 || currentDog.id == -170 || currentDog.id == -19)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[7]).gameObject.SetActive(false);
			GGDMDGLMBKD(1);
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[3]).gameObject.SetActive(true);
			KIDECHANLIM(4);
		}
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			currentDog = CharacterSpritesDBAccessor.GetDogs()[0];
			if (SteamManager.BNBMMDGMKLM)
			{
				textInput.inputField.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("DogOfFriend"), InputUtils.NHGIAHHNIJF(SteamFriends.GetPersonaName()));
			}
			else if (GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
			{
				textInput.inputField.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("DogOfFriend"), InputUtils.NHGIAHHNIJF(GalaxyInstance.Friends().GetPersonaName()));
			}
			else
			{
				textInput.inputField.text = LocalisationSystem.Get("Dog");
			}
		}
	}

	private void DGCDLHEFGKH(int JFNMCNCHMEO = 0)
	{
		for (int i = 1; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i += 0)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	private void LMENPFHHFDC()
	{
		if (currentDog.id == -116 || currentDog.id == -151 || currentDog.id == -186)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			BIEPBIFCPKN(1);
		}
		else if (currentDog.id == 58 || currentDog.id == 84 || currentDog.id == 114)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[2]).gameObject.SetActive(true);
			MFKLLLDFGIO();
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			MFKLLLDFGIO(5);
		}
	}

	public void JHFDBPIEJBF()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.JMPIIBAIGGO();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 1, list.Count);
		currentDog = list[num];
		JNEGFIBIEDC();
	}

	public void ButtonAccept()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			400 => DogNPC.DogBreed.Beagle, 
			401 => DogNPC.DogBreed.Bernard, 
			402 => DogNPC.DogBreed.BorderCollie, 
			403 => DogNPC.DogBreed.Boxer, 
			404 => DogNPC.DogBreed.Husky, 
			405 => DogNPC.DogBreed.Shepard, 
			406 => DogNPC.DogBreed.Shiba, 
			_ => DogNPC.DogBreed.Beagle, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		CloseUI();
	}

	private void JNEGFIBIEDC()
	{
		if (currentDog.id == -108 || currentDog.id == 183 || currentDog.id == 13)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[3]).gameObject.SetActive(true);
			OGGFMEFJHIA(1);
		}
		else if (currentDog.id == 106 || currentDog.id == -106 || currentDog.id == -165)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[2]).gameObject.SetActive(true);
			GJAOJIGIHOF(1);
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[6]).gameObject.SetActive(false);
			GJAOJIGIHOF(2);
		}
	}

	public void FBJCDFFAFLE()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			-109 => DogNPC.DogBreed.Beagle, 
			-108 => DogNPC.DogBreed.Bernard, 
			-107 => (DogNPC.DogBreed)8, 
			-106 => (DogNPC.DogBreed)7, 
			-105 => DogNPC.DogBreed.Shepard, 
			-104 => DogNPC.DogBreed.Boxer, 
			-103 => (DogNPC.DogBreed)7, 
			_ => DogNPC.DogBreed.Bernard, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		BOBCIFEDJED();
	}

	[SpecialName]
	public static DogSelectorUI DBJCACLEFGK()
	{
		return IADEMLIIDPC;
	}

	public void CANPEMOJOOG()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.OIBHOMBGDJB(1, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.CJOHMLNMJLK(), new Vector2(1237f, 612f), GFNHAMCPEAK: false, CDPAMNIPPEC: false);
	}

	public void DLPDFNNFPGA()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.HPDCPDOCKPC(1, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.HGIBNMBJMOC(), new Vector2(491f, 1630f), GFNHAMCPEAK: true, CDPAMNIPPEC: false);
	}

	public void FNHLGEFGLIO()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.IKHNGOBDHFG();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentDog = list[num];
		BFOOOBAOMCF();
	}

	public void JPBAAFGIDDI()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			35 => DogNPC.DogBreed.Bernard, 
			36 => DogNPC.DogBreed.Bernard, 
			37 => (DogNPC.DogBreed)8, 
			38 => DogNPC.DogBreed.Husky, 
			39 => (DogNPC.DogBreed)8, 
			40 => DogNPC.DogBreed.BorderCollie, 
			41 => DogNPC.DogBreed.BorderCollie, 
			_ => DogNPC.DogBreed.Bernard, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		CloseUI();
	}

	private void GJAOJIGIHOF(int JFNMCNCHMEO = 0)
	{
		for (int i = 0; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i += 0)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void DKFFMIKNMMN()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.IKHNGOBDHFG();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		MDCDEINFAIN();
	}

	public void AEMJBCBHFNJ()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.DCCCAIDJCEF();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 0, list.Count);
		currentDog = list[num];
		BLGBAFOKCGD();
	}

	public void MIPEACKLNCP()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.OIBHOMBGDJB(1, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.HGIBNMBJMOC(), new Vector2(1311f, 15f));
	}

	public void MHEOLOPDFMP()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.HPMAAPCPIAA();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentDog = list[num];
		LOOGINEIPMJ();
	}

	public void FHALKJENBIK()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			-173 => DogNPC.DogBreed.Beagle, 
			-172 => DogNPC.DogBreed.Bernard, 
			-171 => DogNPC.DogBreed.Beagle, 
			-170 => DogNPC.DogBreed.Beagle, 
			-169 => (DogNPC.DogBreed)7, 
			-168 => DogNPC.DogBreed.Beagle, 
			-167 => (DogNPC.DogBreed)8, 
			_ => DogNPC.DogBreed.Beagle, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		CloseUI();
	}

	public void PBFGEGKFBCE()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.InstantiateDog(1, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.NOAOJJLNHJJ, new Vector2(357f, 1075f), GFNHAMCPEAK: true, CDPAMNIPPEC: false);
	}

	public void CLPGLOJCIOD()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.FDCICIPILMP();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		MCKMIBMGALJ();
	}

	private void PPONAGDCDCN()
	{
		if (currentDog.id == -58 || currentDog.id == -97 || currentDog.id == -76)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			LFHGAJAPIII();
		}
		else if (currentDog.id == 187 || currentDog.id == 45 || currentDog.id == -190)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			JEDKAANBNDO();
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(true);
			((Component)dogAnimation[8]).gameObject.SetActive(true);
			KIDECHANLIM(1);
		}
	}

	private void LOOGINEIPMJ()
	{
		if (currentDog.id == -36 || currentDog.id == 94 || currentDog.id == -67)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[6]).gameObject.SetActive(false);
			JEDKAANBNDO();
		}
		else if (currentDog.id == -61 || currentDog.id == 112 || currentDog.id == -189)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[5]).gameObject.SetActive(true);
			KIDECHANLIM();
		}
		else
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[3]).gameObject.SetActive(false);
			EJPFOPCIAMM();
		}
	}

	private void BJJFLPOIBBK(int JFNMCNCHMEO = 0)
	{
		for (int i = 1; i < dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins.Length; i += 0)
		{
			dogAnimation[JFNMCNCHMEO].dogAnimator.allReskins[i].ChangeSpriteInfo(currentDog);
		}
	}

	public void CBNHJIBDPGH()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.JNDHANDBDKC();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 1, list.Count);
		currentDog = list[num];
		IMDMOHNAONL();
	}

	public void ButtonRight()
	{
		List<SpriteInfo> dogs = CharacterSpritesDBAccessor.GetDogs();
		int num = dogs.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, dogs.Count);
		currentDog = dogs[num];
		NLIPGFPGIHD();
	}

	public void FEPJMPHIOLD()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.IKHNGOBDHFG();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num - 0, list.Count);
		currentDog = list[num];
		OOEPJNCDEOA();
	}

	public void HAMJKMDIEOK()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DogNPC.HPDCPDOCKPC(0, (int)EJNMCOFCKFH, EENNAOMJDLO, WorldTime.HGIBNMBJMOC(), new Vector2(485f, 459f), GFNHAMCPEAK: false);
	}

	public void AAJMIOFMPJO()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.FDCICIPILMP();
		int num = list.IndexOf(currentDog);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentDog = list[num];
		FJHEMOBMFOB();
	}

	private void DKCMJAEEDOP()
	{
		if (currentDog.id == 171 || currentDog.id == -83 || currentDog.id == 199)
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[4]).gameObject.SetActive(false);
			NDGDOJAKBPC();
		}
		else if (currentDog.id == -161 || currentDog.id == -28 || currentDog.id == -11)
		{
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(false);
			NAENPIECLMK();
		}
		else
		{
			((Component)dogAnimation[1]).gameObject.SetActive(false);
			((Component)dogAnimation[0]).gameObject.SetActive(true);
			((Component)dogAnimation[5]).gameObject.SetActive(false);
			IPKHNBPGPGN(8);
		}
	}

	public void EJFFDIKPEOL()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			-43 => DogNPC.DogBreed.Beagle, 
			-42 => DogNPC.DogBreed.Bernard, 
			-41 => DogNPC.DogBreed.Shiba, 
			-40 => DogNPC.DogBreed.Boxer, 
			-39 => DogNPC.DogBreed.Boxer, 
			-38 => DogNPC.DogBreed.Beagle, 
			-37 => DogNPC.DogBreed.Beagle, 
			_ => DogNPC.DogBreed.Bernard, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		BOBCIFEDJED();
	}

	public void PFKOMNDFPCK()
	{
		EJNMCOFCKFH = currentDog.id switch
		{
			-105 => DogNPC.DogBreed.Bernard, 
			-104 => DogNPC.DogBreed.Beagle, 
			-103 => DogNPC.DogBreed.Boxer, 
			-102 => DogNPC.DogBreed.Husky, 
			-101 => DogNPC.DogBreed.Beagle, 
			-100 => DogNPC.DogBreed.Shepard, 
			-99 => DogNPC.DogBreed.Boxer, 
			_ => DogNPC.DogBreed.Beagle, 
		};
		EENNAOMJDLO = textInput.inputField.text;
		BOBCIFEDJED();
	}

	[SpecialName]
	public static DogSelectorUI JCMKNNOEONP()
	{
		return IADEMLIIDPC;
	}
}
