// ;
using System.Drawing;

namespace Exw.ClickerCore
{
    public abstract class Action
    {
        public enum Type { ACTION_MOVE, ACTION_CLICK, ACTION_DELAY, ACTION_CUSTOM }
        public delegate void ActionBehavior();
        public delegate T ActionBehavior<T>();

        public Type ActionType { get; protected set; }
    }

    public class MoveAction : Action
    {
        public Point Position { get; private set; }
        public ActionBehavior<Point> Behavior { get; set; }

        public MoveAction(int _x, int _y)
        {
            Position = new Point(_x, _y);
            ActionType = Type.ACTION_MOVE;
        }

        public MoveAction(ActionBehavior<Point> _behavior)
        {
            Behavior = _behavior;
            ActionType = Type.ACTION_MOVE;
        }
    }

    public class ClickAction : Action
    {
        //public enum ButtonMask { BTN_LEFT, BTN_RIGHT, BTN_MIDDLE }
        public int Button { get; private set; }
        public ActionBehavior<int> Behavior { get; set; }

        public ClickAction(int _button = 0x0002)
        {
            Button = _button;
            ActionType = Type.ACTION_CLICK;
        }

        public ClickAction(ActionBehavior<int> _behavior)
        {
            Behavior = _behavior;
            ActionType = Type.ACTION_CLICK;
        }
    }

    public class DelayAction : Action
    {
        public uint Delay { get; private set; }
        public ActionBehavior<int> Behavior { get; set; }

        public DelayAction(uint _delay)
        {
            Delay = _delay;
            ActionType = Type.ACTION_DELAY;
        }

        public DelayAction(ActionBehavior<int> _behavior)
        {
            Behavior = _behavior;
            ActionType = Type.ACTION_DELAY;
        }
    }

    public class CustomAction : Action
    {
        public ActionBehavior Behavior { get; set; }

        public CustomAction(ActionBehavior _behavior)
        {
            Behavior = _behavior;
            ActionType = Type.ACTION_CUSTOM;
        }
    }
}
