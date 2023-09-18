using Godot;
using System.Runtime.CompilerServices;


public partial class CallMessage : Node
{
    public override void _EnterTree()
    {
        Print(nameof(_EnterTree));
    }

    public override void _Ready()
    {
        Print(nameof(_Ready));
    }

    private void Print(string callFunctionName)
    {
        GD.Print($"> {GetPath()}.{callFunctionName}");
    }
}
