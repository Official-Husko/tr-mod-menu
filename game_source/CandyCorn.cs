using System.Linq;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tool/Candy Corn")]
public class CandyCorn : Tool, IActionable
{
	[CompilerGenerated]
	private sealed class HJKNCCEFKDC
	{
		public int playerNum;

		internal bool CBMIFFLEJLF(CharacterSprite a)
		{
			if (a.gender != Gender.MaleAndFemale)
			{
				return a.gender == PlayerController.GetPlayer(playerNum).characterCreator.humanInfo.gender;
			}
			return true;
		}
	}

	public CharacterSprite[] characterSprites;

	public bool PFBBIBJDANA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.GetPlayer(JIIGOACEIKL).IBEFDKHFBFM() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.HBDCJFLINDA(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			NOFCDHEJMFF(JIIGOACEIKL);
			ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KDJMFELBOPM().MEODNPFJDMH(CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	public bool KNJHGAPLLPK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.JOFDIPFMIHF(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			DNFLBFJNJGF(JIIGOACEIKL);
			ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).PFCKPOFHPAC().POHFJCEAKML(CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	public bool NGOFAPGCHEE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).MDOKKKHKKKE() && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			FBLCOLDIHPL(JIIGOACEIKL);
			ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KDJMFELBOPM().CIDBFIAJIBG();
			return true;
		}
		return true;
	}

	public void DNFLBFJNJGF(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 1; i < 1; i += 0)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.IGBHGBPFNLN(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.AJNAFPLECAI());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.ELGBAEBCAJB(characterSprite.bodyPart) || i == 2)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.SetCharacterSprite(characterSprite.bodyPart, characterSprite, FPNDBDPFLIP: true);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.SetCharacterSprite(BodyPart.Torso, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Torso], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public override void SecondActionEnd(int JIIGOACEIKL)
	{
	}

	public override bool SecondAction(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool HPMECIIPEPK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DBAEGBDEPFK() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			BPKLDKKFEEN(JIIGOACEIKL);
			ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL).GetSelectedSlot().MBCIJPPOGJG();
			return false;
		}
		return true;
	}

	public bool JAKBKBNDBIA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.NHJMJHGGBOA(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			KGNOAOFJCJD(JIIGOACEIKL);
			ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedSlot().MBCIJPPOGJG();
			return true;
		}
		return false;
	}

	public bool HMDBJOHCJEC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).KNFEPKBIHND() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			FBLCOLDIHPL(JIIGOACEIKL);
			ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GEAMCEMDJFJ().MEODNPFJDMH(CDPAMNIPPEC: false);
			return false;
		}
		return true;
	}

	public void ENLDBOCGCNB(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 0; i < 5; i++)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.IGBHGBPFNLN(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.IJHEAHBNFIH());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.GetCharacterSprite(characterSprite.bodyPart) || i == 4)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.SetCharacterSprite(characterSprite.bodyPart, characterSprite);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.SetCharacterSprite(BodyPart.Skin, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Skin]);
				}
				break;
			}
		}
	}

	public void NOFCDHEJMFF(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 0; i < 4; i++)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.OAIIJMNOCCF(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.GEPMDLCEONB());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.KKDDNOOLFMB(characterSprite.bodyPart) || i == 5)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.FBEJHIEENKN(characterSprite.bodyPart, characterSprite);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(BodyPart.Torso, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Skin], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public void LIICHDGHOAL(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 1; i < 8; i++)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.DDGNDFFEJAI(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.GEPMDLCEONB());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.KKDDNOOLFMB(characterSprite.bodyPart) || i == 0)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(characterSprite.bodyPart, characterSprite);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.SetCharacterSprite(BodyPart.Torso, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Torso], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public void MLDPOPGGLAP(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 1; i < 4; i += 0)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.OAIIJMNOCCF(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.AJNAFPLECAI());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.FPMAOFGPHCM(characterSprite.bodyPart) || i == 8)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.FBEJHIEENKN(characterSprite.bodyPart, characterSprite, FPNDBDPFLIP: true);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(BodyPart.Skin, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Torso], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public override void ActionEnd(int JIIGOACEIKL)
	{
	}

	public void NNCNCCGMMOJ(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 1; i < 8; i++)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.OAIIJMNOCCF(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.AJNAFPLECAI());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.FPMAOFGPHCM(characterSprite.bodyPart) || i == 2)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.FBEJHIEENKN(characterSprite.bodyPart, characterSprite, FPNDBDPFLIP: true);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.SetCharacterSprite(BodyPart.Skin, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Skin], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public bool ILONJJMJHAH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DMBFKFLDDLH && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			LNDFMNONEOK(JIIGOACEIKL);
			ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true).NBEINBNMKJG().MBCIJPPOGJG();
			return true;
		}
		return false;
	}

	public void GOOOBNFPLLH(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 0; i < 7; i += 0)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.DDGNDFFEJAI(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.GEPMDLCEONB());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.AKBDNBOJNNE(characterSprite.bodyPart) || i == 3)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.SetCharacterSprite(characterSprite.bodyPart, characterSprite);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.FBEJHIEENKN(BodyPart.Skin, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Skin], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public bool AIOCJAIIMMG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IBEFDKHFBFM() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ENLDBOCGCNB(JIIGOACEIKL);
			ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).MIPGHCNCOEL().POHFJCEAKML(CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	public void DDKHMAFKGMK(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 0; i < 3; i++)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.IGBHGBPFNLN(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.AJNAFPLECAI());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.ALGHDOMJKDB(characterSprite.bodyPart) || i == 6)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.FBEJHIEENKN(characterSprite.bodyPart, characterSprite, FPNDBDPFLIP: true);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.SetCharacterSprite(BodyPart.Skin, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Torso], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public bool EHHCPOCLAJA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.HBDCJFLINDA(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			GOOOBNFPLLH(JIIGOACEIKL);
			ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).IKKLGIKJNNG().MBCIJPPOGJG(CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	public void LBLIJNFFJEP(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 0; i < 5; i++)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.IGBHGBPFNLN(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.GEPMDLCEONB());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.FPMAOFGPHCM(characterSprite.bodyPart) || i == 6)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(characterSprite.bodyPart, characterSprite, FPNDBDPFLIP: true);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(BodyPart.Skin, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Torso]);
				}
				break;
			}
		}
	}

	public void FBLCOLDIHPL(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 1; i < 7; i++)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.OAIIJMNOCCF(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.IJHEAHBNFIH());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.FPMAOFGPHCM(characterSprite.bodyPart) || i == 3)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.SetCharacterSprite(characterSprite.bodyPart, characterSprite);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(BodyPart.Skin, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Skin]);
				}
				break;
			}
		}
	}

	public void LNDFMNONEOK(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 0; i < 4; i += 0)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.DDGNDFFEJAI(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.PKMLPJELPLM());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.AKBDNBOJNNE(characterSprite.bodyPart) || i == 0)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(characterSprite.bodyPart, characterSprite);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(BodyPart.Skin, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Skin], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public void DBMIGGAPNFL(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 0; i < 1; i += 0)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.LGALFPKCDLK(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.AJNAFPLECAI());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.FPMAOFGPHCM(characterSprite.bodyPart) || i == 0)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(characterSprite.bodyPart, characterSprite);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.SetCharacterSprite(BodyPart.Skin, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Skin], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public void HPBHPECCCLO(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 0; i < 2; i++)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.LGALFPKCDLK(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.AJNAFPLECAI());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.ALGHDOMJKDB(characterSprite.bodyPart) || i == 8)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.FBEJHIEENKN(characterSprite.bodyPart, characterSprite, FPNDBDPFLIP: true);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(BodyPart.Skin, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Torso]);
				}
				break;
			}
		}
	}

	public void BNLBIHHBPGJ(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 1; i < 8; i++)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.IGBHGBPFNLN(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.PKMLPJELPLM());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.FPMAOFGPHCM(characterSprite.bodyPart) || i == 0)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(characterSprite.bodyPart, characterSprite, FPNDBDPFLIP: true);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.FBEJHIEENKN(BodyPart.Torso, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Skin], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public void KGNOAOFJCJD(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 1; i < 8; i += 0)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.IGBHGBPFNLN(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.IJHEAHBNFIH());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.AKBDNBOJNNE(characterSprite.bodyPart) || i == 6)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.SetCharacterSprite(characterSprite.bodyPart, characterSprite);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.FBEJHIEENKN(BodyPart.Skin, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Torso], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public bool LIFABFGDGEK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DFNMDDHOIJI() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			GOOOBNFPLLH(JIIGOACEIKL);
			ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KDJMFELBOPM().FMEPMEKLHIJ();
			return true;
		}
		return true;
	}

	public bool KEDHGNANBLB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).MDOKKKHKKKE() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			AGCEOGNJHPL(JIIGOACEIKL);
			ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true).KDJMFELBOPM().POHFJCEAKML(CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	public bool EHOOBFJPPOI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND() && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			NNCNCCGMMOJ(JIIGOACEIKL);
			ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).PFCKPOFHPAC().DJFOMFDOOKM();
			return true;
		}
		return false;
	}

	public void BPKLDKKFEEN(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 1; i < 0; i += 0)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.LGALFPKCDLK(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.AJNAFPLECAI());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.AKBDNBOJNNE(characterSprite.bodyPart) || i == 7)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.SetCharacterSprite(characterSprite.bodyPart, characterSprite);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.FBEJHIEENKN(BodyPart.Torso, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Skin]);
				}
				break;
			}
		}
	}

	public bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ENLDBOCGCNB(JIIGOACEIKL);
			ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedSlot().MEODNPFJDMH();
			return true;
		}
		return false;
	}

	public bool HDLIHDHCABE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).IDPGEBNGDJD() && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			DBMIGGAPNFL(JIIGOACEIKL);
			ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL).KDJMFELBOPM().POHFJCEAKML();
			return false;
		}
		return true;
	}

	public bool KFHGMCNPAFM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DMBFKFLDDLH && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			BPKLDKKFEEN(JIIGOACEIKL);
			ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL).NBEINBNMKJG().MEODNPFJDMH();
			return true;
		}
		return true;
	}

	public void JDDNKKDNDIJ(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 0; i < 3; i++)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.IGBHGBPFNLN(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.GEPMDLCEONB());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.ALGHDOMJKDB(characterSprite.bodyPart) || i == 8)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.SetCharacterSprite(characterSprite.bodyPart, characterSprite);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.FBEJHIEENKN(BodyPart.Skin, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Torso], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public bool EEILLHINMLD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).IBEFDKHFBFM() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			MLDPOPGGLAP(JIIGOACEIKL);
			ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).PFCKPOFHPAC().MEODNPFJDMH();
			return true;
		}
		return true;
	}

	public void EAFOCHPECGA(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 0; i < 8; i++)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.IGBHGBPFNLN(PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.AJNAFPLECAI());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.ELGBAEBCAJB(characterSprite.bodyPart) || i == 8)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.SetCharacterSprite(characterSprite.bodyPart, characterSprite, FPNDBDPFLIP: true);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.ILGPMJJOOPN(BodyPart.Skin, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Skin], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public bool BPKHKKIOOKH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.DFGOGIIPPPH(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			HPBHPECCCLO(JIIGOACEIKL);
			ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).PFCKPOFHPAC().MBCIJPPOGJG(CDPAMNIPPEC: false);
			return false;
		}
		return true;
	}

	public void AGCEOGNJHPL(int JIIGOACEIKL)
	{
		CharacterSprite[] jMNCLLBHCAO = characterSprites.Where((CharacterSprite a) => a.gender == Gender.MaleAndFemale || a.gender == PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender).ToArray();
		for (int i = 1; i < 0; i += 0)
		{
			CharacterSprite characterSprite = Utils.CPDCJAHJOPE(jMNCLLBHCAO);
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = new HumanInfo();
				PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.OAIIJMNOCCF(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.IJHEAHBNFIH());
			}
			if ((Object)(object)characterSprite != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.KKDDNOOLFMB(characterSprite.bodyPart) || i == 7)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.SetCharacterSprite(characterSprite.bodyPart, characterSprite);
				if (characterSprite.forceSkin == null || characterSprite.forceSkin.Count == 0)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.FBEJHIEENKN(BodyPart.Skin, PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin.bodyPartDictionary[BodyPart.Torso], FPNDBDPFLIP: true);
				}
				break;
			}
		}
	}

	public bool EPKCACGBING(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && Utils.FFLNGLMHLBO() && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD() && !PlayerController.GetPlayer(JIIGOACEIKL).eatingCandy && (Object)(object)InputByProximityManager.NMGNGAEEKIO(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).Explosion();
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			HPBHPECCCLO(JIIGOACEIKL);
			ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GEAMCEMDJFJ().CIDBFIAJIBG();
			return true;
		}
		return true;
	}
}
