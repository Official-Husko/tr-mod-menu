using UnityEngine;
using UnityEngine.SceneManagement;

public class OnlineTree : OnlinePlaceable
{
	protected enum JDBLOKANBMI
	{
		Cut = 10,
		Grow,
		Harvest
	}

	public Tree tree;

	public virtual void ILBACOKPOGC(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = DBGDJFMBJCK;
		array[1] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 47, array);
	}

	public virtual void JCJMKKGCNOM(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[1] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 137, array);
	}

	public virtual void ICDGHPCIDGE(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 81, DBGDJFMBJCK, HIEPPJPDAME);
	}

	protected override void Start()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline() || (Object)(object)placeable == (Object)null || ((Component)this).gameObject.scene != SceneManager.GetSceneByName("Gameplay"))
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			base.CLHLNFFGOGA = placeable.FHEMHCEAICB;
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiatePlaceable(this);
			}
		}
		else
		{
			TreeGenerator treeGeneratorInArea = TreeGenerator.GetTreeGeneratorInArea(((Component)this).transform.position);
			if (Object.op_Implicit((Object)(object)treeGeneratorInArea))
			{
				treeGeneratorInArea.AddForestElement(tree);
			}
		}
	}

	public virtual void FJJCKHMCOFF(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 140, array);
	}

	public virtual void CLMMBGMMPJC(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 215, DBGDJFMBJCK, HIEPPJPDAME, null, null, null, null, null, null);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		tree = ((Component)((Component)this).transform).GetComponent<Tree>();
		tree.onlineTree = this;
	}

	public void BPICLJKNOEI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 238);
	}

	public void PFHMOGKDOLA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 155);
	}

	public virtual void EKLGENLLKML(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = DBGDJFMBJCK;
		array[1] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 170, array);
	}

	public virtual void KBNPAOACNIG(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[0] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 111, array);
	}

	public virtual void GDCKBJKOCON(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = DBGDJFMBJCK;
		array[1] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 210, array);
	}

	public void IEBFACCFJCH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 193);
	}

	public override PlaceableMsg CreateMsg()
	{
		return new TreeMessage(this);
	}

	public void EDKFGBGIEDC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 31);
	}

	public virtual void CAPDKDALONK(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[0] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 214, array);
	}

	public virtual void FIGDFMGEHEL(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 112, array);
	}

	public virtual void FNEJADEAKHC(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[0] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 92, array);
	}

	public void PMEGLFICOLE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 9);
	}

	public void EGIFFICAMGP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 93);
	}

	public void PINFPPLAAKH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 249);
	}

	public virtual void HFGLILGFIKD(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = DBGDJFMBJCK;
		array[1] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 203, array);
	}

	public void KICGCHDGNEH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 243);
	}

	public virtual void HGCDLHPOILL(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[1] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 193, array);
	}

	public void BDNDKOPBDJH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 13);
	}

	public void CPFHCLPONMJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 132);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		if (FACPEEACCMH == 10)
		{
			tree.CutTree(1, (bool)GEMFIOKGIMC[0], (float)GEMFIOKGIMC[1], CDPAMNIPPEC: false);
		}
		else
		{
			base.ReceiveAction(FACPEEACCMH, GEMFIOKGIMC);
		}
	}

	public virtual void BBAFJHADEFO(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[0] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 98, array);
	}

	public void GrowTree()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 11);
	}

	public void MMBMHKHHHBJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 186);
	}

	public virtual void CLDGDFELJJK(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 233, DBGDJFMBJCK, HIEPPJPDAME, null, null, null, null, null, null);
	}

	public virtual void EKBHFBHDMCB(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 203, DBGDJFMBJCK, HIEPPJPDAME, null, null, null, null);
	}

	public virtual void NKLOPFEFPOB(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[1] = DBGDJFMBJCK;
		array[1] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 71, array);
	}

	public virtual void NKELDGEJOFO(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[0] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 124, array);
	}

	public virtual void EEEBMNHHINP(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[1] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 207, array);
	}

	public virtual void Cut(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 10, DBGDJFMBJCK, HIEPPJPDAME);
	}

	public virtual void BEAHBLEOJFE(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = DBGDJFMBJCK;
		array[1] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 170, array);
	}

	public void BIPHCDGCOJC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 145);
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		if (FACPEEACCMH == 11)
		{
			((MonoBehaviour)this).StartCoroutine(tree.SetCurrentAgeNextFrame(tree.currentAge + 1));
		}
	}

	public void KOENGAOPAGF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 222);
	}

	public void NNBBKJKLJPI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 174);
	}

	public void MILOFJOOMFI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 83);
	}

	public void AADCIGGEKDI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 26);
	}

	public void MJMHLLDNDOG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 52);
	}

	public virtual void MLIPOFGFDIP(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = DBGDJFMBJCK;
		array[1] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 124, array);
	}

	public void EELBGNIOBHG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 110);
	}

	public void DLKMPFMOKNF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 202);
	}

	public void NOMGAFINBJE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 218);
	}

	public void AGLIIIJADKD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 143);
	}

	public virtual void HEINJNHJCMK(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[0] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 183, array);
	}

	public void DPMKMICFLGF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 153);
	}

	public void LKMAHJBIKKI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 89);
	}

	public virtual void FNGNDKEKMJF(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[0] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 221, array);
	}

	public void FKACMBMPOKI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 61);
	}

	public void NFPAKAIOOCL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 178);
	}

	public virtual void DNFDJNLJCNF(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[1] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 136, array);
	}

	public virtual void MAFONJCFOII(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[0] = DBGDJFMBJCK;
		array[0] = HIEPPJPDAME;
		instance.SendObjectAction(bEIPALOAAJJ, 120, array);
	}

	public virtual void OLCMAFHCNIN(bool DBGDJFMBJCK, float HIEPPJPDAME)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 32, DBGDJFMBJCK, HIEPPJPDAME, null, null, null, null);
	}
}
