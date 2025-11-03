/*
    Dictionary 
*/

namespace _24_Indexers;

public class ArgsProcessor 
{
    private readonly ArgsActions _actions;

    public ArgsProcessor(ArgsActions actions) 
    {
        _actions = actions;
    }

    public void Process(string[] args) 
    {
        foreach (var arg in args) 
        {
            _actions[arg]?.Invoke();
        }
    }
}

public class ArgsActions 
{
    private readonly Dictionary<string, Action> _argsActions = [];

    public Action this[string s] 
    {
        get {
            Action? action;
            Action defaultAction = () => { };
            return _argsActions.TryGetValue(s, out action) ? action : defaultAction;
        }
    }

    public void SetOption(string s, Action a) 
    {
        _argsActions[s] = a;
    }
}