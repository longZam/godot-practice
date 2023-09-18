using Godot.DependencyInjection;

// godot에서 nuget의 script를 node에 사용할 수 없기 때문에 node에 사용할 수 있도록 만드는 클래스
// Project -> Project Settings -> Autoload에 등록해야 한다.
public partial class DependencyInjectionNode : DependencyInjectionManagerNode
{
}
