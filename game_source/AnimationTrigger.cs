using AlmenaraGames;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
	[SerializeField]
	private string enterTriggerParameter;

	[SerializeField]
	private string exitTriggerParameter;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private AudioObject sound;

	[SerializeField]
	private Transform soundPosition;

	public void CNBKOBHBPGJ()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void LDMAGDLPOIC()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void CEJHOKPMJLB()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void BEGCPGHLKHI()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void JHOEAKHHNDD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("New Text start"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void GGNEOGHPEML()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void OHGPLCAGJLJ()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void MOJBKEGFHOD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Grain Ferment"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void BOHNCJJJFGM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Tutorial/BarnBarks_Holly"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("{0}: {1}\n"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void HEMALEBLOKD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[^0-9]"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void INBCLBHEBKE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("OnConversationStarted "))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void HEDJDBKOECL()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void OGFNPBAAHCN()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void LJEIPAGIMMI()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void LDNCOJPALMK()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void GCAEAMDBGBM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void HDEADNOOBJG()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" 0"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void NPJGOGKKJIO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("  initialState:       {0}\n"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void NPCEFHCNJGE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("MainProgress"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void SoundTrigger()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void PJGLIIGLJPM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Floor_"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("</color> to chest"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void IMOHIBLLPIB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(", "))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void NICLCHABAMK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("D-Pad Left"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void KMOGFANNKNC()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void LJJNLJILINI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveActorPosition"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void EIEKPEEPFGA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveBarnInfo"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Melt"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void AFOFBHPBJKA()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void LJJDGAJNNCH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BirdInteract"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1093"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void KGAPHAIFAFH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LE_10"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Theme: "))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void KCDODEOOBHG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" not found in OnlineEventsManager. Cannot start observe dialogue"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void BFGFGIFBDDL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("City/Agatha/Stand"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("buildingObjective_25_3"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void DNDNCBILKMB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" x "))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void APJFDMCLDBD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Error_Stones"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void HBHBMAKMOCM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" "))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void EPIIANNLMOL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" ("))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void JCFDPDLMOME(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("shopOpen"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void FILGJJPEIFO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReciveHollyPositionForTutorial"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void POHCNHBOMDM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("DecorationTile_11"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void IOENPIKFFPI()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void LKNMBEMPBOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Reputation"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void MNLIEHBCJPJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Cheer"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_682"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void JDFDGHGMIEO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Fortitude/MainEvent 4"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void FKILALCMOOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("christmas"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void LBJEAHNNMCN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UnlockPerkLevel?"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void JMDNANLDLEA()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void DOFONBHGEIE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("DLC "))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void FFAECPIMMIL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("DisableLeft"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void DNLPICFIBDE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveSetInt"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void LKLHCHPDKLJ()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void MGDDKALLJDN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("talentMildAle"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void KKIMDHDCKNF()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void OHLBPABJGFA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Item "))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void NBHAMBCMEGD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Selected"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void PMIPGMBDPEP()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void JLJCBIEGBNB()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void EAJDLPCKDEC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void EBICEBJOKBA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("RentingRooms"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void BAOMBNBGGNL()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void GKKAMMGOJEJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Unlocking recipe "))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void ILJJIFMJICA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[MinePuzzleManager] Could not select enough spread spawners for {0}. Trying another type."))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void DAJNLDPGOKL()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void EIEEHAOJGKO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("CustomerPool.DisableCustomer: customer game object is null!"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void MGJIGIBHAKK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void IFFEOIKNCEP()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void GIOPPDELLPP()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void BEMELBGHEND()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void EMCFHILONOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LE_9"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void KLCFOJHHBJA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Pause"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void EDCINHFBGAN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Xbox"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void KEICGGPGIED(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" without ingredient options"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void OMOKAMDGDFF()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void DINONAEKHPK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void FPEJEGHEMOH()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void HIDDNMLHBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("itemGreenbeanSeeds"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void GHCOOCFODFH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("City/Keen/Sharp"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void JGBLJPDNLMO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("All screen resolutions added..."))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void KEECABAJKFN()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void ACLLIGOCDNN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("/"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void BLBJCANJNBG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" at "))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void CMMHCNOAFCI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Year"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void GAANFGOOBGC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("showui"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void KKONKMFFILD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/34/Dialogue Text"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void FBILJKIANGO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void CMMBKACOOPN()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void EKJIEGLPBLA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("castle interior travelling"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void HPJCDAKAHIK()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void MKCEGNPBGMP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" ("))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("hallway"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void CKLGDPFKOBI()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void JKJLIKJMJFD()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void HJMGMIKGPOI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LE_22"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void GNAFMDKHFDE()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void GGDINGHDFPI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveSitDown"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void LIEIDOIDBLJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("add item "))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void AJCMEBDLIFN()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void PMLPGABFLGE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Perks/playerPerk_description_"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void GDCCIEKPHAI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("MineFloor"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void JOPKPGIEAPD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Clean"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void JHJEDPDBMJN()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void OOALHOHGANE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("(missing title)"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void AAPNGMDNJDA()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Intro/TavernAlone"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	private void BNNLNCGNHFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/26/Dialogue Text"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}

	public void CHPEGMGDLIL()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void NKILHLOMJGO()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void BIJGJOMFNOJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UIInteract"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	private void LHGOFNEIMNN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveDeassignAnimal"))
		{
			anim.SetTrigger(exitTriggerParameter);
		}
	}

	public void JNOPPDCFFIP()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void EJCBAHIDLOO()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	public void JDAMOCMFIGO()
	{
		MultiAudioManager.PlayAudioObject(sound, soundPosition);
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			anim.SetTrigger(enterTriggerParameter);
		}
	}
}
