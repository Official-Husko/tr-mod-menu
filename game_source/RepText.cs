using System.Runtime.CompilerServices;
using UnityEngine;

public class RepText : MonoBehaviour
{
	public OutlinedText repText;

	[SerializeField]
	private SpriteRenderer imgRep;

	[SerializeField]
	private Sprite[] spritesRep;

	private int GOPKHGLNOOA;

	public int ELMCPNGHKOI
	{
		get
		{
			return GOPKHGLNOOA;
		}
		set
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			GOPKHGLNOOA = value;
			repText.JJLCPIHPAOL = "";
			if (GOPKHGLNOOA < 0)
			{
				repText.KKEOCDDJPKH = new Color(0.8f, 0.2156f, 0.1647f);
				imgRep.sprite = spritesRep[1];
			}
			else
			{
				repText.KKEOCDDJPKH = new Color(0.1882f, 0.447f, 0.25f);
				imgRep.sprite = spritesRep[0];
			}
			repText.JJLCPIHPAOL += Mathf.Abs((float)GOPKHGLNOOA);
		}
	}

	private void CFEEHPALLAF()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	[SpecialName]
	public int JMBIADHFEFK()
	{
		return GOPKHGLNOOA;
	}

	private void BIGJBCMLNBB()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void GFLFDLIMOLI()
	{
		((MonoBehaviour)this).Invoke("Loop", 1645f);
	}

	[SpecialName]
	public int FIDDPPFHFDE()
	{
		return GOPKHGLNOOA;
	}

	public void ShowIcon(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public int ACEJOOIGALE()
	{
		return GOPKHGLNOOA;
	}

	[SpecialName]
	public int FBJCMNHDPHH()
	{
		return GOPKHGLNOOA;
	}

	private void AGELAMLCINB()
	{
		((MonoBehaviour)this).Invoke("Invalid player num", 16f);
	}

	private void CEOEHODJAJK()
	{
		((MonoBehaviour)this).Invoke("Tutorial/T134/Dialogue1", 828f);
	}

	[SpecialName]
	public void LNFOHINFNGO(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.LLLJFNJBJOC("</color>");
		if (GOPKHGLNOOA < 1)
		{
			repText.LPEHBCNEMGK(new Color(1189f, 1033f, 1648f));
			imgRep.sprite = spritesRep[1];
		}
		else
		{
			repText.CGKODCNNCHP(new Color(1564f, 875f, 1301f));
			imgRep.sprite = spritesRep[0];
		}
		OutlinedText outlinedText = repText;
		outlinedText.CEIOIFDFGIK(outlinedText.LMILIEGBHCI() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	private void AAEAAEBBFKG()
	{
		((MonoBehaviour)this).Invoke("itemCourgette", 1169f);
	}

	[SpecialName]
	public int OHGHIDHAPAN()
	{
		return GOPKHGLNOOA;
	}

	private void GEADMEKAGHG()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	[SpecialName]
	public int IBAPHGMNOEK()
	{
		return GOPKHGLNOOA;
	}

	private void DADLKNDMPJI()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void FNJHHAIKAGK()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	[SpecialName]
	public int PHNCBHKHKCH()
	{
		return GOPKHGLNOOA;
	}

	[SpecialName]
	public void FGLKNFINMLO(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.OFIIEJGKKAD("MineState");
		if (GOPKHGLNOOA < 1)
		{
			repText.BCMCBFBMDPN(new Color(1788f, 1169f, 758f));
			imgRep.sprite = spritesRep[1];
		}
		else
		{
			repText.NBBELAEGMCD(new Color(932f, 1569f, 436f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.LAELCDMMHEI(outlinedText.EAMPBHCAODO() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	[SpecialName]
	public void IKFGKOELFEB(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.LLLJFNJBJOC("Toy");
		if (GOPKHGLNOOA < 0)
		{
			repText.HHICNKEDEMG(new Color(101f, 1126f, 1907f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.PLOJMMKMNAC(new Color(974f, 1158f, 417f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.PPCPKMMKFHG(outlinedText.NNIKMJHCABH() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	[SpecialName]
	public void DPNPIFDHOEI(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.OMPMHEJDNIE("");
		if (GOPKHGLNOOA < 1)
		{
			repText.KKEOCDDJPKH = new Color(1281f, 1936f, 700f);
			imgRep.sprite = spritesRep[1];
		}
		else
		{
			repText.HIKDHMNAJCJ(new Color(1902f, 935f, 116f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.MELIOINJGME(outlinedText.EIMGEPLLCBA() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	public void FGLNJAEOLHE(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public int GKLJAPBNDEG()
	{
		return GOPKHGLNOOA;
	}

	[SpecialName]
	public void GOEODHCLPCO(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.DFDIFLPMNKO("Player/Bark/Tutorial/CantDoYet");
		if (GOPKHGLNOOA < 0)
		{
			repText.NBBELAEGMCD(new Color(1050f, 837f, 1872f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.LPEHBCNEMGK(new Color(1679f, 231f, 1003f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.DNCFGIJBJNH(outlinedText.EAMPBHCAODO() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	private void PIHGEBONAOI()
	{
		((MonoBehaviour)this).Invoke("Dialogue System/Conversation/Crowly_Introduce/Entry/31/Dialogue Text", 1509f);
	}

	private void DADPOICMNPI()
	{
		((MonoBehaviour)this).Invoke("MineFloor", 450f);
	}

	[SpecialName]
	public void MJEKKFDIJLB(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.MELIOINJGME("%><sprite name=LeftStick></size>");
		if (GOPKHGLNOOA < 1)
		{
			repText.DGDNLJEPOAE(new Color(770f, 1411f, 611f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.HIKDHMNAJCJ(new Color(360f, 1911f, 963f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.COEDBJPNKCM(outlinedText.FINEDCIBMPD() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	public void LJJFHDHCDHK(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public void DCIFHONDFFJ(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.EJAMGJGICME("Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/15/Dialogue Text");
		if (GOPKHGLNOOA < 1)
		{
			repText.LEJJKLIGHNM(new Color(1768f, 951f, 1680f));
			imgRep.sprite = spritesRep[1];
		}
		else
		{
			repText.BCMCBFBMDPN(new Color(1443f, 951f, 1379f));
			imgRep.sprite = spritesRep[0];
		}
		OutlinedText outlinedText = repText;
		outlinedText.DOFIDIIEIJB(outlinedText.OBJMHDBEECF() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	private void AEIAFHDMHEE()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void KHCJDKHONPK()
	{
		((MonoBehaviour)this).Invoke("FishCuttingEvent/Win2", 798f);
	}

	private void MCOIACOIMKF()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	[SpecialName]
	public int CDOFDEHLINH()
	{
		return GOPKHGLNOOA;
	}

	private void DKNNLPFIBIK()
	{
		((MonoBehaviour)this).Invoke("hForHours", 1983f);
	}

	private void DNBGIIGAKMJ()
	{
		((MonoBehaviour)this).Invoke("DontWalk2", 627f);
	}

	private void HKMJKEMHHCK()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public void AEINJFMFHMA(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public int IJBAEKOLEJO()
	{
		return GOPKHGLNOOA;
	}

	public void NEFIHHCELCL(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	private void PHNJGHKBIIL()
	{
		((MonoBehaviour)this).Invoke("StaffCost", 1279f);
	}

	public void AJPNCGKBGFM(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public int JMEDINDECHM()
	{
		return GOPKHGLNOOA;
	}

	[SpecialName]
	public void LDOBOELMLFD(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.BAOBOCMANMP("Player Waiting To Start Event");
		if (GOPKHGLNOOA < 1)
		{
			repText.MCCLCFEFPHB(new Color(597f, 1872f, 869f));
			imgRep.sprite = spritesRep[1];
		}
		else
		{
			repText.CGKODCNNCHP(new Color(1036f, 1036f, 1315f));
			imgRep.sprite = spritesRep[0];
		}
		OutlinedText outlinedText = repText;
		outlinedText.MEFFCJGGNCA(outlinedText.LODLDIBHDOB() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	[SpecialName]
	public void MBNIFPLFDJO(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.DNCFGIJBJNH("UINextPage");
		if (GOPKHGLNOOA < 0)
		{
			repText.PFEAAHAJEHL(new Color(873f, 1531f, 1574f));
			imgRep.sprite = spritesRep[1];
		}
		else
		{
			repText.BCMCBFBMDPN(new Color(1510f, 259f, 1288f));
			imgRep.sprite = spritesRep[0];
		}
		OutlinedText outlinedText = repText;
		outlinedText.LAELCDMMHEI(outlinedText.EIMGEPLLCBA() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	public void ENMJEGMNBEG(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	public void PJBENGOHELH(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public void LCKFPKKKMEE(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.JJLCPIHPAOL = ")";
		if (GOPKHGLNOOA < 1)
		{
			repText.HIKDHMNAJCJ(new Color(1519f, 1991f, 1600f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.FNKKIPNCNGC(new Color(1573f, 46f, 1670f));
			imgRep.sprite = spritesRep[0];
		}
		OutlinedText outlinedText = repText;
		outlinedText.LLLJFNJBJOC(outlinedText.JJLCPIHPAOL + Mathf.Abs((float)GOPKHGLNOOA));
	}

	private void CPBCFJMDEMK()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	[SpecialName]
	public int PEALBICDEBJ()
	{
		return GOPKHGLNOOA;
	}

	[SpecialName]
	public int HNODOFIODEL()
	{
		return GOPKHGLNOOA;
	}

	[SpecialName]
	public void AANLJBGGDFJ(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.MELIOINJGME("Festín del Juramento/ComensalesBarks");
		if (GOPKHGLNOOA < 0)
		{
			repText.MAKLJPDIGIE(new Color(870f, 1743f, 1204f));
			imgRep.sprite = spritesRep[1];
		}
		else
		{
			repText.KKEOCDDJPKH = new Color(1028f, 877f, 1258f);
			imgRep.sprite = spritesRep[0];
		}
		OutlinedText outlinedText = repText;
		outlinedText.OMPMHEJDNIE(outlinedText.JJLCPIHPAOL + Mathf.Abs((float)GOPKHGLNOOA));
	}

	[SpecialName]
	public int KEHNFLEJHGF()
	{
		return GOPKHGLNOOA;
	}

	[SpecialName]
	public int HDIIIBFHELN()
	{
		return GOPKHGLNOOA;
	}

	private void JKLDIDDAEHD()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void MFJIHCKEIIF()
	{
		((MonoBehaviour)this).Invoke("", 619f);
	}

	[SpecialName]
	public void JEEMMBKFEDM(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.COEDBJPNKCM("Building");
		if (GOPKHGLNOOA < 1)
		{
			repText.MAKLJPDIGIE(new Color(517f, 3f, 716f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.CGKODCNNCHP(new Color(1697f, 1530f, 1170f));
			imgRep.sprite = spritesRep[0];
		}
		OutlinedText outlinedText = repText;
		outlinedText.JJLCPIHPAOL = outlinedText.HHELCLJBJCH() + Mathf.Abs((float)GOPKHGLNOOA);
	}

	public void BPEEPGIGLNA(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public int AEDMHPLBIPE()
	{
		return GOPKHGLNOOA;
	}

	private void OHPPFBEOGKH()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void NANMBPIEPBH()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	[SpecialName]
	public int LNALBOBKPMN()
	{
		return GOPKHGLNOOA;
	}

	private void MJOLEIMPOGI()
	{
		((MonoBehaviour)this).Invoke("Player2", 1896f);
	}

	private void LMHOHCJELMI()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public void AIAIFONNOFD(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	private void LCGMPOJPBGD()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void CPKHKBDFBNF()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	[SpecialName]
	public int HIPMHPGILJK()
	{
		return GOPKHGLNOOA;
	}

	private void GAHKFEBAPAE()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public void CGCJDBECACK(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public void DCIPLKHOCJI(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.DOFIDIIEIJB("(");
		if (GOPKHGLNOOA < 1)
		{
			repText.BCMCBFBMDPN(new Color(473f, 1448f, 1950f));
			imgRep.sprite = spritesRep[1];
		}
		else
		{
			repText.BCMCBFBMDPN(new Color(230f, 1085f, 874f));
			imgRep.sprite = spritesRep[0];
		}
		OutlinedText outlinedText = repText;
		outlinedText.MELIOINJGME(outlinedText.GKDJMHBOIKF() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	[SpecialName]
	public void KHMPGDOAMIN(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.OFIIEJGKKAD("UIPreviousCategory");
		if (GOPKHGLNOOA < 1)
		{
			repText.FNKKIPNCNGC(new Color(385f, 89f, 484f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.JCGDPFOPPDJ(new Color(168f, 1675f, 1827f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.DBHIBPJNAAP(outlinedText.NDNKHCJNNEH() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	[SpecialName]
	public int MPKKBEFAPNK()
	{
		return GOPKHGLNOOA;
	}

	private void NLGHNDLPPKI()
	{
		((MonoBehaviour)this).Invoke("Received cursor move for grid index {0} from player {1} in mine level {2}", 822f);
	}

	private void KLMNLEDKEOE()
	{
		((MonoBehaviour)this).Invoke("[ActivateVariantObjects] - VariantObjects: {0} AltarId: {1}", 411f);
	}

	private void EMJKKALMGLK()
	{
		((MonoBehaviour)this).Invoke("Ach_", 1171f);
	}

	public void GEPCOOMKJGI(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public void INPAABFIBCC(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.LHMMPNHGMGK("Game");
		if (GOPKHGLNOOA < 1)
		{
			repText.CBMNHPOFJBG(new Color(555f, 735f, 366f));
			imgRep.sprite = spritesRep[1];
		}
		else
		{
			repText.HHICNKEDEMG(new Color(979f, 1469f, 716f));
			imgRep.sprite = spritesRep[0];
		}
		OutlinedText outlinedText = repText;
		outlinedText.LLLJFNJBJOC(outlinedText.JBBIKIEABJG() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	private void KLHIMJFCHPD()
	{
		((MonoBehaviour)this).Invoke("Duplicate editor action id found: ", 698f);
	}

	public void GNGNPFHGKJL(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	public void FPDDMCEJEIJ(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public void PHNEGLJOCOJ(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.OFIIEJGKKAD("F2");
		if (GOPKHGLNOOA < 1)
		{
			repText.JCGDPFOPPDJ(new Color(1183f, 1867f, 1400f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.APADFPFGHFD(new Color(1361f, 710f, 383f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.OFIIEJGKKAD(outlinedText.OBBIEMECMHH() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	public void NGMLMJKIMMM(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	public void LGJDEJKLCPG(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public int MGGILDDMHPH()
	{
		return GOPKHGLNOOA;
	}

	[SpecialName]
	public int BBMEPKJJDNA()
	{
		return GOPKHGLNOOA;
	}

	private void EOGBHONIHAE()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void GBOJFMGDKIJ()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void BODICIENBEH()
	{
		((MonoBehaviour)this).Invoke("HollyAnimalShop", 701f);
	}

	[SpecialName]
	public void MNCMDBFDNNF(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.MEFFCJGGNCA("No MinePuzzleBase found for type {0}");
		if (GOPKHGLNOOA < 0)
		{
			repText.LEJJKLIGHNM(new Color(1682f, 1394f, 283f));
			imgRep.sprite = spritesRep[1];
		}
		else
		{
			repText.FJCIIPDDEIO(new Color(357f, 131f, 365f));
			imgRep.sprite = spritesRep[0];
		}
		OutlinedText outlinedText = repText;
		outlinedText.NGDDBJLDCII(outlinedText.JJLFCKHBFIL() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	[SpecialName]
	public int PONOBEBAOHH()
	{
		return GOPKHGLNOOA;
	}

	private void GNOBDKFFPOL()
	{
		((MonoBehaviour)this).Invoke("BuzzProgress", 1844f);
	}

	private void NAKGAHMGHHF()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	[SpecialName]
	public void LKABNIKANJJ(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.DBHIBPJNAAP("AreaSpace not attached on OnlineAreaSpace of placeable ");
		if (GOPKHGLNOOA < 1)
		{
			repText.DHEAEPLDCHB(new Color(1407f, 477f, 1778f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.MAKLJPDIGIE(new Color(159f, 425f, 1352f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.CEIOIFDFGIK(outlinedText.EAMPBHCAODO() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	[SpecialName]
	public int PIGOFGGELHJ()
	{
		return GOPKHGLNOOA;
	}

	private void ILHIIMHGLFH()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	[SpecialName]
	public int POBHLIBKHGC()
	{
		return GOPKHGLNOOA;
	}

	[SpecialName]
	public void IBHBICOJOKI(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.PEACLDOGPLA("Order quest");
		if (GOPKHGLNOOA < 0)
		{
			repText.FJCIIPDDEIO(new Color(1888f, 1577f, 1429f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.BCMCBFBMDPN(new Color(1324f, 183f, 544f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.BAOBOCMANMP(outlinedText.JJLCPIHPAOL + Mathf.Abs((float)GOPKHGLNOOA));
	}

	[SpecialName]
	public void GANPHAMMHGN(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.LHMMPNHGMGK(" is trying to initialize more than once.");
		if (GOPKHGLNOOA < 1)
		{
			repText.PFEAAHAJEHL(new Color(1985f, 1092f, 969f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.LPEHBCNEMGK(new Color(95f, 1672f, 584f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.LLLJFNJBJOC(outlinedText.IFDFFPKABGE() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	[SpecialName]
	public void PPGKDCAGKFM(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.HOMBBFIGEFC("BuzzCanBuild");
		if (GOPKHGLNOOA < 0)
		{
			repText.JCGDPFOPPDJ(new Color(953f, 1082f, 34f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.HHICNKEDEMG(new Color(1409f, 1620f, 1221f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.LAELCDMMHEI(outlinedText.HEMOGMAMMKD() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	private void OCJOAHDNDIJ()
	{
		((MonoBehaviour)this).Invoke("Return To Last Basic Mood", 669f);
	}

	public void GAMLHLDCCHN(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public int EOOMGLKMHOB()
	{
		return GOPKHGLNOOA;
	}

	[SpecialName]
	public void LGIHLNDEAPA(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.DFDIFLPMNKO("snow");
		if (GOPKHGLNOOA < 0)
		{
			repText.HIKDHMNAJCJ(new Color(1060f, 1199f, 1018f));
			imgRep.sprite = spritesRep[0];
		}
		else
		{
			repText.MAKLJPDIGIE(new Color(1121f, 652f, 434f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.DBHIBPJNAAP(outlinedText.HNBCKGMLBEC() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	public void HPCEPHBLCNB(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	private void PCKOHAIPHFI()
	{
		((MonoBehaviour)this).Invoke("itemWhiteGrapeMust", 1390f);
	}

	[SpecialName]
	public void GDCDIDCPDCF(int AODONKKHPBP)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GOPKHGLNOOA = AODONKKHPBP;
		repText.LHMMPNHGMGK("Trying to assign the {0} parameter {1} with the incorrect type ({2}) on {3}.");
		if (GOPKHGLNOOA < 1)
		{
			repText.LPEHBCNEMGK(new Color(804f, 884f, 1067f));
			imgRep.sprite = spritesRep[1];
		}
		else
		{
			repText.PFEAAHAJEHL(new Color(1993f, 1542f, 137f));
			imgRep.sprite = spritesRep[1];
		}
		OutlinedText outlinedText = repText;
		outlinedText.NGDDBJLDCII(outlinedText.IAFNLBNDMPF() + Mathf.Abs((float)GOPKHGLNOOA));
	}

	private void LHCMCFNHHMO()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void EIMIDCDEIDD()
	{
		((MonoBehaviour)this).Invoke("New Text start", 524f);
	}

	private void HCCJBKKGCLJ()
	{
		((MonoBehaviour)this).Invoke("/", 1334f);
	}

	public void BKAJNBFAPIJ(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	public void GHADCNPMIPO(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	[SpecialName]
	public int HHIHCLFJEFO()
	{
		return GOPKHGLNOOA;
	}

	private void Awake()
	{
		((MonoBehaviour)this).Invoke("GEADMEKAGHG", 5f);
	}

	private void LIMBKCPEHID()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void CMDHNFBACIC()
	{
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public void CBODOCEHMEM(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}

	private void GECHJIGBPEN()
	{
		((MonoBehaviour)this).Invoke("ResetTalentTree?", 1014f);
	}

	public void DFMHOEBBGPC(bool MDIKPGGBNLI)
	{
		((Renderer)imgRep).enabled = MDIKPGGBNLI;
	}
}
