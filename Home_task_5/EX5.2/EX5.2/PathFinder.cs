namespace EX5._2
{
    internal class PathFinder
    {
        public string FindPath(Box box, string goods, double supermarketBoxSize)
        {
            for(int i = 0; i < box.Boxes.Count; i++)
            {
                if (box.Boxes[i].Boxes is null)
                {
                    if (box.Boxes[i].Goods.Name == goods)
                    {
                        return $"Box name:{box.Name}, size: {box.Size} -> Box name:{box.Boxes[i].Name}, size: {box.Boxes[i].Size} -> Goods name: {goods}, size: {box.Boxes[i].Goods.Size}";
                    }
                }
                else
                {
                    string result = FindPath(box.Boxes[i], goods, supermarketBoxSize);
                    if(result is not null)
                    {
                        string answ = $"Box name:{box.Boxes[i].Name}, size: {box.Boxes[i].Size} -> {result}";
                        //if (box.Size == supermarketBoxSize)
                        {
                            return $"Box name:{box.Name}, size: {box.Size} -> {result}";
                        }
                        //return answ;
                    }
                }
            }
            return null;
        }
    }
}
