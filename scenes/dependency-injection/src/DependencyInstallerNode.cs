namespace DISample;

using System.Diagnostics;
using Godot;
using Godot.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

// Zenject의 Installer와 같은 역할을 수행
public partial class DependencyInstallerNode : Node, IServicesConfigurator
{
    // 바인딩 작업이 이루어지는 메서드
    void IServicesConfigurator.ConfigureServices(IServiceCollection services)
    {
        ISomeService service = GetChild<ISomeService>(0);
        services.AddSingleton<ISomeService>(service);
        GD.Print("Binding service success");
    }
}
