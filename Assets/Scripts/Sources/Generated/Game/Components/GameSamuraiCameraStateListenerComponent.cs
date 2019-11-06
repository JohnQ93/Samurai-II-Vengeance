//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SamuraiCameraStateListenerComponent samuraiCameraStateListener { get { return (SamuraiCameraStateListenerComponent)GetComponent(GameComponentsLookup.SamuraiCameraStateListener); } }
    public bool hasSamuraiCameraStateListener { get { return HasComponent(GameComponentsLookup.SamuraiCameraStateListener); } }

    public void AddSamuraiCameraStateListener(System.Collections.Generic.List<ISamuraiCameraStateListener> newValue) {
        var index = GameComponentsLookup.SamuraiCameraStateListener;
        var component = (SamuraiCameraStateListenerComponent)CreateComponent(index, typeof(SamuraiCameraStateListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSamuraiCameraStateListener(System.Collections.Generic.List<ISamuraiCameraStateListener> newValue) {
        var index = GameComponentsLookup.SamuraiCameraStateListener;
        var component = (SamuraiCameraStateListenerComponent)CreateComponent(index, typeof(SamuraiCameraStateListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSamuraiCameraStateListener() {
        RemoveComponent(GameComponentsLookup.SamuraiCameraStateListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSamuraiCameraStateListener;

    public static Entitas.IMatcher<GameEntity> SamuraiCameraStateListener {
        get {
            if (_matcherSamuraiCameraStateListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SamuraiCameraStateListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSamuraiCameraStateListener = matcher;
            }

            return _matcherSamuraiCameraStateListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddSamuraiCameraStateListener(ISamuraiCameraStateListener value) {
        var listeners = hasSamuraiCameraStateListener
            ? samuraiCameraStateListener.value
            : new System.Collections.Generic.List<ISamuraiCameraStateListener>();
        listeners.Add(value);
        ReplaceSamuraiCameraStateListener(listeners);
    }

    public void RemoveSamuraiCameraStateListener(ISamuraiCameraStateListener value, bool removeComponentWhenEmpty = true) {
        var listeners = samuraiCameraStateListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveSamuraiCameraStateListener();
        } else {
            ReplaceSamuraiCameraStateListener(listeners);
        }
    }
}