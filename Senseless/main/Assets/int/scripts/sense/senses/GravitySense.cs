using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class WorldSense : Sense
{

    public override bool DefaultEnabled
    {
        get
        {
            return false;
        }
    }

    public Vector3 EndRotation
    {
        get
        {
            return new Vector3(0, 0, 180);
        }
    }

    private float startTime = 0;
    private float duration = 0.5f;

    private Vector3 startRotation;
    private Vector3 endRotation;
    private Vector3 playerPos;

    private Trigger tgr;

    private GameObject World;
    private GameObject Player;

    public override void Update()
    {
        if (startTime <= 0 || World == null)
        {
            return;
        }

        World.transform.rotation = Quaternion.Euler(Vector3.Lerp(startRotation, endRotation, (Time.time - startTime) / duration));

        if (Player != null)
        {
            Player.transform.position = playerPos + new Vector3(0, 0.1f, 0);
        }
        if (tgr != null && tgr.Item != null)
        {
            Player.transform.position = tgr.Item.transform.position + new Vector3(0, 0.1f, 0);
        }

        if ((Time.time - startTime) > duration)
        {
            startTime = 0;
            World.transform.rotation = Quaternion.Euler(endRotation);
        }
    }

    public override void On(Trigger trigger)
    {
        base.On(trigger);

        World = Root.Instance.SenseManager.GetLayerItem("World");
        Player = Root.Instance.SenseManager.GetLayerItem("Player");

        if (World == null)
        {
            return;
        }

        if (Player != null)
        {
            playerPos = Player.transform.position;

            if (trigger != null && trigger.Item != null)
            {
                playerPos = trigger.Item.transform.position;
            }
        }

        tgr = trigger;

        startTime = Time.time;
        startRotation = World.transform.rotation.eulerAngles;
        endRotation = EndRotation;
    }

    public override void Off(Trigger trigger)
    {
        base.Off(trigger);

        World = Root.Instance.SenseManager.GetLayerItem("World");
        Player = Root.Instance.SenseManager.GetLayerItem("Player");

        if (World == null)
        {
            return;
        }

        tgr = trigger;

        if (Player != null)
        {
            playerPos = Player.transform.position;
        }
        startTime = Time.time;
        startRotation = World.transform.rotation.eulerAngles;
        endRotation = Vector3.zero;
    }
}
