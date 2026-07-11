using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimalShopUI : ShopBaseUI
{
	[CompilerGenerated]
	private sealed class ABOGJJNHNAC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimalShopUI _003C_003E4__this;

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
		public ABOGJJNHNAC(int _003C_003E1__state)
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
			AnimalShopUI animalShopUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(animalShopUI.JIIGOACEIKL))
				{
					if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
					{
						UISelectionManager.GetPlayer(animalShopUI.JIIGOACEIKL).Select(animalShopUI.firstElement);
					}
					else
					{
						UISelectionManager.GetPlayer(animalShopUI.JIIGOACEIKL).Select(animalShopUI.lastElement);
					}
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

	public static AnimalShopUI[] instances = new AnimalShopUI[3];

	public ChickenAnimation chickenAnimation;

	public PigAnimation pigAnimation;

	public CowAnimation cowAnimation;

	public SheepAnimation sheepAnimation;

	public GameObject firstElement;

	public GameObject lastElement;

	private AnimalType IOFIBBFLPKO;

	public static AnimalShopUI FBKOKJCKICN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JBHAOMNDEAM()
	{
		if (IOFIBBFLPKO == AnimalType.Pig)
		{
			OMLEGMEENON(cowAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			GKLNPBAGAGO(sheepAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			LHMAKDKFNML(pigAnimation, optionsElements[4]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			HGMHGMPJABK(chickenAnimation, optionsElements[6]);
		}
	}

	public void KHGODKAKKLM(int ABAIKKGKDGD)
	{
		INHFPPBMLDO(ABAIKKGKDGD);
	}

	private void EDPGAAGOCMA(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.ForceSetUpDatabase();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.MEDIJHPNCMD(GKCKLNELMIC.shopElement, 0, OLMEEOAEMED: true);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(GKCKLNELMIC.shopElement.BNFDKIDPEFD() as AnimalInstance, OBDGKOCOLIN: true);
			FFHHEGALBKO.ForceDirection((Direction)5);
		}
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			base.CloseUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			InteractObject.GetPlayer(base.JIIGOACEIKL).KOHOJLBBENG = false;
			ClearBasket();
			ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = true;
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void HAMOMCJFKFK()
	{
		if (IOFIBBFLPKO == (AnimalType)4)
		{
			OBKMLPDAOKH(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == (AnimalType)7)
		{
			ICNAJDBMFPH(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			FMKELLCMLAP(pigAnimation, optionsElements[7]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			GKLNPBAGAGO(chickenAnimation, optionsElements[4]);
		}
	}

	public void BJMKADDLGAN()
	{
		if (IOFIBBFLPKO == AnimalType.Sheep)
		{
			ICNAJDBMFPH(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == (AnimalType)7)
		{
			IIEOBMOBPGB(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			INOMBHLEHIA(pigAnimation, optionsElements[2]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			AIEBJBAAGKM(chickenAnimation, optionsElements[5]);
		}
	}

	private void AIEBJBAAGKM(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.EKGPEFAJMDE();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 0, animalInstance);
		GKCKLNELMIC.DGOBOFJOFKO(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: true);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.MFJCPADIAMJ(GKCKLNELMIC.shopElement.KIPHICGPKHO() as AnimalInstance);
			FFHHEGALBKO.ForceDirection(Direction.Up);
		}
	}

	public static AnimalShopUI JOAAFGBPJOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void BNIMEJOJFKP()
	{
		((MonoBehaviour)this).StartCoroutine(PBCDJFLNNKG());
	}

	private IEnumerator GMAAOGEOLGE()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FMMGBBJCBAH()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElement);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(lastElement);
			}
		}
	}

	public void LEDGDNFDAHO()
	{
		((MonoBehaviour)this).StartCoroutine(ACNHBEEBIGG());
	}

	private void OMLEGMEENON(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.CLMAAJIPNAH();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.SetShopItem(GKCKLNELMIC.shopElement, 0, OLMEEOAEMED: true);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.KGIFGHKCOFC(GKCKLNELMIC.shopElement.FOFEOHPPMMA() as AnimalInstance);
			FFHHEGALBKO.ForceDirection(Direction.Right);
		}
	}

	public void NKFCOOFNIIP()
	{
		((MonoBehaviour)this).StartCoroutine(LMAIPMADGDB());
	}

	private void MJNCPBLNGIO(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.ForceSetUpDatabase();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.JFDILLFNLPP(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: true);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.KGIFGHKCOFC(GKCKLNELMIC.shopElement.HHBICHCGPPK() as AnimalInstance);
			FFHHEGALBKO.GAGOGFEBDCP(Direction.Up);
		}
	}

	public void CNKGAKFPOBG()
	{
		((MonoBehaviour)this).StartCoroutine(HMGOPGMPNIH());
	}

	private IEnumerator DIIMLICGIMJ()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElement);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(lastElement);
			}
		}
	}

	public static AnimalShopUI EIMDPBGBBIF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CCKAMGGPDIM(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			if (optionsElements[1].shopElement.FOFEOHPPMMA() != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.LGCKPJCGCAK(optionsElements[1].shopElement.BKCJMBGKDNA() as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Chicken;
		}
		else if (ABAIKKGKDGD == 0)
		{
			if (optionsElements[0].shopElement.BNFDKIDPEFD() != null && (Object)(object)sheepAnimation != (Object)null)
			{
				sheepAnimation.animalAnimator.PEECGCDGNOB(optionsElements[0].shopElement.PGDLGEMHCOH() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = (AnimalType)7;
		}
		else
		{
			switch (ABAIKKGKDGD)
			{
			case 0:
				if (optionsElements[3].shopElement.itemInstance != null && (Object)(object)pigAnimation != (Object)null)
				{
					pigAnimation.animalAnimator.EPEJFHPAFFL(optionsElements[2].shopElement.BKCJMBGKDNA() as AnimalInstance);
				}
				IOFIBBFLPKO = AnimalType.Pig;
				break;
			case 1:
				if (optionsElements[2].shopElement.AFOOOEAJCNP() != null && (Object)(object)chickenAnimation != (Object)null)
				{
					chickenAnimation.animalAnimator.PEECGCDGNOB(optionsElements[4].shopElement.PGDLGEMHCOH() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = AnimalType.Pig;
				break;
			}
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Cow);
			cowAnimation.GAGOGFEBDCP((Direction)5);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Cow);
			sheepAnimation.GAGOGFEBDCP(Direction.Up);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			pigAnimation.GAGOGFEBDCP((Direction)5);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			chickenAnimation.GAGOGFEBDCP((Direction)6);
		}
	}

	private void ODEBJGBOFNF(int ABAIKKGKDGD)
	{
		switch (ABAIKKGKDGD)
		{
		case 0:
			if (optionsElements[1].shopElement.itemInstance != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.MFJCPADIAMJ(optionsElements[1].shopElement.KIPHICGPKHO() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = AnimalType.Chicken;
			break;
		case 1:
			if (optionsElements[1].shopElement.IAAECDPPPKD() != null && (Object)(object)sheepAnimation != (Object)null)
			{
				sheepAnimation.animalAnimator.DLKMKOMMOEK(optionsElements[1].shopElement.PGDLGEMHCOH() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = AnimalType.Sheep;
			break;
		case 8:
			if (optionsElements[5].shopElement.PGDLGEMHCOH() != null && (Object)(object)pigAnimation != (Object)null)
			{
				pigAnimation.animalAnimator.DCAFPHAMHFC(optionsElements[3].shopElement.HHBICHCGPPK() as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Pig;
			break;
		case 3:
			if (optionsElements[4].shopElement.PBBFBFFPFJC() != null && (Object)(object)chickenAnimation != (Object)null)
			{
				chickenAnimation.animalAnimator.AEBBABIBLND(optionsElements[1].shopElement.IAAECDPPPKD() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = AnimalType.Pig;
			break;
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			cowAnimation.ForceDirection((Direction)8);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Cow);
			sheepAnimation.GAGOGFEBDCP((Direction)7);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			pigAnimation.ForceDirection((Direction)5);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			chickenAnimation.ForceDirection((Direction)8);
		}
	}

	public static AnimalShopUI IPDFCJLOHLC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator FAGBHHPGMLA()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FDJKHCCCHCF(int ABAIKKGKDGD)
	{
		ANNDEAIHEKD(ABAIKKGKDGD);
	}

	private void GLMDLCNIAIJ(int ABAIKKGKDGD)
	{
		switch (ABAIKKGKDGD)
		{
		case 0:
			if (optionsElements[1].shopElement.IAAECDPPPKD() != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.IOPDGOIGBPL(optionsElements[0].shopElement.BNFDKIDPEFD() as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Cow;
			break;
		case 1:
			if (optionsElements[0].shopElement.HHBICHCGPPK() != null && (Object)(object)sheepAnimation != (Object)null)
			{
				sheepAnimation.animalAnimator.FFBFELKDNII(optionsElements[1].shopElement.itemInstance as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = (AnimalType)7;
			break;
		case 2:
			if (optionsElements[8].shopElement.HHBICHCGPPK() != null && (Object)(object)pigAnimation != (Object)null)
			{
				pigAnimation.animalAnimator.PEECGCDGNOB(optionsElements[1].shopElement.PJAFAAGCMEI() as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Pig;
			break;
		case 4:
			if (optionsElements[5].shopElement.FOFEOHPPMMA() != null && (Object)(object)chickenAnimation != (Object)null)
			{
				chickenAnimation.animalAnimator.MFJCPADIAMJ(optionsElements[6].shopElement.FOFEOHPPMMA() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = AnimalType.Chicken;
			break;
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			cowAnimation.GAGOGFEBDCP((Direction)6);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == (AnimalType)6);
			sheepAnimation.GAGOGFEBDCP(Direction.Left);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			pigAnimation.ForceDirection((Direction)8);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			chickenAnimation.GAGOGFEBDCP(Direction.Up);
		}
	}

	public void AKCDJKBKIOF()
	{
		((MonoBehaviour)this).StartCoroutine(HMGOPGMPNIH());
	}

	public override void OnContentActivated()
	{
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(false);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(false);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(false);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(false);
		}
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(PBCDJFLNNKG());
		}
		if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
		{
			for (int i = 0; i < 3; i++)
			{
				((Component)optionsElements[i]).gameObject.SetActive(true);
			}
		}
		if ((Object)(object)FarmConstructionManager.GetHenHouse() != (Object)null)
		{
			((Component)optionsElements[3]).gameObject.SetActive(true);
		}
	}

	private IEnumerator NHBHFPFPGBC()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElement);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(lastElement);
			}
		}
	}

	public void JMCMKNKJAFL()
	{
		if (IOFIBBFLPKO == (AnimalType)4)
		{
			HGMHGMPJABK(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Cow)
		{
			IGPNNPLLCFA(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			CMGJLJKFNCA(pigAnimation, optionsElements[3]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			AIEBJBAAGKM(chickenAnimation, optionsElements[7]);
		}
	}

	public void EJBEHHKMPLF(int ABAIKKGKDGD)
	{
		LONMCABFOCM(ABAIKKGKDGD);
	}

	public static AnimalShopUI BFCEHJIIAHN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DDAMGIBABOP()
	{
		((MonoBehaviour)this).StartCoroutine(IBEGGLBCCEL());
	}

	public void AOPNIJBEBDB()
	{
		if (IOFIBBFLPKO == (AnimalType)6)
		{
			AIEBJBAAGKM(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == (AnimalType)5)
		{
			MJNCPBLNGIO(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			OBKMLPDAOKH(pigAnimation, optionsElements[6]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			HGMHGMPJABK(chickenAnimation, optionsElements[3]);
		}
	}

	private IEnumerator BLNGACBEDAD()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	public static AnimalShopUI MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JKPDPBFONCL(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.OACKGECPIKJ();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = true;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 0, animalInstance);
		GKCKLNELMIC.DGOBOFJOFKO(GKCKLNELMIC.shopElement, 0, OLMEEOAEMED: false);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.KGIFGHKCOFC(GKCKLNELMIC.shopElement.KIPHICGPKHO() as AnimalInstance);
			FFHHEGALBKO.GAGOGFEBDCP((Direction)6);
		}
	}

	public void EFEFFDCMILO()
	{
		if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			EDPGAAGOCMA(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			CMGJLJKFNCA(sheepAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			GKLNPBAGAGO(pigAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			CMGJLJKFNCA(chickenAnimation, optionsElements[4]);
		}
	}

	public void JEANPODBPKH()
	{
		if (IOFIBBFLPKO == (AnimalType)4)
		{
			FLPMBEDCENK(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == (AnimalType)8)
		{
			CLMKMELNNBL(sheepAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			GECNEHDLBAE(pigAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			CLMKMELNNBL(chickenAnimation, optionsElements[3]);
		}
	}

	public void GGGCCKMNLKN(int ABAIKKGKDGD)
	{
		LMJPCKCINDP(ABAIKKGKDGD);
	}

	private IEnumerator ACNHBEEBIGG()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElement);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(lastElement);
			}
		}
	}

	public void BDGACNMIHNG()
	{
		if (IOFIBBFLPKO == (AnimalType)5)
		{
			INOMBHLEHIA(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			CLMKMELNNBL(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			INOMBHLEHIA(pigAnimation, optionsElements[4]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			EDPGAAGOCMA(chickenAnimation, optionsElements[5]);
		}
	}

	private void IGPNNPLLCFA(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.OACKGECPIKJ();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = true;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 0, animalInstance);
		GKCKLNELMIC.JFDILLFNLPP(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: true);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(GKCKLNELMIC.shopElement.BNFDKIDPEFD() as AnimalInstance, OBDGKOCOLIN: true);
			FFHHEGALBKO.ForceDirection(Direction.Diagonal);
		}
	}

	public void MAGIOKPAENN()
	{
		((MonoBehaviour)this).StartCoroutine(GMLAFKLOLLC());
	}

	public void OHPDKDOOLLE(int ABAIKKGKDGD)
	{
		LMJPCKCINDP(ABAIKKGKDGD);
	}

	public void RandomSkin()
	{
		if (IOFIBBFLPKO == AnimalType.Cow)
		{
			CMGJLJKFNCA(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Sheep)
		{
			CMGJLJKFNCA(sheepAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			CMGJLJKFNCA(pigAnimation, optionsElements[2]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			CMGJLJKFNCA(chickenAnimation, optionsElements[3]);
		}
	}

	private void PBOCMKDENLH(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			if (optionsElements[1].shopElement.NKCMJAOFLFH() != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.DLKMKOMMOEK(optionsElements[1].shopElement.PGDLGEMHCOH() as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Sheep;
		}
		else
		{
			switch (ABAIKKGKDGD)
			{
			case 0:
				if (optionsElements[1].shopElement.MFGDIJDAJII() != null && (Object)(object)sheepAnimation != (Object)null)
				{
					sheepAnimation.animalAnimator.HKCIJHIJPBG(optionsElements[0].shopElement.IAAECDPPPKD() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = (AnimalType)6;
				break;
			case 7:
				if (optionsElements[1].shopElement.NGKPILAELHO() != null && (Object)(object)pigAnimation != (Object)null)
				{
					pigAnimation.animalAnimator.DCAFPHAMHFC(optionsElements[5].shopElement.AFOOOEAJCNP() as AnimalInstance);
				}
				IOFIBBFLPKO = AnimalType.Chicken;
				break;
			default:
				if (ABAIKKGKDGD == 7)
				{
					if (optionsElements[6].shopElement.BODBEPJAFHL() != null && (Object)(object)chickenAnimation != (Object)null)
					{
						chickenAnimation.animalAnimator.NINEAKFMMNN(optionsElements[8].shopElement.AFOOOEAJCNP() as AnimalInstance, OBDGKOCOLIN: true);
					}
					IOFIBBFLPKO = AnimalType.Chicken;
				}
				break;
			}
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == (AnimalType)6);
			cowAnimation.ForceDirection(Direction.Down);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == (AnimalType)8);
			sheepAnimation.GAGOGFEBDCP(Direction.Down);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			pigAnimation.ForceDirection(Direction.Up);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			chickenAnimation.GAGOGFEBDCP(Direction.Down);
		}
	}

	public void HDMDDPPFNPB()
	{
		if (IOFIBBFLPKO == (AnimalType)6)
		{
			CMGJLJKFNCA(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Cow)
		{
			OABKFEFLJKF(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			KCIJPGOKGLE(pigAnimation, optionsElements[3]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			OBKMLPDAOKH(chickenAnimation, optionsElements[4]);
		}
	}

	private IEnumerator GMLAFKLOLLC()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IEDCIAKLAGA()
	{
		if (IOFIBBFLPKO == (AnimalType)6)
		{
			FLPMBEDCENK(cowAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == (AnimalType)4)
		{
			AIEBJBAAGKM(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			CLMKMELNNBL(pigAnimation, optionsElements[8]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			OMLEGMEENON(chickenAnimation, optionsElements[4]);
		}
	}

	private void IIEOBMOBPGB(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.EKICPODMHOF();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = true;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.SetShopItem(GKCKLNELMIC.shopElement, 0, OLMEEOAEMED: false);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.FHJBLKBDOKN(GKCKLNELMIC.shopElement.FOFEOHPPMMA() as AnimalInstance);
			FFHHEGALBKO.ForceDirection((Direction)8);
		}
	}

	public void FJAMFCFLCBM(int ABAIKKGKDGD)
	{
		DHPJOPPLFPP(ABAIKKGKDGD);
	}

	public static AnimalShopUI JELOGNCPDAB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static AnimalShopUI IMLMJAPMBJA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PPEMOGHNNAA(int ABAIKKGKDGD)
	{
		switch (ABAIKKGKDGD)
		{
		case 0:
			if (optionsElements[0].shopElement.itemInstance != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.SetAnimalSkin(optionsElements[0].shopElement.itemInstance as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Cow;
			break;
		case 1:
			if (optionsElements[1].shopElement.itemInstance != null && (Object)(object)sheepAnimation != (Object)null)
			{
				sheepAnimation.animalAnimator.SetAnimalSkin(optionsElements[1].shopElement.itemInstance as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Sheep;
			break;
		case 2:
			if (optionsElements[2].shopElement.itemInstance != null && (Object)(object)pigAnimation != (Object)null)
			{
				pigAnimation.animalAnimator.SetAnimalSkin(optionsElements[2].shopElement.itemInstance as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Pig;
			break;
		case 3:
			if (optionsElements[3].shopElement.itemInstance != null && (Object)(object)chickenAnimation != (Object)null)
			{
				chickenAnimation.animalAnimator.SetAnimalSkin(optionsElements[3].shopElement.itemInstance as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Chicken;
			break;
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Cow);
			cowAnimation.ForceDirection(Direction.Right);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Sheep);
			sheepAnimation.ForceDirection(Direction.Right);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			pigAnimation.ForceDirection(Direction.Right);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			chickenAnimation.ForceDirection(Direction.Right);
		}
	}

	private void GKLNPBAGAGO(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.EKICPODMHOF();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = true;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.SetShopItem(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: false);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.HKCIJHIJPBG(GKCKLNELMIC.shopElement.FOFEOHPPMMA() as AnimalInstance, OBDGKOCOLIN: true);
			FFHHEGALBKO.ForceDirection(Direction.Left);
		}
	}

	protected override void Update()
	{
		base.Update();
		if (LKOJBFMGMAE && PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UIAddRemove") || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp"))
			{
				OrderBasket();
			}
			else if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UISelectGamepad"))
			{
				RandomSkin();
			}
		}
	}

	public static AnimalShopUI AANKLOIDPOA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator HMGOPGMPNIH()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FLPMBEDCENK(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.CLMAAJIPNAH();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = true;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.DGOBOFJOFKO(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: true);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(GKCKLNELMIC.shopElement.MFGDIJDAJII() as AnimalInstance, OBDGKOCOLIN: true);
			FFHHEGALBKO.ForceDirection(Direction.Up);
		}
	}

	public void BLNJNDOKIDD()
	{
		if (IOFIBBFLPKO == (AnimalType)8)
		{
			NAGKKELBLDI(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == (AnimalType)5)
		{
			CLMKMELNNBL(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			NAGKKELBLDI(pigAnimation, optionsElements[5]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			JKPDPBFONCL(chickenAnimation, optionsElements[7]);
		}
	}

	private void FMKELLCMLAP(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.EKGPEFAJMDE();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 0, animalInstance);
		GKCKLNELMIC.DGOBOFJOFKO(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: true);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(GKCKLNELMIC.shopElement.FOFEOHPPMMA() as AnimalInstance, OBDGKOCOLIN: true);
			FFHHEGALBKO.GAGOGFEBDCP((Direction)6);
		}
	}

	public void NBHKFCNIOHK(int ABAIKKGKDGD)
	{
		PPEMOGHNNAA(ABAIKKGKDGD);
	}

	public void IKGMIBCGDHL()
	{
		((MonoBehaviour)this).StartCoroutine(FAGBHHPGMLA());
	}

	private void INOMBHLEHIA(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.ForceSetUpDatabase();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = true;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.JFDILLFNLPP(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: false);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(GKCKLNELMIC.shopElement.HHBICHCGPPK() as AnimalInstance);
			FFHHEGALBKO.ForceDirection(Direction.Diagonal);
		}
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			base.OpenUI();
			Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Metal, ((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform);
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = false;
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	private IEnumerator FAPFHLKFHNJ()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElement);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(lastElement);
			}
		}
	}

	private void ICNAJDBMFPH(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.OACKGECPIKJ();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = true;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 0, animalInstance);
		GKCKLNELMIC.SetShopItem(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: true);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(GKCKLNELMIC.shopElement.AFOOOEAJCNP() as AnimalInstance);
			FFHHEGALBKO.GAGOGFEBDCP((Direction)5);
		}
	}

	public static AnimalShopUI JCBPABNCBPI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static AnimalShopUI PHDBJGOEKHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator IBEGGLBCCEL()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BCIDBFJGJPE()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	public static AnimalShopUI FFBJPAJKOJH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CHKPPAHCBKL(int ABAIKKGKDGD)
	{
		HDGEPILAAFP(ABAIKKGKDGD);
	}

	public static AnimalShopUI IJJJEMKCNJM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FDPEKLDKJAB()
	{
		if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			GECNEHDLBAE(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Cow)
		{
			MJNCPBLNGIO(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			OABKFEFLJKF(pigAnimation, optionsElements[6]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			IGPNNPLLCFA(chickenAnimation, optionsElements[3]);
		}
	}

	public void GLNJMFKHIBG()
	{
		if (IOFIBBFLPKO == (AnimalType)8)
		{
			CLMKMELNNBL(cowAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == (AnimalType)8)
		{
			NAGKKELBLDI(sheepAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			GECNEHDLBAE(pigAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			CLMKMELNNBL(chickenAnimation, optionsElements[2]);
		}
	}

	private void ANNDEAIHEKD(int ABAIKKGKDGD)
	{
		switch (ABAIKKGKDGD)
		{
		case 0:
			if (optionsElements[0].shopElement.PJAFAAGCMEI() != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.BOMOGFIEKHD(optionsElements[0].shopElement.NGKPILAELHO() as AnimalInstance);
			}
			IOFIBBFLPKO = (AnimalType)8;
			break;
		case 1:
			if (optionsElements[0].shopElement.FOFEOHPPMMA() != null && (Object)(object)sheepAnimation != (Object)null)
			{
				sheepAnimation.animalAnimator.ELDGKDDLHNN(optionsElements[0].shopElement.BODBEPJAFHL() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = AnimalType.Cow;
			break;
		case 4:
			if (optionsElements[6].shopElement.FOFEOHPPMMA() != null && (Object)(object)pigAnimation != (Object)null)
			{
				pigAnimation.animalAnimator.EPEJFHPAFFL(optionsElements[2].shopElement.AFOOOEAJCNP() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = AnimalType.Pig;
			break;
		case 6:
			if (optionsElements[0].shopElement.PGDLGEMHCOH() != null && (Object)(object)chickenAnimation != (Object)null)
			{
				chickenAnimation.animalAnimator.CHAOEBIPCFJ(optionsElements[3].shopElement.PGDLGEMHCOH() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = AnimalType.Chicken;
			break;
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Cow);
			cowAnimation.GAGOGFEBDCP(Direction.Up);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == (AnimalType)4);
			sheepAnimation.ForceDirection((Direction)6);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			pigAnimation.ForceDirection(Direction.Down);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			chickenAnimation.GAGOGFEBDCP(Direction.Up);
		}
	}

	public static AnimalShopUI AGNKKAPMHLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LONMCABFOCM(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			if (optionsElements[1].shopElement.BODBEPJAFHL() != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.FHJBLKBDOKN(optionsElements[0].shopElement.PJAFAAGCMEI() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = (AnimalType)6;
		}
		else
		{
			switch (ABAIKKGKDGD)
			{
			case 0:
				if (optionsElements[0].shopElement.MFGDIJDAJII() != null && (Object)(object)sheepAnimation != (Object)null)
				{
					sheepAnimation.animalAnimator.FFOLBNHJIAD(optionsElements[1].shopElement.itemInstance as AnimalInstance);
				}
				IOFIBBFLPKO = (AnimalType)4;
				break;
			case 3:
				if (optionsElements[3].shopElement.BODBEPJAFHL() != null && (Object)(object)pigAnimation != (Object)null)
				{
					pigAnimation.animalAnimator.KGIFGHKCOFC(optionsElements[6].shopElement.MFGDIJDAJII() as AnimalInstance);
				}
				IOFIBBFLPKO = AnimalType.Chicken;
				break;
			case 6:
				if (optionsElements[4].shopElement.PBBFBFFPFJC() != null && (Object)(object)chickenAnimation != (Object)null)
				{
					chickenAnimation.animalAnimator.HNAMLLBLGIG(optionsElements[1].shopElement.BKCJMBGKDNA() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = AnimalType.Pig;
				break;
			}
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Sheep);
			cowAnimation.ForceDirection(Direction.Up);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == (AnimalType)4);
			sheepAnimation.ForceDirection((Direction)5);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			pigAnimation.ForceDirection(Direction.Diagonal);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			chickenAnimation.ForceDirection(Direction.Down);
		}
	}

	private void HGMHGMPJABK(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.OACKGECPIKJ();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.JFDILLFNLPP(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: true);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.AEBBABIBLND(GKCKLNELMIC.shopElement.NKCMJAOFLFH() as AnimalInstance, OBDGKOCOLIN: true);
			FFHHEGALBKO.GAGOGFEBDCP((Direction)7);
		}
	}

	public void CNFLPPKCAKO(int ABAIKKGKDGD)
	{
		PPEMOGHNNAA(ABAIKKGKDGD);
	}

	public static AnimalShopUI HINOELPNLLC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LKOBDDPBKJH(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.CLMAAJIPNAH();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.MEDIJHPNCMD(GKCKLNELMIC.shopElement, 0, OLMEEOAEMED: false);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(GKCKLNELMIC.shopElement.PBBFBFFPFJC() as AnimalInstance, OBDGKOCOLIN: true);
			FFHHEGALBKO.GAGOGFEBDCP(Direction.Right);
		}
	}

	private IEnumerator LNODIAOMNCH()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PPLKDFIAHPL()
	{
		((MonoBehaviour)this).StartCoroutine(ELHIBHFOONN());
	}

	private void CLMKMELNNBL(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.EKICPODMHOF();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.MEDIJHPNCMD(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: false);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(GKCKLNELMIC.shopElement.IAAECDPPPKD() as AnimalInstance);
			FFHHEGALBKO.GAGOGFEBDCP((Direction)7);
		}
	}

	public static AnimalShopUI PNBHIEINMGH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator LMAIPMADGDB()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElement);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(lastElement);
			}
		}
	}

	private void LMJPCKCINDP(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			if (optionsElements[1].shopElement.BNFDKIDPEFD() != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.DLKMKOMMOEK(optionsElements[1].shopElement.PBBFBFFPFJC() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = (AnimalType)8;
		}
		else
		{
			switch (ABAIKKGKDGD)
			{
			case 0:
				if (optionsElements[0].shopElement.IAAECDPPPKD() != null && (Object)(object)sheepAnimation != (Object)null)
				{
					sheepAnimation.animalAnimator.FHJBLKBDOKN(optionsElements[0].shopElement.itemInstance as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = (AnimalType)5;
				break;
			case 5:
				if (optionsElements[4].shopElement.BKCJMBGKDNA() != null && (Object)(object)pigAnimation != (Object)null)
				{
					pigAnimation.animalAnimator.PEECGCDGNOB(optionsElements[2].shopElement.MFGDIJDAJII() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = AnimalType.Chicken;
				break;
			case 8:
				if (optionsElements[3].shopElement.PGDLGEMHCOH() != null && (Object)(object)chickenAnimation != (Object)null)
				{
					chickenAnimation.animalAnimator.DCAFPHAMHFC(optionsElements[4].shopElement.PJAFAAGCMEI() as AnimalInstance);
				}
				IOFIBBFLPKO = AnimalType.Chicken;
				break;
			}
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Sheep);
			cowAnimation.GAGOGFEBDCP((Direction)7);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Sheep);
			sheepAnimation.ForceDirection(Direction.Down);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			pigAnimation.ForceDirection(Direction.Down);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			chickenAnimation.ForceDirection(Direction.Diagonal);
		}
	}

	private void LHMAKDKFNML(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.ForceSetUpDatabase();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = true;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 0, animalInstance);
		GKCKLNELMIC.SetShopItem(GKCKLNELMIC.shopElement, 0, OLMEEOAEMED: false);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(GKCKLNELMIC.shopElement.NGKPILAELHO() as AnimalInstance);
			FFHHEGALBKO.ForceDirection(Direction.Down);
		}
	}

	private IEnumerator MEOMGNIBMDA()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElement);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(lastElement);
			}
		}
	}

	public void EPFKHAFPODB(int ABAIKKGKDGD)
	{
		PBOCMKDENLH(ABAIKKGKDGD);
	}

	private void CMGJLJKFNCA(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.ForceSetUpDatabase();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = true;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.SetShopItem(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: false);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.SetAnimalSkin(GKCKLNELMIC.shopElement.itemInstance as AnimalInstance);
			FFHHEGALBKO.ForceDirection(Direction.Right);
		}
	}

	public static AnimalShopUI LIFMPGJIEKC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void BINLDBADBIC()
	{
		((MonoBehaviour)this).StartCoroutine(NHBHFPFPGBC());
	}

	public static AnimalShopUI EGBMJGOCIJJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void BBEHPDMCLHL()
	{
		((MonoBehaviour)this).StartCoroutine(ACNHBEEBIGG());
	}

	public void OIJHMKGOPHB()
	{
		((MonoBehaviour)this).StartCoroutine(BLNGACBEDAD());
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public void LJGBLAHOPGO(int ABAIKKGKDGD)
	{
		PIEEOPCKGAN(ABAIKKGKDGD);
	}

	private void INHFPPBMLDO(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			if (optionsElements[0].shopElement.BNFDKIDPEFD() != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.FFBFELKDNII(optionsElements[0].shopElement.KIPHICGPKHO() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = (AnimalType)7;
		}
		else
		{
			switch (ABAIKKGKDGD)
			{
			case 0:
				if (optionsElements[1].shopElement.IAAECDPPPKD() != null && (Object)(object)sheepAnimation != (Object)null)
				{
					sheepAnimation.animalAnimator.SetAnimalSkin(optionsElements[1].shopElement.KIPHICGPKHO() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = AnimalType.Cow;
				break;
			case 4:
				if (optionsElements[6].shopElement.MFGDIJDAJII() != null && (Object)(object)pigAnimation != (Object)null)
				{
					pigAnimation.animalAnimator.LGCKPJCGCAK(optionsElements[0].shopElement.KIPHICGPKHO() as AnimalInstance);
				}
				IOFIBBFLPKO = AnimalType.Chicken;
				break;
			case 2:
				if (optionsElements[7].shopElement.BODBEPJAFHL() != null && (Object)(object)chickenAnimation != (Object)null)
				{
					chickenAnimation.animalAnimator.EPGDGJOPAJD(optionsElements[2].shopElement.NKCMJAOFLFH() as AnimalInstance);
				}
				IOFIBBFLPKO = AnimalType.Chicken;
				break;
			}
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == (AnimalType)5);
			cowAnimation.GAGOGFEBDCP(Direction.Down);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Cow);
			sheepAnimation.GAGOGFEBDCP(Direction.Left);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			pigAnimation.ForceDirection(Direction.Diagonal);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			chickenAnimation.GAGOGFEBDCP(Direction.Diagonal);
		}
	}

	public override void AddItemToBasket(ShopElement IFKKAOEBOFP)
	{
		base.AddItemToBasket(IFKKAOEBOFP);
		RandomSkin();
	}

	private IEnumerator MGPNJABEGLE()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HDGEPILAAFP(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			if (optionsElements[1].shopElement.FOFEOHPPMMA() != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.BOMOGFIEKHD(optionsElements[1].shopElement.MFGDIJDAJII() as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Chicken;
		}
		else if (ABAIKKGKDGD == 0)
		{
			if (optionsElements[0].shopElement.BAKAGAJOMAP() != null && (Object)(object)sheepAnimation != (Object)null)
			{
				sheepAnimation.animalAnimator.KGIFGHKCOFC(optionsElements[1].shopElement.PBBFBFFPFJC() as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Pig;
		}
		else
		{
			switch (ABAIKKGKDGD)
			{
			case 0:
				if (optionsElements[1].shopElement.itemInstance != null && (Object)(object)pigAnimation != (Object)null)
				{
					pigAnimation.animalAnimator.AEBBABIBLND(optionsElements[1].shopElement.PBBFBFFPFJC() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = AnimalType.Pig;
				break;
			case 8:
				if (optionsElements[2].shopElement.AFOOOEAJCNP() != null && (Object)(object)chickenAnimation != (Object)null)
				{
					chickenAnimation.animalAnimator.HNAMLLBLGIG(optionsElements[1].shopElement.NKCMJAOFLFH() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = AnimalType.Chicken;
				break;
			}
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == (AnimalType)7);
			cowAnimation.GAGOGFEBDCP(Direction.Down);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			sheepAnimation.GAGOGFEBDCP(Direction.Down);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			pigAnimation.GAGOGFEBDCP((Direction)7);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			chickenAnimation.GAGOGFEBDCP((Direction)6);
		}
	}

	public void LGAAOJIMEOD()
	{
		if (IOFIBBFLPKO == (AnimalType)7)
		{
			CLMKMELNNBL(cowAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == (AnimalType)8)
		{
			KCIJPGOKGLE(sheepAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			INOMBHLEHIA(pigAnimation, optionsElements[3]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			OBKMLPDAOKH(chickenAnimation, optionsElements[5]);
		}
	}

	public void IBHNFJBBNHI()
	{
		if (IOFIBBFLPKO == (AnimalType)5)
		{
			FLPMBEDCENK(cowAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			FLPMBEDCENK(sheepAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			NAGKKELBLDI(pigAnimation, optionsElements[5]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			LHMAKDKFNML(chickenAnimation, optionsElements[5]);
		}
	}

	public void DPKLMOBCDCM()
	{
		if (IOFIBBFLPKO == (AnimalType)4)
		{
			FMKELLCMLAP(cowAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Cow)
		{
			INOMBHLEHIA(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			JKPDPBFONCL(pigAnimation, optionsElements[6]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			NAGKKELBLDI(chickenAnimation, optionsElements[7]);
		}
	}

	public void HKNLBMCDEIK()
	{
		((MonoBehaviour)this).StartCoroutine(BCIDBFJGJPE());
	}

	private IEnumerator IACFKEDCKPG()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElement);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(lastElement);
			}
		}
	}

	public void GMMOJMHKBDD(int ABAIKKGKDGD)
	{
		LMJPCKCINDP(ABAIKKGKDGD);
	}

	public static AnimalShopUI EKEDKKKPAEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator CGBLGDEBDMG()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FKKBNNEPAIB()
	{
		((MonoBehaviour)this).StartCoroutine(NHBHFPFPGBC());
	}

	public static AnimalShopUI HDMPJKMLFML(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void NGLIONEIPHA(int ABAIKKGKDGD)
	{
		LMJPCKCINDP(ABAIKKGKDGD);
	}

	private void NAGKKELBLDI(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.CLMAAJIPNAH();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = true;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.MEDIJHPNCMD(GKCKLNELMIC.shopElement, 0, OLMEEOAEMED: false);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.FHJBLKBDOKN(GKCKLNELMIC.shopElement.HHBICHCGPPK() as AnimalInstance, OBDGKOCOLIN: true);
			FFHHEGALBKO.ForceDirection((Direction)6);
		}
	}

	public void JGMOEJJCOGJ()
	{
		((MonoBehaviour)this).StartCoroutine(MGPNJABEGLE());
	}

	private void OBKMLPDAOKH(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.EKGPEFAJMDE();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 0, animalInstance);
		GKCKLNELMIC.DGOBOFJOFKO(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: false);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(GKCKLNELMIC.shopElement.FOFEOHPPMMA() as AnimalInstance, OBDGKOCOLIN: true);
			FFHHEGALBKO.ForceDirection((Direction)7);
		}
	}

	public static AnimalShopUI PCEEOGGDBFB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void MPGIHJDKGGC()
	{
		if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			NAGKKELBLDI(cowAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == (AnimalType)5)
		{
			GECNEHDLBAE(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Pig)
		{
			CLMKMELNNBL(pigAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			LKOBDDPBKJH(chickenAnimation, optionsElements[8]);
		}
	}

	public void LBANAAAGIIF()
	{
		((MonoBehaviour)this).StartCoroutine(IBEGGLBCCEL());
	}

	public static AnimalShopUI EOPIEMLAPFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void BPDHCGAKMPE(int ABAIKKGKDGD)
	{
		INHFPPBMLDO(ABAIKKGKDGD);
	}

	public void OnMouseEnterAction(int ABAIKKGKDGD)
	{
		PPEMOGHNNAA(ABAIKKGKDGD);
	}

	private void KCIJPGOKGLE(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.ForceSetUpDatabase();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.SetShopItem(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: true);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(GKCKLNELMIC.shopElement.FOFEOHPPMMA() as AnimalInstance, OBDGKOCOLIN: true);
			FFHHEGALBKO.GAGOGFEBDCP(Direction.Diagonal);
		}
	}

	private IEnumerator KIMDIOIAJCD()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AFNLCPLGNEN(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			if (optionsElements[0].shopElement.BODBEPJAFHL() != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.NINEAKFMMNN(optionsElements[1].shopElement.BKCJMBGKDNA() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = AnimalType.Pig;
		}
		else
		{
			switch (ABAIKKGKDGD)
			{
			case 0:
				if (optionsElements[0].shopElement.itemInstance != null && (Object)(object)sheepAnimation != (Object)null)
				{
					sheepAnimation.animalAnimator.IOPDGOIGBPL(optionsElements[1].shopElement.BODBEPJAFHL() as AnimalInstance);
				}
				IOFIBBFLPKO = (AnimalType)6;
				break;
			case 5:
				if (optionsElements[7].shopElement.BNFDKIDPEFD() != null && (Object)(object)pigAnimation != (Object)null)
				{
					pigAnimation.animalAnimator.BMNJLEAAJLN(optionsElements[3].shopElement.PJAFAAGCMEI() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = AnimalType.Pig;
				break;
			case 3:
				if (optionsElements[2].shopElement.BKCJMBGKDNA() != null && (Object)(object)chickenAnimation != (Object)null)
				{
					chickenAnimation.animalAnimator.MFJCPADIAMJ(optionsElements[2].shopElement.BAKAGAJOMAP() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = AnimalType.Chicken;
				break;
			}
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			cowAnimation.GAGOGFEBDCP(Direction.Down);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == (AnimalType)8);
			sheepAnimation.ForceDirection((Direction)8);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			pigAnimation.GAGOGFEBDCP((Direction)8);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			chickenAnimation.GAGOGFEBDCP(Direction.Left);
		}
	}

	protected override void Start()
	{
		base.Start();
		ShopElementUI shopElementUI = optionsElements[0];
		shopElementUI.OnMouseEnter = (Action<int>)Delegate.Combine(shopElementUI.OnMouseEnter, new Action<int>(OnMouseEnterAction));
		ShopElementUI shopElementUI2 = optionsElements[1];
		shopElementUI2.OnMouseEnter = (Action<int>)Delegate.Combine(shopElementUI2.OnMouseEnter, new Action<int>(OnMouseEnterAction));
		ShopElementUI shopElementUI3 = optionsElements[2];
		shopElementUI3.OnMouseEnter = (Action<int>)Delegate.Combine(shopElementUI3.OnMouseEnter, new Action<int>(OnMouseEnterAction));
		ShopElementUI shopElementUI4 = optionsElements[3];
		shopElementUI4.OnMouseEnter = (Action<int>)Delegate.Combine(shopElementUI4.OnMouseEnter, new Action<int>(OnMouseEnterAction));
	}

	private void DHPJOPPLFPP(int ABAIKKGKDGD)
	{
		switch (ABAIKKGKDGD)
		{
		case 0:
			if (optionsElements[1].shopElement.PGDLGEMHCOH() != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.FFOLBNHJIAD(optionsElements[0].shopElement.IAAECDPPPKD() as AnimalInstance, OBDGKOCOLIN: true);
			}
			IOFIBBFLPKO = (AnimalType)4;
			break;
		case 1:
			if (optionsElements[1].shopElement.HHBICHCGPPK() != null && (Object)(object)sheepAnimation != (Object)null)
			{
				sheepAnimation.animalAnimator.FHJBLKBDOKN(optionsElements[1].shopElement.FOFEOHPPMMA() as AnimalInstance);
			}
			IOFIBBFLPKO = AnimalType.Pig;
			break;
		default:
			switch (ABAIKKGKDGD)
			{
			case 0:
				if (optionsElements[2].shopElement.PBBFBFFPFJC() != null && (Object)(object)pigAnimation != (Object)null)
				{
					pigAnimation.animalAnimator.LGCKPJCGCAK(optionsElements[8].shopElement.PJAFAAGCMEI() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = AnimalType.Pig;
				break;
			case 1:
				if (optionsElements[0].shopElement.BKCJMBGKDNA() != null && (Object)(object)chickenAnimation != (Object)null)
				{
					chickenAnimation.animalAnimator.EPEJFHPAFFL(optionsElements[6].shopElement.FOFEOHPPMMA() as AnimalInstance);
				}
				IOFIBBFLPKO = AnimalType.Pig;
				break;
			}
			break;
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == (AnimalType)7);
			cowAnimation.ForceDirection((Direction)6);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			sheepAnimation.GAGOGFEBDCP(Direction.Up);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			pigAnimation.GAGOGFEBDCP((Direction)7);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			chickenAnimation.GAGOGFEBDCP((Direction)7);
		}
	}

	private IEnumerator PBCDJFLNNKG()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElement);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(lastElement);
			}
		}
	}

	public static AnimalShopUI DGHJBIGOGHG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator ELHIBHFOONN()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)FarmConstructionManager.GetBarn() != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElement);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(lastElement);
			}
		}
	}

	private void OABKFEFLJKF(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.OACKGECPIKJ();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 0, animalInstance);
		GKCKLNELMIC.JFDILLFNLPP(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: true);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.MFJCPADIAMJ(GKCKLNELMIC.shopElement.AFOOOEAJCNP() as AnimalInstance);
			FFHHEGALBKO.GAGOGFEBDCP(Direction.Down);
		}
	}

	public void DLJLFMFCGME(int ABAIKKGKDGD)
	{
		INHFPPBMLDO(ABAIKKGKDGD);
	}

	public static AnimalShopUI KJKABIBIJBD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static AnimalShopUI OMLGNAJPLDE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FBDCOEPAMGC(int ABAIKKGKDGD)
	{
		PIEEOPCKGAN(ABAIKKGKDGD);
	}

	private IEnumerator GDONEDKHDAL()
	{
		return new ABOGJJNHNAC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FirstShopElement()
	{
		((MonoBehaviour)this).StartCoroutine(PBCDJFLNNKG());
	}

	public static AnimalShopUI ANPKEGFMLED(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PIEEOPCKGAN(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			if (optionsElements[0].shopElement.BODBEPJAFHL() != null && (Object)(object)cowAnimation != (Object)null)
			{
				cowAnimation.animalAnimator.NINEAKFMMNN(optionsElements[0].shopElement.BAKAGAJOMAP() as AnimalInstance);
			}
			IOFIBBFLPKO = (AnimalType)7;
		}
		else
		{
			switch (ABAIKKGKDGD)
			{
			case 0:
				if (optionsElements[0].shopElement.FOFEOHPPMMA() != null && (Object)(object)sheepAnimation != (Object)null)
				{
					sheepAnimation.animalAnimator.IOPDGOIGBPL(optionsElements[1].shopElement.AFOOOEAJCNP() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = (AnimalType)4;
				break;
			case 5:
				if (optionsElements[8].shopElement.NGKPILAELHO() != null && (Object)(object)pigAnimation != (Object)null)
				{
					pigAnimation.animalAnimator.CHAOEBIPCFJ(optionsElements[6].shopElement.IAAECDPPPKD() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = AnimalType.Pig;
				break;
			case 8:
				if (optionsElements[2].shopElement.PJAFAAGCMEI() != null && (Object)(object)chickenAnimation != (Object)null)
				{
					chickenAnimation.animalAnimator.HKCIJHIJPBG(optionsElements[4].shopElement.MFGDIJDAJII() as AnimalInstance, OBDGKOCOLIN: true);
				}
				IOFIBBFLPKO = AnimalType.Pig;
				break;
			}
		}
		if ((Object)(object)cowAnimation != (Object)null)
		{
			((Component)cowAnimation).gameObject.SetActive(IOFIBBFLPKO == (AnimalType)6);
			cowAnimation.ForceDirection((Direction)5);
		}
		if ((Object)(object)sheepAnimation != (Object)null)
		{
			((Component)sheepAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Cow);
			sheepAnimation.ForceDirection(Direction.Right);
		}
		if ((Object)(object)pigAnimation != (Object)null)
		{
			((Component)pigAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Pig);
			pigAnimation.GAGOGFEBDCP(Direction.Up);
		}
		if ((Object)(object)chickenAnimation != (Object)null)
		{
			((Component)chickenAnimation).gameObject.SetActive(IOFIBBFLPKO == AnimalType.Chicken);
			chickenAnimation.ForceDirection((Direction)8);
		}
	}

	private void GECNEHDLBAE(AnimalAnimation FFHHEGALBKO, ShopElementUI GKCKLNELMIC)
	{
		CharacterSpritesDBAccessor.ForceSetUpDatabase();
		AnimalInstance animalInstance = GKCKLNELMIC.shopElement.shopItem.item.JMDALJBNFML() as AnimalInstance;
		animalInstance.showBirthdayOnTooltip = false;
		GKCKLNELMIC.shopElement = new ShopElement(GKCKLNELMIC.shopElement.shopItem, 1, animalInstance);
		GKCKLNELMIC.MEDIJHPNCMD(GKCKLNELMIC.shopElement, 1, OLMEEOAEMED: false);
		if ((Object)(object)FFHHEGALBKO != (Object)null)
		{
			FFHHEGALBKO.animalAnimator.HKCIJHIJPBG(GKCKLNELMIC.shopElement.IAAECDPPPKD() as AnimalInstance, OBDGKOCOLIN: true);
			FFHHEGALBKO.GAGOGFEBDCP(Direction.Down);
		}
	}

	public void ACAFLKMDIAE()
	{
		((MonoBehaviour)this).StartCoroutine(CGBLGDEBDMG());
	}

	public static AnimalShopUI AKMJEPMHFMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void GKKGJHDPBJD()
	{
		if (IOFIBBFLPKO == (AnimalType)6)
		{
			INOMBHLEHIA(cowAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Cow)
		{
			ICNAJDBMFPH(sheepAnimation, optionsElements[0]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			OMLEGMEENON(pigAnimation, optionsElements[1]);
		}
		else if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			IIEOBMOBPGB(chickenAnimation, optionsElements[7]);
		}
	}

	public static AnimalShopUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}
}
