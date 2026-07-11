using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimalSpace : MonoBehaviour
{
	public AnimalFeederFood foodFeeder;

	[SerializeField]
	private GameObject buildSquares;

	public GameObject[] toActivateWithAnimal;

	public GameObject[] toDeactivateWithAnimal;

	public Direction direction = Direction.Right;

	public SpriteRenderer animalPoster;

	public Sprite cowPoster;

	public Sprite pigPoster;

	public Sprite sheepPoster;

	public SurfaceSortOrder surfaceSortOrder;

	public Transform defaultPosition;

	public Transform sleepPosition;

	public int JFNMCNCHMEO => foodFeeder.id;

	public AnimalNPC DHJHEALFPJN { get; private set; }

	public void CJFEOLELCJB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)MCJMAPPKDLP() == (Object)null) && !DHJHEALFPJN.behaviour.GetBool(" - ") && WorldGrid.HJPCBBGHPDA(((Component)PGJDHDIEEJI()).transform.position) != PlayerController.GetPlayer(1).LEOIMFNKFGA && (!GameManager.LocalCoop() || WorldGrid.HJPCBBGHPDA(((Component)NHDHHMBJIIH()).transform.position) != PlayerController.GetPlayer(1).LEOIMFNKFGA))
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)NHDHHMBJIIH()).transform.position) == (Location.Tavern | Location.Road | Location.Quarry | Location.Farm))
			{
				JJGCGHPIDGL();
			}
			else if (!WorldGrid.ECOFAPGIGMO(((Component)PGJDHDIEEJI()).transform.position))
			{
				PutAnimalToSleep();
			}
		}
	}

	private void JGDGNGJNAGK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (buildSquares.activeSelf)
		{
			DJOIDDPLIEG(MJHBHDAEDLF: false);
		}
	}

	public void GPIGJAHFPGN()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MCJMAPPKDLP() != (Object)null && !ACMJMOPBCJM().isSick)
		{
			((Component)LGCDJFKHCCF()).transform.position = defaultPosition.position;
			ACMJMOPBCJM().lastFreePathNode = Vector2.op_Implicit(defaultPosition.position);
			MCJMAPPKDLP().AwakeAnimal();
		}
	}

	public void NFFJFLBANJK()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)FDBLHIFNAFJ() == (Object)null) && !MCJMAPPKDLP().behaviour.GetBool("\n<color=#822F00>") && WorldGrid.HJPCBBGHPDA(((Component)HMJKPPJEEIM()).transform.position) != PlayerController.OPHDCMJLLEC(0).LEOIMFNKFGA && (!GameManager.LocalCoop() || WorldGrid.HJPCBBGHPDA(((Component)DHJHEALFPJN).transform.position) != PlayerController.GetPlayer(3).LEOIMFNKFGA))
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)MCJMAPPKDLP()).transform.position) == (Location.River | Location.Quarry | Location.BarnInterior))
			{
				DIAPLCGAFOH();
			}
			else if (!WorldGrid.ECOFAPGIGMO(((Component)DHJHEALFPJN).transform.position))
			{
				KODMENGCANG();
			}
		}
	}

	public void HAJBOAMHELH()
	{
		if ((Object)(object)LGCDJFKHCCF() != (Object)null)
		{
			foodFeeder.WasteUnit(0);
		}
	}

	[SpecialName]
	private void KPONFBKEHHP(AnimalNPC AODONKKHPBP)
	{
		_003CNDACKNPGHNG_003Ek__BackingField = AODONKKHPBP;
	}

	public void PEAPNIDBEMJ(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 1; i < toActivateWithAnimal.Length; i += 0)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 0; j < toDeactivateWithAnimal.Length; j++)
		{
			toDeactivateWithAnimal[j].SetActive(MJHBHDAEDLF);
		}
		if (MJHBHDAEDLF)
		{
			switch (IOFIBBFLPKO)
			{
			case AnimalType.Cow:
				animalPoster.sprite = cowPoster;
				break;
			case AnimalType.Chicken:
				animalPoster.sprite = pigPoster;
				break;
			case (AnimalType)7:
				animalPoster.sprite = sheepPoster;
				break;
			}
		}
	}

	public void MCMDKDLCDGN(bool CDPAMNIPPEC)
	{
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)PGJDHDIEEJI() != (Object)null)
		{
			LGCDJFKHCCF().onlineAnimal.DKMAOIJHAMN();
		}
		CIKJPPMGDAA(null);
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		ODCBJFPFALP(MJHBHDAEDLF: false, AnimalType.Chicken);
	}

	public void WakeUpAnimal()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DHJHEALFPJN != (Object)null && !DHJHEALFPJN.isSick)
		{
			((Component)DHJHEALFPJN).transform.position = defaultPosition.position;
			DHJHEALFPJN.lastFreePathNode = Vector2.op_Implicit(defaultPosition.position);
			DHJHEALFPJN.AwakeAnimal();
		}
	}

	[SpecialName]
	public AnimalNPC FDBLHIFNAFJ()
	{
		return _003CNDACKNPGHNG_003Ek__BackingField;
	}

	private void BGFCHEIOKOG()
	{
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(PFMGIKMPKEH));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(JGDGNGJNAGK));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance3.OnPlaceablePickedUp, new Action<int, Placeable, bool>(FLEMOBAGAKB));
		SurfaceSortOrder obj = surfaceSortOrder;
		obj.OnItemAdded = (Action<Placeable, bool>)Delegate.Combine(obj.OnItemAdded, new Action<Placeable, bool>(DKMJKCAHLHG));
		SurfaceSortOrder obj2 = surfaceSortOrder;
		obj2.OnItemRemoved = (Action<Placeable>)Delegate.Combine(obj2.OnItemRemoved, new Action<Placeable>(MJKKILACANB));
		SurfaceSortOrder obj3 = surfaceSortOrder;
		obj3.OnItemPlaced = (Action<Placeable, int>)Delegate.Combine(obj3.OnItemPlaced, new Action<Placeable, int>(BGOPFMJEENE));
		DKLAOABEFFJ(CDPAMNIPPEC: true);
		FAPJDNDJIKN(MJHBHDAEDLF: true);
	}

	private void FLEMOBAGAKB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (buildSquares.activeSelf)
		{
			DFPFCHICJGP(MJHBHDAEDLF: false);
		}
	}

	public void KBNLNJCBMLG(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void PIKHPDJKPPP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		DJOIDDPLIEG(!((Object)(object)LGCDJFKHCCF() == (Object)null) || !(EAPCLAODGAE.itemSetup.item is Animal animal) || (animal.animalType != AnimalType.Pig && animal.animalType != AnimalType.Sheep && animal.animalType == AnimalType.Chicken));
	}

	private void ONDOJPCMHKC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (buildSquares.activeSelf)
		{
			KGNLAFHLOID(MJHBHDAEDLF: false);
		}
	}

	public void WasteFoodUnit()
	{
		if ((Object)(object)DHJHEALFPJN != (Object)null)
		{
			foodFeeder.WasteUnit(1);
		}
	}

	public void IOOHOGEKHPP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		DFPFCHICJGP((Object)(object)DHJHEALFPJN == (Object)null && EAPCLAODGAE.itemSetup.item is Animal animal && animal.animalType != 0 && animal.animalType != (AnimalType)7 && animal.animalType == AnimalType.Sheep);
	}

	public void PKOKOGPPIKF()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)ACMJMOPBCJM() == (Object)null) && !NHDHHMBJIIH().behaviour.GetBool("IsWeatheringToday") && WorldGrid.HJPCBBGHPDA(((Component)LGCDJFKHCCF()).transform.position) != PlayerController.OPHDCMJLLEC(0).LEOIMFNKFGA && (!GameManager.LocalCoop() || WorldGrid.HJPCBBGHPDA(((Component)FFAPKJDBMLL()).transform.position) != PlayerController.OPHDCMJLLEC(7).LEOIMFNKFGA))
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)FFAPKJDBMLL()).transform.position) == ~(Location.Tavern | Location.Camp | Location.Quarry | Location.Farm))
			{
				DIAPLCGAFOH();
			}
			else if (!WorldGrid.ECOFAPGIGMO(((Component)ACMJMOPBCJM()).transform.position))
			{
				LKDKIJCKEDB();
			}
		}
	}

	[SpecialName]
	public int DNFBGFJBCLM()
	{
		return foodFeeder.id;
	}

	public void DKLAOABEFFJ(bool CDPAMNIPPEC)
	{
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)FDBLHIFNAFJ() != (Object)null)
		{
			PGJDHDIEEJI().onlineAnimal.DKMAOIJHAMN();
		}
		LMDMAEEHDOL(null);
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		CMNKOPJICLE(MJHBHDAEDLF: false, AnimalType.Pig);
	}

	public void INMMDAOKGEG(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 0; i < toActivateWithAnimal.Length; i += 0)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 1; j < toDeactivateWithAnimal.Length; j++)
		{
			toDeactivateWithAnimal[j].SetActive(MJHBHDAEDLF);
		}
		if (MJHBHDAEDLF)
		{
			switch (IOFIBBFLPKO)
			{
			case (AnimalType)5:
				animalPoster.sprite = cowPoster;
				break;
			case AnimalType.Chicken:
				animalPoster.sprite = pigPoster;
				break;
			case AnimalType.Pig:
				animalPoster.sprite = sheepPoster;
				break;
			}
		}
	}

	[SpecialName]
	public AnimalNPC LGCDJFKHCCF()
	{
		return _003CNDACKNPGHNG_003Ek__BackingField;
	}

	public void FAPJDNDJIKN(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void OnItemAddedToSurface(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		ShowSpaceWithAnimal(MJHBHDAEDLF: true, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = false;
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		component.animationBase.FCGBJEIIMBC = direction;
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
	}

	public void FOJAMOPLELB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)NHDHHMBJIIH() == (Object)null) && !NHDHHMBJIIH().behaviour.GetBool("Player") && WorldGrid.HJPCBBGHPDA(((Component)FDBLHIFNAFJ()).transform.position) != PlayerController.GetPlayer(0).LEOIMFNKFGA && (!GameManager.LocalCoop() || WorldGrid.HJPCBBGHPDA(((Component)FFAPKJDBMLL()).transform.position) != PlayerController.OPHDCMJLLEC(4).LEOIMFNKFGA))
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)DHJHEALFPJN).transform.position) == (Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior))
			{
				PutAnimalToSleep();
			}
			else if (!WorldGrid.ECOFAPGIGMO(((Component)PGJDHDIEEJI()).transform.position))
			{
				MCIGNOPDFOD();
			}
		}
	}

	public void LBGNEEAICNI(Placeable EAPCLAODGAE, int PMPLICNLOCC)
	{
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		LLMMMDGPAIM(component, CDPAMNIPPEC: true);
		if (CommonReferences.MNFMOEKMJKN().barnAnimalsTutorial)
		{
			SelectObject.BNMEANGDMIP(PMPLICNLOCC).PDEEEJOFEAI();
			DecorationMode.IECFJGHAIDO(PMPLICNLOCC).LAJPGLFEAIC(AODONKKHPBP: false);
			HollyNPC.EKGMDIHLEEH().ActiveArrows(active: false);
			HollyNPC.OOKBNHMMFON().StartConversation(PMPLICNLOCC, "Items/item_name_672");
			CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = false;
			HollyNPC.EKGMDIHLEEH().barnTutorialAnimal = component;
		}
	}

	public void DFEIFHFPHJI(bool CDPAMNIPPEC)
	{
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)MCJMAPPKDLP() != (Object)null)
		{
			FMECIKJOIEN().onlineAnimal.DKMAOIJHAMN();
		}
		KPONFBKEHHP(null);
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		PEAPNIDBEMJ(MJHBHDAEDLF: false, AnimalType.Chicken);
	}

	public void DMCAFHHHLGE(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = false;
		MCFPCANGOND(MJHBHDAEDLF: false, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
	}

	public void LLJIKFOBIKP(Placeable EAPCLAODGAE, int PMPLICNLOCC)
	{
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		KJNJOEIGJKO(component, CDPAMNIPPEC: false);
		if (CommonReferences.MNFMOEKMJKN().barnAnimalsTutorial)
		{
			SelectObject.BNMEANGDMIP(PMPLICNLOCC).JMCJLHKKDNH();
			DecorationMode.IGMCBPOPNCA(PMPLICNLOCC).PBOIEOIDKCK(AODONKKHPBP: true);
			HollyNPC.JFJOKGAOPHA().JHHOCLMLOKO(active: true);
			HollyNPC.EKGMDIHLEEH().StartConversation(PMPLICNLOCC, "Left Stick Up");
			CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = true;
			HollyNPC.EKGMDIHLEEH().barnTutorialAnimal = component;
		}
	}

	public void OLHNGJJEAKG(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void EFFCONHKBJO(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		OLHNGJJEAKG((Object)(object)FDBLHIFNAFJ() == (Object)null && EAPCLAODGAE.itemSetup.item is Animal animal && (animal.animalType == AnimalType.Pig || animal.animalType == (AnimalType)4 || animal.animalType == (AnimalType)5));
	}

	public void AEKAMBKEHGF(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.EHDBOODEBCI(CDPAMNIPPEC: false);
			}
			IPDHNELNDOG(GGJLNHNAKCF);
			NHDHHMBJIIH().animalSpace = this;
			ACMJMOPBCJM().currentBuilding = Barn.instance;
			FMECIKJOIEN().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.LDJNBOPGDJA(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: true, CDPAMNIPPEC, KOGPKBOIFGN: false);
			((Component)NHDHHMBJIIH()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			BOMHLKPIBIM(MJHBHDAEDLF: true, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = false;
			GGJLNHNAKCF.placeable.pickUpable = true;
			NHDHHMBJIIH().placeable.RigidBodyKinematic(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, PIOFOMECLPM());
			}
		}
	}

	[SpecialName]
	public AnimalNPC NHDHHMBJIIH()
	{
		return _003CNDACKNPGHNG_003Ek__BackingField;
	}

	private void BGFEBEAJOCG()
	{
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(ICCGIABGNEM));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(CDJAFCPDHIC));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences.OnPlaceablePickedUp, new Action<int, Placeable, bool>(CHFCABOIMHA));
		SurfaceSortOrder obj = surfaceSortOrder;
		obj.OnItemAdded = (Action<Placeable, bool>)Delegate.Combine(obj.OnItemAdded, new Action<Placeable, bool>(DDADLAEKJPP));
		SurfaceSortOrder obj2 = surfaceSortOrder;
		obj2.OnItemRemoved = (Action<Placeable>)Delegate.Combine(obj2.OnItemRemoved, new Action<Placeable>(KJJOAPPEHLA));
		SurfaceSortOrder obj3 = surfaceSortOrder;
		obj3.OnItemPlaced = (Action<Placeable, int>)Delegate.Combine(obj3.OnItemPlaced, new Action<Placeable, int>(OnItemPlaced));
		DFEIFHFPHJI(CDPAMNIPPEC: true);
		FAPJDNDJIKN(MJHBHDAEDLF: true);
	}

	[SpecialName]
	public AnimalNPC PGJDHDIEEJI()
	{
		return _003CNDACKNPGHNG_003Ek__BackingField;
	}

	public void IHJDGHOELJH(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.DeassignAnimal(CDPAMNIPPEC: false);
			}
			KPONFBKEHHP(GGJLNHNAKCF);
			PGJDHDIEEJI().animalSpace = this;
			FFAPKJDBMLL().currentBuilding = Barn.instance;
			FFAPKJDBMLL().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.AddToSurface(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: false, CDPAMNIPPEC, KOGPKBOIFGN: false);
			((Component)FDBLHIFNAFJ()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			LPLBBIHCCAM(MJHBHDAEDLF: true, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = true;
			GGJLNHNAKCF.placeable.pickUpable = false;
			LGCDJFKHCCF().placeable.AHGFMGJIHHE(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, PLCNPFOHGOL());
			}
		}
	}

	private void CHIJGHPHCNA()
	{
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(DCGDDOOMJFL));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(FLEMOBAGAKB));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(ONDOJPCMHKC));
		SurfaceSortOrder obj = surfaceSortOrder;
		obj.OnItemAdded = (Action<Placeable, bool>)Delegate.Combine(obj.OnItemAdded, new Action<Placeable, bool>(IALDMGDFBLD));
		SurfaceSortOrder obj2 = surfaceSortOrder;
		obj2.OnItemRemoved = (Action<Placeable>)Delegate.Combine(obj2.OnItemRemoved, new Action<Placeable>(MJKKILACANB));
		SurfaceSortOrder obj3 = surfaceSortOrder;
		obj3.OnItemPlaced = (Action<Placeable, int>)Delegate.Combine(obj3.OnItemPlaced, new Action<Placeable, int>(OFNFLPOBDIO));
		HHCBGJADFPP(CDPAMNIPPEC: false);
		FAPJDNDJIKN(MJHBHDAEDLF: false);
	}

	public void KMFFKANHNCD(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		MCFPCANGOND(MJHBHDAEDLF: false, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = false;
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		component.animationBase.NCAJNNHBHJM(direction);
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
	}

	private void CHFCABOIMHA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (buildSquares.activeSelf)
		{
			KIMHBEIKBLL(MJHBHDAEDLF: false);
		}
	}

	public void LCEPKFLHBPD()
	{
		if ((Object)(object)MCJMAPPKDLP() != (Object)null)
		{
			foodFeeder.WasteUnit(1);
		}
	}

	public void CAACBIGILLK(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.HHCBGJADFPP(CDPAMNIPPEC: false);
			}
			HKODGIFJIIK(GGJLNHNAKCF);
			MCJMAPPKDLP().animalSpace = this;
			FMECIKJOIEN().currentBuilding = Barn.instance;
			LGCDJFKHCCF().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.MNFMOEKMJKN().allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.LDJNBOPGDJA(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: false, CDPAMNIPPEC);
			((Component)FDBLHIFNAFJ()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			ODCBJFPFALP(MJHBHDAEDLF: false, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = false;
			GGJLNHNAKCF.placeable.pickUpable = false;
			DHJHEALFPJN.placeable.RigidBodyKinematic(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, DLHJIEAPPHO());
			}
		}
	}

	public void CAPMDOKNFCF(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void EIODDIPEGIH(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.MCMDKDLCDGN(CDPAMNIPPEC: true);
			}
			MDFAFAKLCCO(GGJLNHNAKCF);
			ACMJMOPBCJM().animalSpace = this;
			PGJDHDIEEJI().currentBuilding = Barn.instance;
			DHJHEALFPJN.pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.MNFMOEKMJKN().allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.BDEJHHKHJFK(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: true, CDPAMNIPPEC);
			((Component)FFAPKJDBMLL()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			FIAMOBLJEBF(MJHBHDAEDLF: true, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = true;
			GGJLNHNAKCF.placeable.pickUpable = true;
			LGCDJFKHCCF().placeable.PFAFNPAGLNB(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, JFNMCNCHMEO);
			}
		}
	}

	public void DJGKGPGIFFG(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void HBDFJIHLLGB()
	{
		if ((Object)(object)ACMJMOPBCJM() != (Object)null)
		{
			foodFeeder.WasteUnit(1);
		}
	}

	public void DFPFCHICJGP(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void PutAnimalToSleepIfPosible()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)DHJHEALFPJN == (Object)null) && !DHJHEALFPJN.behaviour.GetBool("Sleep") && WorldGrid.HJPCBBGHPDA(((Component)DHJHEALFPJN).transform.position) != PlayerController.GetPlayer(1).LEOIMFNKFGA && (!GameManager.LocalCoop() || WorldGrid.HJPCBBGHPDA(((Component)DHJHEALFPJN).transform.position) != PlayerController.GetPlayer(2).LEOIMFNKFGA))
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)DHJHEALFPJN).transform.position) == Location.BarnInterior)
			{
				PutAnimalToSleep();
			}
			else if (!WorldGrid.ECOFAPGIGMO(((Component)DHJHEALFPJN).transform.position))
			{
				PutAnimalToSleep();
			}
		}
	}

	public void LGIKMPHBNMM(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		BOMHLKPIBIM(MJHBHDAEDLF: true, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = false;
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		component.animationBase.NCAJNNHBHJM(direction);
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
	}

	public void MCIGNOPDFOD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)FDBLHIFNAFJ()).transform.position = sleepPosition.position;
		WorldGrid.OCMBMAPHGDC(DHJHEALFPJN.requestInfo.currentNodes, GAKNPAMHAFB: false);
		DHJHEALFPJN.requestInfo.currentNodes = new HashSet<Vector2>();
		ACMJMOPBCJM().Sleep(AODONKKHPBP: true);
		if (OnlineManager.PlayingOnline())
		{
			ACMJMOPBCJM().onlineAnimal.SendTeleportAnimal();
		}
	}

	public void DKMJKCAHLHG(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		LPLBBIHCCAM(MJHBHDAEDLF: false, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = false;
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		component.animationBase.NCAJNNHBHJM(direction);
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
	}

	public void KJPOOJGPAGK(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.EHDBOODEBCI(CDPAMNIPPEC: false);
			}
			KPONFBKEHHP(GGJLNHNAKCF);
			FMECIKJOIEN().animalSpace = this;
			ACMJMOPBCJM().currentBuilding = Barn.instance;
			DHJHEALFPJN.pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.EAHEIFJACAM(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: true, CDPAMNIPPEC);
			((Component)LGCDJFKHCCF()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			ShowSpaceWithAnimal(MJHBHDAEDLF: false, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = false;
			GGJLNHNAKCF.placeable.pickUpable = false;
			DHJHEALFPJN.placeable.MEHDJDJFNDC(ODNGJHPOMMK: true);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, PLCNPFOHGOL());
			}
		}
	}

	public void EELHECDMCCN(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = true;
		INMMDAOKGEG(MJHBHDAEDLF: true, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
	}

	private void NFABFPFLNEE()
	{
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOOHOGEKHPP));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(FLEMOBAGAKB));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(OPLMLNFLAJM));
		SurfaceSortOrder obj = surfaceSortOrder;
		obj.OnItemAdded = (Action<Placeable, bool>)Delegate.Combine(obj.OnItemAdded, new Action<Placeable, bool>(AMGEDJKOFMK));
		SurfaceSortOrder obj2 = surfaceSortOrder;
		obj2.OnItemRemoved = (Action<Placeable>)Delegate.Combine(obj2.OnItemRemoved, new Action<Placeable>(BKKKGDIOOBG));
		SurfaceSortOrder obj3 = surfaceSortOrder;
		obj3.OnItemPlaced = (Action<Placeable, int>)Delegate.Combine(obj3.OnItemPlaced, new Action<Placeable, int>(LLJIKFOBIKP));
		EHDBOODEBCI(CDPAMNIPPEC: false);
		FAPJDNDJIKN(MJHBHDAEDLF: false);
	}

	public void ICCGIABGNEM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		KIMHBEIKBLL((Object)(object)MCJMAPPKDLP() == (Object)null && EAPCLAODGAE.itemSetup.item is Animal animal && (animal.animalType == AnimalType.Chicken || animal.animalType == AnimalType.Cow || animal.animalType == (AnimalType)5));
	}

	[SpecialName]
	public AnimalNPC MCJMAPPKDLP()
	{
		return _003CNDACKNPGHNG_003Ek__BackingField;
	}

	private void OPLMLNFLAJM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (buildSquares.activeSelf)
		{
			KJHLLBCBKKD(MJHBHDAEDLF: true);
		}
	}

	public void KODMENGCANG()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)NHDHHMBJIIH()).transform.position = sleepPosition.position;
		WorldGrid.OCMBMAPHGDC(FFAPKJDBMLL().requestInfo.currentNodes, GAKNPAMHAFB: true);
		MCJMAPPKDLP().requestInfo.currentNodes = new HashSet<Vector2>();
		FDBLHIFNAFJ().Sleep(AODONKKHPBP: true);
		if (OnlineManager.PlayingOnline())
		{
			FFAPKJDBMLL().onlineAnimal.SendTeleportAnimal();
		}
	}

	public void BGMKGEBCCMA(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 0; i < toActivateWithAnimal.Length; i++)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 1; j < toDeactivateWithAnimal.Length; j++)
		{
			toDeactivateWithAnimal[j].SetActive(MJHBHDAEDLF);
		}
		if (MJHBHDAEDLF)
		{
			switch (IOFIBBFLPKO)
			{
			case (AnimalType)6:
				animalPoster.sprite = cowPoster;
				break;
			case AnimalType.Pig:
				animalPoster.sprite = pigPoster;
				break;
			case (AnimalType)7:
				animalPoster.sprite = sheepPoster;
				break;
			}
		}
	}

	private void CDJAFCPDHIC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (buildSquares.activeSelf)
		{
			NJNOIIMBKAD(MJHBHDAEDLF: true);
		}
	}

	public void LLMMMDGPAIM(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.HHCBGJADFPP(CDPAMNIPPEC: true);
			}
			NMPMKEJNCAJ(GGJLNHNAKCF);
			FMECIKJOIEN().animalSpace = this;
			MCJMAPPKDLP().currentBuilding = Barn.instance;
			DHJHEALFPJN.pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.EFJNGCNBMJG(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: true, CDPAMNIPPEC);
			((Component)NHDHHMBJIIH()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			ACNDHJBAPIB(MJHBHDAEDLF: true, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = true;
			GGJLNHNAKCF.placeable.pickUpable = true;
			FDBLHIFNAFJ().placeable.MEHDJDJFNDC(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, DNFBGFJBCLM());
			}
		}
	}

	public void IMFMAKODJIG(Placeable EAPCLAODGAE, int PMPLICNLOCC)
	{
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		MCMINDHBNAD(component, CDPAMNIPPEC: false);
		if (CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial)
		{
			SelectObject.BNMEANGDMIP(PMPLICNLOCC).ResetSelected();
			DecorationMode.FIHGMLABOBB(PMPLICNLOCC).DDHHFMBJNHB(AODONKKHPBP: true);
			HollyNPC.OOKBNHMMFON().DLNBCNBHFEL(active: false);
			HollyNPC.EKGMDIHLEEH().StartConversation(PMPLICNLOCC, "LE_11", FLHBPHPKIML: true);
			CommonReferences.MNFMOEKMJKN().barnAnimalsTutorial = false;
			HollyNPC.OOKBNHMMFON().barnTutorialAnimal = component;
		}
	}

	public void KIMHBEIKBLL(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void KGNLAFHLOID(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void GFINDDOEIIB()
	{
		if ((Object)(object)FFAPKJDBMLL() != (Object)null)
		{
			foodFeeder.WasteUnit(0);
		}
	}

	public void BNAPGDONOKM(Placeable EAPCLAODGAE, int PMPLICNLOCC)
	{
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		LLMMMDGPAIM(component, CDPAMNIPPEC: false);
		if (CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial)
		{
			SelectObject.BNMEANGDMIP(PMPLICNLOCC).ResetSelected();
			DecorationMode.HBDCJFLINDA(PMPLICNLOCC).GAFDHNANIJF(AODONKKHPBP: false);
			HollyNPC.EHJOPCBIGAB().ActiveArrows(active: true);
			HollyNPC.OOKBNHMMFON().StartConversation(PMPLICNLOCC, ")", FLHBPHPKIML: true);
			CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = false;
			HollyNPC.EHJOPCBIGAB().barnTutorialAnimal = component;
		}
	}

	public void GANMFMNOAJM()
	{
		if ((Object)(object)NHDHHMBJIIH() != (Object)null)
		{
			foodFeeder.WasteUnit(0);
		}
	}

	public void MJKKILACANB(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = true;
		BGMKGEBCCMA(MJHBHDAEDLF: true, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
	}

	[SpecialName]
	private void CIKJPPMGDAA(AnimalNPC AODONKKHPBP)
	{
		_003CNDACKNPGHNG_003Ek__BackingField = AODONKKHPBP;
	}

	private void IJGHFMPHIIN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (buildSquares.activeSelf)
		{
			IKKIDFOCKKI(MJHBHDAEDLF: false);
		}
	}

	public void MPJPDPLOJIF(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = true;
		ShowSpaceWithAnimal(MJHBHDAEDLF: false, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
	}

	public void NFBJKJLEMEJ(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = true;
		ODCBJFPFALP(MJHBHDAEDLF: true, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
	}

	public void CFNAFBPPEJP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MCJMAPPKDLP() != (Object)null && !HMJKPPJEEIM().isSick)
		{
			((Component)PGJDHDIEEJI()).transform.position = defaultPosition.position;
			MCJMAPPKDLP().lastFreePathNode = Vector2.op_Implicit(defaultPosition.position);
			LGCDJFKHCCF().AwakeAnimal();
		}
	}

	public void KJJOAPPEHLA(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = false;
		INMMDAOKGEG(MJHBHDAEDLF: false, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
	}

	public void DDCJBAOHEJE(Placeable EAPCLAODGAE, int PMPLICNLOCC)
	{
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		LLMMMDGPAIM(component, CDPAMNIPPEC: true);
		if (CommonReferences.MNFMOEKMJKN().barnAnimalsTutorial)
		{
			SelectObject.GetPlayer(PMPLICNLOCC).ResetSelected();
			DecorationMode.GetPlayer(PMPLICNLOCC).PBOIEOIDKCK(AODONKKHPBP: false);
			HollyNPC.EKGMDIHLEEH().EHNMBKJAODC(active: false);
			HollyNPC.EKGMDIHLEEH().StartConversation(PMPLICNLOCC, "Dialogue System/Conversation/Crowly_Standar/Entry/24/Dialogue Text", FLHBPHPKIML: true);
			CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = true;
			HollyNPC.EHJOPCBIGAB().barnTutorialAnimal = component;
		}
	}

	private void LEKNPKMBAGP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (buildSquares.activeSelf)
		{
			KBNLNJCBMLG(MJHBHDAEDLF: false);
		}
	}

	public void DCGDDOOMJFL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		DJGKGPGIFFG((Object)(object)FMECIKJOIEN() == (Object)null && EAPCLAODGAE.itemSetup.item is Animal animal && animal.animalType != 0 && animal.animalType != (AnimalType)5 && animal.animalType == AnimalType.Chicken);
	}

	private void DHEFAJFMBEM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (buildSquares.activeSelf)
		{
			DJOIDDPLIEG(MJHBHDAEDLF: true);
		}
	}

	public void JJGCGHPIDGL()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)ACMJMOPBCJM()).transform.position = sleepPosition.position;
		WorldGrid.OCMBMAPHGDC(HMJKPPJEEIM().requestInfo.currentNodes, GAKNPAMHAFB: true);
		HMJKPPJEEIM().requestInfo.currentNodes = new HashSet<Vector2>();
		NHDHHMBJIIH().Sleep(AODONKKHPBP: true);
		if (OnlineManager.PlayingOnline())
		{
			FDBLHIFNAFJ().onlineAnimal.SendTeleportAnimal();
		}
	}

	[SpecialName]
	public AnimalNPC FMECIKJOIEN()
	{
		return _003CNDACKNPGHNG_003Ek__BackingField;
	}

	public void IKKIDFOCKKI(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void JLCGPLIEGLL(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void BGEBDIFNHNH()
	{
		if ((Object)(object)HMJKPPJEEIM() != (Object)null)
		{
			foodFeeder.WasteUnit(1);
		}
	}

	public void PFMGIKMPKEH(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		DJGKGPGIFFG(!((Object)(object)FMECIKJOIEN() == (Object)null) || !(EAPCLAODGAE.itemSetup.item is Animal animal) || (animal.animalType != 0 && animal.animalType != (AnimalType)7 && animal.animalType == AnimalType.Pig));
	}

	private void EEKOJEKPIMP()
	{
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(ICCGIABGNEM));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance3.OnPlaceablePickedUp, new Action<int, Placeable, bool>(DHEFAJFMBEM));
		SurfaceSortOrder obj = surfaceSortOrder;
		obj.OnItemAdded = (Action<Placeable, bool>)Delegate.Combine(obj.OnItemAdded, new Action<Placeable, bool>(DDADLAEKJPP));
		SurfaceSortOrder obj2 = surfaceSortOrder;
		obj2.OnItemRemoved = (Action<Placeable>)Delegate.Combine(obj2.OnItemRemoved, new Action<Placeable>(OnItemRemovedFromSurface));
		SurfaceSortOrder obj3 = surfaceSortOrder;
		obj3.OnItemPlaced = (Action<Placeable, int>)Delegate.Combine(obj3.OnItemPlaced, new Action<Placeable, int>(LLJIKFOBIKP));
		DKLAOABEFFJ(CDPAMNIPPEC: false);
		KBNLNJCBMLG(MJHBHDAEDLF: true);
	}

	public void ADEKNEDCJMN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		DFPFCHICJGP((Object)(object)NHDHHMBJIIH() == (Object)null && EAPCLAODGAE.itemSetup.item is Animal animal && (animal.animalType == AnimalType.Chicken || animal.animalType == AnimalType.Pig || animal.animalType == AnimalType.Pig));
	}

	public void MCMINDHBNAD(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.EHDBOODEBCI(CDPAMNIPPEC: true);
			}
			CIKJPPMGDAA(GGJLNHNAKCF);
			FMECIKJOIEN().animalSpace = this;
			FFAPKJDBMLL().currentBuilding = Barn.instance;
			LGCDJFKHCCF().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.MNFMOEKMJKN().allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.AddToSurface(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: true, CDPAMNIPPEC);
			((Component)LGCDJFKHCCF()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			CMNKOPJICLE(MJHBHDAEDLF: false, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = false;
			GGJLNHNAKCF.placeable.pickUpable = false;
			FDBLHIFNAFJ().placeable.RigidBodyKinematic(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, PLCNPFOHGOL());
			}
		}
	}

	private void IAIDKPJKLIC()
	{
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(OnPlaceableSelected));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences2.OnPlaceableDeselected, new Action<int, Placeable, bool>(OPLMLNFLAJM));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceablePickedUp, new Action<int, Placeable, bool>(IJGHFMPHIIN));
		SurfaceSortOrder obj = surfaceSortOrder;
		obj.OnItemAdded = (Action<Placeable, bool>)Delegate.Combine(obj.OnItemAdded, new Action<Placeable, bool>(DKMJKCAHLHG));
		SurfaceSortOrder obj2 = surfaceSortOrder;
		obj2.OnItemRemoved = (Action<Placeable>)Delegate.Combine(obj2.OnItemRemoved, new Action<Placeable>(BKKKGDIOOBG));
		SurfaceSortOrder obj3 = surfaceSortOrder;
		obj3.OnItemPlaced = (Action<Placeable, int>)Delegate.Combine(obj3.OnItemPlaced, new Action<Placeable, int>(BNAPGDONOKM));
		DFEIFHFPHJI(CDPAMNIPPEC: true);
		KGNLAFHLOID(MJHBHDAEDLF: false);
	}

	public void NDAIPGMOIHJ(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.MCMDKDLCDGN(CDPAMNIPPEC: false);
			}
			IPDHNELNDOG(GGJLNHNAKCF);
			FFAPKJDBMLL().animalSpace = this;
			DHJHEALFPJN.currentBuilding = Barn.instance;
			MCJMAPPKDLP().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.LDJNBOPGDJA(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: true, CDPAMNIPPEC);
			((Component)FMECIKJOIEN()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			KNEIDADAKMO(MJHBHDAEDLF: false, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = true;
			GGJLNHNAKCF.placeable.pickUpable = true;
			LGCDJFKHCCF().placeable.ONFDHHHDEIK(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, PIOFOMECLPM());
			}
		}
	}

	public void KNEIDADAKMO(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 0; i < toActivateWithAnimal.Length; i += 0)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 0; j < toDeactivateWithAnimal.Length; j += 0)
		{
			toDeactivateWithAnimal[j].SetActive(!MJHBHDAEDLF);
		}
		if (MJHBHDAEDLF)
		{
			switch (IOFIBBFLPKO)
			{
			case (AnimalType)7:
				animalPoster.sprite = cowPoster;
				break;
			case AnimalType.Pig:
				animalPoster.sprite = pigPoster;
				break;
			case (AnimalType)4:
				animalPoster.sprite = sheepPoster;
				break;
			}
		}
	}

	[SpecialName]
	public AnimalNPC ACMJMOPBCJM()
	{
		return _003CNDACKNPGHNG_003Ek__BackingField;
	}

	public void DDADLAEKJPP(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		LPLBBIHCCAM(MJHBHDAEDLF: true, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = true;
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		component.animationBase.FCGBJEIIMBC = direction;
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
	}

	public void NJNOIIMBKAD(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void BPCCLPGLFMG(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.DFEIFHFPHJI(CDPAMNIPPEC: true);
			}
			IPDHNELNDOG(GGJLNHNAKCF);
			PGJDHDIEEJI().animalSpace = this;
			FDBLHIFNAFJ().currentBuilding = Barn.instance;
			FFAPKJDBMLL().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.BDEJHHKHJFK(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: false, CDPAMNIPPEC, KOGPKBOIFGN: false);
			((Component)DHJHEALFPJN).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			CMNKOPJICLE(MJHBHDAEDLF: true, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = true;
			GGJLNHNAKCF.placeable.pickUpable = true;
			MCJMAPPKDLP().placeable.MEHDJDJFNDC(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, PLCNPFOHGOL());
			}
		}
	}

	public void CMNKOPJICLE(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 0; i < toActivateWithAnimal.Length; i += 0)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 0; j < toDeactivateWithAnimal.Length; j++)
		{
			toDeactivateWithAnimal[j].SetActive(!MJHBHDAEDLF);
		}
		if (MJHBHDAEDLF)
		{
			switch (IOFIBBFLPKO)
			{
			case (AnimalType)5:
				animalPoster.sprite = cowPoster;
				break;
			case AnimalType.Pig:
				animalPoster.sprite = pigPoster;
				break;
			case AnimalType.Cow:
				animalPoster.sprite = sheepPoster;
				break;
			}
		}
	}

	public void DOOKKIIOJEK()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FFAPKJDBMLL() != (Object)null && !ACMJMOPBCJM().isSick)
		{
			((Component)HMJKPPJEEIM()).transform.position = defaultPosition.position;
			PGJDHDIEEJI().lastFreePathNode = Vector2.op_Implicit(defaultPosition.position);
			FFAPKJDBMLL().AwakeAnimal();
		}
	}

	public void HHLLIMCKDKC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		FAPJDNDJIKN((Object)(object)FMECIKJOIEN() == (Object)null && EAPCLAODGAE.itemSetup.item is Animal animal && (animal.animalType == AnimalType.Pig || animal.animalType == AnimalType.Pig || animal.animalType == (AnimalType)4));
	}

	public void OnPlaceableSelected(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		ShowBuildSquares((Object)(object)DHJHEALFPJN == (Object)null && EAPCLAODGAE.itemSetup.item is Animal animal && (animal.animalType == AnimalType.Pig || animal.animalType == AnimalType.Cow || animal.animalType == AnimalType.Sheep));
	}

	[SpecialName]
	public int PIOFOMECLPM()
	{
		return foodFeeder.id;
	}

	public void ACNDHJBAPIB(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 1; i < toActivateWithAnimal.Length; i++)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 1; j < toDeactivateWithAnimal.Length; j++)
		{
			toDeactivateWithAnimal[j].SetActive(!MJHBHDAEDLF);
		}
		if (MJHBHDAEDLF)
		{
			switch (IOFIBBFLPKO)
			{
			case (AnimalType)6:
				animalPoster.sprite = cowPoster;
				break;
			case AnimalType.Chicken:
				animalPoster.sprite = pigPoster;
				break;
			case AnimalType.Pig:
				animalPoster.sprite = sheepPoster;
				break;
			}
		}
	}

	public void DJOIDDPLIEG(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	private void OBBDDLKPAII(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (buildSquares.activeSelf)
		{
			ShowBuildSquares(MJHBHDAEDLF: false);
		}
	}

	public void FGDIENJNBBM(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.DKLAOABEFFJ(CDPAMNIPPEC: true);
			}
			HKODGIFJIIK(GGJLNHNAKCF);
			LGCDJFKHCCF().animalSpace = this;
			MCJMAPPKDLP().currentBuilding = Barn.instance;
			PGJDHDIEEJI().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.LDJNBOPGDJA(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: true, CDPAMNIPPEC);
			((Component)NHDHHMBJIIH()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			ACNDHJBAPIB(MJHBHDAEDLF: false, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = false;
			GGJLNHNAKCF.placeable.pickUpable = false;
			PGJDHDIEEJI().placeable.PFAFNPAGLNB(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, PLCNPFOHGOL());
			}
		}
	}

	[SpecialName]
	public int CIACJCOPMFP()
	{
		return foodFeeder.id;
	}

	public void DIAPLCGAFOH()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)FDBLHIFNAFJ()).transform.position = sleepPosition.position;
		WorldGrid.OCMBMAPHGDC(MCJMAPPKDLP().requestInfo.currentNodes, GAKNPAMHAFB: true);
		HMJKPPJEEIM().requestInfo.currentNodes = new HashSet<Vector2>();
		ACMJMOPBCJM().Sleep(AODONKKHPBP: true);
		if (OnlineManager.PlayingOnline())
		{
			LGCDJFKHCCF().onlineAnimal.SendTeleportAnimal();
		}
	}

	public void ShowSpaceWithAnimal(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 0; i < toActivateWithAnimal.Length; i++)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 0; j < toDeactivateWithAnimal.Length; j++)
		{
			toDeactivateWithAnimal[j].SetActive(!MJHBHDAEDLF);
		}
		if (MJHBHDAEDLF)
		{
			switch (IOFIBBFLPKO)
			{
			case AnimalType.Cow:
				animalPoster.sprite = cowPoster;
				break;
			case AnimalType.Pig:
				animalPoster.sprite = pigPoster;
				break;
			case AnimalType.Sheep:
				animalPoster.sprite = sheepPoster;
				break;
			}
		}
	}

	public void GNDBIPIDHAJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)FFAPKJDBMLL() == (Object)null) && !DHJHEALFPJN.behaviour.GetBool("Dialogue System/Conversation/TooDark/Entry/6/Dialogue Text") && WorldGrid.HJPCBBGHPDA(((Component)FMECIKJOIEN()).transform.position) != PlayerController.OPHDCMJLLEC(1).LEOIMFNKFGA && (!GameManager.LocalCoop() || WorldGrid.HJPCBBGHPDA(((Component)DHJHEALFPJN).transform.position) != PlayerController.OPHDCMJLLEC(8).LEOIMFNKFGA))
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)PGJDHDIEEJI()).transform.position) == ~Location.BarnInterior)
			{
				OADBELNDHKM();
			}
			else if (!WorldGrid.ECOFAPGIGMO(((Component)LGCDJFKHCCF()).transform.position))
			{
				PutAnimalToSleep();
			}
		}
	}

	public void OnItemPlaced(Placeable EAPCLAODGAE, int PMPLICNLOCC)
	{
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		AssignAnimal(component, CDPAMNIPPEC: true);
		if (CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial)
		{
			SelectObject.GetPlayer(PMPLICNLOCC).ResetSelected();
			DecorationMode.GetPlayer(PMPLICNLOCC).DMBFKFLDDLH = false;
			HollyNPC.GGFJGHHHEJC.ActiveArrows(active: false);
			HollyNPC.GGFJGHHHEJC.StartConversation(PMPLICNLOCC, "Tutorial/Barn_Holly");
			CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = false;
			HollyNPC.GGFJGHHHEJC.barnTutorialAnimal = component;
		}
	}

	public void HBKBCGLPNOC()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)ACMJMOPBCJM() == (Object)null) && !FDBLHIFNAFJ().behaviour.GetBool("FerroProgress") && WorldGrid.HJPCBBGHPDA(((Component)FMECIKJOIEN()).transform.position) != PlayerController.GetPlayer(0).LEOIMFNKFGA && (!GameManager.LocalCoop() || WorldGrid.HJPCBBGHPDA(((Component)FMECIKJOIEN()).transform.position) != PlayerController.GetPlayer(8).LEOIMFNKFGA))
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)FDBLHIFNAFJ()).transform.position) == (Location.River | Location.Quarry | Location.Farm))
			{
				JJGCGHPIDGL();
			}
			else if (!WorldGrid.ECOFAPGIGMO(((Component)NHDHHMBJIIH()).transform.position))
			{
				LKDKIJCKEDB();
			}
		}
	}

	[SpecialName]
	public AnimalNPC HMJKPPJEEIM()
	{
		return _003CNDACKNPGHNG_003Ek__BackingField;
	}

	[SpecialName]
	public AnimalNPC FFAPKJDBMLL()
	{
		return _003CNDACKNPGHNG_003Ek__BackingField;
	}

	public void OFNFLPOBDIO(Placeable EAPCLAODGAE, int PMPLICNLOCC)
	{
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		KJPOOJGPAGK(component, CDPAMNIPPEC: false);
		if (CommonReferences.MNFMOEKMJKN().barnAnimalsTutorial)
		{
			SelectObject.GetPlayer(PMPLICNLOCC).PDEEEJOFEAI();
			DecorationMode.KAIIEDCCLHB(PMPLICNLOCC).PBOIEOIDKCK(AODONKKHPBP: false);
			HollyNPC.GGFJGHHHEJC.JHHOCLMLOKO(active: false);
			HollyNPC.OOKBNHMMFON().StartConversation(PMPLICNLOCC, "Object", FLHBPHPKIML: true);
			CommonReferences.MNFMOEKMJKN().barnAnimalsTutorial = true;
			HollyNPC.JFJOKGAOPHA().barnTutorialAnimal = component;
		}
	}

	public void BOMHLKPIBIM(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 0; i < toActivateWithAnimal.Length; i += 0)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 0; j < toDeactivateWithAnimal.Length; j++)
		{
			toDeactivateWithAnimal[j].SetActive(!MJHBHDAEDLF);
		}
		if (MJHBHDAEDLF)
		{
			switch (IOFIBBFLPKO)
			{
			case (AnimalType)6:
				animalPoster.sprite = cowPoster;
				break;
			case AnimalType.Chicken:
				animalPoster.sprite = pigPoster;
				break;
			case (AnimalType)4:
				animalPoster.sprite = sheepPoster;
				break;
			}
		}
	}

	private void Start()
	{
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(OnPlaceableSelected));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance3.OnPlaceablePickedUp, new Action<int, Placeable, bool>(OBBDDLKPAII));
		SurfaceSortOrder obj = surfaceSortOrder;
		obj.OnItemAdded = (Action<Placeable, bool>)Delegate.Combine(obj.OnItemAdded, new Action<Placeable, bool>(OnItemAddedToSurface));
		SurfaceSortOrder obj2 = surfaceSortOrder;
		obj2.OnItemRemoved = (Action<Placeable>)Delegate.Combine(obj2.OnItemRemoved, new Action<Placeable>(OnItemRemovedFromSurface));
		SurfaceSortOrder obj3 = surfaceSortOrder;
		obj3.OnItemPlaced = (Action<Placeable, int>)Delegate.Combine(obj3.OnItemPlaced, new Action<Placeable, int>(OnItemPlaced));
		DeassignAnimal(CDPAMNIPPEC: false);
		ShowBuildSquares(MJHBHDAEDLF: false);
	}

	public void EPOMLIMDPIK()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FFAPKJDBMLL() != (Object)null && !LGCDJFKHCCF().isSick)
		{
			((Component)FMECIKJOIEN()).transform.position = defaultPosition.position;
			LGCDJFKHCCF().lastFreePathNode = Vector2.op_Implicit(defaultPosition.position);
			HMJKPPJEEIM().AwakeAnimal();
		}
	}

	[SpecialName]
	private void MDFAFAKLCCO(AnimalNPC AODONKKHPBP)
	{
		_003CNDACKNPGHNG_003Ek__BackingField = AODONKKHPBP;
	}

	public void NEGOGPEALAK()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)HMJKPPJEEIM()).transform.position = sleepPosition.position;
		WorldGrid.OCMBMAPHGDC(MCJMAPPKDLP().requestInfo.currentNodes, GAKNPAMHAFB: true);
		FFAPKJDBMLL().requestInfo.currentNodes = new HashSet<Vector2>();
		FMECIKJOIEN().Sleep(AODONKKHPBP: true);
		if (OnlineManager.PlayingOnline())
		{
			LGCDJFKHCCF().onlineAnimal.SendTeleportAnimal();
		}
	}

	public void PutAnimalToSleep()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)DHJHEALFPJN).transform.position = sleepPosition.position;
		WorldGrid.OCMBMAPHGDC(DHJHEALFPJN.requestInfo.currentNodes, GAKNPAMHAFB: true);
		DHJHEALFPJN.requestInfo.currentNodes = new HashSet<Vector2>();
		DHJHEALFPJN.Sleep(AODONKKHPBP: true);
		if (OnlineManager.PlayingOnline())
		{
			DHJHEALFPJN.onlineAnimal.SendTeleportAnimal();
		}
	}

	public void OnItemRemovedFromSurface(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = true;
		ShowSpaceWithAnimal(MJHBHDAEDLF: false, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
	}

	public void DMLKIABGOIG()
	{
		if ((Object)(object)FMECIKJOIEN() != (Object)null)
		{
			foodFeeder.WasteUnit(1);
		}
	}

	[SpecialName]
	public int PLCNPFOHGOL()
	{
		return foodFeeder.id;
	}

	private void LFNENELHOGJ()
	{
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(PFMGIKMPKEH));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(ONDOJPCMHKC));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(DHEFAJFMBEM));
		SurfaceSortOrder obj = surfaceSortOrder;
		obj.OnItemAdded = (Action<Placeable, bool>)Delegate.Combine(obj.OnItemAdded, new Action<Placeable, bool>(LGIKMPHBNMM));
		SurfaceSortOrder obj2 = surfaceSortOrder;
		obj2.OnItemRemoved = (Action<Placeable>)Delegate.Combine(obj2.OnItemRemoved, new Action<Placeable>(MJKKILACANB));
		SurfaceSortOrder obj3 = surfaceSortOrder;
		obj3.OnItemPlaced = (Action<Placeable, int>)Delegate.Combine(obj3.OnItemPlaced, new Action<Placeable, int>(LBGNEEAICNI));
		MCMDKDLCDGN(CDPAMNIPPEC: false);
		KIMHBEIKBLL(MJHBHDAEDLF: true);
	}

	public void KMKDAONEDMI()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)HMJKPPJEEIM() != (Object)null && !HMJKPPJEEIM().isSick)
		{
			((Component)FDBLHIFNAFJ()).transform.position = defaultPosition.position;
			FMECIKJOIEN().lastFreePathNode = Vector2.op_Implicit(defaultPosition.position);
			FMECIKJOIEN().AwakeAnimal();
		}
	}

	[SpecialName]
	private void IPDHNELNDOG(AnimalNPC AODONKKHPBP)
	{
		_003CNDACKNPGHNG_003Ek__BackingField = AODONKKHPBP;
	}

	public void COBAALHOKOJ()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)LGCDJFKHCCF() != (Object)null && !FDBLHIFNAFJ().isSick)
		{
			((Component)FDBLHIFNAFJ()).transform.position = defaultPosition.position;
			MCJMAPPKDLP().lastFreePathNode = Vector2.op_Implicit(defaultPosition.position);
			NHDHHMBJIIH().AwakeAnimal();
		}
	}

	public void GGAMKKBLHDG(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.DFEIFHFPHJI(CDPAMNIPPEC: false);
			}
			DHJHEALFPJN = GGJLNHNAKCF;
			ACMJMOPBCJM().animalSpace = this;
			FMECIKJOIEN().currentBuilding = Barn.instance;
			FMECIKJOIEN().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.LDJNBOPGDJA(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: true, CDPAMNIPPEC, KOGPKBOIFGN: false);
			((Component)MCJMAPPKDLP()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			MCFPCANGOND(MJHBHDAEDLF: true, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = false;
			GGJLNHNAKCF.placeable.pickUpable = true;
			HMJKPPJEEIM().placeable.ONFDHHHDEIK(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, PLCNPFOHGOL());
			}
		}
	}

	public void IALDMGDFBLD(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		ShowSpaceWithAnimal(MJHBHDAEDLF: true, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = true;
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		component.animationBase.NCAJNNHBHJM(direction);
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
	}

	public void AFMPFKIBAPI()
	{
		if ((Object)(object)PGJDHDIEEJI() != (Object)null)
		{
			foodFeeder.WasteUnit(0);
		}
	}

	public void ODCBJFPFALP(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 0; i < toActivateWithAnimal.Length; i += 0)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 0; j < toDeactivateWithAnimal.Length; j += 0)
		{
			toDeactivateWithAnimal[j].SetActive(MJHBHDAEDLF);
		}
		if (!MJHBHDAEDLF)
		{
			return;
		}
		switch (IOFIBBFLPKO)
		{
		case (AnimalType)7:
			animalPoster.sprite = cowPoster;
			return;
		case AnimalType.Chicken:
			animalPoster.sprite = pigPoster;
			return;
		}
		if (IOFIBBFLPKO == AnimalType.Chicken)
		{
			animalPoster.sprite = sheepPoster;
		}
	}

	public void AMGEDJKOFMK(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		MCFPCANGOND(MJHBHDAEDLF: false, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = false;
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		component.animationBase.NCAJNNHBHJM(direction);
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
	}

	public void PDCFPHKIJOD()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MCJMAPPKDLP() != (Object)null && !LGCDJFKHCCF().isSick)
		{
			((Component)ACMJMOPBCJM()).transform.position = defaultPosition.position;
			ACMJMOPBCJM().lastFreePathNode = Vector2.op_Implicit(defaultPosition.position);
			FMECIKJOIEN().AwakeAnimal();
		}
	}

	public void LPLBBIHCCAM(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 1; i < toActivateWithAnimal.Length; i += 0)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 0; j < toDeactivateWithAnimal.Length; j += 0)
		{
			toDeactivateWithAnimal[j].SetActive(MJHBHDAEDLF);
		}
		if (MJHBHDAEDLF)
		{
			switch (IOFIBBFLPKO)
			{
			case AnimalType.Sheep:
				animalPoster.sprite = cowPoster;
				break;
			case AnimalType.Chicken:
				animalPoster.sprite = pigPoster;
				break;
			case (AnimalType)4:
				animalPoster.sprite = sheepPoster;
				break;
			}
		}
	}

	public void KJHLLBCBKKD(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void KJNJOEIGJKO(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.EHDBOODEBCI(CDPAMNIPPEC: true);
			}
			DHJHEALFPJN = GGJLNHNAKCF;
			LGCDJFKHCCF().animalSpace = this;
			FDBLHIFNAFJ().currentBuilding = Barn.instance;
			FDBLHIFNAFJ().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.NOJEIGGKJJI(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: true, CDPAMNIPPEC);
			((Component)FFAPKJDBMLL()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			CMNKOPJICLE(MJHBHDAEDLF: true, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = true;
			GGJLNHNAKCF.placeable.pickUpable = false;
			MCJMAPPKDLP().placeable.PFAFNPAGLNB(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, DNFBGFJBCLM());
			}
		}
	}

	public void MCKHFENAMEO(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void DeassignAnimal(bool CDPAMNIPPEC)
	{
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)DHJHEALFPJN != (Object)null)
		{
			DHJHEALFPJN.onlineAnimal.SendDeassignAnimal();
		}
		DHJHEALFPJN = null;
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		ShowSpaceWithAnimal(MJHBHDAEDLF: false, AnimalType.Pig);
	}

	public void LFCHOLCEEPH()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)FDBLHIFNAFJ() == (Object)null) && !FMECIKJOIEN().behaviour.GetBool("Kick out") && WorldGrid.HJPCBBGHPDA(((Component)FMECIKJOIEN()).transform.position) != PlayerController.GetPlayer(0).LEOIMFNKFGA && (!GameManager.LocalCoop() || WorldGrid.HJPCBBGHPDA(((Component)HMJKPPJEEIM()).transform.position) != PlayerController.OPHDCMJLLEC(1).LEOIMFNKFGA))
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)HMJKPPJEEIM()).transform.position) == (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior))
			{
				KODMENGCANG();
			}
			else if (!WorldGrid.ECOFAPGIGMO(((Component)NHDHHMBJIIH()).transform.position))
			{
				LKDKIJCKEDB();
			}
		}
	}

	public void ShowBuildSquares(bool MJHBHDAEDLF)
	{
		buildSquares.SetActive(MJHBHDAEDLF);
	}

	public void BGOPFMJEENE(Placeable EAPCLAODGAE, int PMPLICNLOCC)
	{
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		OMENOFAHKCC(component, CDPAMNIPPEC: false);
		if (CommonReferences.MNFMOEKMJKN().barnAnimalsTutorial)
		{
			SelectObject.BNMEANGDMIP(PMPLICNLOCC).ResetSelected();
			DecorationMode.BGINAIDHDOM(PMPLICNLOCC).LHCCDCNLMKH(AODONKKHPBP: true);
			HollyNPC.GGFJGHHHEJC.LDAIFHLHHHH(active: true);
			HollyNPC.EKGMDIHLEEH().StartConversation(PMPLICNLOCC, "Tools", FLHBPHPKIML: true);
			CommonReferences.GGFJGHHHEJC.barnAnimalsTutorial = true;
			HollyNPC.OOKBNHMMFON().barnTutorialAnimal = component;
		}
	}

	public void GJMKDLADCNK(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.MCMDKDLCDGN(CDPAMNIPPEC: true);
			}
			MDFAFAKLCCO(GGJLNHNAKCF);
			MCJMAPPKDLP().animalSpace = this;
			FFAPKJDBMLL().currentBuilding = Barn.instance;
			FDBLHIFNAFJ().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.AddToSurface(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: false, CDPAMNIPPEC);
			((Component)HMJKPPJEEIM()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			LPLBBIHCCAM(MJHBHDAEDLF: false, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = true;
			GGJLNHNAKCF.placeable.pickUpable = true;
			FFAPKJDBMLL().placeable.MEHDJDJFNDC(ODNGJHPOMMK: true);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, PIOFOMECLPM());
			}
		}
	}

	public void OMENOFAHKCC(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.EHDBOODEBCI(CDPAMNIPPEC: false);
			}
			LMDMAEEHDOL(GGJLNHNAKCF);
			DHJHEALFPJN.animalSpace = this;
			LGCDJFKHCCF().currentBuilding = Barn.instance;
			LGCDJFKHCCF().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.EFJNGCNBMJG(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: true, CDPAMNIPPEC);
			((Component)FFAPKJDBMLL()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			BOMHLKPIBIM(MJHBHDAEDLF: true, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = false;
			GGJLNHNAKCF.placeable.pickUpable = true;
			HMJKPPJEEIM().placeable.AHGFMGJIHHE(ODNGJHPOMMK: true);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, JFNMCNCHMEO);
			}
		}
	}

	public void DNJJHPHKOFF()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MCJMAPPKDLP() != (Object)null && !LGCDJFKHCCF().isSick)
		{
			((Component)FMECIKJOIEN()).transform.position = defaultPosition.position;
			DHJHEALFPJN.lastFreePathNode = Vector2.op_Implicit(defaultPosition.position);
			FMECIKJOIEN().AwakeAnimal();
		}
	}

	public void LKDKIJCKEDB()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)FFAPKJDBMLL()).transform.position = sleepPosition.position;
		WorldGrid.OCMBMAPHGDC(FFAPKJDBMLL().requestInfo.currentNodes, GAKNPAMHAFB: true);
		MCJMAPPKDLP().requestInfo.currentNodes = new HashSet<Vector2>();
		HMJKPPJEEIM().Sleep(AODONKKHPBP: false);
		if (OnlineManager.PlayingOnline())
		{
			MCJMAPPKDLP().onlineAnimal.SendTeleportAnimal();
		}
	}

	public void MKIGEFFJNLP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MCJMAPPKDLP() != (Object)null && !FFAPKJDBMLL().isSick)
		{
			((Component)LGCDJFKHCCF()).transform.position = defaultPosition.position;
			FFAPKJDBMLL().lastFreePathNode = Vector2.op_Implicit(defaultPosition.position);
			DHJHEALFPJN.AwakeAnimal();
		}
	}

	[SpecialName]
	public int DLHJIEAPPHO()
	{
		return foodFeeder.id;
	}

	public void HHCBGJADFPP(bool CDPAMNIPPEC)
	{
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)DHJHEALFPJN != (Object)null)
		{
			PGJDHDIEEJI().onlineAnimal.DKMAOIJHAMN();
		}
		LMDMAEEHDOL(null);
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		ODCBJFPFALP(MJHBHDAEDLF: false, AnimalType.Chicken);
	}

	public void AssignAnimal(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.DeassignAnimal(CDPAMNIPPEC: false);
			}
			DHJHEALFPJN = GGJLNHNAKCF;
			DHJHEALFPJN.animalSpace = this;
			DHJHEALFPJN.currentBuilding = Barn.instance;
			DHJHEALFPJN.pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.AddToSurface(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: false, CDPAMNIPPEC);
			((Component)DHJHEALFPJN).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			ShowSpaceWithAnimal(MJHBHDAEDLF: true, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = true;
			GGJLNHNAKCF.placeable.pickUpable = false;
			DHJHEALFPJN.placeable.RigidBodyKinematic(ODNGJHPOMMK: true);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, JFNMCNCHMEO);
			}
		}
	}

	public void FJECFGAAILJ(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.MCMDKDLCDGN(CDPAMNIPPEC: false);
			}
			HKODGIFJIIK(GGJLNHNAKCF);
			ACMJMOPBCJM().animalSpace = this;
			ACMJMOPBCJM().currentBuilding = Barn.instance;
			LGCDJFKHCCF().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.EAHEIFJACAM(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: true, CDPAMNIPPEC, KOGPKBOIFGN: false);
			((Component)PGJDHDIEEJI()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			BOMHLKPIBIM(MJHBHDAEDLF: true, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = false;
			GGJLNHNAKCF.placeable.pickUpable = true;
			DHJHEALFPJN.placeable.ONFDHHHDEIK(ODNGJHPOMMK: true);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, DNFBGFJBCLM());
			}
		}
	}

	public void FJNGPLCCJBM(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = false;
		FIAMOBLJEBF(MJHBHDAEDLF: true, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
	}

	public void OADBELNDHKM()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)LGCDJFKHCCF()).transform.position = sleepPosition.position;
		WorldGrid.OCMBMAPHGDC(LGCDJFKHCCF().requestInfo.currentNodes, GAKNPAMHAFB: false);
		FMECIKJOIEN().requestInfo.currentNodes = new HashSet<Vector2>();
		MCJMAPPKDLP().Sleep(AODONKKHPBP: true);
		if (OnlineManager.PlayingOnline())
		{
			NHDHHMBJIIH().onlineAnimal.SendTeleportAnimal();
		}
	}

	[SpecialName]
	private void LMDMAEEHDOL(AnimalNPC AODONKKHPBP)
	{
		_003CNDACKNPGHNG_003Ek__BackingField = AODONKKHPBP;
	}

	public void EHDBOODEBCI(bool CDPAMNIPPEC)
	{
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)PGJDHDIEEJI() != (Object)null)
		{
			DHJHEALFPJN.onlineAnimal.DKMAOIJHAMN();
		}
		LMDMAEEHDOL(null);
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		KNEIDADAKMO(MJHBHDAEDLF: false, AnimalType.Chicken);
	}

	public void ANCPLGMDIHP(AnimalNPC GGJLNHNAKCF, bool CDPAMNIPPEC)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGJLNHNAKCF == (Object)null))
		{
			if ((Object)(object)GGJLNHNAKCF.animalSpace != (Object)null)
			{
				GGJLNHNAKCF.animalSpace.HHCBGJADFPP(CDPAMNIPPEC: true);
			}
			NMPMKEJNCAJ(GGJLNHNAKCF);
			MCJMAPPKDLP().animalSpace = this;
			HMJKPPJEEIM().currentBuilding = Barn.instance;
			FMECIKJOIEN().pathNodesRegion = (Barn.instance.IsOpen() ? null : CommonReferences.GGFJGHHHEJC.allBarnScenes[Barn.instance.EONJGMONIOM].pathNodesRegion);
			surfaceSortOrder.NOJEIGGKJJI(((Component)GGJLNHNAKCF).transform, IIHIGNMDBEF: false, CDPAMNIPPEC);
			((Component)PGJDHDIEEJI()).transform.SetParent((Transform)null);
			foodFeeder.SetAnimalFoodRestriction(GGJLNHNAKCF);
			CMNKOPJICLE(MJHBHDAEDLF: true, GGJLNHNAKCF.type);
			((Behaviour)GGJLNHNAKCF.animationBase).enabled = false;
			GGJLNHNAKCF.placeable.pickUpable = true;
			ACMJMOPBCJM().placeable.MEHDJDJFNDC(ODNGJHPOMMK: false);
			GGJLNHNAKCF.lastFreePathNode = Vector2.op_Implicit(((Component)GGJLNHNAKCF).transform.position);
			GGJLNHNAKCF.WalkAround();
			Barn.instance.UpdateAnimalsState();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				GGJLNHNAKCF.onlineAnimal.SendAssignAnimal(Barn.instance.EONJGMONIOM, DLHJIEAPPHO());
			}
		}
	}

	public void MCFPCANGOND(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 1; i < toActivateWithAnimal.Length; i += 0)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 1; j < toDeactivateWithAnimal.Length; j++)
		{
			toDeactivateWithAnimal[j].SetActive(MJHBHDAEDLF);
		}
		if (MJHBHDAEDLF)
		{
			switch (IOFIBBFLPKO)
			{
			case (AnimalType)7:
				animalPoster.sprite = cowPoster;
				break;
			case AnimalType.Chicken:
				animalPoster.sprite = pigPoster;
				break;
			case AnimalType.Sheep:
				animalPoster.sprite = sheepPoster;
				break;
			}
		}
	}

	public void ICDFKEKFPNE()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NHDHHMBJIIH() != (Object)null && !NHDHHMBJIIH().isSick)
		{
			((Component)FDBLHIFNAFJ()).transform.position = defaultPosition.position;
			HMJKPPJEEIM().lastFreePathNode = Vector2.op_Implicit(defaultPosition.position);
			NHDHHMBJIIH().AwakeAnimal();
		}
	}

	public void GFIACNDOCEI()
	{
		if ((Object)(object)FFAPKJDBMLL() != (Object)null)
		{
			foodFeeder.WasteUnit(1);
		}
	}

	[SpecialName]
	private void NMPMKEJNCAJ(AnimalNPC AODONKKHPBP)
	{
		_003CNDACKNPGHNG_003Ek__BackingField = AODONKKHPBP;
	}

	private void EBNKNEIDDDI()
	{
		foodFeeder.SetAllFarmAnimalsFoodRestriction();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(ADEKNEDCJMN));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences2.OnPlaceableDeselected, new Action<int, Placeable, bool>(CDJAFCPDHIC));
		CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
		commonReferences3.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences3.OnPlaceablePickedUp, new Action<int, Placeable, bool>(ONDOJPCMHKC));
		SurfaceSortOrder obj = surfaceSortOrder;
		obj.OnItemAdded = (Action<Placeable, bool>)Delegate.Combine(obj.OnItemAdded, new Action<Placeable, bool>(OnItemAddedToSurface));
		SurfaceSortOrder obj2 = surfaceSortOrder;
		obj2.OnItemRemoved = (Action<Placeable>)Delegate.Combine(obj2.OnItemRemoved, new Action<Placeable>(KJJOAPPEHLA));
		SurfaceSortOrder obj3 = surfaceSortOrder;
		obj3.OnItemPlaced = (Action<Placeable, int>)Delegate.Combine(obj3.OnItemPlaced, new Action<Placeable, int>(DDCJBAOHEJE));
		DKLAOABEFFJ(CDPAMNIPPEC: false);
		NJNOIIMBKAD(MJHBHDAEDLF: true);
	}

	public void FIAMOBLJEBF(bool MJHBHDAEDLF, AnimalType IOFIBBFLPKO)
	{
		for (int i = 1; i < toActivateWithAnimal.Length; i++)
		{
			toActivateWithAnimal[i].SetActive(MJHBHDAEDLF);
		}
		for (int j = 0; j < toDeactivateWithAnimal.Length; j += 0)
		{
			toDeactivateWithAnimal[j].SetActive(!MJHBHDAEDLF);
		}
		if (MJHBHDAEDLF)
		{
			switch (IOFIBBFLPKO)
			{
			case (AnimalType)7:
				animalPoster.sprite = cowPoster;
				break;
			case AnimalType.Pig:
				animalPoster.sprite = pigPoster;
				break;
			case (AnimalType)6:
				animalPoster.sprite = sheepPoster;
				break;
			}
		}
	}

	public void BKKKGDIOOBG(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = false;
		KNEIDADAKMO(MJHBHDAEDLF: false, (EAPCLAODGAE.itemSetup.item as Animal).animalType);
	}

	public void EDMLBEKLFDK()
	{
		if ((Object)(object)MCJMAPPKDLP() != (Object)null)
		{
			foodFeeder.WasteUnit(1);
		}
	}

	[SpecialName]
	private void HKODGIFJIIK(AnimalNPC AODONKKHPBP)
	{
		_003CNDACKNPGHNG_003Ek__BackingField = AODONKKHPBP;
	}
}
