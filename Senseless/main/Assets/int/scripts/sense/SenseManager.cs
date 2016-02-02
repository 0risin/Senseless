using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SenseManager {

    Dictionary<Sense.Type, Sense> senses = new Dictionary<Sense.Type, Sense>()
    {
        {Sense.Type.Feel, new FeelSense() },
        {Sense.Type.Hear, new HearSense() },
        {Sense.Type.Gravity, new WorldSense() },
        {Sense.Type.Look, new LookSense() },
        {Sense.Type.Strength, new Strength() },
        {Sense.Type.Dexterity, new Dexterity() },
        {Sense.Type.Orientation, new Orientation() }
    };

    public Sense GetBossSense()
    {
        System.Random rnd = new System.Random();

        List<Sense> senses = new List<Sense>();

        foreach (Sense.Type type in this.senses.Keys)
        {
            if (type != Sense.Type.Gravity)
            {
                Sense s = this.senses[type];
                if (s.Active)
                {
                    senses.Add(s);
                }
            }
        }

        if (senses.Count <= 0)
        {
            return null;
        }

        return senses[rnd.Next(0, senses.Count - 1)];
    }

    public void Update()
    {
        foreach(Sense sense in senses.Values)
        {
            sense.Update();
        }
    }

    public GameObject GetLayerItem(string name)
    {
        return MonoBehaviour.FindObjectOfType<SenseSystem>().GetLayerItem(name);
    }

    public void SetDefault()
    {
        lock (senses)
        {
            foreach(Sense.Type type in senses.Keys)
            {
                Sense sense = senses[type];
                if (sense.DefaultEnabled)
                {
                    sense.On(null);
                }
                else
                {
                    sense.Off(null);
                }
            }
        }
    }

    public Sense GetSense(Sense.Type type)
    {
        lock(senses)
        {
            if (senses.ContainsKey(type))
            {
                return senses[type];
            }
        }

        return null;
    }

}
