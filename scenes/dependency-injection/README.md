# Dependency Injection

## 사전 설정
이 Scene은 https://www.nuget.org/packages/Godot.DependencyInjection/ 라이브러리에 의존성을 갖습니다.  
nuget을 이용해 <project_name>.csproj에 의존성을 추가하십시오.

* [DependencyInjectionNode.cs](../../src/DependencyInjectionNode.cs) 생성
    * Godot v4.1.1 Mono 에디터에서는 nuget으로 얻어 온 라이브러리의 어셈블리 내 스크립트를 노드에 추가할 수 없습니다. 따라서, Godot에서 사용할 수 있도록 단순히 DependencyInjectionManagerNode를 상속 받은 DependencyInjectionNode 클래스를 생성하도록 합니다.
* DependencyInjectionNode 클래스를 Autoload에 추가
    * 모든 Scene에서 정상적으로 의존성이 설치되고 주입될 수 있도록 Autoload에 추가합니다.
