using AlmenaraGames;
using UnityEngine;

public class LightningEffect : MonoBehaviour
{
	public Animator anim;

	public AudioObject thunder;

	private int MDHCBOJBFGJ;

	private MultiAudioSource BFHBGFLFNGI;

	private void IAEPFFMCKOH()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void MEDIGODLCBN()
	{
		Weather.lightningEffects.Add(this);
	}

	private void HFOCECKNDBG()
	{
		Weather.lightningEffects.Add(this);
	}

	private void MMAMJDLONFA()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void POFIEEODEJO()
	{
		Weather.lightningEffects.Add(this);
	}

	private void NKGNABOCPDG()
	{
		Weather.lightningEffects.Remove(this);
	}

	public void IADPFNOHLDJ(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 2);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Tutorial_Objective_");
				break;
			case 1:
				anim.Play("GENERIC STATE - NAME UNDEFINED");
				break;
			case 2:
				anim.Play("Items/item_name_695");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 24f;
			}
		}
	}

	private void FJFLGDADEKM()
	{
		Weather.lightningEffects.Add(this);
	}

	private void DMEEIHDDALH()
	{
		Weather.lightningEffects.Add(this);
	}

	private void GGIJFBAJLIF()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void GNIBPOBGDNC()
	{
		Weather.lightningEffects.Add(this);
	}

	private void AONIDCIEKCM()
	{
		Weather.lightningEffects.Add(this);
	}

	private void OJLGPAJPCHG()
	{
		Weather.lightningEffects.Add(this);
	}

	private void HGEKPHOPJCD()
	{
		Weather.lightningEffects.Add(this);
	}

	private void FCLABOCLACJ()
	{
		Weather.lightningEffects.Add(this);
	}

	public void KEPCMHLMNLO(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 2);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play(", ");
				break;
			case 1:
				anim.Play("PlaceableOnSpecificSurfaces");
				break;
			case 2:
				anim.Play("Not ready to join room");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 807f;
			}
		}
	}

	public void AIMKHJPCCBO(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 5);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("ReceiveSleepStart");
				break;
			case 1:
				anim.Play("TermasInterior/Rin/Stand");
				break;
			case 2:
				anim.Play("Intro/TavernAlone");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 148f;
			}
		}
	}

	private void ONBNPKMOKLG()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void AJOAKOCODOC()
	{
		Weather.lightningEffects.Add(this);
	}

	private void MEDLNBCAJCL()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void KPOAGLEJGNG()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void GJCADEIJMCM()
	{
		Weather.lightningEffects.Remove(this);
	}

	public void NFABICFOKIG(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 3);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("itemShimejiMushrooms");
				break;
			case 1:
				anim.Play("City/Woody/Stand");
				break;
			case 2:
				anim.Play("Items/item_description_1115");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1881f;
			}
		}
	}

	public void FNGPOEGLJCI(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 3);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("BartenderDescription");
				break;
			case 1:
				anim.Play("<color=#BF0000>");
				break;
			case 2:
				anim.Play("Selected");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1648f;
			}
		}
	}

	private void NELLIBBABJD()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void CKKPEJGBDKK()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void CGHHPELBKBK()
	{
		Weather.lightningEffects.Add(this);
	}

	private void FNPHGGLAFKA()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void DJJENHCMCBN()
	{
		Weather.lightningEffects.Remove(this);
	}

	public void GPBHCNHNNEM(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 0);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("ZuzzuProgress");
				break;
			case 1:
				anim.Play("Player num by bed assigned failed. Finding by name...");
				break;
			case 2:
				anim.Play("connect");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 864f;
			}
		}
	}

	public void NDGBBNBCDKN(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 3);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("quest_description_19");
				break;
			case 1:
				anim.Play("Inventory full");
				break;
			case 2:
				anim.Play("No bucket of water");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 688f;
			}
		}
	}

	private void KJOCGLKMMOM()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void AEMNHHGAPIL()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void GKCKLIAANHA()
	{
		Weather.lightningEffects.Add(this);
	}

	public void FOPBICKECKL(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 0);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("[PlayerName]");
				break;
			case 1:
				anim.Play("Sending cursor move for grid index {0} in mine level {1}");
				break;
			case 2:
				anim.Play("Random");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 757f;
			}
		}
	}

	public void MPMBMDEPEPJ(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 4);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("repUnlockRentingRooms");
				break;
			case 1:
				anim.Play("MineState");
				break;
			case 2:
				anim.Play("ReceiveKickWithoutHit");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1533f;
			}
		}
	}

	private void ELPCMDCKLGN()
	{
		Weather.lightningEffects.Add(this);
	}

	public void KEIKANCNOBE(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 7);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Speed");
				break;
			case 1:
				anim.Play("Tavern must be closed");
				break;
			case 2:
				anim.Play("mForMins");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1508f;
			}
		}
	}

	private void EDBOBLNOBLP()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void HFIHGHBLLAM()
	{
		Weather.lightningEffects.Add(this);
	}

	private void JMJDHLOMKAP()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void PGDBFGFMGKI()
	{
		Weather.lightningEffects.Add(this);
	}

	public void AMPMPKDNHMP(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 2);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("[MinePuzzleManager] Ordered puzzle queue for level {0}: [{1}]");
				break;
			case 1:
				anim.Play("itemIPA");
				break;
			case 2:
				anim.Play("Player");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 341f;
			}
		}
	}

	private void OJLGOCFKLJE()
	{
		Weather.lightningEffects.Add(this);
	}

	private void MNEAOFNAKIP()
	{
		Weather.lightningEffects.Add(this);
	}

	private void MHENLAGHFOD()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void ADJHOLOIGJE()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void KHNBDGDLMIE()
	{
		Weather.lightningEffects.Add(this);
	}

	private void DPFHKHOCFKE()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void BJOOCKCBPLJ()
	{
		Weather.lightningEffects.Add(this);
	}

	public void CHBALFHAPMO(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 4);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play(" </mark>");
				break;
			case 1:
				anim.Play(":</color> <sprite name=\"ChristmasTicket\">");
				break;
			case 2:
				anim.Play("Alheab");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1153f;
			}
		}
	}

	private void KCOFAJBKHAO()
	{
		Weather.lightningEffects.Add(this);
	}

	public void GHEMBMBDENJ(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 0);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Items/item_name_1144");
				break;
			case 1:
				anim.Play("]");
				break;
			case 2:
				anim.Play("Stone");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 990f;
			}
		}
	}

	private void OnEnable()
	{
		Weather.lightningEffects.Add(this);
	}

	private void AFGJLAACCFN()
	{
		Weather.lightningEffects.Add(this);
	}

	public void BDHFPCOAPOL(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 7);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Food");
				break;
			case 1:
				anim.Play("SetNPCPosition");
				break;
			case 2:
				anim.Play("Tavern Zone by id not found ");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1657f;
			}
		}
	}

	private void IJMBEEEGCGF()
	{
		Weather.lightningEffects.Add(this);
	}

	private void EPHDHKDCNOD()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void MBCCCMMBPEK()
	{
		Weather.lightningEffects.Add(this);
	}

	public void HJKNEGOOPKI(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 4);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("ReceiveGenerateMineLevelMaster");
				break;
			case 1:
				anim.Play("RecalculatingAllWallTiles (ONLINE) [client]");
				break;
			case 2:
				anim.Play("Could not find item with id: ");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1709f;
			}
		}
	}

	private void JLLHILICJOC()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void HEMHHGCBEKO()
	{
		Weather.lightningEffects.Remove(this);
	}

	public void HCLBKMOOFKD(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 3);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("resolution");
				break;
			case 1:
				anim.Play("ScrollView");
				break;
			case 2:
				anim.Play("Invalid Player for CursorManager");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 103f;
			}
		}
	}

	private void DHCIDFJBFAD()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void JHKLCLMMOGC()
	{
		Weather.lightningEffects.Add(this);
	}

	private void CCJOOMDHMKM()
	{
		Weather.lightningEffects.Add(this);
	}

	private void HNOKPGCBLOA()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void EEAKGHLCFOM()
	{
		Weather.lightningEffects.Remove(this);
	}

	public void ActivateLightning(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 3);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Lightning");
				break;
			case 1:
				anim.Play("Lightning2");
				break;
			case 2:
				anim.Play("Lightning3");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 0.15f;
			}
		}
	}

	private void LFCDFFBBJFG()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void NMPFHHEFOPH()
	{
		Weather.lightningEffects.Add(this);
	}

	private void PGDAOMNADHA()
	{
		Weather.lightningEffects.Remove(this);
	}

	public void LKGKGCPBCPE(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 0);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/17/Dialogue Text");
				break;
			case 1:
				anim.Play("id: ");
				break;
			case 2:
				anim.Play("Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/2/Dialogue Text");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1626f;
			}
		}
	}

	private void JINLGFOFJAN()
	{
		Weather.lightningEffects.Add(this);
	}

	private void FAKNILODPNH()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void LAOMCDFAFGA()
	{
		Weather.lightningEffects.Add(this);
	}

	private void MPMGGLKFMNJ()
	{
		Weather.lightningEffects.Add(this);
	}

	private void HHHEACKHADN()
	{
		Weather.lightningEffects.Add(this);
	}

	private void OHOHFGMJGAJ()
	{
		Weather.lightningEffects.Add(this);
	}

	private void OFJIMLOLIDP()
	{
		Weather.lightningEffects.Remove(this);
	}

	public void CAFPGNFLLCC(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 8);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("ReceiveFarmConstructionActivated");
				break;
			case 1:
				anim.Play("Items/item_name_602");
				break;
			case 2:
				anim.Play("Trying to set a player's steam name but they're not playing on a steam platform");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1214f;
			}
		}
	}

	public void BJKEDLKFHPE(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 7);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("ReceiveTalentFromOther");
				break;
			case 1:
				anim.Play("Scene");
				break;
			case 2:
				anim.Play("Could not find reputation with id: ");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 349f;
			}
		}
	}

	public void PENLPOKNHMG(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 5);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("UIInteract");
				break;
			case 1:
				anim.Play("Staff");
				break;
			case 2:
				anim.Play("Cross");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1f;
			}
		}
	}

	private void OHIMJBJOGHI()
	{
		Weather.lightningEffects.Add(this);
	}

	private void ADGMAKKMINA()
	{
		Weather.lightningEffects.Add(this);
	}

	public void OKMECAOBKGG(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 2);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Tutorial/T134/Dialogue1");
				break;
			case 1:
				anim.Play("Disabled");
				break;
			case 2:
				anim.Play("</size>");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 715f;
			}
		}
	}

	public void OEAFFHGBKHK(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 2);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Error_NoDogFoodOrWater");
				break;
			case 1:
				anim.Play("Pipe");
				break;
			case 2:
				anim.Play("Dialogue System/Conversation/NeutralInTavern/Entry/6/Dialogue Text");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 41f;
			}
		}
	}

	private void IMOMHCNPCEC()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void CHDGJHNBNEJ()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void OnDisable()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void EPFDKCELPDD()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void EAMLHICIOMO()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void KJJAGKNOFIG()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void OKEGMHBDHIP()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void JAKILILIBIM()
	{
		Weather.lightningEffects.Remove(this);
	}

	public void IOAGHEJEIGD(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 1);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("[HierarchyPrinter] Activa al menos una opción de salida.");
				break;
			case 1:
				anim.Play("psai state: ");
				break;
			case 2:
				anim.Play("ReceiveGiveRoom");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 59f;
			}
		}
	}

	private void KNKILPPBEDC()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void LMPCDDGFBGD()
	{
		Weather.lightningEffects.Add(this);
	}

	public void AJNNMGGMBKH(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 7);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Player 2 inputs disabled.");
				break;
			case 1:
				anim.Play("{0} - The mine piece {1} has a variant object with puzzle altar but the piece ID doesn't match the altar piece ID. Piece ID: {2} - Altar Piece ID: {3}");
				break;
			case 2:
				anim.Play("itemDualHopsSeeds");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1433f;
			}
		}
	}

	private void GBAKNAINDJM()
	{
		Weather.lightningEffects.Add(this);
	}

	public void CHJLKDLFLEL(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 8);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("ReceiveAskHostForRoomToJoin");
				break;
			case 1:
				anim.Play("LE_18");
				break;
			case 2:
				anim.Play("Invalid seating");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1351f;
			}
		}
	}

	public void NFBECIDILOO(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 5);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("\n");
				break;
			case 1:
				anim.Play("");
				break;
			case 2:
				anim.Play("OrderDelivered");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 493f;
			}
		}
	}

	public void GEJPLGKDCBO(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(0, 7);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/23/Dialogue Text");
				break;
			case 1:
				anim.Play("Tutorial/T116/Dialogue1");
				break;
			case 2:
				anim.Play(".");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 785f;
			}
		}
	}

	private void GCAEICHCIMA()
	{
		Weather.lightningEffects.Add(this);
	}

	private void GFPIEOPHABO()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void ONNAGOCFJML()
	{
		Weather.lightningEffects.Add(this);
	}

	private void MHLHJGHHONF()
	{
		Weather.lightningEffects.Add(this);
	}

	private void OIEJIBAPDMM()
	{
		Weather.lightningEffects.Add(this);
	}

	public void EAIFIPFKKCH(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 4);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("");
				break;
			case 1:
				anim.Play("Kyroh not found path to at ");
				break;
			case 2:
				anim.Play("Active Customer Parent");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1515f;
			}
		}
	}

	public void JLFHGBALOLN(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 6);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Miners/Camp/Ferro/Talk");
				break;
			case 1:
				anim.Play("Dialogue System/Conversation/Gass_Quest/Entry/12/Dialogue Text");
				break;
			case 2:
				anim.Play("cleanVerb");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 832f;
			}
		}
	}

	public void BEODOCIABPG(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 5);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play("Open");
				break;
			case 1:
				anim.Play("SeatFound...");
				break;
			case 2:
				anim.Play("itemRedGrapeMust");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 384f;
			}
		}
	}

	private void MAEGGDLLHBG()
	{
		Weather.lightningEffects.Remove(this);
	}

	private void MEAMEBFFMJH()
	{
		Weather.lightningEffects.Add(this);
	}

	public void JHGFMPOJPDM(bool ILOEBFFMKMK)
	{
		if (GraphicsMenuUI.AHPIOAFLNMC)
		{
			MDHCBOJBFGJ = Random.Range(1, 7);
			switch (MDHCBOJBFGJ)
			{
			case 0:
				anim.Play(" not found.");
				break;
			case 1:
				anim.Play("MasterMilestoneLower");
				break;
			case 2:
				anim.Play("CraftedIn");
				break;
			}
		}
		if (ILOEBFFMKMK)
		{
			BFHBGFLFNGI = MultiAudioManager.PlayAudioObject(thunder, ((Component)this).transform);
			if (!Utils.HFJABMOFIML())
			{
				BFHBGFLFNGI.VolumeOverride = 1412f;
			}
		}
	}

	private void AMHGMJDKONK()
	{
		Weather.lightningEffects.Add(this);
	}
}
