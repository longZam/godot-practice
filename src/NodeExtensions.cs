using System.Collections;
using System.Linq;
using Godot;


public static class NodeExtensions
{
    /// <summary>
    /// 자식 노드에서 T 타입의 Node를 result로 얻어옵니다.
    /// </summary>
    /// <typeparam name="T">받고자 하는 Node 타입</typeparam>
    /// <param name="node">탐색 시작점 노드</param>
    /// <param name="result">탐색 결과 노드</param>
    /// <returns>탐색 성공 여부</returns>
    public static bool TryGetChildWithType<T>(this Node node, out T? result)
        where T : Node
    {
        var children = node.GetChildren();

        foreach (var child in children)
        {
            if (child is T t)
            {
                result = t;
                return true;
            }

            if (TryGetChildWithType(child, out result))
                return true;
        }

        result = null;
        return false;
    }
}
