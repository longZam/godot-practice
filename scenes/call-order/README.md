# _EnterTree와 _Ready 호출 순서

한 노드 안에서는 _EnterTree 호출 후 _Ready 함수가 호출된다.  

노드 계층에서는 _EnterTree와 _Ready가 호출되는 순서는 다음과 같다.  
**_EnterTree: 깊이 우선 탐색(Depth-First Search)**  
**_Ready: 후위 순회**
