using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

public class Simple:Goal
{
    public Simple():base() {

    }
    public Simple(string name, string description, int points, bool isCompleted):base(name, description, points, isCompleted)
    {
    }

    public override string Display()
    {

        return $"{base.Display()}";

    }
    public override void recordEvent()
    {
        base.recordEvent();
    }
        public override int DisplayPoints()
    {
        return base.DisplayPoints();
    }


}