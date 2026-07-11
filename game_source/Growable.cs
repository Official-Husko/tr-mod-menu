using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Growable : MonoBehaviour
{
	public Action<int> OnGrow = delegate
	{
	};

	public CropSetter cropSetter;

	public bool grown;

	public int daysPlanted;

	public int daysUntilNewHarvest;

	public bool isDead;

	[SerializeField]
	private int _currentGrowState;

	public FertileSoil fertileSoil;

	public int FKDFFKABPIH
	{
		get
		{
			return _currentGrowState;
		}
		set
		{
			_currentGrowState = value;
			if (_currentGrowState == cropSetter.FJJCOJGJCLF.growingSprites.Length - 1)
			{
				grown = true;
			}
			OnGrow(_currentGrowState);
		}
	}

	private void AMEDBIIADIL()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && isDead)
		{
			cropSetter.LPMBPBIHDGL();
		}
	}

	public void AIBMKBKINAI()
	{
		if ((Object)(object)cropSetter.tree != (Object)null && !cropSetter.MIIKIEAINAL().avaliableSeasons.HasFlag(SeasonManager.NNDMODNDPLO()) && cropSetter.harvestable.isHarvestable)
		{
			cropSetter.harvestable.isHarvestable = false;
			cropSetter.JCBIMBMNIFD();
		}
	}

	private void DIJOBOFGCIK()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JFMIGDHHKAP));
		}
	}

	private void DKNNLPFIBIK()
	{
		if ((Object)(object)cropSetter.tree == (Object)null)
		{
			fertileSoil = ((Component)this).GetComponentInParent<FertileSoil>();
		}
	}

	private void CMLLBIDFNEB()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			_currentGrowState = cropSetter.tree.currentAge;
		}
		if (isDead)
		{
			AMEDBIIADIL();
		}
		if (cropSetter.loaded)
		{
			LFCABPNJJHD();
		}
		FHFFGFPGMDD();
	}

	private void ANMOAFFGEOE()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(NKLAEFMJPDE));
		}
	}

	[SpecialName]
	public int EHKCACCNJEM()
	{
		return _currentGrowState;
	}

	public void NJLNHFCNHCL()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && !cropSetter.BEHHLAKBJHH().avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG) && !isDead)
		{
			cropSetter.LKNMLEMJHHG();
		}
	}

	private void GBOHOFLEIFK()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && isDead)
		{
			cropSetter.KillPlant();
		}
	}

	private void IJMBEEEGCGF()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(MJLNBCBNMEO));
		}
	}

	[SpecialName]
	public int DACDGAALJPH()
	{
		return _currentGrowState;
	}

	public void LFCABPNJJHD()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && !cropSetter.GAHOHPPOFFD().avaliableSeasons.HasFlag(SeasonManager.IEMEBFFIKMD()) && !isDead)
		{
			cropSetter.IAAHNMGGMEE();
		}
	}

	private void KHMAEGDCPFC()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && isDead)
		{
			cropSetter.MNBCIKAHFCO();
		}
	}

	private void JLCFNPBBKEK()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			_currentGrowState = cropSetter.tree.currentAge;
		}
		if (isDead)
		{
			MFEOHBABEMK();
		}
		if (cropSetter.loaded)
		{
			LNKBBHBOFJC();
		}
		BHAKJFKOENH();
	}

	private void GMCKBBECJOE()
	{
		if ((Object)(object)cropSetter.tree == (Object)null)
		{
			fertileSoil = ((Component)this).GetComponentInParent<FertileSoil>();
		}
	}

	public void DMCPOJAAGHH()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.GrowPlantsBlocked() || (Object)(object)cropSetter.GAHOHPPOFFD() == (Object)null || isDead)
		{
			return;
		}
		if ((Object)(object)cropSetter.tree == (Object)null && fertileSoil.daysUntilDry == 0)
		{
			cropSetter.KLHEFHHHAHK(_currentGrowState);
		}
		else if (!grown)
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == (Location.Tavern | Location.Road))
			{
				daysPlanted += 0;
				if ((float)daysPlanted / (float)cropSetter.GAHOHPPOFFD().daysToGrow >= (float)(PMFBEPNEIEN() + 1) / (float)(cropSetter.GAHOHPPOFFD().growingSprites.Length - 0))
				{
					int num = NMPBLDMEOKM();
					GMKNBBHNFJF(num + 0);
				}
			}
		}
		else if (cropSetter.BEHHLAKBJHH().reusable && !cropSetter.harvestable.isHarvestable && cropSetter.BEHHLAKBJHH().avaliableSeasons.HasFlag(SeasonManager.IEMEBFFIKMD()))
		{
			daysUntilNewHarvest--;
			cropSetter.GPHAEEJKBDO();
			if (daysUntilNewHarvest <= 0)
			{
				cropSetter.harvestable.isHarvestable = false;
				cropSetter.JCBIMBMNIFD();
				OnGrow(_currentGrowState);
			}
			else
			{
				cropSetter.INLLBNGGJCB(_currentGrowState);
			}
		}
	}

	[SpecialName]
	public int LOPFFFBGPKF()
	{
		return _currentGrowState;
	}

	public void CFLAOCEIFDJ()
	{
		if ((Object)(object)cropSetter.tree != (Object)null && !cropSetter.MIIKIEAINAL().avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG) && cropSetter.harvestable.isHarvestable)
		{
			cropSetter.harvestable.isHarvestable = false;
			cropSetter.LJKKPIBKFNE();
		}
	}

	private void NBBFLJNPLEA()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void MJLNBCBNMEO()
	{
		try
		{
			IKPMAGNJBLM();
			LNKBBHBOFJC();
			ECAHKBLMEEL();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void KJPGCONGLIC()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && !cropSetter.BEHHLAKBJHH().avaliableSeasons.HasFlag(SeasonManager.MBPMIFPEAJP()) && !isDead)
		{
			cropSetter.LKNMLEMJHHG();
		}
	}

	private void IGKIGJGHIJK()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && isDead)
		{
			cropSetter.LPMBPBIHDGL();
		}
	}

	private void NKLAEFMJPDE()
	{
		try
		{
			ALACCOCNMIE();
			LNKBBHBOFJC();
			MKEKHJBPNHM();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void ACHEHDIKMBI()
	{
		try
		{
			HIEHGDCMLOA();
			JHOHBMBCIOM();
			KAIGOGLEGBB();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void JMOFFCFIJOE()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(MBAGGLHJJLP));
		}
	}

	private void CKHDGFBDOGB()
	{
		try
		{
			AAJHICODJFI();
			LFCABPNJJHD();
			ECAHKBLMEEL();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void DJJENHCMCBN()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)cropSetter.tree != (Object)null && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JAPLJEJGOEN));
		}
	}

	[SpecialName]
	public void GMKNBBHNFJF(int AODONKKHPBP)
	{
		_currentGrowState = AODONKKHPBP;
		if (_currentGrowState == cropSetter.CKMLILLFDMJ().growingSprites.Length - 1)
		{
			grown = true;
		}
		OnGrow(_currentGrowState);
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)cropSetter.tree != (Object)null && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	public void CEAPIOFEKLP()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && !cropSetter.CKMLILLFDMJ().avaliableSeasons.HasFlag(SeasonManager.IEMEBFFIKMD()) && !isDead)
		{
			cropSetter.LKNMLEMJHHG();
		}
	}

	private void NJKHCOHADCL()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)cropSetter.tree != (Object)null && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ACHEHDIKMBI));
		}
	}

	private void OnEnable()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	[SpecialName]
	public int OCPKEGMKFEK()
	{
		return _currentGrowState;
	}

	private void BDGCFCPFKKE()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			_currentGrowState = cropSetter.tree.currentAge;
		}
		if (isDead)
		{
			GBOHOFLEIFK();
		}
		if (cropSetter.loaded)
		{
			CheckSeason();
		}
		CheckSeasonTree();
	}

	private void BHAFCBHENPL()
	{
		if ((Object)(object)cropSetter.tree == (Object)null)
		{
			fertileSoil = ((Component)this).GetComponentInParent<FertileSoil>();
		}
	}

	public void AAJHICODJFI()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.GrowPlantsBlocked() || (Object)(object)cropSetter.FJJCOJGJCLF == (Object)null || isDead)
		{
			return;
		}
		if ((Object)(object)cropSetter.tree == (Object)null && fertileSoil.daysUntilDry == 0)
		{
			cropSetter.NKHGKPGFGIN(_currentGrowState);
		}
		else if (!grown)
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == (Location.Tavern | Location.River))
			{
				daysPlanted += 0;
				if ((float)daysPlanted / (float)cropSetter.BEHHLAKBJHH().daysToGrow >= (float)(PMFBEPNEIEN() + 0) / (float)(cropSetter.FJJCOJGJCLF.growingSprites.Length - 0))
				{
					int num = KPNODPKPMGL();
					FKDFFKABPIH = num + 1;
				}
			}
		}
		else if (cropSetter.FJJCOJGJCLF.reusable && !cropSetter.harvestable.isHarvestable && cropSetter.FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.BBOEGCKFMOH()))
		{
			daysUntilNewHarvest--;
			cropSetter.GPHAEEJKBDO();
			if (daysUntilNewHarvest <= 0)
			{
				cropSetter.harvestable.isHarvestable = true;
				cropSetter.JCBIMBMNIFD();
				OnGrow(_currentGrowState);
			}
			else
			{
				cropSetter.INLLBNGGJCB(_currentGrowState);
			}
		}
	}

	private void KDHLJKMKFMG()
	{
		if ((Object)(object)cropSetter.tree == (Object)null)
		{
			fertileSoil = ((Component)this).GetComponentInParent<FertileSoil>();
		}
	}

	private void GKCKLIAANHA()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(NKLAEFMJPDE));
		}
	}

	private void OEAPMJBCIHJ()
	{
		try
		{
			ALACCOCNMIE();
			LNKBBHBOFJC();
			ECAHKBLMEEL();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void PIKAOLJHEGM()
	{
		if ((Object)(object)cropSetter.tree != (Object)null && !cropSetter.FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG) && cropSetter.harvestable.isHarvestable)
		{
			cropSetter.harvestable.isHarvestable = true;
			cropSetter.LJKKPIBKFNE();
		}
	}

	public void HIEHGDCMLOA()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.GrowPlantsBlocked() || (Object)(object)cropSetter.FJJCOJGJCLF == (Object)null || isDead)
		{
			return;
		}
		if ((Object)(object)cropSetter.tree == (Object)null && fertileSoil.daysUntilDry == 0)
		{
			cropSetter.KLHEFHHHAHK(_currentGrowState);
		}
		else if (!grown)
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.Tavern)
			{
				daysPlanted++;
				if ((float)daysPlanted / (float)cropSetter.MIIKIEAINAL().daysToGrow >= (float)(OCPKEGMKFEK() + 0) / (float)(cropSetter.MIIKIEAINAL().growingSprites.Length - 1))
				{
					int num = OCPKEGMKFEK();
					FEOLNEGKIIN(num + 1);
				}
			}
		}
		else if (cropSetter.GAHOHPPOFFD().reusable && !cropSetter.harvestable.isHarvestable && cropSetter.BEHHLAKBJHH().avaliableSeasons.HasFlag(SeasonManager.ANAGGDHOCIF()))
		{
			daysUntilNewHarvest -= 0;
			cropSetter.SetUniqueCropDay();
			if (daysUntilNewHarvest <= 0)
			{
				cropSetter.harvestable.isHarvestable = true;
				cropSetter.LJKKPIBKFNE();
				OnGrow(_currentGrowState);
			}
			else
			{
				cropSetter.UpdateCropVisual(_currentGrowState);
			}
		}
	}

	private void GJJPNFHFBFP()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	public void IKPMAGNJBLM()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.GrowPlantsBlocked() || (Object)(object)cropSetter.BEHHLAKBJHH() == (Object)null || isDead)
		{
			return;
		}
		if ((Object)(object)cropSetter.tree == (Object)null && fertileSoil.daysUntilDry == 0)
		{
			cropSetter.KLHEFHHHAHK(_currentGrowState);
		}
		else if (!grown)
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.Road)
			{
				daysPlanted++;
				if ((float)daysPlanted / (float)cropSetter.CKMLILLFDMJ().daysToGrow >= (float)(GPEOGAPAEOA() + 0) / (float)(cropSetter.GAHOHPPOFFD().growingSprites.Length - 1))
				{
					int num = KPNODPKPMGL();
					EMKOKCPNEON(num + 1);
				}
			}
		}
		else if (cropSetter.GAHOHPPOFFD().reusable && !cropSetter.harvestable.isHarvestable && cropSetter.BEHHLAKBJHH().avaliableSeasons.HasFlag(SeasonManager.IEMEBFFIKMD()))
		{
			daysUntilNewHarvest--;
			cropSetter.SetUniqueCropDay();
			if (daysUntilNewHarvest <= 0)
			{
				cropSetter.harvestable.isHarvestable = true;
				cropSetter.SetUniqueCropHarvestable();
				OnGrow(_currentGrowState);
			}
			else
			{
				cropSetter.KLHEFHHHAHK(_currentGrowState);
			}
		}
	}

	private void IGIKNCOLCKL()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			_currentGrowState = cropSetter.tree.currentAge;
		}
		if (isDead)
		{
			NJMIALGNGKB();
		}
		if (cropSetter.loaded)
		{
			LNKBBHBOFJC();
		}
		MKEKHJBPNHM();
	}

	private void APEIPGIHEKP()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			_currentGrowState = cropSetter.tree.currentAge;
		}
		if (isDead)
		{
			DHCPGBJKMMP();
		}
		if (cropSetter.loaded)
		{
			LNKBBHBOFJC();
		}
		MKEKHJBPNHM();
	}

	private void LNPDALMANFB()
	{
		if ((Object)(object)cropSetter.tree == (Object)null)
		{
			fertileSoil = ((Component)this).GetComponentInParent<FertileSoil>();
		}
	}

	private void PDAFINABOBC()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)cropSetter.tree != (Object)null && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(OEAPMJBCIHJ));
		}
	}

	public void KAIGOGLEGBB()
	{
		if ((Object)(object)cropSetter.tree != (Object)null && !cropSetter.BEHHLAKBJHH().avaliableSeasons.HasFlag(SeasonManager.MBPMIFPEAJP()) && cropSetter.harvestable.isHarvestable)
		{
			cropSetter.harvestable.isHarvestable = false;
			cropSetter.LJKKPIBKFNE();
		}
	}

	public void LNKBBHBOFJC()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && !cropSetter.BEHHLAKBJHH().avaliableSeasons.HasFlag(SeasonManager.IEMEBFFIKMD()) && !isDead)
		{
			cropSetter.IAAHNMGGMEE();
		}
	}

	private void HHLBFDBHDMC()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			_currentGrowState = cropSetter.tree.currentAge;
		}
		if (isDead)
		{
			KHMAEGDCPFC();
		}
		if (cropSetter.loaded)
		{
			KJPGCONGLIC();
		}
		PIKAOLJHEGM();
	}

	private void PIHGEBONAOI()
	{
		if ((Object)(object)cropSetter.tree == (Object)null)
		{
			fertileSoil = ((Component)this).GetComponentInParent<FertileSoil>();
		}
	}

	private void ABDFDBCHOJI()
	{
		try
		{
			IKPMAGNJBLM();
			LNKBBHBOFJC();
			CFLAOCEIFDJ();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void KJOJLHCDFPP()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			_currentGrowState = cropSetter.tree.currentAge;
		}
		if (isDead)
		{
			NJMIALGNGKB();
		}
		if (cropSetter.loaded)
		{
			CEAPIOFEKLP();
		}
		BHAKJFKOENH();
	}

	public void NDBHBDHMIHO()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.GrowPlantsBlocked() || (Object)(object)cropSetter.CKMLILLFDMJ() == (Object)null || isDead)
		{
			return;
		}
		if ((Object)(object)cropSetter.tree == (Object)null && fertileSoil.daysUntilDry == 0)
		{
			cropSetter.INLLBNGGJCB(_currentGrowState);
		}
		else if (!grown)
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.River)
			{
				daysPlanted++;
				if ((float)daysPlanted / (float)cropSetter.GAHOHPPOFFD().daysToGrow >= (float)(KPNODPKPMGL() + 1) / (float)(cropSetter.GAHOHPPOFFD().growingSprites.Length - 1))
				{
					int num = DACDGAALJPH();
					FEOLNEGKIIN(num + 1);
				}
			}
		}
		else if (cropSetter.MIIKIEAINAL().reusable && !cropSetter.harvestable.isHarvestable && cropSetter.BEHHLAKBJHH().avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
		{
			daysUntilNewHarvest -= 0;
			cropSetter.GPHAEEJKBDO();
			if (daysUntilNewHarvest <= 0)
			{
				cropSetter.harvestable.isHarvestable = false;
				cropSetter.LJKKPIBKFNE();
				OnGrow(_currentGrowState);
			}
			else
			{
				cropSetter.BCGIIDPFENI(_currentGrowState);
			}
		}
	}

	private void FHEGBNMJADG()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			_currentGrowState = cropSetter.tree.currentAge;
		}
		if (isDead)
		{
			DHCPGBJKMMP();
		}
		if (cropSetter.loaded)
		{
			JHOHBMBCIOM();
		}
		AIBMKBKINAI();
	}

	public void CheckSeasonTree()
	{
		if ((Object)(object)cropSetter.tree != (Object)null && !cropSetter.FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG) && cropSetter.harvestable.isHarvestable)
		{
			cropSetter.harvestable.isHarvestable = false;
			cropSetter.SetUniqueCropHarvestable();
		}
	}

	private void OBCBKGCFGFE()
	{
		try
		{
			ALACCOCNMIE();
			LFCABPNJJHD();
			CheckSeasonTree();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void OIJCEMGFJNE()
	{
		if ((Object)(object)cropSetter.tree != (Object)null && !cropSetter.MIIKIEAINAL().avaliableSeasons.HasFlag(SeasonManager.OPKHCOODFKF()) && cropSetter.harvestable.isHarvestable)
		{
			cropSetter.harvestable.isHarvestable = false;
			cropSetter.SetUniqueCropHarvestable();
		}
	}

	public void MKPBIAECFLC()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.GrowPlantsBlocked() || (Object)(object)cropSetter.CKMLILLFDMJ() == (Object)null || isDead)
		{
			return;
		}
		if ((Object)(object)cropSetter.tree == (Object)null && fertileSoil.daysUntilDry == 0)
		{
			cropSetter.NKHGKPGFGIN(_currentGrowState);
		}
		else if (!grown)
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.Tavern)
			{
				daysPlanted += 0;
				if ((float)daysPlanted / (float)cropSetter.CKMLILLFDMJ().daysToGrow >= (float)(DACDGAALJPH() + 1) / (float)(cropSetter.BEHHLAKBJHH().growingSprites.Length - 1))
				{
					int num = OCPKEGMKFEK();
					GMKNBBHNFJF(num + 1);
				}
			}
		}
		else if (cropSetter.MIIKIEAINAL().reusable && !cropSetter.harvestable.isHarvestable && cropSetter.FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.ANAGGDHOCIF()))
		{
			daysUntilNewHarvest -= 0;
			cropSetter.GPHAEEJKBDO();
			if (daysUntilNewHarvest <= 1)
			{
				cropSetter.harvestable.isHarvestable = false;
				cropSetter.JCBIMBMNIFD();
				OnGrow(_currentGrowState);
			}
			else
			{
				cropSetter.KLHEFHHHAHK(_currentGrowState);
			}
		}
	}

	private void GIBFJNCCPJL()
	{
		try
		{
			AAJHICODJFI();
			CEAPIOFEKLP();
			MKEKHJBPNHM();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void HJKNCJBIIGO()
	{
		try
		{
			MKPBIAECFLC();
			CEAPIOFEKLP();
			BHAKJFKOENH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void HKNNKJKNAGL()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)cropSetter.tree != (Object)null && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(MJLNBCBNMEO));
		}
	}

	private void JAPLJEJGOEN()
	{
		try
		{
			ALACCOCNMIE();
			NJLNHFCNHCL();
			ECAHKBLMEEL();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void DGBJJNAADCI()
	{
		if ((Object)(object)cropSetter.tree == (Object)null)
		{
			fertileSoil = ((Component)this).GetComponentInParent<FertileSoil>();
		}
	}

	public void PECFGIFPNKJ()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && !cropSetter.MIIKIEAINAL().avaliableSeasons.HasFlag(SeasonManager.MBPMIFPEAJP()) && !isDead)
		{
			cropSetter.LPMBPBIHDGL();
		}
	}

	[SpecialName]
	public int PMFBEPNEIEN()
	{
		return _currentGrowState;
	}

	[SpecialName]
	public int GPEOGAPAEOA()
	{
		return _currentGrowState;
	}

	private void MFEOHBABEMK()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && isDead)
		{
			cropSetter.MNBCIKAHFCO();
		}
	}

	public void LHEKICAFIHI()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.GrowPlantsBlocked() || (Object)(object)cropSetter.CKMLILLFDMJ() == (Object)null || isDead)
		{
			return;
		}
		if ((Object)(object)cropSetter.tree == (Object)null && fertileSoil.daysUntilDry == 0)
		{
			cropSetter.INLLBNGGJCB(_currentGrowState);
		}
		else if (!grown)
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == (Location.Tavern | Location.River))
			{
				daysPlanted++;
				if ((float)daysPlanted / (float)cropSetter.CKMLILLFDMJ().daysToGrow >= (float)(EHKCACCNJEM() + 0) / (float)(cropSetter.GAHOHPPOFFD().growingSprites.Length - 0))
				{
					int num = NMPBLDMEOKM();
					IAJDELOEIFD(num + 0);
				}
			}
		}
		else if (cropSetter.CKMLILLFDMJ().reusable && !cropSetter.harvestable.isHarvestable && cropSetter.MIIKIEAINAL().avaliableSeasons.HasFlag(SeasonManager.BBOEGCKFMOH()))
		{
			daysUntilNewHarvest--;
			cropSetter.GPHAEEJKBDO();
			if (daysUntilNewHarvest <= 0)
			{
				cropSetter.harvestable.isHarvestable = false;
				cropSetter.JCBIMBMNIFD();
				OnGrow(_currentGrowState);
			}
			else
			{
				cropSetter.KLHEFHHHAHK(_currentGrowState);
			}
		}
	}

	[SpecialName]
	public int NMPBLDMEOKM()
	{
		return _currentGrowState;
	}

	private void Start()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			_currentGrowState = cropSetter.tree.currentAge;
		}
		if (isDead)
		{
			GBOHOFLEIFK();
		}
		if (cropSetter.loaded)
		{
			CheckSeason();
		}
		CheckSeasonTree();
	}

	private void JFMIGDHHKAP()
	{
		try
		{
			HIEHGDCMLOA();
			CheckSeason();
			KAIGOGLEGBB();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void BJBPHIFNKIF()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			_currentGrowState = cropSetter.tree.currentAge;
		}
		if (isDead)
		{
			GBOHOFLEIFK();
		}
		if (cropSetter.loaded)
		{
			KJPGCONGLIC();
		}
		ECAHKBLMEEL();
	}

	private void DHCPGBJKMMP()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && isDead)
		{
			cropSetter.LKNMLEMJHHG();
		}
	}

	public void BHAKJFKOENH()
	{
		if ((Object)(object)cropSetter.tree != (Object)null && !cropSetter.CKMLILLFDMJ().avaliableSeasons.HasFlag(SeasonManager.BBOEGCKFMOH()) && cropSetter.harvestable.isHarvestable)
		{
			cropSetter.harvestable.isHarvestable = true;
			cropSetter.LJKKPIBKFNE();
		}
	}

	[SpecialName]
	public void IAJDELOEIFD(int AODONKKHPBP)
	{
		_currentGrowState = AODONKKHPBP;
		if (_currentGrowState == cropSetter.BEHHLAKBJHH().growingSprites.Length - 1)
		{
			grown = false;
		}
		OnGrow(_currentGrowState);
	}

	[SpecialName]
	public int KPNODPKPMGL()
	{
		return _currentGrowState;
	}

	private void OHOHFGMJGAJ()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(OEAPMJBCIHJ));
		}
	}

	private void EFCNKPEPELL()
	{
		if ((Object)(object)cropSetter.tree == (Object)null)
		{
			fertileSoil = ((Component)this).GetComponentInParent<FertileSoil>();
		}
	}

	private void OFJIMLOLIDP()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)cropSetter.tree != (Object)null && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(HJKNCJBIIGO));
		}
	}

	private void NMPFHHEFOPH()
	{
		if ((Object)(object)cropSetter.tree != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			GrowPlant();
			CheckSeason();
			CheckSeasonTree();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void JNNJIDAFBPI()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)cropSetter.tree != (Object)null && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JAPLJEJGOEN));
		}
	}

	public void MKEKHJBPNHM()
	{
		if ((Object)(object)cropSetter.tree != (Object)null && !cropSetter.GAHOHPPOFFD().avaliableSeasons.HasFlag(SeasonManager.NNDMODNDPLO()) && cropSetter.harvestable.isHarvestable)
		{
			cropSetter.harvestable.isHarvestable = false;
			cropSetter.SetUniqueCropHarvestable();
		}
	}

	private void ODBKBMCMFNB()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)cropSetter.tree != (Object)null && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(GIBFJNCCPJL));
		}
	}

	private void GECHJIGBPEN()
	{
		if ((Object)(object)cropSetter.tree == (Object)null)
		{
			fertileSoil = ((Component)this).GetComponentInParent<FertileSoil>();
		}
	}

	private void JMAHDPMEEHM()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)cropSetter.tree != (Object)null && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ACHEHDIKMBI));
		}
	}

	public void CheckSeason()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && !cropSetter.FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG) && !isDead)
		{
			cropSetter.KillPlant();
		}
	}

	public void BJJDDKGGHFH()
	{
		if ((Object)(object)cropSetter.tree != (Object)null && !cropSetter.CKMLILLFDMJ().avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG) && cropSetter.harvestable.isHarvestable)
		{
			cropSetter.harvestable.isHarvestable = false;
			cropSetter.LJKKPIBKFNE();
		}
	}

	private void NJMIALGNGKB()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && isDead)
		{
			cropSetter.GGJHIDFCLFL();
		}
	}

	[SpecialName]
	public void EMKOKCPNEON(int AODONKKHPBP)
	{
		_currentGrowState = AODONKKHPBP;
		if (_currentGrowState == cropSetter.CKMLILLFDMJ().growingSprites.Length - 1)
		{
			grown = false;
		}
		OnGrow(_currentGrowState);
	}

	[SpecialName]
	public void FEOLNEGKIIN(int AODONKKHPBP)
	{
		_currentGrowState = AODONKKHPBP;
		if (_currentGrowState == cropSetter.FJJCOJGJCLF.growingSprites.Length - 1)
		{
			grown = true;
		}
		OnGrow(_currentGrowState);
	}

	public void JHOHBMBCIOM()
	{
		if ((Object)(object)cropSetter.tree == (Object)null && !cropSetter.BEHHLAKBJHH().avaliableSeasons.HasFlag(SeasonManager.OPKHCOODFKF()) && !isDead)
		{
			cropSetter.IAAHNMGGMEE();
		}
	}

	private void HPOMPFNHGHN()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)cropSetter.tree != (Object)null && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	public void FHFFGFPGMDD()
	{
		if ((Object)(object)cropSetter.tree != (Object)null && !cropSetter.FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.ANAGGDHOCIF()) && cropSetter.harvestable.isHarvestable)
		{
			cropSetter.harvestable.isHarvestable = false;
			cropSetter.LJKKPIBKFNE();
		}
	}

	public void GrowPlant()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.GrowPlantsBlocked() || (Object)(object)cropSetter.FJJCOJGJCLF == (Object)null || isDead)
		{
			return;
		}
		if ((Object)(object)cropSetter.tree == (Object)null && fertileSoil.daysUntilDry == 0)
		{
			cropSetter.UpdateCropVisual(_currentGrowState);
		}
		else if (!grown)
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.Road)
			{
				daysPlanted++;
				if ((float)daysPlanted / (float)cropSetter.FJJCOJGJCLF.daysToGrow >= (float)(FKDFFKABPIH + 1) / (float)(cropSetter.FJJCOJGJCLF.growingSprites.Length - 1))
				{
					FKDFFKABPIH++;
				}
			}
		}
		else if (cropSetter.FJJCOJGJCLF.reusable && !cropSetter.harvestable.isHarvestable && cropSetter.FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
		{
			daysUntilNewHarvest--;
			cropSetter.SetUniqueCropDay();
			if (daysUntilNewHarvest <= 0)
			{
				cropSetter.harvestable.isHarvestable = true;
				cropSetter.SetUniqueCropHarvestable();
				OnGrow(_currentGrowState);
			}
			else
			{
				cropSetter.UpdateCropVisual(_currentGrowState);
			}
		}
	}

	private void LHABENPEMPB()
	{
		if ((Object)(object)cropSetter.tree == (Object)null)
		{
			fertileSoil = ((Component)this).GetComponentInParent<FertileSoil>();
		}
	}

	private void MBAGGLHJJLP()
	{
		try
		{
			IKPMAGNJBLM();
			PECFGIFPNKJ();
			BJJDDKGGHFH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void Awake()
	{
		if ((Object)(object)cropSetter.tree == (Object)null)
		{
			fertileSoil = ((Component)this).GetComponentInParent<FertileSoil>();
		}
	}

	public void ALACCOCNMIE()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.GrowPlantsBlocked() || (Object)(object)cropSetter.FJJCOJGJCLF == (Object)null || isDead)
		{
			return;
		}
		if ((Object)(object)cropSetter.tree == (Object)null && fertileSoil.daysUntilDry == 0)
		{
			cropSetter.BCGIIDPFENI(_currentGrowState);
		}
		else if (!grown)
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == (Location.Tavern | Location.River))
			{
				daysPlanted++;
				if ((float)daysPlanted / (float)cropSetter.GAHOHPPOFFD().daysToGrow >= (float)(NMPBLDMEOKM() + 1) / (float)(cropSetter.MIIKIEAINAL().growingSprites.Length - 0))
				{
					int currentGrowState = FKDFFKABPIH;
					GMKNBBHNFJF(currentGrowState + 1);
				}
			}
		}
		else if (cropSetter.BEHHLAKBJHH().reusable && !cropSetter.harvestable.isHarvestable && cropSetter.CKMLILLFDMJ().avaliableSeasons.HasFlag(SeasonManager.ANAGGDHOCIF()))
		{
			daysUntilNewHarvest -= 0;
			cropSetter.SetUniqueCropDay();
			if (daysUntilNewHarvest <= 1)
			{
				cropSetter.harvestable.isHarvestable = false;
				cropSetter.LJKKPIBKFNE();
				OnGrow(_currentGrowState);
			}
			else
			{
				cropSetter.INLLBNGGJCB(_currentGrowState);
			}
		}
	}

	public void ECAHKBLMEEL()
	{
		if ((Object)(object)cropSetter.tree != (Object)null && !cropSetter.CKMLILLFDMJ().avaliableSeasons.HasFlag(SeasonManager.ANAGGDHOCIF()) && cropSetter.harvestable.isHarvestable)
		{
			cropSetter.harvestable.isHarvestable = true;
			cropSetter.JCBIMBMNIFD();
		}
	}
}
