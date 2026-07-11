using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineLoadCrops : OnlineLoadBase
{
	[Serializable]
	private class LoadCropsInfoMsg : LoadMessageBase
	{
		[JsonProperty("1")]
		public CropInfo[] cropsInfo;

		private void AEMPDGLILKE(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.KDGILDLAPNI(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.BCGIIDPFENI(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void JDEJOBDOMDA(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.DEAHAPFFPLM(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.BCGIIDPFENI(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void IBIHIEBIAGK(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MGOBBKFAEPP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.BCGIIDPFENI(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void FJNFHAFPBCO(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.FJJCOJGJCLF = FJJCOJGJCLF;
			BOIGHCFJHPF.growable.IAJDELOEIFD(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.KLHEFHHHAHK(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void JOIAPCCOACC(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.DEAHAPFFPLM(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void BAGBPBPFMAA(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.KDGILDLAPNI(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.EMKOKCPNEON(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.NKHGKPGFGIN(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void PONGGBEFAAN(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.DEAHAPFFPLM(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FEOLNEGKIIN(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.KLHEFHHHAHK(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void MGEHCCPGHDN(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.INNLLPDAJJP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.IAJDELOEIFD(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void HOMFJAAEJGL(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MFEDJIEKKHC(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.EMKOKCPNEON(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.BCGIIDPFENI(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void BJFCFCFNIPK(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MGOBBKFAEPP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void DCFNLMHFFJI(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.FJJCOJGJCLF = FJJCOJGJCLF;
			BOIGHCFJHPF.growable.EMKOKCPNEON(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.INLLBNGGJCB(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void GIILEDGPHEA(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MFEDJIEKKHC(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.IAJDELOEIFD(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.KLHEFHHHAHK(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void KEBFDMHIOGK(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.KDGILDLAPNI(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.EMKOKCPNEON(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.KLHEFHHHAHK(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void JHJMEMJAPIA(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.FJJCOJGJCLF = FJJCOJGJCLF;
			BOIGHCFJHPF.growable.FKDFFKABPIH = KCLEPKBCBBI.growstage;
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void EAOADAHAMCL(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MGOBBKFAEPP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.NKHGKPGFGIN(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void KKNONHIDAAN(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.INNLLPDAJJP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FEOLNEGKIIN(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.KLHEFHHHAHK(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void DINGOPLPEOG(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.FJJCOJGJCLF = FJJCOJGJCLF;
			BOIGHCFJHPF.growable.FEOLNEGKIIN(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void KPCKECBMEFE(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MFEDJIEKKHC(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.IAJDELOEIFD(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.KLHEFHHHAHK(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void PJNFFKBJGOL(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.KDGILDLAPNI(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FEOLNEGKIIN(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.INLLBNGGJCB(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void COONNMMODIA(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MGOBBKFAEPP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.EMKOKCPNEON(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void PEAPNLOAFMG(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.FJJCOJGJCLF = FJJCOJGJCLF;
			BOIGHCFJHPF.growable.FEOLNEGKIIN(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.BCGIIDPFENI(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void DPPADPGBGDK(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.INNLLPDAJJP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.BCGIIDPFENI(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void IJKCCCFHKII(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.INNLLPDAJJP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.KLHEFHHHAHK(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void KHFCJDOKKBP(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.DEAHAPFFPLM(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.IAJDELOEIFD(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.INLLBNGGJCB(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void DCBMCOGLPPN(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.FJJCOJGJCLF = FJJCOJGJCLF;
			BOIGHCFJHPF.growable.FKDFFKABPIH = KCLEPKBCBBI.growstage;
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.BCGIIDPFENI(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void AHDPIHEOFFD(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MFEDJIEKKHC(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.IAJDELOEIFD(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.NKHGKPGFGIN(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void AGFBNACBEKK(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MFEDJIEKKHC(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FKDFFKABPIH = KCLEPKBCBBI.growstage;
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void PPFHPDHDFMC(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.DEAHAPFFPLM(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void BEEEAHAMKDB(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.INNLLPDAJJP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FEOLNEGKIIN(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.NKHGKPGFGIN(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void IMPJOJLPDHI(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.DEAHAPFFPLM(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.EMKOKCPNEON(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.KLHEFHHHAHK(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void NOOEKPJJBLP(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.INNLLPDAJJP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.IAJDELOEIFD(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void PLMAIJIKPGE(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.KDGILDLAPNI(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FKDFFKABPIH = KCLEPKBCBBI.growstage;
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.BCGIIDPFENI(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void GIJAOLCDMKL(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.INNLLPDAJJP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FEOLNEGKIIN(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void ONBGAOCFPKN(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.KDGILDLAPNI(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void FJACDGFIECB(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MFEDJIEKKHC(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FKDFFKABPIH = KCLEPKBCBBI.growstage;
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.INLLBNGGJCB(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void NIFBEGMFJDI(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.DEAHAPFFPLM(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.INLLBNGGJCB(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void FPMMBLGLAGL(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.KDGILDLAPNI(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.EMKOKCPNEON(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.KLHEFHHHAHK(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		public override void OEJJGDMKIDN()
		{
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < cropsInfo.Length; i++)
			{
				Crop crop = CropDatabaseAccessor.GetCrop(cropsInfo[i].cropID);
				if (crop.seed is SproutSeed)
				{
					FertileSoil fertileSoil = null;
					CropSetter component = Object.Instantiate<GameObject>(crop.growablePrefabs[cropsInfo[i].growstage], Vector2.op_Implicit(Utils.BPKGAMFNAGC(cropsInfo[i].position)), Quaternion.identity).GetComponent<CropSetter>();
					DGKOOMOGOAA(crop, component, cropsInfo[i]);
				}
				else if (WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(Utils.BPKGAMFNAGC(cropsInfo[i].position))))
				{
					FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Utils.BPKGAMFNAGC(cropsInfo[i].position));
					if ((Object)(object)fertileSoil != (Object)null)
					{
						CropSetter component = (fertileSoil.plantedCropSetter = crop.FNILKBLEDKJ(((Component)fertileSoil).transform).GetComponent<CropSetter>());
						fertileSoil.plantedCropSetter.loaded = true;
						DGKOOMOGOAA(crop, component, cropsInfo[i]);
						WorldGrid.CFAHJNLAJNK(((Component)fertileSoil).transform.position, JBNJGMKBKCB: false);
					}
				}
			}
		}

		private void HINEBHEJKOM(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.KDGILDLAPNI(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.NKHGKPGFGIN(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void IFPBMNAOOAC(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MGOBBKFAEPP(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FKDFFKABPIH = KCLEPKBCBBI.growstage;
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void OEGJMGKHPII(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.KDGILDLAPNI(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.IAJDELOEIFD(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.NKHGKPGFGIN(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void DGKOOMOGOAA(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.FJJCOJGJCLF = FJJCOJGJCLF;
			BOIGHCFJHPF.growable.FKDFFKABPIH = KCLEPKBCBBI.growstage;
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void JNKHFPFOKLC(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MFEDJIEKKHC(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FEOLNEGKIIN(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.INLLBNGGJCB(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void OLEJJCMPFBF(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.DEAHAPFFPLM(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.GMKNBBHNFJF(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void LPHAHMGMFBM(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.KDGILDLAPNI(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FKDFFKABPIH = KCLEPKBCBBI.growstage;
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.KLHEFHHHAHK(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void OEGAMBNAMHK(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.KDGILDLAPNI(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.IAJDELOEIFD(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void LEGKHBGPEJO(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MFEDJIEKKHC(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.FEOLNEGKIIN(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.UpdateCropVisual(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}

		private void LKNIKIHFEKA(Crop FJJCOJGJCLF, CropSetter BOIGHCFJHPF, CropInfo KCLEPKBCBBI)
		{
			BOIGHCFJHPF.MFEDJIEKKHC(FJJCOJGJCLF);
			BOIGHCFJHPF.growable.IAJDELOEIFD(KCLEPKBCBBI.growstage);
			BOIGHCFJHPF.growable.daysPlanted = KCLEPKBCBBI.daysPlanted;
			BOIGHCFJHPF.growable.isDead = KCLEPKBCBBI.isDead;
			BOIGHCFJHPF.growable.daysUntilNewHarvest = KCLEPKBCBBI.daysUntilNewHarvest;
			BOIGHCFJHPF.harvestable.isHarvestable = KCLEPKBCBBI.isHarvestable;
			BOIGHCFJHPF.BCGIIDPFENI(KCLEPKBCBBI.growstage);
			if ((Object)(object)BOIGHCFJHPF.harvestable.BKPIJNHCPHP != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.harvestable.BKPIJNHCPHP.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.harvestable.BKPIJNHCPHP);
			}
			else if ((Object)(object)BOIGHCFJHPF.onlineObject != (Object)null && KCLEPKBCBBI.uniqueID != 0)
			{
				BOIGHCFJHPF.onlineObject.uniqueId = KCLEPKBCBBI.uniqueID;
				OnlineObjectsManager.instance.AddObjectInDictionary(BOIGHCFJHPF.onlineObject);
			}
		}
	}

	[Serializable]
	private struct CropInfo
	{
		[JsonProperty("1")]
		public int uniqueID;

		[JsonProperty("2")]
		public Vector2Online position;

		[JsonProperty("3")]
		public int cropID;

		[JsonProperty("4")]
		public byte growstage;

		[JsonProperty("5")]
		public bool isHarvestable;

		[JsonProperty("6")]
		public byte daysUntilNewHarvest;

		[JsonProperty("7")]
		public byte reusableCount;

		[JsonProperty("8")]
		public bool isDead;

		[JsonProperty("9")]
		public byte daysPlanted;
	}

	private void BBBMAICBDBG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void AHGMCGNNEBO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void OGBEJMONPBE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void JGPADCCBHBE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void EADFELILDHJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void FOEELOMMGEN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void BJHGIFKANHL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void PBDDEMBNIHL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void GEIEINBKCPK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void BCCONIPDOMP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void DGCABHDMFAO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void BFDOFIECIFO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void EFEMFMPGNKP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void HNGFFCMNDCO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void LKDEMKPLONL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void PKNMFHOJALH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void KFGHFONEGKK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void IJKHMFCMKOD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void GPDLBDMKGLF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void PIDEALCNAIN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void EOKMNFLKGPF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void JJNIODFHBAP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void OMEFCJELGFN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void CDJOHNHMHHL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void NELMNAFNFOO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void AJBMGOLNOEH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void JGEDGPPEJLG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void GLPAIAHEEML(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void OFFFLMBPBJK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player targetPlayer = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		LoadCropsInfoMsg cropsInfoMsg = new LoadCropsInfoMsg();
		List<CropInfo> cropsList = new List<CropInfo>();
		int j = 0;
		int numMessages = 0;
		CropSetter[] crops = Object.FindObjectsOfType<CropSetter>();
		for (int i = 0; i < crops.Length; i++)
		{
			if (WorldGrid.HJPCBBGHPDA(((Component)crops[i]).transform.position) == Location.Road)
			{
				CropInfo item = default(CropInfo);
				item.position = Utils.LGLEABBIGAH(Vector2.op_Implicit(((Component)crops[i]).transform.position));
				item.cropID = crops[i].FJJCOJGJCLF.id;
				item.growstage = (byte)crops[i].growable.FKDFFKABPIH;
				item.daysPlanted = (byte)crops[i].growable.daysPlanted;
				item.isDead = crops[i].growable.isDead;
				item.daysUntilNewHarvest = (byte)crops[i].growable.daysUntilNewHarvest;
				item.isHarvestable = crops[i].harvestable.isHarvestable;
				if ((Object)(object)crops[i].harvestable != (Object)null && (Object)(object)crops[i].harvestable.BKPIJNHCPHP != (Object)null)
				{
					item.uniqueID = crops[i].harvestable.BKPIJNHCPHP.uniqueId;
				}
				if ((Object)(object)crops[i].harvestable != (Object)null && (Object)(object)crops[i].onlineObject != (Object)null)
				{
					item.uniqueID = crops[i].onlineObject.uniqueId;
				}
				cropsList.Add(item);
				j++;
				if (j >= OnlineManager.LMALNDLJILM.MessageLimits.CropsPerMessage)
				{
					j = 0;
					cropsInfoMsg.cropsInfo = cropsList.ToArray();
					AHGEFIOOEBL("ReceiveInfoCrops", targetPlayer, cropsInfoMsg, numMessages++);
					cropsList.Clear();
					yield return OnlineLoadManager.LICLEEOILOO;
				}
			}
		}
		cropsInfoMsg.cropsInfo = cropsList.ToArray();
		AHGEFIOOEBL("ReceiveInfoCrops", targetPlayer, cropsInfoMsg, numMessages, KJOOOPJKLBB: true);
	}

	private void OCGHPCDHALC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void JDKFCGHHDKP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void BGBPMDHFGON(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void IIDIGKNHKDK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void AMPPPPLMCFM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void EGMKPBMJMNK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void NIOMAHKBDDN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void GENKMBDFMON(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveInfoCrops(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void GGOICNEGFHJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void AIONPGCGDFF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void IJODJEDFMKA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void MJJKEEEHAAJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void ABEAIJLKEAF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void MPHMOBFEPOA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void AHOBPCANADN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void EKJEMBCNAIK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void HGMGNBHPPAK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void LMBIMDCKOKL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void NJANDJAIACH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void JDGCBNLABKF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void JPENOFCCPLE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void BAOJPMJHFMO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}

	private void KGGOCJHMFBO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadCropsInfoMsg>(OINICMNOLPK);
	}
}
