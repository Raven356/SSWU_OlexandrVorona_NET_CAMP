namespace EX5._2
{
    internal class PathFinder
    {
        public string FindPath(Box box, string goods)
        {
            for(int i = 0; i < box.Boxes.Count; i++)
            {
                if (box.Boxes[i].Boxes is null)
                {
                    if (box.Boxes[i].Goods.Name == goods)
                    {
                        return $"Box name: {box.Name}, height: { box.Height }, wigth: {box.Width}, length: {box.Length} -> " +
                            $"Box name: {box.Boxes[i].Name}, height: {box.Boxes[i].Height}, wigth: {box.Boxes[i].Width}, length: {box.Boxes[i].Length} -> " +
                            $"Goods name: {goods}, height: {box.Boxes[i].Goods.Height}, wigth: {box.Boxes[i].Goods.Width}, length: {box.Boxes[i].Goods.Length}";
                    }
                }
                else
                {
                    string result = FindPath(box.Boxes[i], goods);
                    if(result is not null)
                    {
                        string answ = $"Box name:{box.Boxes[i].Name}, height: {box.Boxes[i].Height}, wigth: {box.Boxes[i].Width}, length: {box.Boxes[i].Length} -> {result}";
                        return $"Box name: {box.Name}, height: {box.Height}, width: {box.Width}, length: {box.Length} -> {result}";
                    }
                }
            }
            return null;
        }
    }
}
